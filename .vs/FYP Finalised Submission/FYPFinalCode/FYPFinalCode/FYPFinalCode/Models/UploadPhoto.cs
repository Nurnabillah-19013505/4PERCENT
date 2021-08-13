using System;
using System.Collections.Generic;

namespace FYPFinalCode.Models
{
    public partial class UploadPhoto
    {
        public UploadPhoto()
        {
            Journal = new HashSet<Journal>();
            Mission = new HashSet<Mission>();
        }

        public int PhotoId { get; set; }
        public string PhotoDes { get; set; }

        public virtual ICollection<Journal> Journal { get; set; }
        public virtual ICollection<Mission> Mission { get; set; }
    }
}
