using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant.Admin
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void UserNamebtn_Click(object sender, EventArgs e)
        {
            string oldUserName = txtOld.Text;
            string newUserName = txtNew23.Text;

            if (string.IsNullOrEmpty(oldUserName) || string.IsNullOrEmpty(newUserName))
            {
                MessageBox.Show("Please enter both old and new user names.");
                return;
            }

            bool isUpdated = User9.UpdateUserName(oldUserName, newUserName);

            if (isUpdated)
            {
                MessageBox.Show("User Name updated successfully.");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed to update user name. Please check the old user name or try again later.");
            }
        }

        private void Passwordbtn_Click(object sender, EventArgs e)
        {
            string oldPassword = txtOld.Text;
            string newPassword = txtNew23.Text;

            if (string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please enter both old and new passwords.");
                return;
            }

            bool isUpdated = User9.UpdatePassword(oldPassword, newPassword);

            if (isUpdated)
            {
                MessageBox.Show("Password updated successfully.");
            }
            else
            {
                MessageBox.Show("Failed to update password. Please check the old password or try again later.");
            }
        }

        private void Emailbtn_Click(object sender, EventArgs e)
        {
            string oldEmail = txtOld.Text;
            string newEmail = txtNew23.Text;

            if (string.IsNullOrEmpty(oldEmail) || string.IsNullOrEmpty(newEmail))
            {
                MessageBox.Show("Please enter both old and new email addresses.");
                this.Hide();
                return;

            }

            bool isUpdated = User9.UpdateEmail(oldEmail, newEmail);

            if (isUpdated)
            {
                MessageBox.Show("Email address updated successfully.");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed to update email address. Please check the old email or try again .");
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.Show();
            this.Hide();
        }
    }
}    
