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
    public partial class AdministrationForm : Form
    {
        private StudentServiceClient _proxy;
        private Form _parentForm;
        private List<Subject> _subjects;
        private List<Group> _groups;
        private List<Student> _students;
        private Teacher _teacher;

        public AdministrationForm(StudentServiceClient proxy, Form parentForm, Teacher teacher)
        {
            InitializeComponent();
            _proxy = proxy;
            _parentForm = parentForm;
            _teacher = teacher;
        }

        private void AdministrationForm_Load(object sender, EventArgs e)
        {
            dgv_studentDetails[0, 0].Value = String.Empty;
            dgv_studentDetails[1, 0].Value = String.Empty;
            dgv_studentDetails[2, 0].Value = String.Empty;
            LoadGroups();
            LoadSubjects();
            LoadStudents();
        }

        private void LoadStudents()
        {
            lv_students.Items.Clear();
            _students = _proxy.GetAllStudents().ToList<Student>();
            Guid groupId = _groups[lb_groups.SelectedIndex].Id;
            foreach(Student st in _students)
            {
                if(st.GroupId == groupId)
                    lv_students.Items.Add(new ListViewItem(new string[]{st.SName, st.Name, st.PName}));
            }
        }

        private void LoadSubjects()
        {
            _subjects = _proxy.GetAllSubjects().ToList<Subject>();
            List<String> subjectNames = (from subject in _subjects select subject.Name).ToList<String>(); 
            lb_subjects.DataSource = subjectNames;
        }

        private void LoadGroups()
        {
            _groups = _proxy.GetAllGroups().ToList<Group>();
            List<String> groupNames = (from gr in _groups select gr.Name).ToList<String>();
            lb_groups.DataSource = groupNames;
        }

        private void btn_addSubject_Click(object sender, EventArgs e)
        {
            if (tb_subjectName.Text == String.Empty)
            {
                MessageBox.Show("Поле \"Назва предмету\" пусте! Заповність його!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_subjectName.Focus();
                return;
            }
            Subject subject = new Subject(tb_subjectName.Text);
            try
            {
                _proxy.AddSubject(subject);
                tb_subjectName.Text = String.Empty;
                LoadSubjects();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_editSubject_Click(object sender, EventArgs e)
        {
            if (tb_subjectName.Text == String.Empty)
            {
                MessageBox.Show("Поле \"Назва предмету\" пусте! Заповність його!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_subjectName.Focus();
                return;
            }
            Subject subject = _subjects[lb_subjects.SelectedIndex];
            try
            {
                _proxy.EditSubject(subject, tb_subjectName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            LoadSubjects();
            return;
        }

        private void btn_removeSubject_Click(object sender, EventArgs e)
        {
            string subjToEditName = (string)lb_subjects.SelectedItem;
            Subject subject = _subjects[lb_subjects.SelectedIndex];
            try
            {
                _proxy.DeleteSubject(subject);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            LoadSubjects();
            return;
        }

        private void btn_addGroup_Click(object sender, EventArgs e)
        {
            if (tb_groupName.Text == String.Empty)
            {
                MessageBox.Show("Поле \"Ім'я групи\" пусте! Заповність його!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_groupName.Focus();
                return;
            }
            Group group = new Group(tb_groupName.Text);
            try
            {
                _proxy.AddGroup(group);
                tb_groupName.Text = String.Empty;
                LoadGroups();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_editGroup_Click(object sender, EventArgs e)
        {
            if (tb_groupName.Text == String.Empty)
            {
                MessageBox.Show("Поле \"Ім'я групи\" пусте! Заповність його!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_groupName.Focus();
                return;
            }
            Group group = _groups[lb_groups.SelectedIndex];
            try
            {
                _proxy.EditGroup(group, tb_groupName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            LoadGroups();
            return;
        }

        private void btn_removeGroup_Click(object sender, EventArgs e)
        {
            Group group = _groups[lb_groups.SelectedIndex];
            try
            {
                _proxy.DeleteGroup(group);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            LoadGroups();
            return;
        }

        private void btn_addStudent_Click(object sender, EventArgs e)
        {
            string sName = dgv_studentDetails[0, 0].Value.ToString();
            string name = dgv_studentDetails[1, 0].Value.ToString();
            string pName = dgv_studentDetails[2, 0].Value.ToString();
            Group group = _groups[lb_groups.SelectedIndex];
            if (sName == String.Empty || name == String.Empty || pName == String.Empty)
            {
                MessageBox.Show("Заповніть всі поля ПІБ студента!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dgv_studentDetails.Focus();
                return;
            }
            Student student = new Student(sName, name, pName, group.Id);
            try
            {
                _proxy.AddStudent(student);
                ClearDgv_StudentDetails();
                LoadStudents();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearDgv_StudentDetails()
        {
            dgv_studentDetails[0, 0].Value = String.Empty;
            dgv_studentDetails[1, 0].Value = String.Empty;
            dgv_studentDetails[2, 0].Value = String.Empty;
        }

        private void lb_groups_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void btn_editStudent_Click(object sender, EventArgs e)
        {
            if(lv_students.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Оберіть студента для редагування!");
                return;
            }
            Student student = _students[lv_students.SelectedIndices[0]];
            string newSName = dgv_studentDetails[0, 0].Value.ToString();
            string newName = dgv_studentDetails[1, 0].Value.ToString();
            string newPName = dgv_studentDetails[2, 0].Value.ToString();
            string[] newValues = new string[3] { newSName, newName, newPName };
            try
            {
                _proxy.EditStudent(student, newValues);
                ClearDgv_StudentDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            LoadStudents();
            return;
        }

        private void btn_removeStudent_Click(object sender, EventArgs e)
        {
            if (lv_students.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Оберіть студента для видалення!");
                return;
            }
            Student student = _students[lv_students.SelectedIndices[0]];
            try
            {
                _proxy.DeleteStudent(student);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            LoadStudents();
            return;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
