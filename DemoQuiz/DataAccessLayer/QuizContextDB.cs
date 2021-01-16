using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DemoQuiz.DataAccessLayer
{
    public partial class QuizContextDB : DbContext
    {
        public QuizContextDB()
            : base("name=QuizContextDB")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<Quiz> Quizs { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.AccountID)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Class)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Faculty)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.role)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Results)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Answer>()
                .Property(e => e.Correct)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Class>()
                .Property(e => e.ClassID)
                .IsUnicode(false);

            modelBuilder.Entity<Class>()
                .Property(e => e.FacultyID)
                .IsUnicode(false);

            modelBuilder.Entity<Class>()
                .HasMany(e => e.Accounts)
                .WithOptional(e => e.Class1)
                .HasForeignKey(e => e.Class);

            modelBuilder.Entity<Exam>()
                .Property(e => e.AccountID)
                .IsUnicode(false);

            modelBuilder.Entity<Exam>()
                .HasMany(e => e.Results)
                .WithRequired(e => e.Exam)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Faculty>()
                .Property(e => e.FacultyID)
                .IsUnicode(false);

            modelBuilder.Entity<Faculty>()
                .HasMany(e => e.Accounts)
                .WithOptional(e => e.Faculty1)
                .HasForeignKey(e => e.Faculty);

            modelBuilder.Entity<Quiz>()
                .Property(e => e.Level)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Result>()
                .Property(e => e.AccountID)
                .IsUnicode(false);

            modelBuilder.Entity<Subject>()
                .Property(e => e.FacultyID)
                .IsUnicode(false);

            modelBuilder.Entity<Subject>()
                .HasMany(e => e.Exams)
                .WithRequired(e => e.Subject)
                .WillCascadeOnDelete(false);
        }
    }
}
