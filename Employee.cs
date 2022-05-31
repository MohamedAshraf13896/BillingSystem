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
    public partial class Employee : Form
    {
        Bils_SRS db;
        public Employee()
        {
            InitializeComponent();
            db = new Bils_SRS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Employee_Data = db.Employes.Where(Employe => Employe.Employe_Name == txt_employee.Text).ToList().SingleOrDefault();
            if (txt_employee.Text != "")
            {
                if (Employee_Data == null)
                {
                    Employe emp = new Employe()
                    {
                        Employe_Name = txt_employee.Text,
                        Employe_Date = txt_time.Value
                    };
                    db.Employes.Add(emp);
                    db.SaveChanges();
                    error_employe.Text = "Done";
                    error_employe.ForeColor = Color.Green;
                    txt_employee.Text = "";
                   
                }
                else
                {
                    error_employe.Text = "Employee Name has already existed before";
                    error_employe.ForeColor = Color.Red;
                }

            }
            else
            {
                error_employe.Text = "Employee Name is Required";
                error_employe.ForeColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Want to Delete All Data ?", "Asking", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                txt_employee.Text = "";
                error_employe.Text = "";
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            txt_time.Format = DateTimePickerFormat.Time;
            txt_time.ShowUpDown = true;
        }
    }
}
