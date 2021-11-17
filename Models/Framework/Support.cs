namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Support")]
    public partial class Support
    {
        public int ID { get; set; }

        [StringLength(500)]
        public string Name { get; set; }

        [StringLength(20)]
        public string Tel { get; set; }

        public int? Type { get; set; }

        [StringLength(50)]
        public string Nick { get; set; }

        public int? Order { get; set; }

        public int? Status { get; set; }
    }
}
