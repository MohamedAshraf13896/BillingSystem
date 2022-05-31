using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    public class Employe
    {
        [Key]
        [Required]
        [Index("Employe_ID has already existed before", IsUnique = true)]
        public int Employe_ID { get; set; }
        [MaxLength(100)]
        public string Employe_Name { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Employe DATE is Required")]
        public DateTime Employe_Date { get; set; }
        public virtual List<Sales_Invoices> employe_invoice { get; set; }



      
    }
}
