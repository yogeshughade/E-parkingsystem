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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPark p1 = new frmPark();
            p1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddFees af1 = new frmAddFees();
            af1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmRelease r1 = new frmRelease();
            r1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmShowPark fsp1 = new frmShowPark();
            fsp1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmShowRealease fsr1 = new frmShowRealease();
            fsr1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmDeleteAll da1 = new frmDeleteAll();
            da1.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
