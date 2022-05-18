﻿using Course.DAL.Models;
using System;
using System.Collections.Generic;

namespace MOCK_Course.DAL.Models
{
    public class Enrollment : BaseEntity<Guid>
    {
        public Guid CourseId { get; set; }
        public Guid UserId { get; set; }

        public AppUser User { get; set; }
        public Courses Courses { get; set; }
        public ICollection<CourseReview> CourseReviews { get; set; }
    }
}
