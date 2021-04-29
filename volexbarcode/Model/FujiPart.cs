namespace volexbarcode.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FujiPart
    {
        public int id { get; set; }

        [Required]
        [StringLength(128)]
        public string name { get; set; }

        [Required]
        [StringLength(255)]
        public string reg { get; set; }
    }
}
