using MyDataBaseFramework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StudentLogic
{
    [DataContract]
    public class Group : Base<Group>
    {
        [DataMember]
        private string _name;

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        public Group(string name)
        {
            Name = name;
        }

        public Group(Guid id, string name): base(id)
        {
            Name = name;
        }

        public static Group GetByName(string name)
        {
            Group result = null;
            foreach(Group gr in GetAllGroups())
            {
                if (gr.Name == name)
                {
                    result = gr;
                    break;
                }
            }
            return result;
        }

        public static Group GetById(Guid id)
        {
            Group result = null;
            foreach (Group gr in GetAllGroups())
            {
                if (gr.Id == id)
                {
                    result = gr;
                    break;
                }
            }
            return result;
        }

        public Student GetStudentBySName(string sname)
        {
            Student result = null;
            foreach (Student st in Student.Items.Values)
            {
                if (st.SName == sname && this.Id == st.GroupId)
                {
                    result = st;
                    break;
                }
            }
            return result;
        }
        public void AddStudent(string sname, string name, string pname)
        {
            new Student(sname, name, pname, this.Id);
        }

        public bool IsStudentConsist(string sname, string name, string pname)
        {
            foreach (var student in Student.Items.Values)
                if (student.SName == sname && student.Name == name && student.PName == pname)
                    return false;
            return true;
        }

        public static List<Group> GetAllGroups()
        {
            List<Group> groups = new List<Group>();
            DataTable groupsTable = TableData.SelectAll("Group", "StudentProgressDB");
            if (groupsTable.Rows.Count == 0)
                return groups;
            foreach(DataRow gr in groupsTable.Rows)   
            {
                Guid grId = Guid.Parse(gr[0].ToString());
                if (Group.Items.Keys.Contains(grId))
                    groups.Add(Group.Items[grId]);
                else
                {
                    string grName = gr[1].ToString();
                    groups.Add(new Group(grId, grName));
                }
            }
            return groups;
        }

        public static int CreateNew(Group group)
        {
            if (GetByName(group.Name) != null)
                throw new Exception(String.Format("Група з ім'ям \"{0}\" вже існує!", group.Name));
            Group gr = new Group(group.Id, group.Name);
            return TableData.InsertInto("Group", "StudentProgressDB",
                new List<string>() { gr.Id.ToString(), gr.Name },
                new List<string>() { "GroupID", "Name" });
        }

        public int Edit(string newName)
        {
            if (GetByName(newName) != null)
                throw new Exception(String.Format("Група з ім'ям \"{0}\" вже існує!", newName));
            int result = TableData.Update("Group", "StudentProgressDB",
                new List<string>() { "Name" },
                new List<string>() { this.Name },
                new List<string>() { newName });
            if (result > 0)
                Group.Items[this.Id].Name = newName;
            return result;
        }

        public int Delete()
        {
            int result = TableData.DeleteByColumnValues("Group", "StudentProgressDB",
                   new List<string>() { "GroupID" },
                   new List<string>() { this.Id.ToString() });
            if (result > 0)
                Group.Items.Remove(this.Id);
            return result;
        }
    }
}
