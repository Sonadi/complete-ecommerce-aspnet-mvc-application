namespace etickets1.Models
{
    public class Actor
    {
        [key]
        public int ActorId { get; set; }
        public String ProfilePictureURL { get; set; }
        public String FullName { get; set; }
        public String Bio { get; set; }

    }
}
