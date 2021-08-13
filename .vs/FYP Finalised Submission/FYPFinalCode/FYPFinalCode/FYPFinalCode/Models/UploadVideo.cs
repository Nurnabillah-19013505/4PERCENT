using System;
using System.Collections.Generic;

namespace FYPFinalCode.Models
{
    public partial class UploadVideo
    {
        public UploadVideo()
        {
            Journal = new HashSet<Journal>();
            Mission = new HashSet<Mission>();
        }

        public int VideoId { get; set; }
        public string VideoDes { get; set; }

        public virtual ICollection<Journal> Journal { get; set; }
        public virtual ICollection<Mission> Mission { get; set; }
    }
}
