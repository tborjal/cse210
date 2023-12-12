public class Reception : Event
{
    private string email;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string email)
        : base(title, description, date, time, address)
    {
        this.email = email;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nEmail: {email}";
    }
}