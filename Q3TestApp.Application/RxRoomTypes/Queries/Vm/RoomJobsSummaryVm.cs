using System;
using System.Collections.Generic;
using System.Text;

namespace Q3TestApp.Application.RxRoomTypes.Queries.Vm
{
    public class RoomJobsSummaryVm
    {
        public string RoomTypeName { get; set; }
        public string JobStatus { get; set; }
        public int CountOfJobs { get; set; }
    }
}
