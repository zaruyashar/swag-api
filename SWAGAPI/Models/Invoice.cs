using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWAGAPI.Models
{
    public class Invoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int invoiceId { get; set; }
        public int clientId { get; set; }
        public DateTime issueDate { get; set; }
        public double totalAmount { get; set; }
        public bool isPaid { get; set; }
    }
}
