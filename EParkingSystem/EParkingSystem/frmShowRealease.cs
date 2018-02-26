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
    public partial class frmShowRealease : Form
    {
        public frmShowRealease()
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
            sql = "select * from tblRelease where Date='" + string.Format("{0:MM/dd/yyyy}", dtpDate.Value) + "' ";
            adp = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            adp.Fill(ds);
            dgvData.DataSource = ds.Tables[0];
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
