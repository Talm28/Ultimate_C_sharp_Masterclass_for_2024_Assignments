using TicketDataAggregator.DataAggregator;
using TicketDataAggregator.Data;
using TicketDataAggregator.DataSaver;

namespace TicketDataAggregator.TicektApp;

public class TicketApp{

    private IDataAggregator _dataAggregator;
    private IDataSaver _dataSaver;

    public TicketApp(IDataAggregator dataAggregator, IDataSaver dataSaver)
    {
        _dataAggregator = dataAggregator;
        _dataSaver = dataSaver;
    }

    public void Run()
    {
        List<Ticket> ticketList = _dataAggregator.GetData().ToList();
        _dataSaver.SaveData(ticketList);
        Console.WriteLine($"Result saved to {_dataSaver.GetFilePath()}");
        Console.WriteLine("Press any key to close.");
        Console.ReadLine();
    }
}