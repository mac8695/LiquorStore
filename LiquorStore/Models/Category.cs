namespace LiquorStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Category
    {
        public string CategoryId { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime EditDate { get; set; }
    }
}
