using System;

class Program
{
    static void Main(string[] args)
    {
        Event baseEvent = new Event();
        Address lectureAddress = new Address("420 Beaker Street", "Rexburg", "Idaho", "USA");
        Lecture lectureEvent = new Lecture("Brother Hayton on coding", "Brother Hayton of ByuL will be providing information on how we can better code.", "12-11-25", "9:00 AM", lectureAddress, "Lecture", "Aidrian Hayton", 100);
        Address receptionAddress = new Address("555 Reception way", "San Diego", "California", "USA");
        Reception receptionEvent = new Reception("Wedding of Matthew and Kate", "The marraige of Matthew Pantry and Kate Loveland", "12-15-25", "6:00 PM", receptionAddress, "Reception", "Matt.Kay@email.com");
        Address outdoorGatheringAddress = new Address("505 Middle da woods way", "Denver", "Colorado", "USA");
        OutdoorGathering outdoorGatheringEvent = new OutdoorGathering("Search for Bigfoot", "Join us as we search the woods for bigfoot in order to find his location, snacks will be provided", "7-2-25", "3:00AM", outdoorGatheringAddress, "Ourdoor Gathering", "Cloudy");

        Console.WriteLine("Details for the Events: ");
        Console.WriteLine("====================================");  
        lectureEvent.DisplayStandardDetails();
        Console.WriteLine("====================================");
        receptionEvent.DisplayStandardDetails();
        Console.WriteLine("====================================");
        outdoorGatheringEvent.DisplayStandardDetails();
        Console.WriteLine();

        Console.WriteLine("Full details for the Events: ");
        Console.WriteLine("====================================");
        lectureEvent.DisplayStandardDetails();
        lectureEvent.LectureDetails();
        Console.WriteLine("====================================");
        receptionEvent.DisplayStandardDetails();
        receptionEvent.DisplayReceptionDetails();
        Console.WriteLine("====================================");
        outdoorGatheringEvent.DisplayStandardDetails();
        outdoorGatheringEvent.DisplayWeatherDetails();
        Console.WriteLine();

        Console.WriteLine("Short decscription for the Events: ");
        Console.WriteLine("====================================");
        lectureEvent.DisplayShortDetails();
        Console.WriteLine("====================================");
        receptionEvent.DisplayShortDetails();
        Console.WriteLine("====================================");
        outdoorGatheringEvent.DisplayShortDetails();
        Console.WriteLine();    
        
    }
}