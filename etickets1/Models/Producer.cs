﻿using System.ComponentModel.DataAnnotations;

namespace etickets1.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }
        public String ProfilePictureURL { get; set; }
        public String FullName { get; set; }
        public String Bio { get; set; }
    }
}
