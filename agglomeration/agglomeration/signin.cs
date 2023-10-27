using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agglomeration
{
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 account = new Form1();
            account.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtfamily.Text = "";
            txtname.Text = "";
            txtpass.Text = "";
            txtusername.Text = "";
            
        }
    }
}
