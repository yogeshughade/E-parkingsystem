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
    public partial class frmShowPark : Form
    {
        public frmShowPark()
        {
            InitializeComponent();
        }
        String sql;
        SqlDataAdapter adp = new SqlDataAdapter();
        DataSet ds;
        SqlConnection con = new SqlConnection("Data Source=RK-PC;Initial Catalog=EParking;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        clsProgram p1 = new clsProgram();
      
        private void btnSearch_Click(object sender, EventArgs e)
        {
            sql = "select * from tblPark where Date='" + string.Format("{0:MM/dd/yyyy}", dtpDate.Value) + "' ";
            adp = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            adp.Fill(ds);
            dgvData.DataSource = ds.Tables[0];
           
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

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
