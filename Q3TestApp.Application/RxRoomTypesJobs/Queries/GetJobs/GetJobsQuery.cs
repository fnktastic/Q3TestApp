using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Q3TestApp.Application.Common.Interfaces;
using Q3TestApp.Application.RxRoomTypes.Queries.Dto;
using Q3TestApp.Application.RxRoomTypes.Queries.Vm;
using Q3TestApp.Application.RxRoomTypesJobs.Queries.Vm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Q3TestApp.Application.RxRoomTypes.Queries.GetJobs
{
    public class GetJobsQuery : IRequest<JobsVm>
    {

    }

    public class GetJobsQueryHandler : IRequestHandler<GetJobsQuery, JobsVm>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetJobsQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<JobsVm> Handle(GetJobsQuery request, CancellationToken cancellationToken)
        {
            return new JobsVm
            {
                Items = (await _context.Jobs
                    .ProjectTo<RxJobDto>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken))
                    .Select(x => new JobVm
                    {
                        Id = x.Id,
                        Floor = x.Floor,
                        JobStatus = x.Status,
                        Name = x.Name,
                        RoomType = x.RoomType.Name
                    })
                    .ToList()
            };
        }
    }
}
