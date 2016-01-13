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
    public partial class AttendanceForm : Form
    {
        private StudentServiceClient _proxy;
        private WorkForm _parrentForm;
        private List<StudingTheSubject> _currentPair;
        private List<Group> _groups;
        private List<Student> _students;
        public AttendanceForm(StudentServiceClient proxy, WorkForm parrentForm, List<StudingTheSubject> currentPair)
        {
            InitializeComponent();
            _proxy = proxy;
            _parrentForm = parrentForm;
            _currentPair = currentPair;
        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            if (_currentPair.Count == 0)
                return;
            LoadGroups();
            LoadStudents();
        }

        private void LoadStudents()
        {
            lv_students.Items.Clear();
            _students = _proxy.GetAllStudents().ToList<Student>();
            Guid groupId = _groups[lb_groups.SelectedIndex].Id;
            List<Student> studentOfGroup = new List<Student>();
            foreach (Student st in _students)
            {
                if (st.GroupId == groupId)
                {
                    studentOfGroup.Add(st);
                    List<string> item = new List<string> { st.SName, st.Name, st.PName };
                    List<Presence> studentPresences = _proxy.GetAllPresences(st).ToList<Presence>();
                    StudingTheSubject pairStudent = null;
                    foreach (var pair in _currentPair)
                    {
                        if (pair.GroupId == st.GroupId)
                        {
                            pairStudent = pair;
                            break;
                        }
                    }
                    foreach(var presence in studentPresences)
                    {
                        if (presence.PairId == pairStudent.Id && presence.Date == DateTime.Now.Date)
                            item.Add(presence.Presencing.ToString());
                    }
                    lv_students.Items.Add(new ListViewItem(item.ToArray<string>()));
                }
            }
            _students = studentOfGroup;
        }

        private void LoadGroups()
        {
            _groups = new List<Group>();
            foreach (var pair in _currentPair)
                _groups.Add(_proxy.GetGroupById(pair.GroupId));
            List<String> groupNames = (from gr in _groups select gr.Name).ToList<String>();
            lb_groups.DataSource = groupNames;
        }

        private void lb_groups_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            _parrentForm.Show();
            this.Close();
        }

        private void btn_exist_Click(object sender, EventArgs e)
        {
            if (lv_students.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Оберіть студента для фіксації відвідуваності!");
                return;
            }
            Student student = _students[lv_students.SelectedIndices[0]];
            StudingTheSubject pairStudent = null;
            foreach(var pair in _currentPair)
            {
                if(pair.GroupId == student.GroupId)
                {
                    pairStudent = pair;
                    break;
                }
            }
            try
            {
                _proxy.AttendStudent(student, true, pairStudent);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadStudents();
        }

        private void btn_dontExist_Click(object sender, EventArgs e)
        {
            if (lv_students.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Оберіть студента для фіксації відвідуваності!");
                return;
            }
            Student student = _students[lv_students.SelectedIndices[0]];
            StudingTheSubject pairStudent = null;
            foreach (var pair in _currentPair)
            {
                if (pair.GroupId == student.GroupId)
                {
                    pairStudent = pair;
                    break;
                }
            }
            try
            {
                _proxy.AttendStudent(student, false, pairStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadStudents();
            LoadStudents();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            if (lv_students.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Оберіть студента для отримання статистики!");
                return;
            }
            Student student = _students[lv_students.SelectedIndices[0]];
            new StudentStatisticsForm(_proxy, student).ShowDialog();
        }
    }
}
