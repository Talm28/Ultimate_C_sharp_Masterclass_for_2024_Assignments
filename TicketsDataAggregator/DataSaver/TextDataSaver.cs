using System.Globalization;
using TicketDataAggregator.Data;

namespace TicketDataAggregator.DataSaver;

public class TextDataSaver : IDataSaver
{
    public string _ticketPath;

    public TextDataSaver(string ticketPath, string fileName)
    {
        _ticketPath = Path.Combine(ticketPath, fileName);
    }

    public void SaveData(IEnumerable<Ticket> tickets)
    {
        using(StreamWriter writetext = new StreamWriter(_ticketPath))
        {
            foreach(Ticket ticket in tickets)
            {
                writetext.WriteLine($"{ticket.title, -40} | {ticket.date.ToString("d", CultureInfo.InvariantCulture)} | {ticket.date.ToString("t", CultureInfo.InvariantCulture)}");
            }
        }
    }

    public string GetFilePath() => _ticketPath;
}