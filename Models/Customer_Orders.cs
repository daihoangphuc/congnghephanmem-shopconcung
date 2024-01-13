using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuanLy_ShopConCung.Models
{
    public class Customer_Orders
    {
        [Key]
        [Required]
        public string? Customer_OrderId { get; set; }
        [Column("CustomerId")]
        [StringLength(10)]
        public string? CustomerId { get; set; }

        [Column("OrderId")]
        [StringLength(10)]
        public string? OrderId { get; set; }

        [ForeignKey("CustomerId")]
        public Customers? Customer { get; set; }

        [ForeignKey("OrderId")]
        public Orders? Order { get; set; }
    }
}
