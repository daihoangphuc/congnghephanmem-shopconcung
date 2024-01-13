using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuanLy_ShopConCung.Models
{
    public class Orders
    {
        [Key]
        [Required]
        [Column("OrderId")]
        [StringLength(10)]
        public string? OrderId { get; set; }

        [Required]
        [Column("ProductId")]
        public int ProductId { get; set; }

        [Required]
        [Column("CustomerId")]
        [StringLength(10)]
        public string? CustomerId { get; set; }

        [Required]
        [Column("StaffId")]
        [StringLength(10)]
        public string? StaffId { get; set; }

        [Required]
        [Column("OrderDate")]
        public DateTime OrderDate { get; set; }

        [Required]
        [Column("Quantity")]
        public int Quantity { get; set; }

        [Required]
        [Column("Price")]
        public int Price { get; set; }

        [Required]
        [Column("OderStatus")]
        [StringLength(50)]
        public string? OderStatus { get; set; }

        [ForeignKey("ProductId")]
        public Product? Product { get; set; }

        [ForeignKey("CustomerId")]
        public Customers? Customer { get; set; }

        [ForeignKey("StaffId")]
        public Staffs? Staff { get; set; }
    }
}
