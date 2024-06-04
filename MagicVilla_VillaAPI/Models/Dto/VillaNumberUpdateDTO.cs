using System;
using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Models.Dto
{
    // work with api
	public class VillaNumberUpdateDTO
    {
        [Required]
        public int VillaNo { get; set; }

        public string SpecialDetails { get; set; }
    }
}

// working with API