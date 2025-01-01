using System.Globalization;
using System.IO;
using System.Text;
using TicketDataAggregator.DataAggregator;
using TicketDataAggregator.DataSaver;
using TicketDataAggregator.TicektApp;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;

const string ticketPath = "C:\\Projects\\C# Masterclass\\Assignments\\TicketsDataAggregator\\Tickets";

try{
    IDataAggregator dataAggregator = new PdfDataAggregator(ticketPath);
    IDataSaver dataSaver = new TextDataSaver(ticketPath, "aggregatedTickets.txt");

    TicketApp app = new TicketApp(dataAggregator, dataSaver);

    app.Run();
}
catch(Exception ex)
{
    Console.WriteLine($"An exception has accured: {ex.Message}");
}

