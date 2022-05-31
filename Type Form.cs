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
    public partial class Type_Form : Form
    {
        Bils_SRS db;
        public Type_Form()
        {
            InitializeComponent();
            db = new Bils_SRS();
        }

        private void Type_Form_Load(object sender, EventArgs e)
        {
            var companies = db.Company.ToList();
            combo_company_Name.DisplayMember = "Company_Name";
            combo_company_Name.ValueMember = "Company_ID";
            combo_company_Name.DataSource = companies;
        }

        private void btn_save_type_Click(object sender, EventArgs e)
        {
            var Type_data = db.Types.Where(type => type.Type_Name == txt_type.Text).ToList().SingleOrDefault();
            if (txt_type.Text != "")
            {
                if (Type_data == null)
                {
                    Types type = new Types()
                    {
                        Type_Name = txt_type.Text,
                        Type_Notes = note_type.Text,
                        Company_ID = (int)combo_company_Name.SelectedValue
                    };
                    db.Types.Add(type);
                    errorType.Text = "";
                    db.SaveChanges();
                    errorType.Text = "Done";
                    errorType.ForeColor = Color.Green;
                }
                else
                {
                    errorType.Text = "Type Name has already existed before";
                    errorType.ForeColor = Color.Red;
                }

            }
            else
            {
                errorType.Text = "Type Name is Required";
                errorType.ForeColor = Color.Red;
            }
        }

        private void btn_type_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Want to Delete All Data ?", "Asking", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                txt_type.Text = "";
                note_type.Text = "";
                errorType.Text = "";
            }
        }

        private void note_type_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
