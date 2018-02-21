using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCDApp
{
    public partial class ERPLog : Form
    {
        public ERPLog()
        {
            InitializeComponent();
        }

        private void ERPLog_Load(object sender, EventArgs e)
        {
         
            DataTable erpdt = new DataTable();
            DataRow dr = null;
            erpdt.Columns.Add(new DataColumn("Date", typeof(string)));
            erpdt.Columns.Add(new DataColumn("Start", typeof(string)));
            erpdt.Columns.Add(new DataColumn("Middle", typeof(string)));
            erpdt.Columns.Add(new DataColumn("End", typeof(string)));
            erpdt.Columns.Add(new DataColumn("Comments", typeof(string)));
            dr = erpdt.NewRow();
            dr["Date"] = DateTime.Now;
            dr["Start"] = string.Empty;
            dr["Middle"] = string.Empty;
            dr["End"] = string.Empty;
            dr["Comments"] = string.Empty;
            erpdt.Rows.Add(dr);

            dataGrdERPLog.DataSource = erpdt;
            
            }

    }

     
      
           // if (txtStart.Text != "" && txtMiddle.Text != "" && txtEnd.Text != "" && txtComments.Text != "")
          
               
        
}
