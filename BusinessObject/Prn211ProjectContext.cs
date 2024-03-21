using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BusinessObject;

public partial class Prn211ProjectContext : DbContext
{
    public Prn211ProjectContext()
    {
    }

    public Prn211ProjectContext(DbContextOptions<Prn211ProjectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<ClassSubject> ClassSubjects { get; set; }

    public virtual DbSet<Exam> Exams { get; set; }

    public virtual DbSet<Option> Options { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<Test> Tests { get; set; }

    public virtual DbSet<TestDetail> TestDetails { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-7RDVN58;database=PRN211_Project;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasKey(e => e.ClassId).HasName("PK__class__FDF47986A6DA9063");

            entity.ToTable("class");

            entity.Property(e => e.ClassId)
                .ValueGeneratedNever()
                .HasColumnName("class_id");
            entity.Property(e => e.ClassName)
                .HasMaxLength(255)
                .HasColumnName("class_name");
        });

        modelBuilder.Entity<ClassSubject>(entity =>
        {
            entity.HasKey(e => new { e.SubjectId, e.ClassId, e.StudentId }).HasName("PK__class_su__B4F182FEE801E7DB");

            entity.ToTable("class_subject");

            entity.Property(e => e.SubjectId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("subject_id");
            entity.Property(e => e.ClassId).HasColumnName("class_id");
            entity.Property(e => e.StudentId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("student_id");

            entity.HasOne(d => d.Class).WithMany(p => p.ClassSubjects)
                .HasForeignKey(d => d.ClassId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__class_sub__class__4F7CD00D");

            entity.HasOne(d => d.Student).WithMany(p => p.ClassSubjects)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__class_sub__stude__5165187F");

            entity.HasOne(d => d.Subject).WithMany(p => p.ClassSubjects)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__class_sub__subje__5070F446");
        });

        modelBuilder.Entity<Exam>(entity =>
        {
            entity.HasKey(e => e.ExamId).HasName("PK__exam__9C8C7BE9801A38E8");

            entity.ToTable("exam");

            entity.Property(e => e.ExamId)
                .ValueGeneratedNever()
                .HasColumnName("exam_id");
            entity.Property(e => e.ExamName)
                .HasMaxLength(255)
                .HasColumnName("exam_name");
        });

        modelBuilder.Entity<Option>(entity =>
        {
            entity.HasKey(e => e.OptionId).HasName("PK__option__F4EACE1BD8307462");

            entity.ToTable("option");

            entity.Property(e => e.OptionId)
                .ValueGeneratedNever()
                .HasColumnName("option_id");
            entity.Property(e => e.OptionContent)
                .HasMaxLength(255)
                .HasColumnName("option_content");
            entity.Property(e => e.QuestionId).HasColumnName("question_id");
            entity.Property(e => e.RightAnswer).HasColumnName("right_answer");

            entity.HasOne(d => d.Question).WithMany(p => p.Options)
                .HasForeignKey(d => d.QuestionId)
                .HasConstraintName("FK__option__question__49C3F6B7");
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasKey(e => e.QuestionId).HasName("PK__question__2EC215491D1960D9");

            entity.ToTable("question");

            entity.Property(e => e.QuestionId)
                .ValueGeneratedNever()
                .HasColumnName("question_id");
            entity.Property(e => e.ExamId).HasColumnName("exam_id");
            entity.Property(e => e.QuestionContent)
                .HasMaxLength(255)
                .HasColumnName("question_content");
            entity.Property(e => e.SubjectId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("subject_id");

            entity.HasOne(d => d.Exam).WithMany(p => p.Questions)
                .HasForeignKey(d => d.ExamId)
                .HasConstraintName("FK_question_exam");

            entity.HasOne(d => d.Subject).WithMany(p => p.Questions)
                .HasForeignKey(d => d.SubjectId)
                .HasConstraintName("FK__question__subjec__52593CB8");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__role__760965CC2F4A269A");

            entity.ToTable("role");

            entity.Property(e => e.RoleId)
                .ValueGeneratedNever()
                .HasColumnName("role_id");
            entity.Property(e => e.RoleName)
                .HasMaxLength(255)
                .HasColumnName("role_name");
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.SubjectId).HasName("PK__subject__5004F6605C48D1B1");

            entity.ToTable("subject");

            entity.Property(e => e.SubjectId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("subject_id");
            entity.Property(e => e.SubjectName)
                .HasMaxLength(255)
                .HasColumnName("subject_name");
        });

        modelBuilder.Entity<Test>(entity =>
        {
            entity.HasKey(e => e.TestId).HasName("PK__test__F3FF1C025156F92D");

            entity.ToTable("test");

            entity.Property(e => e.TestId)
                .ValueGeneratedNever()
                .HasColumnName("test_id");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("created_date");
            entity.Property(e => e.ExamId).HasColumnName("exam_id");
            entity.Property(e => e.NumberOfQuestion).HasColumnName("number_of_question");
            entity.Property(e => e.PaperNo).HasColumnName("paper_no");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.SubjectId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("subject_id");
            entity.Property(e => e.TestCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("test_code");
            entity.Property(e => e.TestTime).HasColumnName("test_time");

            entity.HasOne(d => d.Exam).WithMany(p => p.Tests)
                .HasForeignKey(d => d.ExamId)
                .HasConstraintName("FK__test__exam_id__4BAC3F29");

            entity.HasOne(d => d.Subject).WithMany(p => p.Tests)
                .HasForeignKey(d => d.SubjectId)
                .HasConstraintName("FK__test__subject_id__4AB81AF0");
        });

        modelBuilder.Entity<TestDetail>(entity =>
        {
            entity.HasKey(e => new { e.QuestionId, e.TestId, e.UserId }).HasName("PK__test_det__1F445ABED717CF73");

            entity.ToTable("test_detail");

            entity.Property(e => e.QuestionId).HasColumnName("question_id");
            entity.Property(e => e.TestId).HasColumnName("test_id");
            entity.Property(e => e.UserId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("user_id");
            entity.Property(e => e.OptionChoosen).HasColumnName("option_choosen");

            entity.HasOne(d => d.Question).WithMany(p => p.TestDetails)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__test_deta__quest__4D94879B");

            entity.HasOne(d => d.Test).WithMany(p => p.TestDetails)
                .HasForeignKey(d => d.TestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__test_deta__test___4CA06362");

            entity.HasOne(d => d.User).WithMany(p => p.TestDetails)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__test_deta__user___4E88ABD4");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__user__B9BE370F89EC0D9D");

            entity.ToTable("user");

            entity.Property(e => e.UserId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("user_id");
            entity.Property(e => e.Dob)
                .HasColumnType("date")
                .HasColumnName("dob");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FullName)
                .HasMaxLength(255)
                .HasColumnName("full_name");
            entity.Property(e => e.Gender).HasColumnName("gender");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.RoleId).HasColumnName("role_id");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__user__role_id__48CFD27E");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
