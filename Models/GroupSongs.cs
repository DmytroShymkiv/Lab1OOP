using System;
using System.Collections.Generic;

namespace Laba1
{
    public partial class GroupSongs
    {
        public int Id { get; set; }
        public int SongId { get; set; }
        public int GroupId { get; set; }

        public virtual Group Group { get; set; }
        public virtual Song Song { get; set; }
    }
}
