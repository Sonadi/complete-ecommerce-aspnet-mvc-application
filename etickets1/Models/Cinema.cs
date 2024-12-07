using System.ComponentModel.DataAnnotations;

namespace etickets1.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public String Logo { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }

        //Relationships
        public List<Movie> Movies  { get; set; }
    }
}
