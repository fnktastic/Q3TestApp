using MediatR;
using Q3TestApp.Application.Common.Exceptions;
using Q3TestApp.Application.Common.Interfaces;
using Q3TestApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Q3TestApp.Application.RxRoomTypes.Commands.MarkJobAsCompleted
{

    public class MarkJobAsCompletedCommand : IRequest
    {
        public Guid Id { get; set; }
    }

    public class MarkJobAsCompletedCommandHandler : IRequestHandler<MarkJobAsCompletedCommand>
    {
        private readonly IApplicationDbContext _context;

        public MarkJobAsCompletedCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(MarkJobAsCompletedCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Jobs.FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(RxJob), request.Id);
            }

            entity.MardAsCompleted();
            
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
