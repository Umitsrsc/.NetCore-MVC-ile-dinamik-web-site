using System.ComponentModel.DataAnnotations;

namespace TeknlojiŞirketi.Models
{
    public class News
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [StringLength(250)]
        public string Image { get; set; }
        public DateTime DateTime { get; set; }
    }
}
