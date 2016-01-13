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
    public class TimeTable : Base<TimeTable>
    {
        [DataMember]
        private DateTime _firstWeek;
        [DataMember]
        private DateTime _secondWeek;
        [DataMember]
        private Guid _teacherId;
        public DateTime FirstWeek
        {
            get { return _firstWeek; }
            private set { _firstWeek = value; }
        }

        public DateTime SecondWeek
        {
            get { return _secondWeek; }
            private set { _secondWeek = value; }
        }

        public Guid TeacherId
        {
            get { return _teacherId; }
            private set { _teacherId = value; }
        }

        public TimeTable(Guid teacherId)
        {
            _teacherId = teacherId;
        }

        public void SetFirstAndSecondWeek(DateTime date)
        {
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    TimeTable.Items[this.Id]._firstWeek = date.Date;
                    TimeTable.Items[this.Id]._secondWeek = date.Date + TimeSpan.FromDays(7);
                    break;
                case DayOfWeek.Tuesday:
                    TimeTable.Items[this.Id]._firstWeek = date.Date - TimeSpan.FromDays(1);
                    TimeTable.Items[this.Id]._secondWeek = date.Date + TimeSpan.FromDays(7);
                    break;
                case DayOfWeek.Wednesday:
                    TimeTable.Items[this.Id]._firstWeek = date.Date - TimeSpan.FromDays(2);
                    TimeTable.Items[this.Id]._secondWeek = date.Date + TimeSpan.FromDays(7);
                    break;
                case DayOfWeek.Thursday:
                    TimeTable.Items[this.Id]._firstWeek = date.Date - TimeSpan.FromDays(3);
                    TimeTable.Items[this.Id]._secondWeek = date.Date + TimeSpan.FromDays(7);
                    break;
                case DayOfWeek.Friday:
                    TimeTable.Items[this.Id]._firstWeek = date.Date - TimeSpan.FromDays(4);
                    TimeTable.Items[this.Id]._secondWeek = date.Date + TimeSpan.FromDays(7);
                    break;
                case DayOfWeek.Saturday:
                    TimeTable.Items[this.Id]._firstWeek = date.Date - TimeSpan.FromDays(5);
                    TimeTable.Items[this.Id]._secondWeek = date.Date + TimeSpan.FromDays(7);
                    break;
                case DayOfWeek.Sunday:
                    TimeTable.Items[this.Id]._firstWeek = date.Date - TimeSpan.FromDays(6);
                    TimeTable.Items[this.Id]._secondWeek = date.Date + TimeSpan.FromDays(7);
                    break;
            }
        }

        private DateTime GetMondeyDate(DateTime date)
        {
            DateTime result = new DateTime();
            switch(date.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    result = date - TimeSpan.FromDays(0);
                    break;
                case DayOfWeek.Tuesday:
                    result = date - TimeSpan.FromDays(1);
                    break;
                case DayOfWeek.Wednesday:
                    result = date - TimeSpan.FromDays(2);
                    break;
                case DayOfWeek.Thursday:
                    result = date - TimeSpan.FromDays(3);
                    break;
                case DayOfWeek.Friday:
                    result = date - TimeSpan.FromDays(4);
                    break;
                case DayOfWeek.Saturday:
                    result = date - TimeSpan.FromDays(5);
                    break;
                case DayOfWeek.Sunday:
                    result = date - TimeSpan.FromDays(6);
                    break;
            }
            return result;
        }

        public TypeOfWeek GetTypeOfWeek(DateTime date)
        {
            var mondayDate = GetMondeyDate(date);
            int delta = Math.Abs((_firstWeek - mondayDate).Days);
            if (delta % 14 == 0)
                return TypeOfWeek.First;
            else
                return TypeOfWeek.Second;
        }

        public TypeOfPair GetTypeOfPair(DateTime date)
        {
            if (date.Hour * 60 + date.Minute < 605 && date.Hour * 60 + date.Minute >= 510)
                return TypeOfPair.First;
            else if (date.Hour * 60 + date.Minute < 720 && date.Hour * 60 + date.Minute >= 625)
                return TypeOfPair.Second;
            else if (date.Hour * 60 + date.Minute < 835 && date.Hour * 60 + date.Minute >= 740)
                return TypeOfPair.Third;
            else if (date.Hour * 60 + date.Minute < 950 && date.Hour * 60 + date.Minute >= 855)
                return TypeOfPair.Fourth;
            else if (date.Hour * 60 + date.Minute < 1065 && date.Hour * 60 + date.Minute >= 970)
                return TypeOfPair.Fifth;
            else
                return TypeOfPair.Undefined;
        }

        public List<StudingTheSubject> GetPair(DateTime date)
        {
            List<StudingTheSubject> result = new List<StudingTheSubject>();
            DataTable pairTable = TableData.SelectByRule("StudingTheSubject","StudentProgressDB",
                                                    new List<string>() { "TeacherID", "Day", "TypeOfWeek", "TypeOfPair"},
                                                    new List<string>() 
                                                    { _teacherId.ToString(), 
                                                        date.DayOfWeek.ToString(), 
                                                        GetTypeOfWeek(date).ToString(), 
                                                        GetTypeOfPair(date).ToString()});
            if (pairTable.Rows.Count == 0)
                return result;
            foreach (DataRow pair in pairTable.Rows)
            {
                Guid pairId = Guid.Parse(pair[0].ToString());
                if (StudingTheSubject.Items.Keys.Contains(pairId))
                {
                    result.Add(StudingTheSubject.Items[pairId]);
                }
                else
                {
                    Guid subjId = Guid.Parse(pair[1].ToString());
                    Guid grId = Guid.Parse(pair[2].ToString());
                    DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), pair[4].ToString(), true);
                    TypeOfWeek weekType = (TypeOfWeek)Enum.Parse(typeof(TypeOfWeek), pair[5].ToString(), true);
                    TypeOfPair pairType = (TypeOfPair)Enum.Parse(typeof(TypeOfPair), pair[6].ToString(), true);
                    int room = Int32.Parse(pair[7].ToString());
                    result.Add(new StudingTheSubject(pairId ,subjId, grId, _teacherId, day, weekType, pairType, room));
                }
            }
            return result;
        }

        public List<StudingTheSubject> GetNextPair(out DateTime date)
        {
            date = DateTime.Now;
            List<StudingTheSubject> pairs = new List<StudingTheSubject>();
            if (GetAllPairs(Teacher.GetById(this.TeacherId)).Count == 0)
                return pairs;
            while(pairs.Count == 0)
            {
                date += new TimeSpan(1, 35, 0);
                pairs = GetPair(date);
            }
            return pairs;
        }
        public static TimeTable GetByTeacher(Teacher teacher)
        {
            DataTable timetable = TableData.SelectByRule("TimeTable", "StudentProgressDB", new List<string>() { "TeacherID" }, new List<string>() { teacher.Id.ToString()});
            TimeTable tm = null;
            if (timetable.Rows.Count == 0)
                return tm;
            Guid tmId = Guid.Parse(timetable.Rows[0][0].ToString());
            if (TimeTable.Items.Keys.Contains(tmId))
                tm = TimeTable.Items[tmId];
            else
            {
                tm = new TimeTable(teacher.Id);
                tm.SetFirstAndSecondWeek(DateTime.Parse(timetable.Rows[0][1].ToString()));
            }
            return tm;
        }

        public static int CreateNew(TimeTable tmt)
        {
            return TableData.InsertInto("TimeTable", "StudentProgressDB",
                new List<string>() { tmt.Id.ToString(), String.Format("{0}.{1}.{2}", tmt.FirstWeek.Month, tmt.FirstWeek.Day, tmt.FirstWeek.Year), String.Format("{0}.{1}.{2}", tmt.SecondWeek.Month, tmt.SecondWeek.Day, tmt.SecondWeek.Year), tmt.TeacherId.ToString() },
                new List<string>() { "TimeTableID", "FirstWeek", "SecondWeek", "TeacherID" });
        }

        public static List<StudingTheSubject> GetAllPairs(Teacher teacher)
        {
            List<StudingTheSubject> pairs = new List<StudingTheSubject>();
            DataTable pairsTable = TableData.SelectByRule("StudingTheSubject", "StudentProgressDB", new List<string>() { "TeacherID" }, new List<string>() { teacher.Id.ToString()});
            if (pairsTable.Rows.Count == 0)
                return pairs;
            foreach (DataRow pair in pairsTable.Rows)
            {
                Guid pairId = Guid.Parse(pair[0].ToString());
                if (StudingTheSubject.Items.Keys.Contains(pairId))
                    pairs.Add(StudingTheSubject.Items[pairId]);
                else
                {
                    Guid grId = Guid.Parse(pair[2].ToString());
                    Guid teachId = Guid.Parse(pair[3].ToString());
                    Guid subjId = Guid.Parse(pair[1].ToString());
                    DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), pair[4].ToString());
                    TypeOfWeek weekType = (TypeOfWeek)Enum.Parse(typeof(TypeOfWeek), pair[5].ToString());
                    TypeOfPair pairType = (TypeOfPair)Enum.Parse(typeof(TypeOfPair), pair[6].ToString());
                    int room = Int32.Parse(pair[7].ToString());
                    pairs.Add(new StudingTheSubject(pairId, subjId, grId, teachId, day, weekType, pairType, room));
                }
            }
            return pairs;
        }
    }
}