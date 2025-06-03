using DvhLess07.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DvhLess07.Controllers
{
    public class DvhEmpolyeeController : Controller
    {
        // mốc data
        private static List<DvhEmpolyee> dvhListEmpolyee = new List<DvhEmpolyee>
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
        // GET: DvhEmpolyeeController
        public ActionResult DvhIndex()
        {
            return View(dvhListEmpolyee);
        }

        // GET: DvhEmpolyeeController/DvhDetails/5
        public ActionResult DvhDetails(int id)
        {
            var dvhEmpolyee = dvhListEmpolyee.FirstOrDefault(x => x.DvhId == id);
            return View(dvhEmpolyee);
        }

        // GET: DvhEmpolyeeController/DvhCreate
        public ActionResult DvhCreate()
        {

            var dvhEmpolyee = new DvhEmpolyee();
            return View(dvhEmpolyee);
        }

        // POST: DvhEmpolyeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DvhCreate(DvhEmpolyee dvhModel)
        {
            try
            {
                //thêm mới nhân viên vào list
                dvhModel.DvhId = dvhListEmpolyee.Max(x => x.DvhId) + 1;
                dvhListEmpolyee.Add(dvhModel);
                return RedirectToAction(nameof(DvhIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: DvhEmpolyeeController/DvhEdit/5
        public ActionResult DvhEdit(int id)
        {
            var dvhEmpolyee = dvhListEmpolyee.FirstOrDefault(x => x.DvhId == id);
            return View(dvhEmpolyee);
        }

        // POST: DvhEmpolyeeController/DvhEdit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DvhEdit(int id, DvhEmpolyee dvhModel)
        {
            try
            {
                for (int i = 0; i < dvhListEmpolyee.Count(); i++)
                {
                    if (dvhListEmpolyee[i].DvhId == id)
                    {
                        dvhListEmpolyee[i] = dvhModel;
                        break;
                    }
                }
                return RedirectToAction(nameof(DvhIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: DvhEmpolyeeController/Delete/5
        public ActionResult DvhDelete(int id)
        {
            var dvhEmpolyee = dvhListEmpolyee.FirstOrDefault(x => x.DvhId == id);
            return View(dvhEmpolyee);
        }

        // POST: DvhEmpolyeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DvhDelete(int id, DvhEmpolyee dvhModel)
        {
            try
            {
                for (int i = 0; i < dvhListEmpolyee.Count(); i++)
                {
                    if (dvhListEmpolyee[i].DvhId == id)
                    {
                        dvhListEmpolyee[i] = dvhModel;
                        break;
                    }
                }
                return RedirectToAction(nameof(DvhIndex));
            }
            catch
            {
                return View();
            }
        }
    }
}
