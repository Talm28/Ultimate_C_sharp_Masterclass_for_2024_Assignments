namespace TicketDataAggregator.Data;

public struct Ticket{
    public string title;
    public DateTime date;

    public Ticket(string title, DateTime date)
    {
        this.title = title;
        this.date = date;
    }
}