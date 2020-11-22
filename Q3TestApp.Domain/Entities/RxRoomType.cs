using System;
using System.Collections.Generic;

namespace Q3TestApp.Domain.Entities
{
    public class RxRoomType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<RxJob> Jobs { get; private set; } = new List<RxJob>();
    }
}
