using Client.StudentService;
using StudentLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class WorkForm : Form
    {
        private StudentServiceClient _proxy;
        private Teacher _teacher;
        private FormLogin _parrentForm;
        private List<StudingTheSubject> _currentPair;
        private List<StudingTheSubject> _nextPair;
        System.Threading.Timer _timer;
        public WorkForm(Teacher teacher, FormLogin parentForm, StudentServiceClient proxy)
        {
            InitializeComponent();
            _teacher = teacher;
            _parrentForm = parentForm;
            _proxy = proxy;
        } 

        private void WorkForm_Load(object sender, EventArgs e)
        {
            TimerCallback loadPair = new TimerCallback(LoadCurrentPair);
            loadPair += LoadNextPair;
            _timer = new System.Threading.Timer(loadPair, null, 0, 60000);
            toolStripStatusLabel1.Text = String.Format("{0} {1} {2}", _teacher.Sname, _teacher.Name, _teacher.Pname);
        }

        private void  LoadCurrentPair(object obj)
        {
            if (_proxy.State == System.ServiceModel.CommunicationState.Faulted)
                _proxy = new StudentServiceClient();
            _currentPair = _proxy.GetCurrentPair(DateTime.Now, _teacher).ToList<StudingTheSubject>();
            if (_currentPair.Count != 0)
            {
                this.Invoke((Action)delegate
                {
                    if (_currentPair.Count != 0)
                    {
                        tb_currPairDate.Text = "Зараз";
                        tb_currGroups.Text = String.Empty;
                        foreach (var pair in _currentPair)
                            tb_currGroups.Text += "  " + _proxy.GetGroupById(pair.GroupId).Name;
                        tb_currSubject.Text = _proxy.GetSubjectById(_currentPair[0].SubjectId).Name;
                        tb_currRoom.Text = _currentPair[0].Classroom.ToString();
                    }
                });
            }
            else
            {
                this.Invoke((Action)delegate
                {
                    tb_currPairDate.Text = String.Empty;
                    tb_currGroups.Text = String.Empty;
                    tb_currSubject.Text = String.Empty;
                    tb_currRoom.Text = String.Empty;
                });
            }
        }

        private void LoadNextPair(object obj)
        {
            DateTime date;
            _nextPair = _proxy.GetNextPair(_teacher, out date).ToList<StudingTheSubject>();
            if (_nextPair.Count != 0)
            {
                this.Invoke((Action)delegate
                {
                    tb_nextPairDate.Text = date.ToShortDateString() + "  " + ConvertPairTypeToTime(_nextPair[0].PairType);
                    tb_nextPairGroups.Text = String.Empty;
                    foreach (var pair in _nextPair)
                        tb_nextPairGroups.Text += "  " +_proxy.GetGroupById(pair.GroupId).Name;
                    tb_nextPairSubj.Text = _proxy.GetSubjectById(_nextPair[0].SubjectId).Name;
                    tb_nextPairRoom.Text = _nextPair[0].Classroom.ToString();
                });
            }
            else
            {
                this.Invoke((Action)delegate
                {
                    tb_nextPairDate.Text = String.Empty;
                    tb_nextPairGroups.Text = String.Empty;
                    tb_nextPairSubj.Text = String.Empty;
                    tb_nextPairRoom.Text = String.Empty;
                });
            }
        }
        private void групиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AdministrationForm(_proxy, this, _teacher).Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            _parrentForm.Show();
            _parrentForm.Clear();
        }

        private void розкладToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_proxy.IsTimeTableForTeacher(_teacher))
            {
                new CreationTimeTableForm(_proxy, this, _teacher).Show();
                this.Hide();
            }
            else
            {
                new ConfigurationForm(_proxy, this, _teacher).Show();
                this.Hide();
            }
        }

        private string ConvertPairTypeToTime(TypeOfPair pairType)
        {
            string res = null;
            switch(pairType)
            {
                case TypeOfPair.First:
                    res = "08:30:00";
                    break;
                case TypeOfPair.Second:
                    res = "10:25:00";
                    break;
                case TypeOfPair.Third:
                    res = "12:20:00";
                    break;
                case TypeOfPair.Fourth:
                    res = "14:15:00";
                    break;
                case TypeOfPair.Fifth:
                    res = "16:10:00";
                    break;
            }
            return res;
        }

        private void btn_deginWork_Click(object sender, EventArgs e)
        {
            new AttendanceForm(_proxy, this, _currentPair).Show();
            this.Hide();
        }

        private void btn_changePair_Click(object sender, EventArgs e)
        {
            new CreationTimeTableForm(_proxy, this, _teacher).Show();
            this.Hide();
        }
    }
}
