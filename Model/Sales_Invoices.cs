using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    public class Sales_Invoices
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "BILL DATE is Required")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Quantity is Required")]

        public int Total_Price { get; set; }
        [NotMapped]
        public int Net { get; set; }
        [ForeignKey("Client_obj")]
        public int Client_ID { get; set; }

        [ForeignKey("Employe_obj")]
        public int Employee_ID { get; set; }
        public virtual Client Client_obj { get; set; }
        public virtual List<Invoice_Items> Invoices { get; set; }
        public virtual Employe Employe_obj { get; set; }
    }
}
