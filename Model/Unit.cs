using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    public class Unit
    {
        [Key]
        public int Unit_ID { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "Unit NAME is Required")]
        public string Unit_Name { get; set; }
        [MaxLength(100)]
        public string Unit_Notes { get; set; }
        public virtual List<Item> Item_Unit { get; set; }
    }
}
