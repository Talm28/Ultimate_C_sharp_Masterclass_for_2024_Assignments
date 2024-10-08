using CsvDataAccess.CsvReading;
using CsvDataAccess.Interface;

namespace CsvDataAccess.NewSolution;

public class FastTableDataBuilder : ITableDataBuilder
{
     public ITableData Build(CsvData csvData)
    {
        var resultRows = new List<FastRow>();

        foreach (var row in csvData.Rows)
        {
            FastRow fastRow = new FastRow();
            for (int columnIndex = 0; columnIndex < csvData.Columns.Length; ++columnIndex)
            {
                var column = csvData.Columns[columnIndex];
                string valueAsString = row[columnIndex]; 
                
                // Convert and insert the value to the row
                if(string.IsNullOrEmpty(valueAsString))
                    continue;
                else if (valueAsString == "TRUE") 
                {
                    fastRow.AssignCell(column, true);
                }
                else if (valueAsString == "FALSE")
                {
                    fastRow.AssignCell(column, false);
                }
                else if (int.TryParse(valueAsString, out var valueAsInt))
                {
                    fastRow.AssignCell(column, valueAsInt);
                }
                else if (valueAsString.Contains(".") && decimal.TryParse(valueAsString, out var valueAsDecimal))
                {
                    fastRow.AssignCell(column, valueAsDecimal);
                }
                else
                    fastRow.AssignCell(column, valueAsString);
            }

            resultRows.Add(fastRow);
        }

        return new FastTableData(csvData.Columns, resultRows);
    }


    private void InsertValueToFastRow(string value, FastRow fastRow, string column)
    {
        if(string.IsNullOrEmpty(value))
            return;
        else if (value == "TRUE") 
        {
            fastRow.AssignCell(column, true);
        }
        else if (value == "FALSE")
        {
            fastRow.AssignCell(column, false);
        }
        else if (int.TryParse(value, out var valueAsInt))
        {
            fastRow.AssignCell(column, valueAsInt);
        }
        else if (value.Contains(".") && decimal.TryParse(value, out var valueAsDecimal))
        {
            fastRow.AssignCell(column, valueAsDecimal);
        }
        else
            fastRow.AssignCell(column, value);
    }
}
