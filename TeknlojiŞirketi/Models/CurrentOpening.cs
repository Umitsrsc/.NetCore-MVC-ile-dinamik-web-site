using System.ComponentModel.DataAnnotations;

namespace TeknlojiŞirketi.Models
{
    public class CurrentOpening
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string? Name { get; set; }
        [StringLength(5000)]
        public string? Description { get; set; }
        public DateTime DateTime { get; set; }=DateTime.Now;
        [StringLength(100)]
        public string? Location { get; set; }

    }
}
