using System.Collections;
using System.Net.NetworkInformation;

namespace CoockieCoockbook.FileThing
{
    public class FileGenerator
    {
        
        private string _fileName;
        private FileFormat _fileFormat;

        public FileGenerator(string fileName, FileFormat fileFormat)
        {
            _fileName = fileName;
            _fileFormat = fileFormat;
        } 

        public string Generate()
        {
            string filePrefix = "";
            switch (_fileFormat)
            {
                case FileFormat.Json:
                    filePrefix = "json";
                    break;
                case FileFormat.Text:
                    filePrefix = "txt";
                    break;   
            }
            return $"{_fileName}.{filePrefix}";
        }
    }
}