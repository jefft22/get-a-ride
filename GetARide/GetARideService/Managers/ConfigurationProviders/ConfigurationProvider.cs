namespace GetARideService.Managers.ConfigurationProviders
{
    using System.Threading.Tasks;
    using GetARideService.Managers.Models;

    internal sealed class ConfigurationProvider : ConfigurationProviderBase
    {
        public ConfigurationProvider() : base("appsettings.json")
        {
        }

        protected override async Task <GatewayConfiguration> GetLyftGatewayConfigurationCore()
        {
            var configuration = new GatewayConfiguration()
            {
                AuthenticationUrl = await GetSettingsValue("LyftGateway", "AuthenticationUrl"),
                ApiUrl = await GetSettingsValue("LyftGateway", "ApiUrl"),
                ClientId = await GetSettingsValue("LyftGateway", "ClientId"),
                ClientSecret = await GetSettingsValue("LyftGateway", "ClientSecret")
            };

            return configuration;
        }
    }
}