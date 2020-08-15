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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dataSet1.users);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbPassword.Text == tbVerifyPassword.Text)
                {
                    this.usersTableAdapter.Insert(5, tbUsername.Text, tbPassword.Text);
                    MessageBox.Show("Data has been saved");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password not correct");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
    }
}
