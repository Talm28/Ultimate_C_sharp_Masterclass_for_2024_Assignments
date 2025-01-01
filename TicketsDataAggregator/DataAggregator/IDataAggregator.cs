using TicketDataAggregator.Data;

namespace TicketDataAggregator.DataAggregator;

public interface IDataAggregator
{
    IEnumerable<Ticket> GetData();
}