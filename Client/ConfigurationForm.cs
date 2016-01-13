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
    public partial class ConfigurationForm : Form
    {
        private StudentServiceClient _proxy;
        private Form _parentForm;
        private Teacher _teacher;
        public ConfigurationForm(StudentServiceClient proxy, Form parentForm, Teacher teacher)
        {
            InitializeComponent();
            _proxy = proxy;
            _parentForm = parentForm;
            _teacher = teacher;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            _parentForm.Show();
        }

        private void btn_goNext_Click(object sender, EventArgs e)
        {
            TimeTable tm = new TimeTable(_teacher.Id);
            tm.SetFirstAndSecondWeek(drp_firstWeekDate.Value.Date);
            _proxy.CreateTimeTable(tm);
            new CreationTimeTableForm(_proxy, _parentForm, _teacher).Show();
            this.Close();
        }
    }
}
