namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GroupProduct")]
    public partial class GroupProduct
    {
        public int ID { get; set; }

        [StringLength(500)]
        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        [StringLength(500)]
        public string Image { get; set; }

        public int? Order { get; set; }

        public int? Status { get; set; }

        public virtual Product Product { get; set; }
    }
}
