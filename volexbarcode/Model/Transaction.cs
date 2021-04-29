namespace volexbarcode.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transaction
    {
        public int id { get; set; }
        
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime stampDate { get; set; }

        [Required]
        [StringLength(128)]
        public string line { get; set; }

        [Required]
        [StringLength(128)]
        public string partName { get; set; }

        [Required]
        [StringLength(255)]
        public string scannedBarcode { get; set; }

        [Required]
        [StringLength(50)]
        public string status { get; set; }

        [StringLength(225)]
        public string note { get; set; }
    }
}
