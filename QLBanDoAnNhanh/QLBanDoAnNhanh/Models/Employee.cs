namespace QLBanDoAnNhanh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            Orders = new HashSet<Order>();
            Products = new HashSet<Product>();
            TypeProducts = new HashSet<TypeProduct>();
        }

        [Key]
        public int IdEmployee { get; set; }

        [StringLength(250)]
        public string NameEmployee { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? BirthDay { get; set; }

        public bool? Gender { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        public int? IdRole { get; set; }

        public virtual RoleEmployee RoleEmployee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TypeProduct> TypeProducts { get; set; }
    }
}
