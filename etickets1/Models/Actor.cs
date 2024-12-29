using System.ComponentModel.DataAnnotations;

namespace etickets1.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Profile Picture")]
        public String ProfilePictureURL { get; set; }
        [Display(Name ="Full Name")]
        public String FullName { get; set; }
        [Display(Name ="Biography")]
        public String Bio { get; set; }
        public List<Actor_Movie> Actor_Movies { get; set; }

    }
}
