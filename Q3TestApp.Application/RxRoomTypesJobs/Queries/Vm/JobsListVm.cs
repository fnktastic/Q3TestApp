using Q3TestApp.Application.RxRoomTypes.Queries.Dto;
using Q3TestApp.Application.RxRoomTypesJobs.Queries.Vm;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q3TestApp.Application.RxRoomTypes.Queries.Vm
{
    public class JobsListVm
    {
        public List<JobVm> Items { get; set; } = new List<JobVm>();
    }
}
