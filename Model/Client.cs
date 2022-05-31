using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    public class Client
    {
        [Key]
        [Required]
        [Index("CLIENT ID has already existed before", IsUnique = true)]
        public int Client_ID { get; set; }
        [Required(ErrorMessage = "CLIENT NAME is Required")]
        [MaxLength(50)]
        public string Client_Name { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Address is Required”")]
        [MaxLength(50)]
        public string Address { get; set; }
        public virtual List<Sales_Invoices> Client_Invoices { get; set; }
    }
}
