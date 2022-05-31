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

    public partial class Company_Data : Form
    {
        Bils_SRS db;
        public Company_Data()
        {
            InitializeComponent();
            db = new Bils_SRS();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var company_data = db.Company.Where(company => company.Company_Name == txt_company_data.Text).ToList().SingleOrDefault();
            if (txt_company_data.Text !="")
            {
                if(company_data == null)
                {
                    Company comp = new Company()
                    {
                        Company_Name = txt_company_data.Text,
                        Company_Notes = notecompany_data.Text,     
                    };
                    db.Company.Add(comp);
                    errorCompany.Text = "Done";
                    errorCompany.ForeColor = Color.Green;
                    txt_company_data.Text = "";
                    notecompany_data.Text = "";
                    db.SaveChanges();
                }else
                {
                    errorCompany.Text = "Company Name has already existed before";
                    errorCompany.ForeColor = Color.Red;
                }
                
            }else
            {
                errorCompany.Text = "Company Name is Required";
                errorCompany.ForeColor = Color.Red;
            }
            
            
        }

        private void btn_c_cancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Want to Delete All Data ?", "Asking",MessageBoxButtons.OKCancel)== DialogResult.OK)
            {
                txt_company_data.Text = "";
                notecompany_data.Text = "";
                errorCompany.Text = "";
            }
        }
    }
}
