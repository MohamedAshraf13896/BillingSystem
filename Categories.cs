using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Model;

namespace Project
{
   
    public partial class Categories : Form
    {
        Bils_SRS db;
        public Categories()
        {
            InitializeComponent();
            db = new Bils_SRS();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            var items_company = db.Company.ToList();
            cb_companyname.DisplayMember = "Company_Name";
            cb_companyname.ValueMember = "Company_ID";
            cb_companyname.DataSource = items_company;
           
            var unit_name = db.Unit.ToList();
            cmb_unit.DisplayMember = "Unit_Name";
            cmb_unit.ValueMember = "Unit_ID";
            cmb_unit.DataSource=unit_name;
        }

  
        public bool CheckPrice(int num)
        { return num >= 0; }

        private void btn_save_item_Click_1(object sender, EventArgs e)
        {

            bool isValid = true;


            //requird
            if (txt_item_data.Text.Equals(""))
            {
                Erroritem.Text = "Item Name is Required";
                Erroritem.ForeColor = Color.Red;
                isValid = false;
            }
            var Item_Data = db.Item.Where(itemx => itemx.Item_Name == txt_item_data.Text).ToList().SingleOrDefault();
            //uniqe 
            if (Item_Data != null)
            {
                Erroritem.Text = "“Item Name Has already existed before";
                isValid = false;
            }
            // check for selling and buying

            int y = 0 ,  x = 0;
            
            if(txt_item_sellig.Text!="" && txt_item_buying.Text!= "")
            {
                 x = int.Parse(txt_item_buying.Text);
                if (!CheckPrice(x))
                {
                    error_Selling_Price.Text = "Buying Price Must Be Grater than or Equal zero";
                    error_Selling_Price.ForeColor = Color.Red;
                    isValid = false;
                }

                 y = int.Parse(txt_item_sellig.Text);
                if (!CheckPrice(y))
                {
                    Eror_selling.Text = "Selling Price Must Be Grater than or Equal zero";
                    Eror_selling.ForeColor = Color.Red;
                    isValid = false;
                }

                if (y < x)
                {
                    Eror_selling.Text = "Selling Price Must Be Grater than or Equal Buying Price";
                    Eror_selling.ForeColor = Color.Red;
                    isValid = false;
                }
            }else
            {
                error_Selling_Price.Text = "You should Enter Price";
                Eror_selling.Text = "You should Enter Price";
                isValid = false;
            }
            if (isValid)
            {
                Item item = new Item()
                {
                    Item_Name = txt_item_data.Text,
                    notes_item = note_item.Text,
                    Selling_Price = int.Parse(txt_item_sellig.Text),
                    Buying_Price = int.Parse(txt_item_buying.Text),
                    Unit_ID = (int)cmb_unit.SelectedValue,
                    Type_ID = (int)cb_typename.SelectedValue,
                };
                

                db.Item.Add(item);
                db.SaveChanges();
                error_Selling_Price.Text = "";
                Eror_selling.Text = "";
                Erroritem.ForeColor = Color.Green;
                Erroritem.Text = "Done";
                //conect item with company 
                item.Type_Obj.Company_ID = (int)cb_companyname.SelectedValue;
                db.SaveChanges();

            }

        }

        private void btn_item_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Want to Delete All Data ?", "Asking", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                txt_item_data.Text = "";
                txt_item_buying.Text = "";
                txt_item_sellig.Text = "";
                note_item.Text = "";
                Eror_selling.Text = "";
                error_Selling_Price.Text = "";
            }
        }

        private void cb_companyname_SelectionChangeCommitted(object sender, EventArgs e)
        {
             var items_type = db.Types.Where(t=>t.Company_ID==(int)cb_companyname.SelectedValue).ToList();
            cb_typename.DisplayMember = "Type_Name";
            cb_typename.ValueMember = "Type_ID";
            cb_typename.DataSource = items_type;
        }
    }

}
