using System;
using System.Collections.Generic;

namespace Laba1
{
    public partial class Award
    {
        public Award()
        {
            GroupAward = new HashSet<GroupAward>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int AwardYear { get; set; }

        public virtual ICollection<GroupAward> GroupAward { get; set; }
    }
}
