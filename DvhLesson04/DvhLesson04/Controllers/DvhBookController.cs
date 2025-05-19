using DvhLesson04.Models;
using Microsoft.AspNetCore.Mvc;

namespace DvhLesson04.Controllers
{
    public class DvhBookController : Controller
    {
        private List<DvhBook> dvhBooks = new List<DvhBook>
                {
                    new DvhBook
                    {
                        DvhId = "B001",
                        DvhTitle = "C# Programming Basics",
                        DvhDescription = "An introductory book to C# programming.",
                        DvhImage = "images/book-1.jpg",
                        DvhPrice = 19.99f,
                        DvhPage = 320
                    },
                    new DvhBook
                    {
                        DvhId = "B002",
                        DvhTitle = "Mastering ASP.NET Core",
                        DvhDescription = "Deep dive into ASP.NET Core for web development.",
                        DvhImage = "images/book-2.jpg",
                        DvhPrice = 29.99f,
                        DvhPage = 450
                    },
                    new DvhBook
                    {
                        DvhId = "B003",
                        DvhTitle = "Data Structures and Algorithms",
                        DvhDescription = "Essential concepts of data structures and algorithms.",
                        DvhImage = "images/book-3.jpg",
                        DvhPrice = 24.5f,
                        DvhPage = 380
                    },
                    new DvhBook
                    {
                        DvhId = "B004",
                        DvhTitle = "Design Patterns in C#",
                        DvhDescription = "A guide to software design patterns using C#.",
                        DvhImage = "images/book-4.jpg",
                        DvhPrice = 34.75f,
                        DvhPage = 410
                    },
                    new DvhBook
                    {
                        DvhId = "B005",
                        DvhTitle = "Entity Framework Core Essentials",
                        DvhDescription = "Learn how to use EF Core with real-world examples.",
                        DvhImage = "images/book-5.jpg",
                        DvhPrice = 22.0f,
                        DvhPage = 290
                    }
                };




        //GET: /DvhBook/DvhIndex => Lay tat ca cac cuon sach 
        public IActionResult DvhIndex()
        {

            // Đưa dữ liệu lên view
            return View();
        }
        public IActionResult DvhCreat ()
        {

            DvhBook dvhBook = new DvhBook();
           
            return View(dvhBook);
        }
        public IActionResult DvhCreatSubmit()
        {

            return RedirectToAction("DvhIndex");
        }
        public IActionResult DvhEdit( string id)
        {
            return View();
        }
        public IActionResult DvhEditSubmit()
        {

            return RedirectToAction("DvhIndex");
        }
    }
}
