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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("لطفا نام کاربری و رمز عبور خود را وارد کنید و یا  وارد صفحه ثبت نام شوید", " لطفا فرم را تکمیل کنید", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbpass.ForeColor = System.Drawing.Color.Red;
                lbuser.ForeColor = System.Drawing.Color.Red;
                txtpassword.BackColor= System.Drawing.Color.Red;
                txtusername.BackColor = System.Drawing.Color.Red;

            }
            else if (txtusername.Text == "admin" && txtpassword.Text == "admin")
            {
                main m = new main();
                m.ShowDialog();
                this.Close();
            }
            else
            { 
                
                MessageBox.Show(" نام کاربری یا رمز عبور  اشتباه می باشد ", " لطفا اطلاعات خود را چک کنید کنید", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Text = "";
                txtusername.Text = "";
            }

        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            signin sign = new signin();
            sign.ShowDialog();
            this.Close();
            

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }
    }
}
