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
    public partial class sales_invoice : Form
    {
        Bils_SRS db;
        Item item;
        List<object> ite;
        decimal billTotal = 0;
        public sales_invoice()
        {
            InitializeComponent();
            db = new Bils_SRS();
            ite = new List<object>();
        }

        private void sales_invoice_Load(object sender, EventArgs e)
        {
            var sales_clientname = db.Client.ToList();
            cb_sales_clientname.DisplayMember = "Client_Name";
            cb_sales_clientname.ValueMember = "Client_ID";
            cb_sales_clientname.DataSource = sales_clientname;
            var sales_itemname = db.Item.ToList();
            cb_sales_itemname.DisplayMember = "Item_Name";
            cb_sales_itemname.ValueMember = "Item_ID";
            cb_sales_itemname.DataSource = sales_itemname;
            var id_sales = db.Sales_Invoices.Select(t => t).ToList();
            txt_numbersales.SelectedText = (id_sales.Count + 1).ToString();
            txt_numbersales.Enabled = false;
            date_now.Value = DateTime.Now;
            txt_quatity_sales.Enabled = false;
            txt_valuediscount.Enabled = false;
            txt_net.Enabled = false;
            txt_billstotal.Enabled = false;
            txt_rest.Enabled = false;
            txt_total_sales.Enabled=false;
            cb_employeename.DisplayMember = "Employe_Name";
            cb_employeename.ValueMember = "Employe_ID ";
            cb_employeename.DataSource = db.Employes.ToList();
            date_now.Format = DateTimePickerFormat.Short;
            date_now.ShowUpDown = true;
            txt_sellingprice_sales.Enabled = false;
            //dvg_sales.DataSource = db.Sales_Invoices.Select(n=> new { n.ID , n.Client_ID , n.Total_Price , n.Employee_ID, n.Date , n.Net}).ToList();
            //dvg_sales.DataSource = db.Sales_Invoices.ToList();
        }
        //item selected
        private void cb_sales_itemname_SelectionChangeCommitted(object sender, EventArgs e)
        {
            item = db.Item.Where(t => t.Item_ID == (int)cb_sales_itemname.SelectedValue).First();
            txt_sellingprice_sales.Text = item.Selling_Price.ToString();
            txt_quatity_sales.Enabled = true;
            txt_quatity_sales.Value = 0;
            txt_total_sales.Text = "0";
        }

        private void txt_quatity_sales_ValueChanged(object sender, EventArgs e)
        {

            var quantity = (decimal)txt_quatity_sales.Value;
            var selling = decimal.Parse(txt_sellingprice_sales.Text);
            decimal total = quantity * selling;
            txt_total_sales.Text = total.ToString();
            

        }

        private void btn_save_item_Click(object sender, EventArgs e)
        {


            int a = 1;
            a = Convert.ToInt32(txt_quatity_sales.Value);
            if (a <= 0)
            {
                MessageBox.Show("Enter greater then zero!!");

            }
            else
            {
                a = Convert.ToInt32(txt_quatity_sales.Value);

                var data = db.Item.Select(i => new { item_code = i.Item_ID, item_name = i.Item_Name, unit = i.Unit_obj.Unit_Name, quantiy = txt_quatity_sales.Value, total = (txt_quatity_sales.Value * i.Selling_Price) }).Where(ii => ii.item_code == (int)cb_sales_itemname.SelectedValue).ToList().Single();
                ite.Add(data);



                dvg_sales.DataSource = null;
                dvg_sales.DataSource = ite;
                


                foreach (var item in ite)
                    billTotal += (decimal)item.GetType().GetProperty("total").GetValue(item, null);
                txt_billstotal.Text = billTotal.ToString();
                billTotal = 0;
            }

            //rest qun&total
            txt_quatity_sales.Value = 0;
            txt_total_sales.Text = "0";

        }

        private void txt_per_discoun_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                var calcdiscount = ((txt_per_discoun.Value / 100) * decimal.Parse(txt_billstotal.Text)).ToString();
                txt_valuediscount.Text = calcdiscount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("enter your total price");
            }
        }

        private void txt_valuediscount_TextChanged(object sender, EventArgs e)
        {
            var calcnet = (decimal.Parse(txt_billstotal.Text) - decimal.Parse(txt_valuediscount.Text)).ToString();
            txt_net.Text = calcnet.ToString();
        }

        private void txt_paid_TextChanged(object sender, EventArgs e)
        {
           
                try
                {
                    var calcrest = (decimal.Parse(txt_paid.Text) - decimal.Parse(txt_net.Text));
                    txt_rest.Text = calcrest.ToString();
                }
                catch (Exception) { MessageBox.Show("enter number only"); }
        


        }

        private void btn_unites_cancel_Click(object sender, EventArgs e)
        {

            //if (MessageBox.Show("Are You Want to Delete All Data ?", "Asking", MessageBoxButtons.OKCancel) == DialogResult.OK)
            //{
            //    txt_numbersales.Text = "";
            //    txt_sellingprice_sales.Text = "";
            //    txt_total_sales.Text = "";
            //    txt_billstotal.Text = "";
            //    txt_valuediscount.Text = "";
            //    txt_paid.Text = "";
            //}
            //sales_invoice_Load(new sales_invoice(),null);
          this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string paid = txt_paid.Text;
            string net = txt_net.Text;
        if ( paid == "" )
            {
                MessageBox.Show("enter your paid first ");
            }
        else if(double.Parse(net) > double.Parse(paid))
            {
                MessageBox.Show("paid up must be greater than or equal net");
            }
        else
            {
                Employe emp = cb_employeename.SelectedValue as Employe;
                Sales_Invoices sales_Invoice = new Sales_Invoices()

                {
                    Client_ID = (int)cb_sales_clientname.SelectedValue,
                    Date = DateTime.Now,
                    Employee_ID = emp.Employe_ID,
                    Total_Price = int.Parse(txt_billstotal.Text),
                    
                };

                // save to db
                db.Sales_Invoices.Add(sales_Invoice);
                db.SaveChanges();


                Invoice_Items invoice_Items = new Invoice_Items()
                {
                    Invoice_ID = sales_Invoice.ID,
                    Item_ID = (int)cb_sales_itemname.SelectedValue,
                    Quantity = (int)txt_quatity_sales.Value

                };
                db.Invoice_Items.Add(invoice_Items);
                db.SaveChanges();

            }
        }
    }
}
