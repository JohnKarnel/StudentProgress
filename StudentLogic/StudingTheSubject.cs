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
    public class StudingTheSubject : Base<StudingTheSubject>
    {
        [DataMember]
        private Guid _subjectId;
        [DataMember]
        private Guid _groupId;
        [DataMember]
        private Guid _teacherId;
        [DataMember]
        private DayOfWeek _day;
        [DataMember]
        private TypeOfWeek _typeOfWeek;
        [DataMember]
        private TypeOfPair _typeOfPair;
        [DataMember]
        private int _classroom;


        public StudingTheSubject(Guid subjId, Guid grId, Guid teachId, DayOfWeek day, TypeOfWeek typeOfWeek, TypeOfPair typeOfPair, int classroom)   
        {
            _subjectId = subjId;
            _groupId = grId;
            _teacherId = teachId;
            _day = day;
            _typeOfWeek = typeOfWeek;
            _typeOfPair = typeOfPair;
            _classroom = classroom;
        }

        public StudingTheSubject(Guid id, Guid subjId, Guid grId, Guid teachId, DayOfWeek day, TypeOfWeek typeOfWeek, TypeOfPair typeOfPair, int classroom) : base(id)
        {
            _subjectId = subjId;
            _groupId = grId;
            _teacherId = teachId;
            _day = day;
            _typeOfWeek = typeOfWeek;
            _typeOfPair = typeOfPair;
            _classroom = classroom;
        }

        public Guid SubjectId
        {
            get { return _subjectId; }
            set { _subjectId = value; }
        }
        
        public Guid GroupId
        {
            get { return _groupId; }
            set { _groupId = value; }
        }
        
        public Guid TeacherId
        {
            get { return _teacherId; }
            set { _teacherId = value; }
        }
        
        public DayOfWeek Day
        {
            get { return _day; }
            set { _day = value; }
        }

        public TypeOfWeek WeekType
        {
            get { return _typeOfWeek; }
            set { _typeOfWeek = value; }
        }

        public TypeOfPair PairType
        {
            get { return _typeOfPair; }
            set { _typeOfPair = value; }
        }

        public int Classroom
        {
            get { return _classroom; }
            set { _classroom = value; }
        }

        public static int CreateNew(StudingTheSubject pair)
        {
            DataTable result = TableData.SelectByRule("StudingTheSubject", "StudentProgressDB", new List<string>() { "Day", "TypeOfWeek", "TypeOfPair" }, new List<string>() { pair.Day.ToString(), pair.WeekType.ToString(), pair.PairType.ToString()});
            if(result.Rows.Count != 0)
            {
                foreach(DataRow row in result.Rows)
                {
                    Guid subjId = Guid.Parse(row[1].ToString());
                    Guid teachId = Guid.Parse(row[3].ToString());
                    int room = Int32.Parse(row[7].ToString());
                    Guid grId = Guid.Parse(row[2].ToString());
                    if (subjId != pair.SubjectId || teachId != pair.TeacherId || room != pair.Classroom || grId == pair.GroupId)
                        throw new Exception("Цей час у розкладі вже зайнято іншою парою!");
                }
            }
            StudingTheSubject newPair = new StudingTheSubject(pair.Id, pair.SubjectId, pair.GroupId, pair.TeacherId, pair.Day, pair.WeekType, pair.PairType, pair.Classroom);
            return TableData.InsertInto("StudingTheSubject", "StudentProgressDB",
                new List<string>() { newPair.Id.ToString(), newPair.SubjectId.ToString(), newPair.GroupId.ToString(), newPair.TeacherId.ToString(), newPair.Day.ToString(), newPair.WeekType.ToString(), newPair.PairType.ToString(), newPair.Classroom.ToString() },
                new List<string>() { "StudingTheSubjectID", "SubjectID", "GroupID", "TeacherID", "Day", "TypeOfWeek", "TypeOfPair", "ClassRoom" });
        }

        public int Edit(string[] newValues)
        {
            string newWeekType = newValues[0];
            string newDay = newValues[1];
            string newPairType = newValues[2];
            string newGrId = newValues[3];
            string newSubjId = newValues[4];
            string techerId = newValues[5];
            string newRoom = newValues[6];

            int result = TableData.UpdateWithRule("StudingTheSubject", "StudentProgressDB", 
                new List<string>(){"SubjectID", "GroupID", "TeacherID", "Day", "TypeOfWeek", "TypeOfPair", "ClassRoom"},
                new List<string>(){newSubjId, newGrId, techerId, newDay, newWeekType, newPairType, newRoom},
                new List<string>() { "StudingTheSubjectID" },
                new List<string>() { this.Id.ToString() });
            if (result > 0)
            {
                StudingTheSubject.Items[this.Id].WeekType = (TypeOfWeek)Enum.Parse(typeof(TypeOfWeek), newWeekType);
                StudingTheSubject.Items[this.Id].Day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek),newDay);
                StudingTheSubject.Items[this.Id].PairType = (TypeOfPair)Enum.Parse(typeof(TypeOfPair), newPairType);
                StudingTheSubject.Items[this.Id].GroupId = Guid.Parse(newGrId);
                StudingTheSubject.Items[this.Id].SubjectId = Guid.Parse(newSubjId);
                StudingTheSubject.Items[this.Id].Classroom = Int32.Parse(newRoom);
            }
            return result;
        }

        public int Delete()
        {
            int result = TableData.DeleteByColumnValues("StudingTheSubject", "StudentProgressDB",
                   new List<string>() { "StudingTheSubjectID" },
                   new List<string>() { this.Id.ToString() });
            if (result > 0)
                Subject.Items.Remove(this.Id);
            return result;
        }
    } 
}
