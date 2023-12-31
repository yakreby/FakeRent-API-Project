﻿using System.ComponentModel.DataAnnotations;

namespace FakeRentAPI.Models.Dto
{
    public class HouseCreateDTO
    {
        [Required]
        [MaxLength(30)]
        public string? Name { get; set; }
        public string? Details { get; set; }
        [Required]
        public double Rate { get; set; }
        public int Occupancy { get; set; }
        public int SquareFeet { get; set; }
        public string? ImageUrl { get; set; }
        public string? Amenity { get; set; }
    }
}
