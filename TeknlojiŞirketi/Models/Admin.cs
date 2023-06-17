using System.ComponentModel.DataAnnotations;

namespace TeknlojiŞirketi.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [StringLength(50)]
        public string AdminUserName { get; set; }
        [StringLength(25)]
        public string AdminPassword { get; set; }
        [StringLength(10)]
        public string AdminRole { get; set; }
    }
}
