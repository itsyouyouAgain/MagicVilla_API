﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MagicVilla_Web.Models.Dto
{
    // work with api
	public class VillaNumberDTO
    {
        [Required]
        public int VillaNo { get; set; }

        [Required]
        public int VillaID { get; set; }

        public string SpecialDetails { get; set; }

        public VillaDTO Villa { get; set; }
    }
}

// working with API