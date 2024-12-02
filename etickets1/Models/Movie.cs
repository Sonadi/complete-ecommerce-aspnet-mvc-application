using etickets1.Data;
using System.ComponentModel.DataAnnotations;

namespace etickets1.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        public String CinemaNAme { get; set; }
        public String MovieActors { get; set; }
        public Moviecategory MovieCategory { get; set; }
        public String MovieProducer { get; set; }

        public String ImageURL { get; set; }
    }
}
