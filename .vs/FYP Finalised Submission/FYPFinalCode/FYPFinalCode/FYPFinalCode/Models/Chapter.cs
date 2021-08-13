using System;
using System.Collections.Generic;

namespace FYPFinalCode.Models
{
    public partial class Chapter
    {
        public Chapter()
        {
            Journal = new HashSet<Journal>();
            Mission = new HashSet<Mission>();
        }

        public int ChapterNo { get; set; }
        public int StudentId { get; set; }
        public string ChapterTitle { get; set; }
        public string ChapterCompletion { get; set; }

        public virtual Student Student { get; set; }
        public virtual ICollection<Journal> Journal { get; set; }
        public virtual ICollection<Mission> Mission { get; set; }
    }
}
