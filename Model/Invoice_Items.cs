using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    public class Invoice_Items
    {
        [ForeignKey("item_obj")]
        [Required(ErrorMessage = "Item ID Is Required")]
        [Key, Column(Order = 1)]
        public int Item_ID { get; set; }
        [ForeignKey("Invoices_obj")]
        [Required(ErrorMessage = "Invoice_ID Is Required")]
        [Key, Column(Order = 2)]
        public int Invoice_ID { get; set; }
        [Required(ErrorMessage = "Quantity is Required")]
        public int Quantity { get; set; }

        public virtual Item item_obj { get; set; }
        public virtual Sales_Invoices Invoices_obj { get; set; }

    }
}
