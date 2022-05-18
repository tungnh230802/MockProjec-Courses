using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MOCK_Course.DAL.Models;

namespace Course.DAL.Configuration
{
    internal class CoursesConfiguration : IEntityTypeConfiguration<Courses>
    {
        public void Configure(EntityTypeBuilder<Courses> builder)
        {
            // 1-n:category-course
            builder.HasOne(course => course.Category)
                .WithMany(cate => cate.courses)
                .HasForeignKey(course => course.CategoryId);

            // 1-n:user-course
            builder.HasOne(c => c.User)
                .WithMany(u => u.courses)
                .HasForeignKey(c => c.UserId);

            builder.Property(c => c.Price).HasColumnType("money");
        }
    }
}
