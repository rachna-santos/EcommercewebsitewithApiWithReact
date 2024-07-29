﻿using System.ComponentModel.DataAnnotations;

namespace EcommercewebsitewithApi.Model
{
    public class City
    {
        [Key]
        public int cityId { get; set; }
        [Required]
        [MaxLength(200)]
        public string cityName { get; set; }
        [Required]
        public int countryId { get; set; }
        //public virtual Country Country { get; set; }
    }
}
