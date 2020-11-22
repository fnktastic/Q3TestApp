using Microsoft.AspNetCore.Mvc;
using Q3TestApp.Application.RxRoomTypes.Commands.MarkJobAsCompleted;
using Q3TestApp.Application.RxRoomTypes.Queries.GetJobs;
using Q3TestApp.Application.RxRoomTypes.Queries.GetRoomJobsSummary;
using Q3TestApp.Application.RxRoomTypes.Queries.Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Q3TestApp.WebApi.Controllers
{
    public class MainController : ApiBaseController
    {
        [HttpGet]
        public async Task<ActionResult<JobsVm>> GetJobs()
        {
            return await Mediator.Send(new GetJobsQuery());
        }

        [HttpGet]
        [Route("stats")]
        public async Task<ActionResult<RoomJobsSummaryListVm>> RoomJobsSummary()
        {
            return await Mediator.Send(new GetRoomJobsSummaryQuery());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Create(Guid id, MarkJobAsCompletedCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            await Mediator.Send(command);

            return NoContent();
        }
    }
}
