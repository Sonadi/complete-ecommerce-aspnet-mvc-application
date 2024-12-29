﻿using System.ComponentModel.DataAnnotations;

namespace etickets1.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile picture")]
        public String ProfilePictureURL { get; set; }
        [Display(Name = "Full name")]
        public String FullName { get; set; }
        [Display(Name = "Biography")]
        public String Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
