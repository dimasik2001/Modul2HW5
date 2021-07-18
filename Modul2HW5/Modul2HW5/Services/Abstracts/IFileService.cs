namespace Modul2HW5
{
   public interface IFileService
    {
        public void Init(string fileName, string fileExtension, string directoryPath);
        public void Write(string text);
    }
}
