using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuanLy_ShopConCung.Models
{
    public class Staffs
    {
        [Key]
        [Required]
        [Column("StaffId")]
        [StringLength(10)]
        public string? StaffId { get; set; }

        [Column("StaffName")]
        [StringLength(50)]
        public string? StaffName { get; set; }

        [Column("StaffGender")]
        [StringLength(5)]
        public string? StaffGender { get; set; }

        [Column("StaffRole")]
        [StringLength(50)]
        public string? StaffRole { get; set; }


        [Column("StaffPhone")]
        [StringLength(10)]
        public string? StaffPhone { get; set; }
    }
}
