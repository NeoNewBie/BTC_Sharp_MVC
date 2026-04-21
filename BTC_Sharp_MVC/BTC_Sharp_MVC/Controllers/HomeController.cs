using BTC_Sharp_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using BTC_Sharp_MVC.Models;

namespace UniversityManager.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Action xử lý yêu cầu hiển thị Sinh viên
        public IActionResult StudentInfo()
        {
            // Bước 1: Khởi tạo Model Student và gán giá trị (Hardcode theo yêu cầu demo)
            // Trong thực tế, bạn sẽ dùng ApplicationDbContext để query từ Database (vd: _context.Students.Find(id))
            var studentModel = new Student
            {
                StudentId = 2026001,
                FullName = "Quốc Nguyễn",
                DateOfBirth = new DateTime(2006, 12, 18),
                Email = "quoc.nguyen@university.edu.vn"
            };

            // Bước 2: Truyền Model vào View
            return View(studentModel);
        }
    }
}