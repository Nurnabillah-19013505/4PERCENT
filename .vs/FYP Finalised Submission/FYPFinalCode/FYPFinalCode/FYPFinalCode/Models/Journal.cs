using System;
using System.Collections.Generic;

namespace FYPFinalCode.Models
{
    public partial class Journal
    {
        public int JournalId { get; set; }
        public int StudentId { get; set; }
        public int ChapterNo { get; set; }
        public int MissionTask { get; set; }
        public int PhotoUpload { get; set; }
        public int VideoUpload { get; set; }

        public virtual Chapter ChapterNoNavigation { get; set; }
        public virtual Mission MissionTaskNavigation { get; set; }
        public virtual UploadPhoto PhotoUploadNavigation { get; set; }
        public virtual Student Student { get; set; }
        public virtual UploadVideo VideoUploadNavigation { get; set; }
    }
}
