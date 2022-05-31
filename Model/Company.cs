using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    public class Company
    {
        [Key]
        public int Company_ID { get; set; }
        [Required(ErrorMessage = "COMPANY NAME is Required")]
        [Index("UniqueConstraint", IsUnique = true)]
        [MaxLength(50)]
        public string Company_Name { get; set; }
        [MaxLength(100)]
        public string Company_Notes { get; set; }
        public virtual List<Types>Company_Type { get; set; }
        
    }
}
