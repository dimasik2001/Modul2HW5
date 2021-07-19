using System;
using System.IO;

namespace Modul2HW5
{
    public class FileService : IFileService
    {
        private StreamWriter _streamWriter;
        private DirectoryInfo _directoryInfo;
        private int _directoryCapacity;

        public void Init(string fileName, string fileExtension, string directoryPath, int capacity)
        {
            _directoryCapacity = capacity;
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
                ClearDirectory(_directoryCapacity);
            }
        }

        private void ClearDirectory(int max)
        {
            var files = _directoryInfo.GetFiles();

            if (files.Length >= max)
            {
                Array.Sort(files, new CreationTimeComparer());

                for (var i = 0; i < files.Length - (max - 1); i++)
                {
                    files[i].Delete();
                }
            }
        }
    }
}
