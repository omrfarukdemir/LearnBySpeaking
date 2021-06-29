using LearnBySpeaking.Web.Commands.Exam.Model;
using LearnBySpeaking.Web.Models.ViewModels.Exam;
using LearnBySpeaking.Web.Queries.Exam.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LearnBySpeaking.Web.Controllers
{
    [Authorize]
    public class ExamController : BaseController
    {
        public async Task<IActionResult> Index()
        {
            var result = await Mediator.Value.Send(new GetExamListQuery());

            return View(result);
        }

        public async Task<IActionResult> Create(string url = null)
        {
            var result = await Mediator.Value.Send(new CreateExamQuery() { Url = url });

            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateExamViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", model);
            }

            await Mediator.Value.Send(Mapper.Value.Map<CreateExamCommand>(model));

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var result = await Mediator.Value.Send(new ExamDeleteCommand() { Id = id });

            if (!result.Success)
            {
                TempData["Errors"] = string.Join('\n', result.ErrorMessages);
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Quiz(int id)
        {
            var result = await Mediator.Value.Send(new GetExamQuery() { Id = id });

            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Complete([FromBody] ExamCompleteViewModel model)
        {
            var result = await Mediator.Value.Send(Mapper.Value.Map<CompleteExamQuery>(model));

            return Ok(result);
        }
    }
}