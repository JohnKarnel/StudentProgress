using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLogic
{
    public class Mark : Base<Mark>
    {
        private Guid _subjectId;
        private Guid _teacherId;
        private DateTime _date;
        private byte _mark;
        private Guid _studentId;
    }
}
