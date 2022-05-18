using Course.DAL.Models;
using System;
using System.Collections.Generic;

namespace MOCK_Course.DAL.Models
{
    public class Courses : BaseEntity<Guid>
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string PreviewVideoUrl { get; set; }
        public decimal Price { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public Guid UserId { get; set; }
        public AppUser User { get; set; }


        public ICollection<Section> sections { get; set; }
        public ICollection<CourseCompletion> courseCompletions { get; set; }
        public ICollection<Enrollment> enrollments { get; set; }
        public ICollection<ShoppingCart> carts { get; set; }
        public ICollection<Order> orders { get; set; }
    }
}
