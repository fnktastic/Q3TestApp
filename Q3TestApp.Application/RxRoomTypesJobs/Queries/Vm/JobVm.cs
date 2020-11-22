using System;
using System.Collections.Generic;
using System.Text;

namespace Q3TestApp.Application.RxRoomTypesJobs.Queries.Vm
{
    public class JobVm
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int? Floor { get; set; }
        public string JobStatus { get; set; }
        public string RoomType { get; set; }
    }
}
