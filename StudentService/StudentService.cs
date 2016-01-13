using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Interfaces;
using StudentLogic;

namespace StudentService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentService" in both code and config file together.
    public class StudentService : IStudentService
    {

        public List<StudingTheSubject> GetCurrentPair(DateTime date, Teacher teacher)
        {
            try
            {
                var tm = TimeTable.GetByTeacher(teacher);
                if (tm == null)
                    return new List<StudingTheSubject>();
                var currentPairs = tm.GetPair(DateTime.Now);
                return currentPairs;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public Teacher GetTeacher(string login, string password)
        {
            try
            {
                return Teacher.GetTeacherByLogin(login, password);
            }
            catch(Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void BeginWork()
        {

            Serializer.Deserialize();
        }

        public void EndWork()
        {
            Serializer.Serialize();
        }

        public int RegistrateTeacher(Teacher teacher, string login, string password)
        {
            try
            {
                return Teacher.RegistrateTeacher(teacher, login, password);
            }
            catch(Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public List<Group> GetAllGroups()
        {
            try
            {
                return Group.GetAllGroups();
            }
            catch(Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public List<Subject> GetAllSubjects()
        {
            try
            {
                return Subject.GetAllSubjects();
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public List<Student> GetAllStudents()
        {
            try
            {
                return Student.GetAllStudents();
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public int AddSubject(Subject subject)
        {
            try
            {
                return Subject.CreateNew(subject);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }


        public int EditSubject(Subject subject, string newName)
        {
            try
            {
                return subject.Edit(newName);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }


        public int DeleteSubject(Subject subject)
        {
            try
            {
                return subject.Delete();
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public int AddGroup(Group group)
        {
            try
            {
                return Group.CreateNew(group);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public int EditGroup(Group group, string newName)
        {
            try
            {
                return group.Edit(newName);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public int DeleteGroup(Group group)
        {
            try
            {
                return group.Delete();
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public int AddStudent(Student student)
        {
            try
            {
                return Student.CreateNew(student);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public int EditStudent(Student student, string[] newValues)
        {
            try
            {
                return student.Edit(newValues);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public int DeleteStudent(Student student)
        {
            try
            {
                return student.Delete();
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }
        public bool IsTimeTableForTeacher(Teacher teacher)
        {
            try
            {
                if (TimeTable.GetByTeacher(teacher) == null)
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public int CreateTimeTable(TimeTable tmt)
        {
            try
            {
                return TimeTable.CreateNew(tmt);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }


        public List<StudingTheSubject> GetAllSdudingSubjects(Teacher teacher)
        {
            try
            {
                return TimeTable.GetAllPairs(teacher);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public int AddPair(StudingTheSubject pair)
        {
            try
            {
                return StudingTheSubject.CreateNew(pair);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public Group GetGroupById(Guid id)
        {
            try
            {
                return Group.GetById(id);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }


        public Subject GetSubjectById(Guid id)
        {
            try
            {
                return Subject.GetById(id);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }


        public List<StudingTheSubject> GetNextPair(Teacher teacher, out DateTime date)
        {
            try
            {
                var tm = TimeTable.GetByTeacher(teacher);
                if (tm == null)
                {
                    date = DateTime.Now;
                    return new List<StudingTheSubject>();
                }
                var nextPairs = tm.GetNextPair(out date);
                return nextPairs;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }


        public int EditPair(StudingTheSubject pair, string[] newvalues)
        {
            try
            {
                return pair.Edit(newvalues);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }


        public int DeletePair(StudingTheSubject pair)
        {
            try
            {
                return pair.Delete();
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }


        public void AttendStudent(Student student, bool presence, StudingTheSubject pair)
        {
            try
            {
                student.Attend(presence, pair);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }


        public List<Presence> GetAllPresences(Student student)
        {
            try
            {
                return student.Presences;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }
    }
}
