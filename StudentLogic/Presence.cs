using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace StudentLogic
{
    [DataContract]
    public class Presence : Base<Presence>
    {
        [DataMember]
        private Guid _studentId;
        [DataMember]
        private Guid _pairId;
        [DataMember]
        private DateTime _date;
        [DataMember]
        private bool _presencing;


        public Guid StudentId
        {
            get { return _studentId; }
            private set { _studentId = value; }
        }
        public Guid PairId
        {
            get { return _pairId; }
            private set { _pairId = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            private set { _date = value; }
        }

        public bool Presencing
        {
            get { return _presencing; }
            private set { _presencing = value; }
        }

        public Presence(Guid stusentId, Guid pairId, DateTime date, bool presencing)
        {
            _studentId = stusentId;
            _pairId = pairId;
            _date = date;
            _presencing = presencing;
        }
        public Presence(Guid Id, Guid stusentId, Guid pairId, DateTime date, bool presencing)
            : base(Id)
        {
            _studentId = stusentId;
            _pairId = pairId;
            _date = date;
            _presencing = presencing;
        }
    }
}
