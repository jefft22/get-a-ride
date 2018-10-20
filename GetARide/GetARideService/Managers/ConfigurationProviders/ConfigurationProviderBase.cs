namespace GetARideService.Managers.ConfigurationProviders
{
    using System.IO;
    using System.Threading.Tasks;
    using Newtonsoft.Json.Linq;
    using GetARideService.Managers.Models;

    internal abstract class ConfigurationProviderBase
    {
        private readonly string _configurationFilename;

        protected ConfigurationProviderBase(string configurationFilename)
        {
            _configurationFilename = configurationFilename;
        }

        public async Task<GatewayConfiguration> GetLyftGatewayConfiguration()
        {
            return await GetLyftGatewayConfigurationCore();
        }

        public async Task<GatewayConfiguration> GetMapquestGatewayConfiguration()
        {
            return await GetMapquestGatewayConfigurationCore();
        }

        protected async Task<string> GetSettingsValue(string section, string key)
        {
            if (!File.Exists(_configurationFilename))
            {
                throw new System.NotImplementedException("Make a missing configuration file exception");
            }

            var fileBuffer = string.Empty;

            using (var streamReader = new StreamReader(_configurationFilename))
            {
                fileBuffer = await streamReader.ReadToEndAsync();
            }

            var jsonObject = JObject.Parse(fileBuffer);
            var settingsArray = jsonObject[section];
            var result = settingsArray[key];

            if (result == null)
            {
                throw new System.NotImplementedException("Make a missing configuration section / key exception");
            }

            return result.ToString();
        }

        protected abstract Task<GatewayConfiguration> GetLyftGatewayConfigurationCore();

        protected abstract Task<GatewayConfiguration> GetMapquestGatewayConfigurationCore();
    }
}