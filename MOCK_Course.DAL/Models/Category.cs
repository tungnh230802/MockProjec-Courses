using MOCK_Course.DAL.Models;
using System;
using System.Collections.Generic;

namespace Course.DAL.Models
{
    public class Category : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public Guid? ParentcategoryId { get; set; }
        public Category Parentcategory { get; set; }
        public ICollection<Category> categories { get; set; }
        public ICollection<Courses> courses { get; set; }
    }
}
