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
            if (this.Tag != null)
            {
                this.usersTableAdapter.FillBy(this.dataSet1.users, Convert.ToInt32(this.Tag));
                buttonDelete.Visible = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbPassword.Text == tbVerifyPassword.Text)
                {
                    if(this.Tag == null)
                    {
                        this.usersTableAdapter.Insert(5, tbUsername.Text, tbPassword.Text);
                        MessageBox.Show("Data has been saved");
                        this.Close();
                    }
                    else
                    {
                        Form userView = new Form1();
                        this.usersTableAdapter.Update(tbUsername.Text, tbPassword.Text, Convert.ToInt32(this.Tag), Convert.ToInt32(this.Tag));
                        userView.MdiParent = this.ParentForm;
                        userView.Show();
                        this.Close();
                    }
                    
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Form userView = new Form1();
            try
            {
                DialogResult dialogResult = MessageBox.Show("Apakah akan dihapus?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.usersTableAdapter.Delete(Convert.ToInt32(this.Tag));
                    userView.MdiParent = this.ParentForm;
                    userView.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
