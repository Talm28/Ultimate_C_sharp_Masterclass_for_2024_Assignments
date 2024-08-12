namespace GameDataParser.IO
{
    public interface IUserInteraction
    {
        public string GetFileName();
    }

    public class userConsoleInteraction : IUserInteraction
    {
        private IPrinter _printer;

        public userConsoleInteraction(IPrinter printer)
        {
            _printer = printer;
        }

        public string GetFileName()
        {
            bool isInputValid = false;
            string fileName = default;
            do
            {
                fileName = Console.ReadLine();
                try
                {
                    isInputValid = InputValidate(fileName);
                }
                catch(Exception ex)
                {
                    _printer.ShowMassage(ex.Message);
                    isInputValid = false;
                }

            }while(! isInputValid);
            return fileName;
        }

        private bool InputValidate(string input)
        {
            if(input == null)
                throw new FileNullException("File name cannot be null.");
            else if(input == "")
                throw new FileEmptyException("File name cannot be empty.");
            else if(!File.Exists(input))
                throw new FileDoesNotExistException("File not found.");
            return true;
        }
    }
}
