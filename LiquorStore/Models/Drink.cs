namespace LiquorStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Drink
    {
        public string DrinkId { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        [StringLength(128)]
        public string DrinkVolume { get; set; }

        [Required]
        [StringLength(128)]
        public string AlcoholContent { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime EditDate { get; set; }
    }
}
