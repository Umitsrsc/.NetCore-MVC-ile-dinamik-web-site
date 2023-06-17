using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeknlojiŞirketi.Models
{
    public class Solution
    {
        [Key]
        
        public int Id { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(5000)]
        public string Description { get; set; }
        [StringLength(250)]
        public string Image { get; set; }
        
       
        
    }
}
