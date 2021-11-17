namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Advertise")]
    public partial class Advertise
    {
        public int ID { get; set; }

        [StringLength(500)]
        public string Url { get; set; }

        public int? Width { get; set; }

        public int? Height { get; set; }

        [StringLength(500)]
        public string Link { get; set; }

        public int? Target { get; set; }

        public int? Position { get; set; }

        public int? Order { get; set; }

        public int? Status { get; set; }
    }
}
