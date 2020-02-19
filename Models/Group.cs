using System;
using System.Collections.Generic;

namespace Laba1
{
    public partial class Group
    {
        public Group()
        {
            GroupAward = new HashSet<GroupAward>();
            GroupSongs = new HashSet<GroupSongs>();
            Member = new HashSet<Member>();
        }

        public int Id { get; set; }
        public int CityId { get; set; }
        public string GroupName { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<GroupAward> GroupAward { get; set; }
        public virtual ICollection<GroupSongs> GroupSongs { get; set; }
        public virtual ICollection<Member> Member { get; set; }
    }
}
