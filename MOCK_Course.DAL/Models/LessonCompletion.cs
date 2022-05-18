using MOCK_Course.DAL.Models;
using System;

namespace Course.DAL.Models
{
    public class LessonCompletion : BaseEntity<Guid>
    {
        public Guid UserId { get; set; }
        public AppUser User { get; set; }

        public Guid LessonId { get; set; }
        public Lesson lesson { get; set; }
    }
}
