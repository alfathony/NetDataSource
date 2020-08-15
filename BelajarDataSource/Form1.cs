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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dataSet11.users);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            Form ParsingData = new UserForm();
            ParsingData.Tag = row.Cells[0].Value.ToString();
            ParsingData.MdiParent = this.ParentForm;
            ParsingData.Show();
            this.Close();
        }
    }
}
