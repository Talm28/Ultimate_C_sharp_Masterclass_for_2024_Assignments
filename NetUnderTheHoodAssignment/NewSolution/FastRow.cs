namespace CsvDataAccess.NewSolution;

public class FastRow
{
    private Dictionary<string, bool> _dataBool;
    private Dictionary<string, int> _dataInt;
    private Dictionary<string, decimal> _dataDecimal;
    private Dictionary<string, string> _dataString;

    public FastRow()
    {
        _dataBool = new Dictionary<string,bool>();
        _dataInt = new Dictionary<string,int>();
        _dataDecimal = new Dictionary<string,decimal>();
        _dataString = new Dictionary<string,string>();
    }

    public void AssignCell(string columnName, bool value)
    {
        _dataBool[columnName] = value;
    }
    public void AssignCell(string columnName, int value)
    {
        _dataInt[columnName] = value;
    }
    public void AssignCell(string columnName, decimal value)
    {
        _dataDecimal[columnName] = value;
    }
    public void AssignCell(string columnName, string value)
    {
        _dataString[columnName] = value;
    }


    public object GetAtColumn(string columnName)
    {
        if(_dataBool.ContainsKey(columnName)) return _dataBool[columnName];
        else if(_dataInt.ContainsKey(columnName)) return _dataInt[columnName];
        else if(_dataDecimal.ContainsKey(columnName)) return _dataDecimal[columnName];
        else if(_dataString.ContainsKey(columnName)) return _dataString[columnName];
        return null;
    }
}