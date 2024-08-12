namespace GameDataParser.IO
{
    public class FileNullException : Exception
    {
        public FileNullException(){}

        public FileNullException(string message) : base(message){}

        public FileNullException(string message, Exception innerException) : base(message, innerException){}
    }

    public class FileEmptyException : Exception
    {
        public FileEmptyException(){}

        public FileEmptyException(string message) : base(message){}

        public FileEmptyException(string message, Exception innerException) : base(message, innerException){}
    }

    public class FileDoesNotExistException : Exception
    {
        public FileDoesNotExistException(){}

        public FileDoesNotExistException(string message) : base(message){}

        public FileDoesNotExistException(string message, Exception innerException) : base(message, innerException){}
    }
}
