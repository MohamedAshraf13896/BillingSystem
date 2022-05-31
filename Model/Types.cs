using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    public class Types
    {
        [Key]
        public int Type_ID { get; set; }
        [MaxLength(50)]
        [Index("TYPE NAME has already existed before", IsUnique = true)]
        [Required(ErrorMessage = "TYPE NAME is Required")]
        public string Type_Name { get; set; }
        [MaxLength(100)]
        public string Type_Notes { get; set; }
        [ForeignKey("Company_obj")]
        public int Company_ID { get; set; }
        public virtual List<Item>Items { get; set; }
        public virtual Company Company_obj  { get; set; }
    }
}
