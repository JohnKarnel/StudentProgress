using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Data;
using MyDataBaseFramework;

namespace StudentLogic
{
    [DataContract]
    public class Subject : Base<Subject>
    {
        [DataMember]
        private string _name;

        public Subject(string name)
        {
            Name = name;
        }

        public Subject(Guid id, string name) : base(id)
        {
            Name = name;
        }
        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        public static Subject GetSubjectByName(string name)
        {
            Subject result = null;
            foreach(var subj in GetAllSubjects())
            {
                if (subj.Name == name)
                {
                    result = subj;
                    break;
                }
            }
            return result;
        }

        public static Subject GetById(Guid id)
        {
            Subject result = null;
            foreach (var subj in GetAllSubjects())
            {
                if (subj.Id == id)
                {
                    result = subj;
                    break;
                }
            }
            return result;
        }
        public static List<Subject> GetAllSubjects()
        {
            List<Subject> subjects = new List<Subject>();
            DataTable subjectsTable = TableData.SelectAll("Subject", "StudentProgressDB");
            if (subjectsTable.Rows.Count == 0)
                return subjects;
            foreach (DataRow subj in subjectsTable.Rows)
            {
                Guid subjId = Guid.Parse(subj[0].ToString());
                if (Subject.Items.Keys.Contains(subjId))
                    subjects.Add(Subject.Items[subjId]);
                else
                {
                    string subjName = subj[1].ToString();
                    subjects.Add(new Subject(subjId, subjName));
                }
            }
            return subjects;
        }

        public static int CreateNew(Subject subject)
        {
            if (GetSubjectByName(subject.Name) != null)
                throw new Exception(String.Format("Предмет з назвою \"{0}\" вже існує!", subject.Name));
            Subject subj = new Subject(subject.Id, subject.Name);
            return TableData.InsertInto("Subject", "StudentProgressDB",
                new List<string>() { subj.Id.ToString(), subj.Name }, 
                new List<string>() { "SubjectID", "Name" });
        }

        public int Edit(string newName)
        {
            if (GetSubjectByName(newName) != null)
                throw new Exception(String.Format("Предмет з назвою \"{0}\" вже існує!", newName));
            int result = TableData.Update("Subject", "StudentProgressDB",
                new List<string>() { "Name" },
                new List<string>() { this.Name },
                new List<string>() { newName});
            if (result > 0)
                Subject.Items[this.Id].Name = newName;
            return result;
        }

        public int Delete()
        {
            int result = TableData.DeleteByColumnValues("Subject", "StudentProgressDB",
                   new List<string>() { "SubjectID" },
                   new List<string>() { this.Id.ToString() });
            if (result > 0)
                Subject.Items.Remove(this.Id);
            return result;
        }
    }
}
