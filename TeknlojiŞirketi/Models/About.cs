using System.ComponentModel.DataAnnotations;

namespace TeknlojiŞirketi.Models
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        [StringLength(5000)]
        public string Details1 { get; set; }
        [StringLength(5000)]
        public string Details2 { get; set; }
        [StringLength(250)]
        public string Image1 { get; set; }
        [StringLength(250)]
        public string Image2 { get; set; }
    }
}
