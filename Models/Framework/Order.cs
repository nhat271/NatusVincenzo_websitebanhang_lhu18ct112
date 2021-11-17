namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        public int ID { get; set; }

        public int? Customer_ID { get; set; }

        public double? TotalMoney { get; set; }

        public DateTime? Date { get; set; }

        public int? Status { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual OrderDetail OrderDetail { get; set; }
    }
}
