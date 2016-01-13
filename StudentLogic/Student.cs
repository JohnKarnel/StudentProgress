using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using MyDataBaseFramework;
using System.Data;

namespace StudentLogic
{
    [DataContract]
    public class Student : Base<Student>
    {
        [DataMember]
        private string _name;
        [DataMember]
        private string _sname;
        [DataMember]
        private string _pname;
        [DataMember]
        private Guid _groupId;

        public Student(string sname, string name, string pname, Guid groupId)
        {
            _name = name;
            _sname = sname;
            _pname = pname;
            _groupId = groupId;
        }

        public Student(Guid id, string sname, string name, string pname, Guid groupId)
            : base(id)
        {
            _name = name;
            _sname = sname;
            _pname = pname;
            _groupId = groupId;
        }

        public Guid GroupId
        {
            get { return _groupId; }
            private set { _groupId = value; }
        }
        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }
        public string SName
        {
            get { return _sname; }
            private set { _sname = value; }
        }
        public string PName
        {
            get { return _pname; }
            private set { _pname = value; }
        }

        public List<Presence> Presences
        {
            get 
            {
                List<Presence> result = new List<Presence>();

                DataTable data = TableData.SelectByRule("Presence", "StudentProgressDB", new List<string>() { "StudentID" }, new List<string>() { this.Id.ToString()});
                if (data.Rows.Count > 0)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        Guid presenceId = Guid.Parse(row[0].ToString());
                        if (Presence.Items.Keys.Contains<Guid>(presenceId))
                        {
                            result.Add(Presence.Items[presenceId]);
                        }
                        else
                        {
                            Guid studentId = Guid.Parse(row[1].ToString());
                            Guid pairId = Guid.Parse(row[2].ToString());
                            DateTime date = (DateTime)row[3];
                            Boolean presencing = Convert.ToBoolean(row[4].ToString());
                            Presence presence = new Presence(presenceId, studentId, pairId, date, presencing);
                            result.Add(presence);
                        }
                    }
                }
                return result;
            }
        }

        public void Attend(bool presence, StudingTheSubject pair)
        {
            DateTime date = DateTime.Now;
            DataTable result = TableData.SelectByRule("Presence", "StudentProgressDB", new List<string>() { "StudentID", "PairID", "[Date]" }, new List<string>() { this.Id.ToString(), pair.Id.ToString(), String.Format("{0}.{1}.{2}", date.Date.Month, date.Date.Day, date.Date.Year) });
            if (result.Rows.Count != 0)
                throw new Exception("Цього студента вже відмічали!");
            Presence stPresence = new Presence(this.Id, pair.Id, date.Date, presence);
            string presenceId = stPresence.Id.ToString();
            string studentId = stPresence.StudentId.ToString();
            string pairId = stPresence.PairId.ToString();
            string prDate = String.Format("{0}.{1}.{2}", stPresence.Date.Month, stPresence.Date.Day, stPresence.Date.Year);
            string presencing = stPresence.Presencing ? "1" : "0";
            TableData.InsertInto("Presence", "StudentProgressDB", new List<string>() { presenceId, studentId, pairId, prDate, presencing }, new List<string>() { "PresenceID", "StudentID", "PairID", "[Date]", "Presence" });
        }

        public static List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            DataTable studentsTable = TableData.SelectAll("Student", "StudentProgressDB");
            if (studentsTable.Rows.Count == 0)
                return students;
            foreach (DataRow st in studentsTable.Rows)
            {
                Guid stId = Guid.Parse(st[0].ToString());
                if (Student.Items.Keys.Contains(stId))
                    students.Add(Student.Items[stId]);
                else
                {
                    string sName = st[1].ToString();
                    string name = st[2].ToString();
                    string pName = st[3].ToString();
                    Guid grId = Guid.Parse(st[4].ToString());
                    students.Add(new Student(stId, sName, name, pName, grId));
                }
            }
            return students;
        }

        public static int CreateNew(Student stud)
        {
            Student student = new Student(stud.SName, stud.Name, stud.PName, stud.GroupId);
            return TableData.InsertInto("Student", "StudentProgressDB",
                new List<string>() { student.Id.ToString(), student.SName, student.Name, student.PName, student.GroupId.ToString()},
                new List<string>() { "StudentID", "SName", "Name", "PName", "GroupID"});
        }

        public int Edit(string[] newValues)
        {
            string newSName = (newValues[0] != String.Empty) ? newValues[0] : this.SName;
            string newName = (newValues[1] != String.Empty) ? newValues[1] : this.Name;
            string newPName = (newValues[2] != String.Empty) ? newValues[2] : this.PName;
            int result = TableData.UpdateWithRule("Student", "StudentProgressDB",
                new List<string>() { "SName", "Name", "PName" },
                new List<string>() { newSName, newName, newPName },
                new List<string>() { "StudentID" },
                new List<string>() { this.Id.ToString()});
            if (result > 0)
            {
                Student.Items[this.Id].SName = newSName;
                Student.Items[this.Id].Name = newName;
                Student.Items[this.Id].PName = newPName;
            }
            return result;
        }

        public int Delete()
        {
            int result = TableData.DeleteByColumnValues("Student", "StudentProgressDB",
                   new List<string>() { "StudentID" },
                   new List<string>() { this.Id.ToString() });
            if (result > 0)
                Subject.Items.Remove(this.Id);
            return result;
        }
    }
}
