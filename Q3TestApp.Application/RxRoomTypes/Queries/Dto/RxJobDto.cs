using Q3TestApp.Application.Common.Mappings;
using Q3TestApp.Domain.Entities;
using System;

namespace Q3TestApp.Application.RxRoomTypes.Queries.Dto
{
    public class RxJobDto : IMapFrom<RxJob>
    {
        public Guid Id { get; set; }
        public int? ContractorId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public int? Floor { get; set; }
        public int? Room { get; set; }
        public string DelayReason { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateCompleted { get; set; }
        public DateTime? DateDelayed { get; set; }
        public int? StatusNum { get; set; }
        public int? RJobID { get; set; }

        public Guid RoomTypeId { get; set; }
        public RxRoomTypeDto RoomType { get; set; }
    }
}
