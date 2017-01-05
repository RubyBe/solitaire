using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solitaire.Models;

namespace Solitaire.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Deck()
        {
            List<Card> cards = new List<Card>();
            for (int i = 1; i < 53; i++)
            {
                Card newCard = new Card(i);
                cards.Add(newCard);
            }
            return View(cards);
        }

        public IActionResult Stats()
        {
            ViewData["Message"] = "View Game Statistics";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
