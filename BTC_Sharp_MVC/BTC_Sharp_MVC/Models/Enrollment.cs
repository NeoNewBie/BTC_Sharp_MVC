
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BTC_Sharp_MVC.Models
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }

        public int StudentId { get; set; }
        [ForeignKey("StudentId")]
        public Student? Student { get; set; }

        public int ClassId { get; set; }
        [ForeignKey("ClassId")]
        public CourseClass? CourseClass { get; set; }

        public float? Grade { get; set; } // Điểm số (có thể null nếu chưa thi)
    }
}