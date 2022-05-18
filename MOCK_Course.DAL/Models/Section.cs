using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOCK_Course.DAL.Models
{
    public class Section : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        public int TotalTime { get; set; }
        public List<Assignment> Assignments { get; set; }
    }
}
