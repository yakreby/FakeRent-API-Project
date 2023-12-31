﻿using System.ComponentModel.DataAnnotations;

namespace FakeRentAPI.Models.Dto
{
    public class HouseNumberUpdateDTO
    {
        [Required]
        public int HouseNo { get; set; }
        [Required]
        public int HouseId { get; set; }
        public string? SpecialDetails { get; set; }
    }
}
