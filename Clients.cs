using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Model;

namespace Project
{
    public partial class Clients : Form
    {
        Bils_SRS db;
        public Clients()
        {
            InitializeComponent();
            db = new Bils_SRS();
        }

        private void btn_save_item_Click(object sender, EventArgs e)
        {
            //var Client_data = db.Client.Where(client => client.Client_Name == txt_clientname.Text).ToList().SingleOrDefault();
            bool isvalid = true;
            if (txt_clientname.Text == "")
            {

                Error_Name.Text = "Client Name is Required";
                isvalid = false;
            }
            else
            {
                Error_Name.Text = "";
            }
            if (txt_address.Text == "")
            {
                error_address.Text = "Address is Required";
                isvalid = false;

            }
            else
            {
                error_address.Text = "";
            }
            if (txt_phoneclient.Text.Length != 14)
            {
                Error_phone.Text = "Phone Number must be 14 digit";
                isvalid = false;
            }
            else
            {
                Error_phone.Text = "";
            }
            if  (db.Client.Where(n => n.Client_Name == txt_clientname.Text).ToList().SingleOrDefault() != null)
            {
                Error_Name.ForeColor = Color.Red;
                Error_Name.Text = "Client Name Duplicated";
                txt_clientname.Text = "";
                isvalid = false;
            }

            if (isvalid)
            {
                Client client = new Client()
                {
                    Client_Name = txt_clientname.Text,
                    Address = txt_address.Text,
                    Phone = txt_phoneclient.Text
                };
                db.Client.Add(client);
                error_address.Text = "";
                Error_Name.Text = "";
                txt_clientname.Text = "";
                txt_phoneclient.Text = "";
                Error_phone.Text = "";
                txt_address.Text = "";
                Error_done.ForeColor = Color.Green;
                Error_done.Text = "Done";
                db.SaveChanges();
            }

        }

        private void Clients_Load(object sender, EventArgs e)
        {
            var number_client = db.Client.ToList().LastOrDefault();
            if (number_client == null)
            {
                txt_number.Text = "1";
            }
            else
            {
                txt_number.Text = (number_client.Client_ID + 1).ToString();
            }

            txt_number.Enabled = false;
        }

        private void btn_item_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Want to Delete All Data ?", "Asking", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                
                txt_clientname.Text = "";
                txt_phoneclient.Text = "";
                txt_address.Text = "";

            }
        }
    }
}
