using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace StudentLogic.Data
{
    //class StudentData
    //{
    //    private string _table;
    //    public StudentData()
    //    {
    //       _table = "Students";
    //    }

    //    public void Insert(string sname, string name, string pname, string groupId)
    //    {
    //        using(DataBase dataBase = new DataBase())
    //        {
    //            dataBase.ConnectionOpen();
    //            string commandStr = "INSERT INTO + " + _table + " VALUES ('"+sname+"','"+name+"','"+ pname+ "','"+ groupId +"')";
    //            dataBase.Insert(commandStr);
    //        }
    //    }
    //    public void Delete(string studId)
    //    {
    //        using(DataBase dataBase = new DataBase())
    //        {
    //            dataBase.ConnectionOpen();
    //            string commandStr = "DELETE + " + _table + " WHERE StudentId = '"+studId+"'";
    //            dataBase.Delete(commandStr);
    //        }
    //    }

    //    public List<Student> Select()
    //    {
    //        using (DataBase dataBase = new DataBase())
    //        {
    //            dataBase.ConnectionOpen();
    //            List<Student> students = new List<Student>();
    //            string commandStr = "SELECT * FROM " + _table;
    //            SqlCommand sqlCommand = new SqlCommand(commandStr);
    //            using (SqlDataReader reader = sqlCommand.ExecuteReader())
    //            {
    //                DataTable dt = new DataTable();
    //                dt.Load(reader);
    //                foreach (Student st in dt.Rows)
    //                {
    //                    students.Add(new Student(st.SName, st.Name, st.PName, st.GroupId));
    //                }
    //            }
    //            return students;
    //        }
    //    }

    //    public Student Select(string studId)
    //    {
    //        using (DataBase dataBase = new DataBase())
    //        {
    //            dataBase.ConnectionOpen();
    //            DataTable dt = new DataTable();
    //            Student student = null;
    //            string commandStr = "SELECT * FROM " + _table + "WHERE StudentId = '"+studId+"'";
    //            SqlCommand sqlCommand = new SqlCommand(commandStr);
    //            using (SqlDataReader reader = sqlCommand.ExecuteReader())
    //            {
    //                dt.Load(reader);
    //                foreach (Student st in dt.Rows)
    //                {
    //                    student = new Student(st.SName, st.Name, st.PName, st.GroupId);
    //                }
    //            }
    //            return student;
    //        }
    //    }
    //}
}
