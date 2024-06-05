using System;
using System.ComponentModel.DataAnnotations;

namespace MagicVilla_Web.Models.Dto
{
    // work with api
	public class VillaNumberUpdateDTO
    {
        [Required]
        public int VillaNo { get; set; }

        [Required]
        public int VillaID { get; set; }

        public string SpecialDetails { get; set; }
    }
}

// working with API