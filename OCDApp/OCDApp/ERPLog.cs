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


        DataTable erpdt = new DataTable();


        private void ERPLog_Load(object sender, EventArgs e)
        {
            erpdt.Columns.Add(new DataColumn("Date", typeof(string)));
            erpdt.Columns.Add(new DataColumn("Start", typeof(string)));
            erpdt.Columns.Add(new DataColumn("Middle", typeof(string)));
            erpdt.Columns.Add(new DataColumn("End", typeof(string)));
            erpdt.Columns.Add(new DataColumn("Comments", typeof(string)));


            dataGrdERPLog.DataSource = erpdt;


        }
        private void btnAddERPLog_Click(object sender, EventArgs e)
        {
            if (txtStart.Text != "" && txtMiddle.Text != "" && txtEnd.Text != "" && txtComments.Text != "")
            {
                
                DataRow dr = null;
                dr = erpdt.NewRow();
                dr["Date"] = DateTime.Now;
                dr["Start"] = txtStart;
                dr["Middle"] = txtMiddle;
                dr["End"] = txtEnd;
                dr["Comments"] = txtComments;
                erpdt.Rows.Add(dr);

                // dr = erpdt.NewRow();
                // dr["Date"] = DateTime.Now;
                // dr["Start"] = string.Empty;
                // dr["Middle"] = string.Empty;
                //  dr["End"] = string.Empty;
                //  dr["Comments"] = string.Empty;
                
            }
        }



        // if (txtStart.Text != "" && txtMiddle.Text != "" && txtEnd.Text != "" && txtComments.Text != "")

    }

}
