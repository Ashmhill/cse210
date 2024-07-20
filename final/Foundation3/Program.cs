using System;

class Program
{
    static void Main()
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Vancouver", "BC", "Canada");
        Address address3 = new Address("789 Oak St", "Sydney", "NSW", "Australia");

        // Create events
        Event lecture = new Lecture("Tech Talk", "A talk on the latest in technology.", new DateTime(2024, 8, 15), new TimeSpan(14, 0, 0), address1, "Dr. Jane Doe", 100);
        Event reception = new Reception("Company Gala", "Annual company gala.", new DateTime(2024, 8, 20), new TimeSpan(18, 0, 0), address2, "rsvp@company.com");
        Event outdoorGathering = new OutdoorGathering("Community Picnic", "A picnic for the community.", new DateTime(2024, 8, 25), new TimeSpan(12, 0, 0), address3, "Sunny with a chance of showers");

        // Create a list of events
        Event[] events = { lecture, reception, outdoorGathering };

        // Display marketing messages for each event
        foreach (Event evt in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(evt.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("Full Details:");
            Console.WriteLine(evt.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("Short Description:");
            Console.WriteLine(evt.GetShortDescription());
            Console.WriteLine(new string('=', 40));
        }
    }
}
