using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWAGAPI.Models
{
    public class Service
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int serviceId { get; set; }
        public string serviceName { get; set; }
        public float unitPrice { get; set; }
        public string description { get; set; }
    }
}
