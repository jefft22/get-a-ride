namespace GetARideService.Managers.Gateways
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using GetARideService.Managers.Gateways.Mappers;
    using GetARideService.Managers.Models;
    using GetARideService.Managers.Models.Lyft;

    internal sealed class GetARideLyftGateway : GetARideBaseGateway
    {
        private readonly GatewayConfiguration _gatewayConfiguration;

        public GetARideLyftGateway(GatewayConfiguration gatewayConfiguration) : base()
        {
            _gatewayConfiguration = gatewayConfiguration;
        }

        protected override async Task<GetARideResponse> GetRidesCore(GetARideRequest getARideRequest)
        {
            // Validate request 
            var getARideResponse = new GetARideResponse();
            var accessResponse = await GetAccessToken();

            var rideTypesResponse = await GetLyftDtoFromLyftApi<LyftRideTypesResponse>(_gatewayConfiguration.ApiUrl + "/ridetypes?lat=37.7763&lng=-122.3918", accessResponse.AccessToken);
            var rideEstimatesResponse = await GetLyftDtoFromLyftApi<LyftRideEstimatesResponse>(_gatewayConfiguration.ApiUrl + "/cost?start_lat=37.7763&start_lng=-122.3918&end_lat=37.7972&end_lng=-122.4533", accessResponse.AccessToken);
            var etaNearbyDriversResponse = await GetLyftDtoFromLyftApi<LyftNearbyDriversEtasResponse>(_gatewayConfiguration.ApiUrl + "/nearby-drivers-pickup-etas?lat=37.7763&lng=-122.3918", accessResponse.AccessToken);

            LyftMapper.MapLyftToGetARide(getARideResponse, rideTypesResponse, rideEstimatesResponse, etaNearbyDriversResponse);

            getARideResponse.AccessToken = accessResponse.AccessToken;
            getARideResponse.AccessTokenExpirationMilliseconds = accessResponse.ExpiresIn;
            getARideResponse.ServiceStatus = "OK";
            getARideResponse.ServiceStatusMessage = "OK";

            return getARideResponse;
        }

        private async Task<T> GetLyftDtoFromLyftApi<T>(string url, string accessToken)
        {
            using (var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, url))
            {
                httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                var httpResponseMessage = await _httpClient.SendAsync(httpRequestMessage);
                await EnsureSuccessfulStatusCode(httpResponseMessage);
                var content = await httpResponseMessage.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(content);
            }
        }

        private async Task<LyftAccessResponse> GetAccessToken()
        {
            var accessTokenRequest = CreateAccessTokenHttpRequestMessage();
            var response = await _httpClient.SendAsync(accessTokenRequest);

            await EnsureSuccessfulStatusCode(response);

            return JsonConvert.DeserializeObject<LyftAccessResponse>(await response.Content.ReadAsStringAsync());
        }

        private HttpRequestMessage CreateAccessTokenHttpRequestMessage()
        {
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, _gatewayConfiguration.AuthenticationUrl);
            var accessTokenRequest = new LyftAccessRequest() { GrantType = "client_credentials", Scope = "public" };
            var accessTokenRequestString = JsonConvert.SerializeObject(accessTokenRequest);
            var accessTokenRequestContent = new StringContent(accessTokenRequestString, Encoding.UTF8, "application/json");
            var encodedClientOAuth = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{_gatewayConfiguration.ClientId}:{_gatewayConfiguration.ClientSecret}"));

            httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Basic", encodedClientOAuth);
            httpRequestMessage.Content = accessTokenRequestContent;

            return httpRequestMessage;
        }

        private async Task EnsureSuccessfulStatusCode(HttpResponseMessage httpResponseMessage)
        {
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                return;
            }

            var content = await httpResponseMessage.Content.ReadAsStringAsync();
            switch (httpResponseMessage.StatusCode)
            {
                case HttpStatusCode.ProxyAuthenticationRequired:
                    throw new NotImplementedException("Need to implement proxy authentication exception.");

                case HttpStatusCode.BadRequest:
                    throw new NotImplementedException("Need to implement bad request exception.");

                case HttpStatusCode.TooManyRequests:
                    throw new NotImplementedException("Need to implement too many requests exceptions.");

                default:
                    throw new NotImplementedException("Need to implement a unsuccessful, unsupported status code exception.");
            }
        }
    }
}