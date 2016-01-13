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
    public partial class StudentStatisticsForm : Form
    {
        private StudentServiceClient _proxy;
        private Student _student; 
        public StudentStatisticsForm(StudentServiceClient proxy, Student student)
        {
            InitializeComponent();
            _proxy = proxy;
            _student = student;
        }

        private void StudentStatisticsForm_Load(object sender, EventArgs e)
        {
            List<Presence> presences = _proxy.GetAllPresences(_student).ToList<Presence>();
            int countOfProg = 0;
            foreach (var presence in presences)
                if (presence.Presencing == true)
                {
                    lb_presences.ForeColor = Color.Green;
                    lb_presences.Items.Add(presence.Date);
                }
                else
                {
                    lb_presences.ForeColor = Color.Red;
                    lb_presences.Items.Add(presence.Date);
                    countOfProg++;
                }
            tb_progylu.Text = countOfProg.ToString();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
