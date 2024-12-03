namespace etickets1.Models
{
    public class Actor_Movie
    {
        public int MovieeId { get; set; }
        public Movie Movie { get; set; }
        public int ActorrId { get; set; }
        public Actor Actor { get; set; }

    }
}
