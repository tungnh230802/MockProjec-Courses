using Course.DAL.Models;
using System.Collections.Generic;

namespace MOCK_Course.DAL.Models
{
    public class AppUser : UserBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FacebookLink { get; set; }
        public string LinkedlnLink { get; set; }
        public string YoutubeLink { get; set; }
        public string Instroduction { get; set; }
        public string Description { get; set; }

        public ICollection<Enrollment> enrollments { get; set; }
        public ICollection<CourseCompletion> courseCompletions { get; set; }
        public ICollection<Courses> courses { get; set; }
        public ICollection<Subscription> subscriptions { get; set; }
        public ICollection<LessonCompletion> lessonCompletions { get; set; }
        public ICollection<Order> orders { get; set; }
        public ICollection<ShoppingCart> carts { get; set; }
    }
}
