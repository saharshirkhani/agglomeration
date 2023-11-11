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

namespace agglomeration
{
    public partial class signin : Form
    {
        SqlConnection sqlcon = new SqlConnection("Data Source=.;Initial Catalog=agglomeration;Integrated Security=True");
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

        private void signin_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand sqlcmd = new SqlCommand("insert into Users values('"+txtname.Text+"','"+txtfamily.Text+"','"+txtusername.Text+"','"+txtpass.Text+"','"+lstjob.SelectedItem.ToString()+"')'",sqlcon);
            sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("ثبت نام با موفقیت انجام شد", "تائیدیه ثبت نام", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
