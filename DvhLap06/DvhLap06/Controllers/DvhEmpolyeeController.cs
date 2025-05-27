using DvhLap06.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace DvhLap06.Controllers
{
    public class DvhEmpolyeeController : Controller
    {
        private static List<DvhEmpolyee> dvhListEmpolyee = new List<DvhEmpolyee>()
        {
            new DvhEmpolyee
            {
                DvhId = 1,
                DvhName = "Dinh Van Hieu",
                DvhBirthDay = new DateTime(2002, 5, 15),
                DvhEmail = "hieu.dinh@example.com",
                DvhPhone = "0901234567",
                DvhSalary = 1000,
                DvhStatus = true
            },
            new DvhEmpolyee
            {
                DvhId = 2,
                DvhName = "Nguyen Thi Lan",
                DvhBirthDay = new DateTime(1998, 3, 22),
                DvhEmail = "lan.nguyen@example.com",
                DvhPhone = "0912345678",
                DvhSalary = 1200,
                DvhStatus = true
            },
            new DvhEmpolyee
            {
                DvhId = 3,DvhName = "Tran Van Nam",DvhBirthDay = new DateTime(1995, 7, 10),DvhEmail = "nam.tran@example.com",DvhPhone = "0934567890",DvhSalary = 1100,DvhStatus = false
            },
            new DvhEmpolyee
            {
                DvhId = 4,
                DvhName = "Le Thi Huong",
                DvhBirthDay = new DateTime(2000, 12, 5),
                DvhEmail = "huong.le@example.com",
                DvhPhone = "0945678901",
                DvhSalary = 1300,
                DvhStatus = true
            },
            new DvhEmpolyee
            {
                DvhId = 5,
                DvhName = "Pham Van Tuan",
                DvhBirthDay = new DateTime(1999, 8, 30),
                DvhEmail = "tuan.pham@example.com",
                DvhPhone = "0956789012",
                DvhSalary = 1150,
                DvhStatus = false
            }
        };
        public IActionResult DvhIndex()
        {
            return View(dvhListEmpolyee);
        }
        public IActionResult DvhCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DvhCreate(DvhEmpolyee emp)
        {
            if (ModelState.IsValid)
            {
                // Gán ID mới (tự tăng)
                emp.DvhId = DvhEmpolyeeController.dvhListEmpolyee.Max(e => e.DvhId) + 1;

                // Thêm vào danh sách
                DvhEmpolyeeController.dvhListEmpolyee.Add(emp);

                // Chuyển hướng về danh sách nhân viên
                return RedirectToAction("DvhIndex");
            }

            // Nếu model không hợp lệ, quay lại view tạo
            return View(emp);
        }

    }
}
