namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Province")]
    public partial class Province
    {
        public int ID { get; set; }

        [StringLength(500)]
        public string Name { get; set; }

        public virtual Shop Shop { get; set; }
    }
}
