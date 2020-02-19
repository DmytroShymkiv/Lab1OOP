using System;
using System.Collections.Generic;

namespace Laba1
{
    public partial class Song
    {
        public Song()
        {
            GroupSongs = new HashSet<GroupSongs>();
        }

        public int Id { get; set; }
        public string SongName { get; set; }
        public int ReleaseYear { get; set; }

        public virtual ICollection<GroupSongs> GroupSongs { get; set; }
    }
}
