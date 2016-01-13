using Client.StudentService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentLogic;

namespace Client
{
    public partial class FormLogin : Form
    {
        StudentServiceClient _proxy;
        public FormLogin()
        {
            InitializeComponent();
            _proxy = new StudentServiceClient();
        }

        private void tb_login_Enter(object sender, EventArgs e)
        {
            if (tb_login.Text == "Логін")
            {
                tb_login.Text = String.Empty;
                tb_login.Font = new Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                tb_login.ForeColor = Color.Black;
            }
        }

        private void tb_login_Leave(object sender, EventArgs e)
        {
            if (tb_login.Text == String.Empty)
            {
                tb_login.Font = new Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                tb_login.ForeColor = Color.DimGray;
                tb_login.Text = "Логін";
            }
        }

        private void tb_password_Enter(object sender, EventArgs e)
        {
            if (tb_password.Text == "Пароль")
            {
                tb_password.Text = String.Empty;
                tb_password.Font = new Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                tb_password.ForeColor = Color.Black;
                tb_password.UseSystemPasswordChar = true;
            }
        }

        private void tb_password_Leave(object sender, EventArgs e)
        {
            if (tb_password.Text == String.Empty)
            {
                tb_password.Font = new Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                tb_password.ForeColor = Color.DimGray;
                tb_password.UseSystemPasswordChar = false;
                tb_password.Text = "Пароль";
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                Teacher teacher = _proxy.GetTeacher(tb_login.Text, tb_password.Text);
                new WorkForm(teacher, this, _proxy).Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void llb_registrate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RegistrationForm(_proxy).ShowDialog();
        }

        public void Clear()
        {
            tb_login.Font = new Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tb_login.ForeColor = Color.DimGray;
            tb_login.Text = "Логін";
            tb_password.Font = new Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tb_password.ForeColor = Color.DimGray;
            tb_password.UseSystemPasswordChar = false;
            tb_password.Text = "Пароль";
        }
    }
}

