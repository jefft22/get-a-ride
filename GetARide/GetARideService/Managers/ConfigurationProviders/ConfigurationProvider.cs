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
            return new GatewayConfiguration()
            {
                AuthenticationUrl = await GetSettingsValue("LyftGateway", "AuthenticationUrl"),
                ApiUrl = await GetSettingsValue("LyftGateway", "ApiUrl"),
                ClientId = await GetSettingsValue("LyftGateway", "ClientId"),
                ClientSecret = await GetSettingsValue("LyftGateway", "ClientSecret")
            };
        }

        protected override async Task<GatewayConfiguration> GetMapquestGatewayConfigurationCore()
        {
            return new GatewayConfiguration()
            {
                AuthenticationUrl = string.Empty,
                ApiUrl = await GetSettingsValue("MapquestGateway", "ApiUrl"),
                ClientId = await GetSettingsValue("MapquestGateway", "ClientId"),
                ClientSecret = await GetSettingsValue("MapquestGateway", "ClientSecret")
            };
        }
    }
}