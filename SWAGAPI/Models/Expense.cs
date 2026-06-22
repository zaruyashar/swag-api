using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWAGAPI.Models
{
    public class Expense
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int expenseId { get; set; }
        public string category { get; set; } // e.g. sw license, hw, travel etc.
        public float amount { get; set; }
        public DateTime expenseDate { get; set; }
        public string receiptUrl { get; set; }
    }
}
