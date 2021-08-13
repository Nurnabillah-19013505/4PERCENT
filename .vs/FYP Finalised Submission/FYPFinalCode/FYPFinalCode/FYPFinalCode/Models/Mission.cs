using System;
using System.Collections.Generic;

namespace FYPFinalCode.Models
{
    public partial class Mission
    {
        public Mission()
        {
            Journal = new HashSet<Journal>();
        }

        public int MissionTask { get; set; }
        public int ChapterNo { get; set; }
        public string MissionDes { get; set; }
        public DateTime MiStartDate { get; set; }
        public DateTime MiEndDate { get; set; }
        public int? PhotoUpload { get; set; }
        public string PhotoStatus { get; set; }
        public int? VideoUpload { get; set; }
        public string VideoStatus { get; set; }
        public string CompletionStatus { get; set; }

        public virtual Chapter ChapterNoNavigation { get; set; }
        public virtual UploadPhoto PhotoUploadNavigation { get; set; }
        public virtual UploadVideo VideoUploadNavigation { get; set; }
        public virtual ICollection<Journal> Journal { get; set; }
    }
}
