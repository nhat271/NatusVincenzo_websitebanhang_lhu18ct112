namespace Ictshop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sanpham")]
    public partial class Sanpham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sanpham()
        {
            Chitietdonhangs = new HashSet<Chitietdonhang>();
        }

        [Key]
        [Display(Name ="Mã sản phẩm")]
        public int Masp { get; set; }

        [StringLength(50)]
        [Display(Name = "Tên sản phẩm")]
        public string Tensp { get; set; }

        [Display(Name = "Giá tiền")]
        public decimal? Giatien { get; set; }

        [Display(Name = "Số lượng")]
        public int? Soluong { get; set; }

        [Column(TypeName = "ntext")]
        [Display(Name = "Mô tả")]
        public string Mota { get; set; }

        [Display(Name = "Sản phẩm mới")]
        public bool? Sanphammoi { get; set; }

        public int? Ram { get; set; }

        [StringLength(10)]
        [Display(Name = "Ảnh bìa")]
        public string Anhbia { get; set; }

        [Display(Name = "Mã hàng")]
        public int? Mahang { get; set; }
        [Display(Name = "Mã hệ điều hành")]
        public int? Mahdh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitietdonhang> Chitietdonhangs { get; set; }

        public virtual Hangsanxuat Hangsanxuat { get; set; }

        public virtual Hedieuhanh Hedieuhanh { get; set; }
    }
}
