using System;
using System.Collections.Generic;

namespace Laba1
{
    public partial class Country
    {
        public Country()
        {
            City = new HashSet<City>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<City> City { get; set; }
    }
}
