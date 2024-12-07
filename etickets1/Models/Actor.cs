using System.ComponentModel.DataAnnotations;

namespace etickets1.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public String ProfilePictureURL { get; set; }
        public String FullName { get; set; }
        public String Bio { get; set; }
        public List<Actor_Movie> Actor_Movies { get; set; }

    }
}
