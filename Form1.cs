using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            formload(new homepage());
        }

        public void formload(object form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void btn_company_Click(object sender, EventArgs e)
        {
            formload(new Company_Data());
        }

        private void btn_species_Click(object sender, EventArgs e)
        {
            formload(new Type_Form());
        }

        private void btn_unites_Click(object sender, EventArgs e)
        {
            formload(new Unites_form());
        }

        private void btn_homepage_Click(object sender, EventArgs e)
        {
            formload(new homepage());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            formload(new homepage());
        }

        private void btn_Categories_Click(object sender, EventArgs e)
        {
            formload(new Categories());
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            formload(new Clients());
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            formload(new Report());
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            formload(new sales_invoice());
        }

        private void btn_emp_Click(object sender, EventArgs e)
        {
            formload(new Employee());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;

            }
        }
    }
}
