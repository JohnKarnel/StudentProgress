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
    public partial class CreationTimeTableForm : Form
    {
        private StudentServiceClient _proxy;
        private Form _parentForm;
        private Teacher _teacher;
        private List<Group> _groups;
        private List<Subject> _subjects;
        private List<StudingTheSubject> _pairs;
        public CreationTimeTableForm(StudentServiceClient proxy, Form parentForm, Teacher techer)
        {
            InitializeComponent();
            _proxy = proxy;
            _parentForm = parentForm;
            _teacher = techer;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void LoadPairs()
        {
            lv_timeTable.Items.Clear();
            _pairs = _proxy.GetAllSdudingSubjects(_teacher).ToList<StudingTheSubject>();
            foreach (var pair in _pairs)
            {
                string weekType = ParseWeekTypeFromEnum(pair.WeekType);
                string day = ParseDayOfWeekFromEnum(pair.Day);
                string pairType = ParsePairTypeFromEnum(pair.PairType);
                string group = null;
                foreach (var gr in _groups)
                {
                    if (gr.Id == pair.GroupId)
                        group = gr.Name;
                }
                string subject = null;
                foreach (var subj in _subjects)
                {
                    if (subj.Id == pair.SubjectId)
                        subject = subj.Name;
                }
                string room = pair.Classroom.ToString();
                lv_timeTable.Items.Add(new ListViewItem(new string[6] { weekType, day, pairType, subject, group, room }));
            }
        }

        private void ClearPairDetails()
        {
            cb_day.Text = String.Empty;
            cb_group.Text = String.Empty;
            cb_pairNum.Text = String.Empty;
            cb_subject.Text = String.Empty;
            cb_weekType.Text = String.Empty;
            tb_room.Text = String.Empty;
        }

        private DayOfWeek ParseDayOfWeek(string day)
        {
            DayOfWeek res = DayOfWeek.Monday;
            switch (day)
            {
                case "Понеділок":
                    res = DayOfWeek.Monday;
                    break;
                case "Вівторок":
                    res = DayOfWeek.Tuesday;
                    break;
                case "Середа":
                    res = DayOfWeek.Wednesday;
                    break;
                case "Четверг":
                    res = DayOfWeek.Thursday;
                    break;
                case "П'ятниця":
                    res = DayOfWeek.Friday;
                    break;
                case "Субота":
                    res = DayOfWeek.Saturday;
                    break;
            }
            return res;
        }

        private TypeOfPair ParsePairType(string pairType)
        {
            TypeOfPair res = TypeOfPair.First;
            switch (pairType)
            {
                case "Перша":
                    res = TypeOfPair.First;
                    break;
                case "Друга":
                    res = TypeOfPair.Second;
                    break;
                case "Третя":
                    res = TypeOfPair.Third;
                    break;
                case "Четверта":
                    res = TypeOfPair.Fourth;
                    break;
                case "П'ята":
                    res = TypeOfPair.Fifth;
                    break;
            }
            return res;
        }

        private TypeOfWeek ParseWeekType(string weekType)
        {
            TypeOfWeek res = TypeOfWeek.First;
            switch (weekType)
            {
                case "Перший":
                    res = TypeOfWeek.First;
                    break;
                case "Другий":
                    res = TypeOfWeek.Second;
                    break;
            }
            return res;
        }

        private string ParseDayOfWeekFromEnum(DayOfWeek day)
        {
            string res = null;
            switch (day)
            {
                case DayOfWeek.Monday:
                    res = "Понеділок";
                    break;
                case DayOfWeek.Tuesday:
                    res = "Вівторок";
                    break;
                case DayOfWeek.Wednesday:
                    res = "Середа";
                    break;
                case DayOfWeek.Thursday:
                    res = "Четверг";
                    break;
                case DayOfWeek.Friday:
                    res = "П'ятниця";
                    break;
                case DayOfWeek.Saturday:
                    res = "Субота";
                    break;
            }
            return res;
        }

        private string ParsePairTypeFromEnum(TypeOfPair pairType)
        {
            string res = null;
            switch (pairType)
            {
                case TypeOfPair.First:
                    res = "Перша";
                    break;
                case TypeOfPair.Second:
                    res = "Друга";
                    break;
                case TypeOfPair.Third:
                    res = "Третя";
                    break;
                case TypeOfPair.Fourth:
                    res = "Четверта";
                    break;
                case TypeOfPair.Fifth:
                    res = "П'ята";
                    break;
            }
            return res;
        }

        private string ParseWeekTypeFromEnum(TypeOfWeek weekType)
        {
            string res = null;
            switch (weekType)
            {
                case TypeOfWeek.First:
                    res = "Перший";
                    break;
                case TypeOfWeek.Second:
                    res = "Другий";
                    break;
            }
            return res;
        }

        private void CreationTimeTableForm_Load(object sender, EventArgs e)
        {
            _groups = _proxy.GetAllGroups().ToList<Group>();
            _subjects = _proxy.GetAllSubjects().ToList<Subject>();
            List<string> grNames = new List<string>();
            List<string> subjNames = new List<string>();
            foreach (var gr in _groups)
                grNames.Add(gr.Name);
            foreach (var subj in _subjects)
                subjNames.Add(subj.Name);
            cb_subject.DataSource = subjNames;
            cb_group.DataSource = grNames;
            LoadPairs();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (cb_day.Text == String.Empty || cb_pairNum.Text == String.Empty || cb_weekType.Text == String.Empty || cb_subject.Text == String.Empty || cb_group.Text == String.Empty || tb_room.Text == String.Empty)
            {
                MessageBox.Show("Заповніть всі поля атрибутів пари!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DayOfWeek day = ParseDayOfWeek(cb_day.Text);
            TypeOfPair pairType = ParsePairType(cb_pairNum.Text);
            TypeOfWeek weekType = ParseWeekType(cb_weekType.Text);
            Group gr = _groups[cb_group.SelectedIndex];
            Subject subj = _subjects[cb_subject.SelectedIndex];
            int room = Int32.Parse(tb_room.Text);
            StudingTheSubject sts = new StudingTheSubject(subj.Id, gr.Id, _teacher.Id, day, weekType, pairType, room);
            try
            {
                _proxy.AddPair(sts);
                ClearPairDetails();
                LoadPairs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            //if (lv_timeTable.SelectedIndices.Count == 0)
            //{
            //    MessageBox.Show("Оберіть пару для редагування!");
            //    return;
            //}
            //if (cb_weekType.Text == String.Empty || cb_subject.Text == String.Empty || cb_pairNum.Text == String.Empty || cb_group.Text == String.Empty || cb_day.Text == String.Empty || tb_room.Text == String.Empty)
            //{
            //    MessageBox.Show("Заповніть всі поля для редагування!");
            //    return;
            //}
            //TypeOfWeek weekType = ParseWeekType(cb_weekType.Text);
            //DayOfWeek day = ParseDayOfWeek(cb_day.Text);
            //TypeOfPair pairType = ParsePairType(cb_pairNum.Text);
            //Group gr = _groups[cb_group.SelectedIndex];
            //Subject subj = _subjects[cb_subject.SelectedIndex];
            //int room = Int32.Parse(tb_room.Text);
            //StudingTheSubject pair = _pairs[lv_timeTable.SelectedIndices[0]];
            //try
            //{
            //    string[] newValues = new string[7] { weekType.ToString(), day.ToString(), pairType.ToString(), gr.Id.ToString(), subj.Id.ToString(), _teacher.Id.ToString(), room.ToString() };
            //    _proxy.EditPair(pair, newValues);
            //    Clear_PairDetails();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            //LoadPairs();
            //return;
        }

        private void Clear_PairDetails()
        {
            cb_day.Text = String.Empty;
            cb_group.Text = String.Empty;
            cb_pairNum.Text = String.Empty;
            cb_subject.Text = String.Empty;
            cb_weekType.Text = String.Empty;
            tb_room.Text = String.Empty;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lv_timeTable.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Оберіть пару для видалення!");
                return;
            }
            StudingTheSubject pair = _pairs[lv_timeTable.SelectedIndices[0]];
            try
            {
                _proxy.DeletePair(pair);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            LoadPairs();
            return;
        }
    }
}
