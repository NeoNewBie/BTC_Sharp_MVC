
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTC_Sharp_MVC.Models
{
    public class CourseClass
    {
        [Key]
        public int ClassId { get; set; }
        public string ClassName { get; set; } // VD: IT101-Nhóm 1
        public string Semester { get; set; }

        // Khóa ngoại liên kết tới Course
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course? Course { get; set; }

        // Khóa ngoại liên kết tới Teacher
        public int TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public Teacher? Teacher { get; set; }

        // Quan hệ 1-N: Lớp học phần có nhiều lượt đăng ký
        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}