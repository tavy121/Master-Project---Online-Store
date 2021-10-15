
using BookStore.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Web.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly IFeedbackService feedbackService;

        public FeedbackController(IFeedbackService feedbackService)
        {
            this.feedbackService = feedbackService;
        }

        [HttpGet]
        [Route("Feedback/{id}")]
        public IActionResult Index(int id)
        {
            var feedback = feedbackService.GetFeedback(id);
            return View(feedback);
        }
    }
}
