using System.ComponentModel.DataAnnotations;

namespace etickets1.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Cinema Logo")]
        public String Logo { get; set; }
        [Display(Name = "Cinema Nmae")]
        public String Name { get; set; }
        [Display(Name = "Description")]
        public String Description { get; set; }

        //Relationships
        public List<Movie> Movies  { get; set; }
    }
}
