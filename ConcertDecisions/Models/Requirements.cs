namespace ConcertDecisions.Models
{
    public class Requirements
    {
        public int Id { get; set; }

        //Event Type (Concert, festival)
        public string Event_Type { get; set; } = string.Empty;

        //Excelent Points to go to an Event, Dont miss it
        public int Excelent_Points { get; set; }

        //Good Points to go to an Event
        public int Good_Points { get; set; }

        //Regular points to go to an Event
        public int Regular_Points { get; set; }

        //Minimum of points to go to an Event
        public int Minimum_Points { get; set; }


    }
}
