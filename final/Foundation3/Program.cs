using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();

        Address address1 = new Address("1234 Millberry lane", "Colorado Springs", "Colorado", "USA");
        Lecture lecture = new Lecture("On the Power of Play", "A brief history of play and its psychological impacts on mammals", "January 31, 2021", "7:30 PM", address1, "Jordan", 460);
        events.Add(lecture);

        Address address2 = new Address("14598 Stallion Circuit", "Montgomery", "Alabama", "USA");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Kaelyn's Graduation", "A celebration for Kaelyn, who graduated High School last week!", "May 31, 2024", "2:30 pm", address2, "Expected partly cloudy with a chance of rain at 5:00. Bring a jacket!");
        events.Add(outdoorGathering);

        Address address3 = new Address("001 Washington Street", "Washington", "Washington", "USA");
        Reception reception = new Reception("Adam and Eve's Wedding Reception!", "Join us for the first wedding reception since our fall from heaven!", "January 1, 10000 BC", "12:01 pm", address3, "adam&3v3@gmail.com");
        events.Add(reception);


        foreach (Event _event in events)
        {
            Console.WriteLine("\nStandard Details:\n" + _event.StandardDetails());
            Console.WriteLine("\nFull Details:\n" + _event.FullDetails());
            Console.WriteLine("\nShort Details:\n" + _event.ShortDetails());
        }
    }
}