using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using StudentLogic;

namespace Interfaces
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStudentService" in both code and config file together.
    [ServiceContract]
    public interface IStudentService
    {
        [OperationContract]
        List<StudingTheSubject> GetCurrentPair(DateTime date, Teacher teacher);
        [OperationContract]
        void AttendStudent(Student student, bool presence, StudingTheSubject pair);
        [OperationContract]
        Teacher GetTeacher(string login, string password);
        [OperationContract]
        void BeginWork();
        [OperationContract]
        void EndWork();
        [OperationContract]
        int RegistrateTeacher(Teacher teacher, string login, string password);
        [OperationContract]
        List<Group> GetAllGroups();
        [OperationContract]
        List<Subject> GetAllSubjects();
        [OperationContract]
        List<Student> GetAllStudents();
        [OperationContract]
        int AddSubject(Subject subject);
        [OperationContract]
        int EditSubject(Subject subject, string newName);
        [OperationContract]
        int DeleteSubject(Subject subject);
        [OperationContract]
        int AddGroup(Group group);
        [OperationContract]
        int EditGroup(Group group, string newName);
        [OperationContract]
        int DeleteGroup(Group group);
        [OperationContract]
        int AddStudent(Student student);
        [OperationContract]
        int EditStudent(Student student, string[] newValues);
        [OperationContract]
        int DeleteStudent(Student student);
        [OperationContract]
        bool IsTimeTableForTeacher(Teacher teacher);
        [OperationContract]
        int CreateTimeTable(TimeTable tmt);
        [OperationContract]
        List<StudingTheSubject> GetAllSdudingSubjects(Teacher teacher);
        [OperationContract]
        int AddPair(StudingTheSubject pair);
        [OperationContract]
        Group GetGroupById(Guid id);
        [OperationContract]
        Subject GetSubjectById(Guid id);
        [OperationContract]
        List<StudingTheSubject> GetNextPair(Teacher teacher, out DateTime date);
        [OperationContract]
        int EditPair(StudingTheSubject pair, string[] newvalues);
        [OperationContract]
        int DeletePair(StudingTheSubject pair);
        [OperationContract]
        List<Presence> GetAllPresences(Student student);
    }
}
