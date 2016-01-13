using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StudentLogic
{
    public static class Serializer
    {
        public static void Serialize()
        {
            Teacher.SerializeItems();
            Group.SerializeItems();
            Student.SerializeItems();
            Subject.SerializeItems();
            StudingTheSubject.SerializeItems();
            TimeTable.SerializeItems();
        }

        public static void Deserialize()
        {
            Teacher.DeserializeItems();
            Group.DeserializeItems();
            Student.DeserializeItems();
            Subject.DeserializeItems();
            StudingTheSubject.DeserializeItems();
            TimeTable.DeserializeItems();
        }
    }
}
