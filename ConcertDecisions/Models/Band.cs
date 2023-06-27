namespace ConcertDecisions.Models
{
    public class Band
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        //Value from 0 to 100 of how much I want to go to a concert of this band
        public int Fan_Level { get; set; }
    }
}
