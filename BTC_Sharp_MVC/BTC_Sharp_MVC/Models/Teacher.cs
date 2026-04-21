
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BTC_Sharp_MVC.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string FullName { get; set; }
        public string Department { get; set; }

        // Quan hệ 1-N: Một giáo viên dạy nhiều lớp học phần
        public ICollection<CourseClass>? CourseClasses { get; set; }
    }
}
