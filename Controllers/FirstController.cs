using Microsoft.AspNetCore.Mvc;
using Second.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Second.Controllers
{
    public class FirstController : Controller
    {
        private readonly AppDbContaxt _Db;
        public FirstController(AppDbContaxt Db)
        {
            _Db = Db;
        }
        public IActionResult Index()
        {
            var listifData = _Db.DataModels.ToList();
            return View(listifData);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(DataModel modle)
        {
            _Db.DataModels.Add(modle);
            _Db.SaveChanges();
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = _Db.DataModels.Where(x => x.StdID == id).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(DataModel modle)
        {
            var data = _Db.DataModels.Where(x => x.StdID == modle.StdID).FirstOrDefault();
            if (data != null)
            {
                data.StdID = modle.StdID;
                data.firstname = modle.firstname;
                data.lastname = modle.lastname;
                data.date = modle.date;
                
                data.Email = modle.Email;
                data.Password = modle.Password;
                data.ConfirmPassword = modle.ConfirmPassword;
                data.securityQ = modle.securityQ;
                data.securityA = modle.securityA;
                data.address = modle.address;
                data.city = modle.city;
                data.state = modle.state;
                data.zipcode = modle.zipcode;
                data.phone = modle.phone;
                _Db.SaveChanges();

            }
            return View();
        }
        public ActionResult Details(int id)
        {
            var data = _Db.DataModels.Where(x => x.StdID == id).FirstOrDefault();
            return View(data);
        }
        public ActionResult Delete(int id)
        {
            var ddata = _Db.DataModels.Where(x => x.StdID == id).FirstOrDefault();
            _Db.DataModels.Remove(ddata);
            _Db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
