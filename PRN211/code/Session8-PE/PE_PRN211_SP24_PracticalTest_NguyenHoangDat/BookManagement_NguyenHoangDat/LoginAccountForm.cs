using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement_NguyenHoangDat
{
    public partial class LoginAccountForm : Form
    {
        public LoginAccountForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all fields!", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserAccountService service = new();
            UserAccount? account = service.CheckLogin(txtEmail.Text, txtPassword.Text);

            if (account != null)
            {
                if (account.Role != 1)
                {
                    MessageBox.Show("You have no permission to access this system!", "Wrong privilege", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show("Login successfully!");
                this.Hide();
                BookManagementMainUI mainUI = new();
                mainUI.ShowDialog();
            }
            MessageBox.Show("Login failed!", "Wrong credentials", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
