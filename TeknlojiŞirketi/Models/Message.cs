

using System.ComponentModel.DataAnnotations;

namespace TeknlojiŞirketi.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string? SenderMail { get; set; }
        [StringLength(50)]
        public string ReceiverMail { get; set; }
        [StringLength(100)]
        public string Subject { get; set; }
        public string MessageContent { get; set; }
        public DateTime MessageDate { get; set; } = DateTime.Now;
    }
}
