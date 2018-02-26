using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EParkingSystem
{
    public partial class frmDeleteAll : Form
    {
        public frmDeleteAll()
        {
            InitializeComponent();
        }
        string sql;
        DataSet ds;
        clsProgram p1 = new clsProgram();
        int cnt;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            sql = "delete from tblRelease where Date='" + string.Format("{0:MM/dd/yyyy}", dtpDate.Value) + "'";
                p1.execute(sql);
                sql = "delete from tblPark where Date='" + string.Format("{0:MM/dd/yyyy}", dtpDate.Value) + "'";
                p1.execute(sql);
                MessageBox.Show("Are you sure to delete Record");
                MessageBox.Show("Record Delete Successfully");
               
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
