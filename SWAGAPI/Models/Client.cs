using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWAGAPI.Models
{
    // Industry best practice is to use Fluent API. However, in this demo task, we're using DataAnnotations only.

    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int clientId { get; set; }
        public string companyName { get; set; }
        public string contactPerson { get; set; }
        public double taxNumber { get; set; }
    }
}
