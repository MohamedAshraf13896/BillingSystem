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
    public partial class Report : Form
    {
        Bils_SRS db;
        public Report()
        {
            InitializeComponent();
            db= new Bils_SRS();
        }

        private void btn_save_report_Click(object sender, EventArgs e)
        {
            //var q = DBC
            DateTime from = from_date.Value;
            DateTime to = to_date.Value;
            var q = db.Sales_Invoices.Where(i => i.Date.Day >= from.Date.Day && i.Date.Day <= to.Date.Day).Select(i => new { i.Date,i.Client_ID,i.Employee_ID ,i.Employe_obj.Employe_Name,i.Client_obj.Client_Name}).ToList();
            dvg_report.DataSource = q;            
        }

        private void Report_Load(object sender, EventArgs e)
        {
            from_date.Format = DateTimePickerFormat.Short;
            from_date.ShowUpDown = true;
            to_date.Format = DateTimePickerFormat.Short;
            to_date.ShowUpDown = true;
        }
    }
}
