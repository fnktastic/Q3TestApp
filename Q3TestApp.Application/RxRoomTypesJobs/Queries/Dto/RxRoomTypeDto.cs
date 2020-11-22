using Q3TestApp.Application.Common.Mappings;
using Q3TestApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q3TestApp.Application.RxRoomTypes.Queries.Dto
{
    public class RxRoomTypeDto : IMapFrom<RxRoomType>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<RxJobDto> Jobs { get; private set; } = new List<RxJobDto>();
    }
}
