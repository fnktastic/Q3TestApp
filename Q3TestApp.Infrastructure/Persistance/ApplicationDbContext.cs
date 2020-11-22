using Microsoft.EntityFrameworkCore;
using Q3TestApp.Application.Common.Interfaces;
using Q3TestApp.Domain.Entities;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Q3TestApp.Infrastructure.Persistance
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<RxJob> Jobs { get; set; }
        public DbSet<RxRoomType> RoomTypes { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            int result = await SaveChangesAsync(cancellationToken);

            return result;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
