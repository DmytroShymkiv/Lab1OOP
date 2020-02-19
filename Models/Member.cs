using System;
using System.Collections.Generic;

namespace Laba1
{
    public partial class Member
    {
        public int Id { get; set; }
        public string YearofBirth { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int GroupId { get; set; }

        public virtual Group Group { get; set; }
    }
}
