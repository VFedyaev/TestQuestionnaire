using System;
using System.Diagnostics;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Questionnaire.Service.Interfaces;
using Questionnaire.WEB.Models;

namespace Questionnaire.WEB.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IMapper mapper, IAnswerService answerService, UserManager<User> userManager) : base(mapper, answerService, userManager) { }

        public IActionResult Index(string query)
        {
            ViewBag.SearchQuery = (query ?? "");

            return View();
        }

        public JsonResult GetData(int pageNumber, string query, int sort)
        {
            var pageSize = 20;
            var models =  GetData(pageSize, pageNumber, sort, query);

            return Json(new { models.Data, total = models.RecordsTotal, filtered = models.RecordsFiltered });
        }

        [Authorize]
        public IActionResult Answer()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Answer(AnswerViewModel model)
        {
            if (ModelState.IsValid)
            {
                var currentUser = await _userManager.GetUserAsync(HttpContext.User);
                model.Answer.UserId = Guid.Parse(currentUser.Id);

                _answerService.AddAnswer(model.Answer);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [Authorize]
        public IActionResult About(string answerId)
        {
            var answer = _answerService.GetAnswerById(Guid.Parse(answerId));
            var viewModel = new AnswerViewModel
            {
                Answer = answer
            };
            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}