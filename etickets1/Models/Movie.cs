using etickets1.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public Moviecategory MovieCategory { get; set; }
        public String ImageURL { get; set; }

        //Relationships
        public List<Actor_Movie> Actor_Movies { get; set; }

        //cinema
        public int CinemaaId { get; set; }
        [ForeignKey("CinemaaId")]
        public Cinema Cinema { get; set; }

        //producer
        public int ProducerrId { get; set; }
        [ForeignKey("ProducerrId")]
        public Producer Producer { get; set; }

    }
}
