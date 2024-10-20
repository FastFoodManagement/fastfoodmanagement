namespace QLBanDoAnNhanh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        public int IdProduct { get; set; }

        [StringLength(100)]
        public string NameProduct { get; set; }

        [Column(TypeName = "money")]
        public decimal? PriceProduct { get; set; }

        [StringLength(150)]
        public string Decriptions { get; set; }

        public byte[] Images { get; set; }

        public bool? IsActive { get; set; }

        public int IdTypeProduct { get; set; }

        public int? IdEmployee { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public virtual TypeProduct TypeProduct { get; set; }
    }
}
