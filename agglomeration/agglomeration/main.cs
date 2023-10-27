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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            additem add = new additem();
            add.ShowDialog();
            this.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            search search = new search();
            search.ShowDialog();
            this.Close();
        }
    }
}
