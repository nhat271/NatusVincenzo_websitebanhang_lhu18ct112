namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int ID { get; set; }

        [StringLength(500)]
        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        public string Detail { get; set; }

        public double? Price { get; set; }

        [StringLength(500)]
        public string Image { get; set; }

        public double? PriceNew { get; set; }

        public DateTime? Date { get; set; }

        public int? Order { get; set; }

        public int? Status { get; set; }

        public int? GroupProduct_ID { get; set; }

        public virtual GroupProduct GroupProduct { get; set; }

        public virtual OrderDetail OrderDetail { get; set; }
    }
}
