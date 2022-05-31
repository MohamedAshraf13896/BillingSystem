using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Model
{
    public class Item
    {
        [Key]
        public int Item_ID { get; set; }
        [MaxLength(50)]
        [Required]
        [Index("ITEM NAME has already existed before", IsUnique = true)]
        public string Item_Name { get; set; }
        public int Selling_Price { get; set; }
        public int Buying_Price { get; set; }
        public string notes_item { get; set; }


        [ForeignKey("Unit_obj")]
        [Required]
        public int Unit_ID { get; set; }

        [ForeignKey("Type_Obj")]
        [Required]
        public int Type_ID { get; set; }
        public virtual Types Type_Obj  { get; set; }
        public virtual List<Invoice_Items> Invoices { get; set; }
        public virtual Unit Unit_obj { get; set; }

    }
}
