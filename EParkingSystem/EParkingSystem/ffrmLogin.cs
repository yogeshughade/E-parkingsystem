using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EParkingSystem
{
    public partial class ffrmLogin : Form
    {
        public ffrmLogin()
        {
            InitializeComponent();
        }
        clsProgram cl = new clsProgram();
        int cnt;
        string str;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            str = "select count (*) from tblLogin where UID = '" + txtUserID.Text + "' and PASS = '" + txtPassword.Text + "'";
            cnt = cl.exescl(str);
            if (cnt == 0)
            {
                MessageBox.Show("incorrect Data");
            }
            else
            {
                this.Hide();
                frmMenu l1 = new frmMenu();
                l1.ShowDialog();

            }
            clear();
        }
        public void clear()
        {
            txtUserID.Text = "";
            txtPassword.Text = "";
            txtUserID.Focus();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ffrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
