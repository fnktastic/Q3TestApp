using Microsoft.AspNetCore.Mvc;
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
        public async Task<ActionResult<RoomJobsSummaryListVm>> GetDiets()
        {
            return await Mediator.Send(new GetRoomJobsSummaryQuery());
        }
    }
}
