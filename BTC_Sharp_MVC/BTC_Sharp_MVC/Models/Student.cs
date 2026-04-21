using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BTC_Sharp_MVC.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }

        // Quan hệ 1-N: Một sinh viên có thể đăng ký nhiều lớp
        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}