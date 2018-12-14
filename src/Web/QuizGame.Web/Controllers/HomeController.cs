using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuizApp.Web.Models;
using QuizGame.Services.DataServices.Contracts;
using QuizGame.Services.Models.Home;

namespace QuizApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IQuestionsService questionsService;

        public HomeController(IQuestionsService questionsService)
        {
            this.questionsService = questionsService;
        }

        public IActionResult Index()
        {
            var questions = this.questionsService.GetRandomQuestion(1);

            var viewModel = new IndexViewModel
            {
                Questions = questions,
            };
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
