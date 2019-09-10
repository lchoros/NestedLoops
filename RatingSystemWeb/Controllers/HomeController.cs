using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RatingSystemWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DrawRating(int rating)
        {

            var fullStars = rating / 10;
            var emptyStars = (100 - rating) / 10;
            var halfStars = 10 - fullStars - emptyStars;
            var stars = "";
            for (int i = 0; i < fullStars; i++)
            {
                stars += "<img src='/Content/icons/starfull.png' />";
            }
            if(halfStars > 0)
            {
                stars += "<img src='/Content/icons/starhalf.png' />";
            }
            for (int i = 0; i < emptyStars; i++)
            {
                stars += "<img src='/Content/icons/starempty.png' />";
            }
            ViewBag.Rating = rating;
            ViewBag.Stars = stars;
            return View("Index", "", stars);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}