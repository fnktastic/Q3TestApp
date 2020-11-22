using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Q3TestApp.Application.Common.Interfaces;
using Q3TestApp.Application.RxRoomTypes.Queries.Dto;
using Q3TestApp.Application.RxRoomTypes.Queries.Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Q3TestApp.Application.RxRoomTypes.Queries.GetRoomJobsSummary
{
    public class GetRoomJobsSummaryQuery : IRequest<RoomJobsSummaryListVm>
    {
    }

    public class GetRoomJobsSummaryQueryHandler : IRequestHandler<GetRoomJobsSummaryQuery, RoomJobsSummaryListVm>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetRoomJobsSummaryQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<RoomJobsSummaryListVm> Handle(GetRoomJobsSummaryQuery request, CancellationToken cancellationToken)
        {
            var roomTypes = await _context.RoomTypes
                .ProjectTo<RxRoomTypeDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            var roomJobsSummaries = new RoomJobsSummaryListVm();

            foreach(var roomType in roomTypes)
            {
                var roomStatuses = roomType.Jobs.GroupBy(z => z.Status);

                var roomSummary = roomStatuses.Select(y =>
                {
                    return new RoomJobsSummaryVm
                    {
                        RoomTypeName = roomType.Name,
                        JobStatus = y.Key,
                        CountOfJobs = y.Count()
                    };
                });

                roomJobsSummaries.Items.AddRange(roomSummary);
            }

            return roomJobsSummaries;
        }
    }
}
