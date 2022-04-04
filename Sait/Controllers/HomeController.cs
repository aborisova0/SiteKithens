using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sait.Models;

namespace Sait.Controllers
{
    public class HomeController : Controller
    {
        KitchenContext db;

        public HomeController(KitchenContext context)
        {
            db = context;
        }

        public IActionResult Index(string dropdown_Style, string dropdown_Available) //главная страница
        {
            string selectedStyle = dropdown_Style; //фильтрация по стилю
            string selectedAvailable = dropdown_Available; //фильтрация по наличию

            IQueryable<Kitchen> kitchen = db.Kitchens;

            if (!String.IsNullOrEmpty(selectedStyle) && !selectedStyle.Equals("Все"))
            {
                kitchen = kitchen.Where(p => p.Style == selectedStyle);
            }
            if (!String.IsNullOrEmpty(selectedAvailable) && !selectedAvailable.Equals("Выбрать"))
            {
                kitchen = kitchen.Where(p => p.Available == selectedAvailable);
            }

            ViewBag.Kitchens = kitchen;
            return View();
            
        }

        [HttpGet]
        public IActionResult AddFeedback() //добавление отзыва
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddFeedback(Feedback feedback) //взаимодействие с бд
        {
            db.Feedback.Add(feedback);
            db.SaveChanges();
            return RedirectToAction("SeeFeedbacks");
        }

        public IActionResult About() //страница с советами
        {
            return View();
        }

        public IActionResult SeeFeedbacks() //страница отзывов
        {
            IQueryable<Feedback> feedbacks = db.Feedback;
            ViewBag.Feedbacks = feedbacks;
            return View();
        }

        [HttpGet]
        public ActionResult Product(int? id) //просмотр товара
        {
            IQueryable<Kitchen> kitchens = db.Kitchens;
            ViewBag.Kitchens = kitchens;
            if (id == null)
            {
                return RedirectToAction("Index"); 
            }
            Kitchen kitchen = db.Kitchens.Find(id);
            if (kitchen == null)
            {
                return RedirectToAction("Index");
               
            }
            return View(kitchen);
        }

        [HttpGet]
        public ActionResult ProductInfo(int? id)
        {
            Kitchen kitchen = db.Kitchens.Find(id);

            return View(kitchen);


        }
    }
}
