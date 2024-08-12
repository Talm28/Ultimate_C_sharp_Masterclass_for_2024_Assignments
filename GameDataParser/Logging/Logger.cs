namespace GameDataParser.Logging
{
    public class Logger
    {
        private string _logName = "log.txt";

        public void Message(Exception ex)
        {
            DateTime currentTime = DateTime.Now;
            string timeAndDate = $"[{currentTime}]";
            string expMessage = ex.Message;
            string? stackTrace = ex.StackTrace;
            File.AppendAllText(_logName, timeAndDate + "\n");
            File.AppendAllText(_logName, $"Exception message: {expMessage}\n");
            File.AppendAllText(_logName, $"Stack trace: {stackTrace}\n");
            File.AppendAllText(_logName, "\n");
        }
    }
}