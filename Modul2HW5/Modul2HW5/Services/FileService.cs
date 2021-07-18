using System;
using System.IO;

namespace Modul2HW5
{
    public class FileService : IFileService
    {
        private StreamWriter _streamWriter;
        private DirectoryInfo _directoryInfo;

        public void Init(string fileName, string fileExtension, string directoryPath)
        {
            DirectoryInit(directoryPath);
            _streamWriter = new StreamWriter($"{directoryPath}{fileName}{fileExtension}", true);
        }

        public void Write(string text)
        {
            _streamWriter.WriteLine(text);
        }

        private void DirectoryInit(string directoryPath)
        {
            _directoryInfo = new DirectoryInfo(directoryPath);
            if (!_directoryInfo.Exists)
            {
                _directoryInfo.Create();
            }
            else
            {
                ClearDirectory();
            }
        }

        private void ClearDirectory()
        {
            var files = _directoryInfo.GetFiles();

            if (files.Length > 3)
            {
                Array.Sort(files, new CreationTimeComparer());

                for (var i = 0; i < files.Length - 2; i++)
                {
                    files[i].Delete();
                }
            }
        }
    }
}
