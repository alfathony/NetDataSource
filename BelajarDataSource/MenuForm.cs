using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelajarDataSource
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.MdiParent = this;
            f.Show();
        }

        private void homepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new MenuForm();
            f.MdiParent = this;
            f.Show();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new UserForm();
            f.MdiParent = this;
            f.Show();
        }
    }
}
