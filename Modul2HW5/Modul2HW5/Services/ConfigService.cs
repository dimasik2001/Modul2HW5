using System;
using System.IO;
using Newtonsoft.Json;

namespace Modul2HW5
{
    public class ConfigService : IConfigService
    {
        private readonly string _path;
        private Config _config;
        public ConfigService()
        {
            _path = "Configs/Config.json";
            ConfigInit();
        }

        public Config Config => _config;
        private void ConfigInit()
        {
            var text = File.ReadAllText(_path);
            _config = JsonConvert.DeserializeObject<Config>(text);
        }
    }
}
