using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace Modul2HW5
{
    public class AppStarter
    {
        public void Run()
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ILogger, Logger>()
                .AddTransient<IConfigService, ConfigService>()
                .AddTransient<IFileService, FileService>()
                .AddTransient<Actions>()
                .AddTransient<Starter>().BuildServiceProvider();
            var starter = serviceProvider.GetService<Starter>();
            starter.Run();
        }
    }
}
