using System;
using System.IO;
using Newtonsoft.Json;

namespace Modul2HW5
{
    public class ConfigService : IConfigService
    {
        private const string Path = "Configs/Config.json";
        private Config _config;
        public ConfigService()
        {
            ConfigInit();
        }

        public Config Config => _config;
        private void ConfigInit()
        {
            var text = File.ReadAllText(Path);
            _config = JsonConvert.DeserializeObject<Config>(text);
        }
    }
}
