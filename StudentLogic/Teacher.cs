using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using MyDataBaseFramework;
using System.Data;

namespace StudentLogic
{
    [DataContract]
    public class Teacher : Base<Teacher>
    {        
        [DataMember]
        private string _sname;
        [DataMember]
        private string _name;
        [DataMember]
        private string _pname;

        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        public string Sname
        {
            get { return _sname; }
            private set { _sname = value; }
        }

        public string Pname
        {
            get { return _pname; }
            private set { _pname = value; }
        }
        public Teacher(string sname, string name, string pname)
        {
            _name = name;
            _sname = sname;
            _pname = pname;
        }
        public Teacher(Guid id, string sname, string name, string pname) : base(id) 
        {
            _name = name;
            _sname = sname;
            _pname = pname;
        }

        public static Teacher GetTeacherByLogin(string login, string password)
        {
            var result = TableData.SelectByRule("Teacher", "StudentProgressDB", new List<string>(){ "[Login]", "[Password]"}, new List<string>(){ login, password});
            if(result.Rows.Count == 0)
            {
                throw new Exception("Такого користувача не існує");
            }
            Guid id = Guid.Parse(result.Rows[0][0].ToString());
            Teacher teacher;
            try
            {
                teacher = Teacher.Items[id];
            }
            catch(Exception)
            {
                teacher = null;
            }
            if (teacher == null)
            {
                teacher = new Teacher(id, result.Rows[0][1].ToString(), result.Rows[0][2].ToString(), result.Rows[0][3].ToString());
            }
            return teacher;
        }

        public static int RegistrateTeacher(Teacher teacher, string login, string password)
        {
            DataTable result = TableData.SelectByRule("Teacher", "StudentProgressDB", new List<string>(){ "[Login]"}, new List<string>(){ login});
            if (result.Rows.Count != 0)
                throw new Exception("Вчитель з таким логіном вже існує");
            return TableData.InsertInto("Teacher", "StudentProgressDB", new List<string>(){ teacher.Id.ToString(), teacher.Sname, teacher.Name, teacher.Pname, login, password}, new List<string>(){ "TeacherID", "SName", "Name", "PName", "[Login]", "[Password]"});
        }

        public static List<Teacher> GetAllTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();
            DataTable teachersTable = TableData.SelectAll("Teacher", "StudentProgressDB");
            if (teachersTable.Rows.Count == 0)
                return teachers;
            foreach (DataRow teach in teachersTable.Rows)
            {
                Guid teachId = Guid.Parse(teach[0].ToString());
                if (Teacher.Items.Keys.Contains(teachId))
                    teachers.Add(Teacher.Items[teachId]);
                else
                {
                    string teachSName = teach[1].ToString(); 
                    string teachName = teach[2].ToString();
                    string teachPName = teach[3].ToString();
                    teachers.Add(new Teacher(teachId, teachSName, teachName, teachPName));
                }
            }
            return teachers;
        }

        public static Teacher GetById(Guid id)
        {
            Teacher result = null;
            foreach (var teach in GetAllTeachers())
            {
                if (teach.Id == id)
                {
                    result = teach;
                    break;
                }
            }
            return result;
        }
    }
}
