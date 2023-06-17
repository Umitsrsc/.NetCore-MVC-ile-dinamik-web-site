using System.ComponentModel.DataAnnotations;

namespace TeknlojiŞirketi.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string? Surname { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        public string? Phone { get; set; }

        [StringLength(50)]
        public string Subject { get; set; }
        [StringLength(1000)]
        public string Message { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
    }
}
