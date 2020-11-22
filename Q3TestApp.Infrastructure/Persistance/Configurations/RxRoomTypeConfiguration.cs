using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Q3TestApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q3TestApp.Infrastructure.Persistance.Configurations
{
    public class RxRoomTypeConfiguration : IEntityTypeConfiguration<RxRoomType>
    {
        public void Configure(EntityTypeBuilder<RxRoomType> builder)
        {
            builder.ToTable("RX_RoomType").HasKey(x => x.Id);
        }
    }
}
