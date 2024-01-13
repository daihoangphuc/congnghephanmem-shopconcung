using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuanLy_ShopConCung.Models
{
    public class Customers
    {
        [Key]
        [Required]
        [Column("CustomerId")]
        [StringLength(10)]
        public string? CustomerId { get; set; }

        [Column("CustomerName")]
        [StringLength(50)]
        public string? CustomerName { get; set; }

        [Column("CustomerGender")]
        [StringLength(5)]
        public string? CustomerGender { get; set; }

        [Column("CustomerCity")]
        [StringLength(50)]
        public string? CustomerCity { get; set; }


        [Column("CustomerPhone")]
        [StringLength(10)]
        public string? CustomerPhone { get; set; }
    }
}
