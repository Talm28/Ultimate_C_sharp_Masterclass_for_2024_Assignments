using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;
using System.Text;
using System.Globalization;
using TicketDataAggregator.Data;

namespace TicketDataAggregator.DataAggregator;

public class PdfDataAggregator : IDataAggregator
{
    private string _ticketPath;
    private Dictionary<string, CultureInfo> _cultureMap = new Dictionary<string, CultureInfo>{
        {"com", new CultureInfo("en-US")}, 
        {"fr", new CultureInfo("fr-FR")}, 
        {"jp", new CultureInfo("ja-JP")}
    };

    public PdfDataAggregator(string ticketPath)
    {
        _ticketPath = ticketPath;
    }

    public IEnumerable<Ticket> GetData()
    {
        List<Ticket> tickets = new List<Ticket>();

        // Get all pdf files from path
        string[] files = Directory.GetFiles(_ticketPath, "*.pdf");

        // Read all pdf tickets
        foreach(string file in files)
        {
            using (PdfDocument document = PdfDocument.Open(file))
            {
                Page page = document.GetPage(1);
                // Get tickets from text
                List<Ticket> fileTickets = GetTickets(page); 
                tickets.AddRange(fileTickets);
            }
        }
        
        return tickets;
    }

    private List<Ticket> GetTickets(Page page)
    {
        List<Ticket> tickets = new List<Ticket>();

        string pageText = page.Text;

        string[] textWords = pageText.Split(new string[] {"Title:", "Date:", "Time:", "Visit us:"}, StringSplitOptions.None);
        string region = GetRegion(textWords[textWords.Length - 1]);

        for(int i = 1; i < textWords.Length - 3; i+=3)
        {
            Ticket ticket = new Ticket();
            ticket.title = textWords[i];
            ticket.date = DateTime.Parse(textWords[i+1] + " " + textWords[i+2], _cultureMap[region]);
            tickets.Add(ticket);
        }

        return tickets;
    }

    private string GetRegion(string url)
    {
        string[] urlParts = url.Split('.');
        return urlParts[urlParts.Length - 1];
    }
}