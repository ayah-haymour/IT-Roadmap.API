using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace IT_Roadmap.Core.Data
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Contactu> Contactus { get; set; } = null!;
        public virtual DbSet<Learningpath> Learningpaths { get; set; } = null!;
        public virtual DbSet<Learningresorce> Learningresorces { get; set; } = null!;
        public virtual DbSet<Pathstep> Pathsteps { get; set; } = null!;
        public virtual DbSet<Pathstepchild> Pathstepchildren { get; set; } = null!;
        public virtual DbSet<Preference> Preferences { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Skill> Skills { get; set; } = null!;
        public virtual DbSet<Testimonial> Testimonials { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SID=XE)));User Id=C##IT;Password=1234;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("C##IT")
                .UseCollation("USING_NLS_COMP");

            modelBuilder.Entity<Contactu>(entity =>
            {
                entity.HasKey(e => e.Contactusid)
                    .HasName("SYS_C008641");

                entity.ToTable("CONTACTUS");

                entity.Property(e => e.Contactusid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CONTACTUSID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Message)
                    .HasMaxLength(900)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGE");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Subject)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SUBJECT");
            });

            modelBuilder.Entity<Learningpath>(entity =>
            {
                entity.HasKey(e => e.Pathid)
                    .HasName("SYS_C008645");

                entity.ToTable("LEARNINGPATH");

                entity.Property(e => e.Pathid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PATHID");

                entity.Property(e => e.Compleationstatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COMPLEATIONSTATUS");

                entity.Property(e => e.Skillid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SKILLID");

                entity.Property(e => e.Userid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("USERID");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.Learningpaths)
                    .HasForeignKey(d => d.Skillid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("SYS_C008646");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Learningpaths)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("SYS_C008647");
            });

            modelBuilder.Entity<Learningresorce>(entity =>
            {
                entity.HasKey(e => e.Resorceid)
                    .HasName("SYS_C008653");

                entity.ToTable("LEARNINGRESORCE");

                entity.Property(e => e.Resorceid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RESORCEID");

                entity.Property(e => e.Description)
                    .HasMaxLength(900)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Link)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("LINK");

                entity.Property(e => e.Provider)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROVIDER");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TITLE");
            });

            modelBuilder.Entity<Pathstep>(entity =>
            {
                entity.HasKey(e => e.Stepid)
                    .HasName("SYS_C008655");

                entity.ToTable("PATHSTEP");

                entity.Property(e => e.Stepid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("STEPID");

                entity.Property(e => e.Completed)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COMPLETED");

                entity.Property(e => e.Image)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE");

                entity.Property(e => e.Pathid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PATHID");

                entity.Property(e => e.Resorceid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("RESORCEID");

                entity.Property(e => e.Stepname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STEPNAME");

                entity.Property(e => e.Stepnumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("STEPNUMBER");

                entity.HasOne(d => d.Path)
                    .WithMany(p => p.Pathsteps)
                    .HasForeignKey(d => d.Pathid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("SYS_C008656");

                entity.HasOne(d => d.Resorce)
                    .WithMany(p => p.Pathsteps)
                    .HasForeignKey(d => d.Resorceid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("SYS_C008657");
            });

            modelBuilder.Entity<Pathstepchild>(entity =>
            {
                entity.HasKey(e => e.Stepchildid)
                    .HasName("SYS_C008659");

                entity.ToTable("PATHSTEPCHILD");

                entity.Property(e => e.Stepchildid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("STEPCHILDID");

                entity.Property(e => e.Completed)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COMPLETED");

                entity.Property(e => e.Image)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE");

                entity.Property(e => e.Pathid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PATHID");

                entity.Property(e => e.Resorceid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("RESORCEID");

                entity.Property(e => e.Stepid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("STEPID");

                entity.Property(e => e.Stepname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STEPNAME");

                entity.Property(e => e.Stepnumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("STEPNUMBER");

                entity.HasOne(d => d.Path)
                    .WithMany(p => p.Pathstepchildren)
                    .HasForeignKey(d => d.Pathid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("SYS_C008660");

                entity.HasOne(d => d.Resorce)
                    .WithMany(p => p.Pathstepchildren)
                    .HasForeignKey(d => d.Resorceid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("SYS_C008661");

                entity.HasOne(d => d.Step)
                    .WithMany(p => p.Pathstepchildren)
                    .HasForeignKey(d => d.Stepid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("SYS_C008662");
            });

            modelBuilder.Entity<Preference>(entity =>
            {
                entity.HasKey(e => e.Preferencesid)
                    .HasName("SYS_C008649");

                entity.ToTable("PREFERENCES");

                entity.Property(e => e.Preferencesid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PREFERENCESID");

                entity.Property(e => e.Commitmenttime)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COMMITMENTTIME");

                entity.Property(e => e.Experiencelevel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EXPERIENCELEVEL");

                entity.Property(e => e.Goals)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("GOALS");

                entity.Property(e => e.Skillid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SKILLID");

                entity.Property(e => e.Userid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("USERID");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.Preferences)
                    .HasForeignKey(d => d.Skillid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("SYS_C008650");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Preferences)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("SYS_C008651");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("ROLE");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Rolename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROLENAME");
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.ToTable("SKILL");

                entity.Property(e => e.Skillid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SKILLID");

                entity.Property(e => e.Skillname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SKILLNAME");
            });

            modelBuilder.Entity<Testimonial>(entity =>
            {
                entity.ToTable("TESTIMONIAL");

                entity.Property(e => e.Testimonialid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TESTIMONIALID");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Testimonialdate)
                    .HasPrecision(6)
                    .HasColumnName("TESTIMONIALDATE")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Testimonialtext)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("TESTIMONIALTEXT");

                entity.Property(e => e.Userid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Testimonials)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("SYS_C008639");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("USERS");

                entity.Property(e => e.Userid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("USERID");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Dateofbirth)
                    .HasColumnType("DATE")
                    .HasColumnName("DATEOFBIRTH");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GENDER");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PHONENUMBER");

                entity.Property(e => e.Profileimage)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PROFILEIMAGE");

                entity.Property(e => e.Registrationdate)
                    .HasPrecision(6)
                    .HasColumnName("REGISTRATIONDATE")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Username)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Roleid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("SYS_C008636");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
