using Microsoft.EntityFrameworkCore;
using Q3TestApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Q3TestApp.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<RxJob> Jobs { get; set; }
        DbSet<RxRoomType> RoomTypes { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
