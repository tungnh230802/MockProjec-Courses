using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOCK_Course.DAL.Models;

namespace Course.DAL.Configuration
{
    internal class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            // 1-n:user-enrollment
            builder.HasOne(e => e.User)
                .WithMany(u => u.enrollments)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            // 1-n:course-enrollment
            builder.HasOne(e => e.Courses)
                .WithMany(c => c.enrollments)
                .HasForeignKey(e => e.CourseId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
