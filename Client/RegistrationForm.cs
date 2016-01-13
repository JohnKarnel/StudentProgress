using Client.StudentService;
using StudentLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class RegistrationForm : Form
    {
        StudentServiceClient _proxy;
        public RegistrationForm(StudentServiceClient proxy)
        {
            InitializeComponent();
            _proxy = proxy;
        }

        private async void btn_registrate_Click(object sender, EventArgs e)
        {
            if (tb_sName.Text == String.Empty || tb_name.Text == String.Empty || tb_pName.Text == String.Empty ||
                tb_login.Text == String.Empty || tb_password.Text == String.Empty || tb_passwordAgain.Text == String.Empty)
            {
                MessageBox.Show("Заповніть всі поля!");
                return;
            }
            if (tb_password.Text != tb_passwordAgain.Text)
            {
                MessageBox.Show("Паролі не співпадають. Введіть пароль ще раз!");
                return;
            }
            Teacher teacher = new Teacher(tb_sName.Text, tb_name.Text, tb_pName.Text);
            try
            {
                int res = await _proxy.RegistrateTeacherAsync(teacher, tb_login.Text, tb_password.Text);
                if (res > 0)
                {
                    MessageBox.Show("Викладача зареєстровано", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
