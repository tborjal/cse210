public class Address
{
    public string Street { get; }
    public string City { get; }
    public string State { get; }
    public string Country { get; }
    public string ZipCode { get; }

    public Address(string street, string city, string state, string country, string zipCode)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
        ZipCode = zipCode;
    }

    public bool IsInUSA()
    {
        return Country == "USA";
    }

    public override string ToString()
    {
        return $"{Street}\n{City}, {State}\n{Country} {ZipCode}";
    }
}