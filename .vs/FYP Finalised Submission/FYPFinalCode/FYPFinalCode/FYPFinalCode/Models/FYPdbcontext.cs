using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FYPFinalCode.Models
{
    public partial class FYPdbcontext : DbContext
    {
        public FYPdbcontext()
        {
        }

        public FYPdbcontext(DbContextOptions<FYPdbcontext> options)
            : base(options)
        {
        }

        public virtual DbSet<CardDeck> CardDeck { get; set; }
        public virtual DbSet<Chapter> Chapter { get; set; }
        public virtual DbSet<Journal> Journal { get; set; }
        public virtual DbSet<Mission> Mission { get; set; }
        public virtual DbSet<Parent> Parent { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<UploadPhoto> UploadPhoto { get; set; }
        public virtual DbSet<UploadVideo> UploadVideo { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CardDeck>(entity =>
            {
                entity.HasKey(e => e.CardId)
                    .HasName("PK__CardDeck__45AA4B633C67C6A8");

                entity.Property(e => e.CardId).HasColumnName("Card_Id");

                entity.Property(e => e.CardTier)
                    .IsRequired()
                    .HasColumnName("Card_Tier")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PicFile)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Chapter>(entity =>
            {
                entity.HasKey(e => e.ChapterNo)
                    .HasName("PK__Chapter__BBD70611C1E13F4F");

                entity.Property(e => e.ChapterNo).HasColumnName("Chapter_No");

                entity.Property(e => e.ChapterCompletion)
                    .IsRequired()
                    .HasColumnName("Chapter_Completion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChapterTitle)
                    .IsRequired()
                    .HasColumnName("Chapter_Title")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StudentId).HasColumnName("Student_Id");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Chapter)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Chapter__Student__286302EC");
            });

            modelBuilder.Entity<Journal>(entity =>
            {
                entity.Property(e => e.JournalId).HasColumnName("Journal_Id");

                entity.Property(e => e.ChapterNo).HasColumnName("Chapter_No");

                entity.Property(e => e.MissionTask).HasColumnName("Mission_Task");

                entity.Property(e => e.PhotoUpload).HasColumnName("Photo_Upload");

                entity.Property(e => e.StudentId).HasColumnName("Student_Id");

                entity.Property(e => e.VideoUpload).HasColumnName("Video_Upload");

                entity.HasOne(d => d.ChapterNoNavigation)
                    .WithMany(p => p.Journal)
                    .HasForeignKey(d => d.ChapterNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Journal__Chapter__37A5467C");

                entity.HasOne(d => d.MissionTaskNavigation)
                    .WithMany(p => p.Journal)
                    .HasForeignKey(d => d.MissionTask)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Journal__Mission__38996AB5");

                entity.HasOne(d => d.PhotoUploadNavigation)
                    .WithMany(p => p.Journal)
                    .HasForeignKey(d => d.PhotoUpload)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Journal__Photo_U__398D8EEE");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Journal)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Journal__Student__36B12243");

                entity.HasOne(d => d.VideoUploadNavigation)
                    .WithMany(p => p.Journal)
                    .HasForeignKey(d => d.VideoUpload)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Journal__Video_U__3A81B327");
            });

            modelBuilder.Entity<Mission>(entity =>
            {
                entity.HasKey(e => e.MissionTask)
                    .HasName("PK__Mission__0624C71F327DFB17");

                entity.Property(e => e.MissionTask).HasColumnName("Mission_Task");

                entity.Property(e => e.ChapterNo).HasColumnName("Chapter_No");

                entity.Property(e => e.CompletionStatus)
                    .IsRequired()
                    .HasColumnName("Completion_Status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiEndDate)
                    .HasColumnName("Mi_EndDate")
                    .HasColumnType("date");

                entity.Property(e => e.MiStartDate)
                    .HasColumnName("Mi_StartDate")
                    .HasColumnType("date");

                entity.Property(e => e.MissionDes)
                    .IsRequired()
                    .HasColumnName("Mission_Des")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoStatus)
                    .IsRequired()
                    .HasColumnName("Photo_Status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoUpload).HasColumnName("Photo_Upload");

                entity.Property(e => e.VideoStatus)
                    .IsRequired()
                    .HasColumnName("Video_Status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VideoUpload).HasColumnName("Video_Upload");

                entity.HasOne(d => d.ChapterNoNavigation)
                    .WithMany(p => p.Mission)
                    .HasForeignKey(d => d.ChapterNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Mission__Chapter__2F10007B");

                entity.HasOne(d => d.PhotoUploadNavigation)
                    .WithMany(p => p.Mission)
                    .HasForeignKey(d => d.PhotoUpload)
                    .HasConstraintName("FK__Mission__Photo_U__300424B4");

                entity.HasOne(d => d.VideoUploadNavigation)
                    .WithMany(p => p.Mission)
                    .HasForeignKey(d => d.VideoUpload)
                    .HasConstraintName("FK__Mission__Video_U__30F848ED");
            });

            modelBuilder.Entity<Parent>(entity =>
            {
                entity.Property(e => e.ParentId).HasColumnName("Parent_Id");

                entity.Property(e => e.ParentEmail)
                    .IsRequired()
                    .HasColumnName("Parent_email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentEmailPass)
                    .IsRequired()
                    .HasColumnName("Parent_emailPass")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentEntryPass)
                    .IsRequired()
                    .HasColumnName("Parent_entryPass")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentMobileNo)
                    .IsRequired()
                    .HasColumnName("Parent_MobileNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentName)
                    .IsRequired()
                    .HasColumnName("Parent_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentVc).HasColumnName("Parent_VC");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.StudentId)
                    .HasColumnName("Student_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentAge).HasColumnName("Student_Age");

                entity.Property(e => e.StudentBc)
                    .IsRequired()
                    .HasColumnName("Student_BC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StudentName)
                    .IsRequired()
                    .HasColumnName("Student_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UploadPhoto>(entity =>
            {
                entity.HasKey(e => e.PhotoId)
                    .HasName("PK__Upload_P__7A07F6E2DB720EC8");

                entity.ToTable("Upload_Photo");

                entity.Property(e => e.PhotoId).HasColumnName("Photo_Id");

                entity.Property(e => e.PhotoDes)
                    .IsRequired()
                    .HasColumnName("Photo_Des")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UploadVideo>(entity =>
            {
                entity.HasKey(e => e.VideoId)
                    .HasName("PK__Upload_V__D8F76589B253BE6E");

                entity.ToTable("Upload_Video");

                entity.Property(e => e.VideoId).HasColumnName("Video_Id");

                entity.Property(e => e.VideoDes)
                    .IsRequired()
                    .HasColumnName("Video_Des")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
