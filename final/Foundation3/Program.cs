using System;
public class Program
{
    public static void Main(string[] args)
    {
        Address address = new Address { Street = "39 Monserrat Hills", City = "NCR", State = "MM", ZipCode = "1810" };

        Event lecture = new Lecture("Big Bang Theory", "A fascinating lecture about space", new DateTime(2023, 1, 3), new TimeSpan(14, 0, 0), address, "Dr. Smith", 200);
        Event reception = new Reception("Pool Blast", "A cool party to celebrate something", new DateTime(2023, 11, 27), new TimeSpan(18, 0, 0), address, "terence@coolparty.com");
        Event outdoorGathering = new OutdoorGathering("Windy Chilly", "An outdoor picnic with a twist", new DateTime(2023, 12, 12), new TimeSpan(12, 0, 0), address, "Humid and Warm");

        string lectureStandardDetails = lecture.GetStandardDetails();
        string lectureFullDetails = lecture.GetFullDetails();
        string lectureShortDescription = lecture.GetShortDescription();

        string receptionStandardDetails = reception.GetStandardDetails();
        string receptionFullDetails = reception.GetFullDetails();
        string receptionShortDescription = reception.GetShortDescription();

        string outdoorGatheringStandardDetails = outdoorGathering.GetStandardDetails();
        string outdoorGatheringFullDetails = outdoorGathering.GetFullDetails();
        string outdoorGatheringShortDescription = outdoorGathering.GetShortDescription();

        Console.WriteLine(lectureStandardDetails);
        Console.WriteLine(lectureFullDetails);
        Console.WriteLine(lectureShortDescription);
        Console.WriteLine("---------------------------------------------------------------------------");

        Console.WriteLine(receptionStandardDetails);
        Console.WriteLine(receptionFullDetails);
        Console.WriteLine(receptionShortDescription);
        Console.WriteLine("---------------------------------------------------------------------------");

        Console.WriteLine(outdoorGatheringStandardDetails);
        Console.WriteLine(outdoorGatheringFullDetails);
        Console.WriteLine(outdoorGatheringShortDescription);
        Console.WriteLine("---------------------------------------------------------------------------");
    }
}