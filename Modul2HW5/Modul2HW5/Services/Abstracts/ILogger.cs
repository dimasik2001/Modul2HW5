namespace Modul2HW5
{
    public interface ILogger
    {
        public void Write(LogType type, string message);
        public void WriteError(string message);
        public void WriteWarning(string message);
        public void WriteInfo(string message);
    }
}
