using System;
using System.Collections.Generic;

namespace Laba1
{
    public partial class GroupAward
    {
        public int Id { get; set; }
        public int AwardId { get; set; }
        public int GroupId { get; set; }

        public virtual Award Award { get; set; }
        public virtual Group Group { get; set; }
    }
}
