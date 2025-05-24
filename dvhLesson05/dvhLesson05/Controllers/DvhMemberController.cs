using dvhLesson05.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace dvhLesson05.Controllers
{
    public class DvhMemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DvhGetMember()
        {
            var dvhMember = new DvhMember();
            dvhMember.DvhMemberId = Guid.NewGuid().ToString();
            dvhMember.DvhUserName = "Hiếu";
            dvhMember.DvhFullName = "Đinh Văn Hiếu";
            dvhMember.DvhPassWord = "123456789";
            dvhMember.DvhEmail = "hieudinhvan464@gmail.com";

            ViewBag.dvhMember = dvhMember;
            return View();
        }
        public static readonly List<DvhMember> DvhMembers = new List<DvhMember>
        {
                    new DvhMember { DvhMemberId = Guid.NewGuid().ToString(), DvhUserName = "dvhuser1", DvhFullName = "Dinh Van Hieu", DvhPassWord = "pass1", DvhEmail = "dvh1@gmail.com" },
                    new DvhMember { DvhMemberId = Guid.NewGuid().ToString(), DvhUserName = "dvhuser2", DvhFullName = "Nguyen Van A", DvhPassWord = "pass2", DvhEmail = "dvh2@gmail.com" },
                    new DvhMember { DvhMemberId = Guid.NewGuid().ToString(), DvhUserName = "dvhuser3", DvhFullName = "Tran Thi B", DvhPassWord = "pass3", DvhEmail = "dvh3@gmail.com" }
        };
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(DvhMember member)
        {
            if (ModelState.IsValid)
            {
                DvhMembers.Add(member);
                return RedirectToAction("Index");
            }
            return View(member);
        }


    }
}
