using TicketDataAggregator.Data;

namespace TicketDataAggregator.DataSaver;

public interface IDataSaver
{
    void SaveData(IEnumerable<Ticket> tickets);
    string GetFilePath();
}