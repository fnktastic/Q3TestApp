using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Q3TestApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q3TestApp.Infrastructure.Persistance.Configurations
{
    public class RxJobConfiguration : IEntityTypeConfiguration<RxJob>
    {
        public void Configure(EntityTypeBuilder<RxJob> builder)
        {
            builder.ToTable("RX_Job").HasKey(x => x.Id);
        }
    }
}
