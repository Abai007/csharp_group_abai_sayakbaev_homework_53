using homework_51.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace homework_51.Controllers
{
    public class PhonesController : Controller
    {
        private MobileContext _db;
        public List<double> values = new List<double>();
        public PhonesController(MobileContext db)
        {
            _db = db;
        }
        public IActionResult Index1(int id)
        {
            var phone = _db.Phones.FirstOrDefault(e => e.Id == id);
            foreach (var i in Program.Currencies)
            {
                values.Add(phone.Price * i.CurrencyRate);
            }
            ViewBag.Message = values;
            return View(phone);
        }
        public IActionResult Index()
        {
            List<Phone> phones = _db.Phones.ToList();
            return View(phones);
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Phone phone)
        {
            if (phone != null)
            {
                _db.Phones.Add(phone);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
