
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BTC_Sharp_MVC.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int Credits { get; set; }

        // Quan hệ 1-N: Một môn học có thể mở nhiều lớp học phần
        public ICollection<CourseClass>? CourseClasses { get; set; }
    }
}
