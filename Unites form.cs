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
    public partial class Unites_form : Form
    {
        Bils_SRS db;
        public Unites_form()
        {
            InitializeComponent();
            db = new Bils_SRS();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var Unit_Data = db.Unit.Where(unit => unit.Unit_Name == txt_unite_data.Text).ToList().SingleOrDefault();
            if (txt_unite_data.Text != "")
            {
                if (Unit_Data == null)
                {
                    Unit unit = new Unit()
                    {
                        Unit_Name = txt_unite_data.Text,
                        Unit_Notes = noteunite_data.Text   

                    };
                    db.Unit.Add(unit);
                    Error_Units.Text = "";
                    db.SaveChanges();
                    Error_Units.Text = "Done";
                    Error_Units.ForeColor = Color.Green;
                    txt_unite_data.Text = "";
                    noteunite_data.Text = "";
                }
                else
                {
                    Error_Units.Text = "Unit Name has already existed before";
                    Error_Units.ForeColor = Color.Red;
                }

            }
            else
            {
                Error_Units.Text = "Unit Name is Required";
                Error_Units.ForeColor = Color.Red;
            }
        }

        private void btn_c_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Want to Delete All Data ?", "Asking", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                txt_unite_data.Text = "";
                noteunite_data.Text = "";
                Error_Units.Text = "";
                noteunite_data.Text = "";
            }
        }
    }
}
