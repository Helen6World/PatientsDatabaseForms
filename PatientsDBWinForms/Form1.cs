using System;
using System.Windows.Forms;

namespace PatientsDBWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_log_in_Click(object sender, EventArgs e)
        {
            if (tb_login.Text == "Admin" && tb_password.Text == "1502")
            {
                lb_error.Visible = false;
                FormDB transition = new FormDB();
                transition.Show();
                this.Hide();
            }
            else
            {
                lb_error.Visible = true;
            }
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            tb_password.UseSystemPasswordChar = true;
        }
    }
}
