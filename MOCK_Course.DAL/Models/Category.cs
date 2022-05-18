﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOCK_Course.DAL.Models
{
    public class Category : BaseEntity
    {
        [Required]  
        [MaxLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }
        public List<CategoryCourse> CategoryCourses { get; set; }

    }
}
