using System;
namespace Modul2HW5
{
    public class Logger
    {
        private readonly IConfigService _configService;
        private readonly IFileService _fileService;
        private readonly LoggerConfig _loggerConfig;
        public Logger(IConfigService configService, IFileService fileService)
        {
            _configService = configService;
            _loggerConfig = _configService.Config.LoggerConfig;
            _fileService = fileService;
            FileServiceInit();
        }

        public void Write(LogType type, string message)
        {
            var log = $"{DateTime.UtcNow.ToString(_loggerConfig.TimeFormat)}: {type}: {message}";
            Console.WriteLine(log);
            _fileService.Write(log);
        }

        public void WriteError(string message)
        {
            Write(LogType.Error, message);
        }

        public void WriteWarning(string message)
        {
            Write(LogType.Warning, message);
        }

        public void WriteInfo(string message)
        {
            Write(LogType.Info, message);
        }

        private void FileServiceInit()
        {
            var fileName = DateTime.UtcNow.ToString(_loggerConfig.NameFormat);
            var fileExtension = _loggerConfig.FileExtension;
            var directoryPath = _loggerConfig.DirectoryPath;
            _fileService.Init(fileName, fileExtension, directoryPath);
        }
    }
}
