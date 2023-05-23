using Book_Store_API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Book_Store_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Class> Classes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>()
                .HasMany(a => a.Students)
                .WithOne(b => b.Class)
                .HasForeignKey(b => b.ClassId);

            modelBuilder.Entity<StudentCourses>()
                .HasOne(b => b.Course)
                .WithMany(a => a.StudentCourse)
                .HasForeignKey(x => x.CourseId);

            modelBuilder.Entity<StudentCourses>()
                .HasOne(b => b.Student)
                .WithMany(a => a.StudentCourses)
                .HasForeignKey(x => x.StudentId);

            modelBuilder.Entity<Exam>()
                .HasMany(b => b.Students)
                .WithMany(a => a.Exams);

            modelBuilder.Entity<Exam>()
                .HasOne(b => b.Lecturer)
                .WithMany(a => a.Exams)
                .HasForeignKey(x => x.LecturerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Exam>()
                .HasOne(b => b.Course)
                .WithMany(a => a.Exams)
                .HasForeignKey(x => x.CourseId);

            modelBuilder.Entity<Lecturer>()
                .HasMany(b => b.Courses)
                .WithOne(a => a.Lecturer)
                .HasForeignKey(x => x.LecturerId);

            // Other configuration...
        }

    }
}
