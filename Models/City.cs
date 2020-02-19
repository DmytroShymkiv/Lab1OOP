using System;
using System.Collections.Generic;

namespace Laba1
{
    public partial class City
    {
        public City()
        {
            Group = new HashSet<Group>();
        }

        public int Id { get; set; }
        public string Cname { get; set; }
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Group> Group { get; set; }
    }
}
