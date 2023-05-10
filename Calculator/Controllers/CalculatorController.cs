using Microsoft.AspNetCore.Mvc;
using Calculator.Models;

namespace Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        public ActionResult Index()
        {
            var viewModel = new CalculatorViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Index(CalculatorViewModel viewModel)
        {
            switch (viewModel.Operation)
            {
                case "+":
                    viewModel.Result = viewModel.Number1 + viewModel.Number2;
                    break;
                case "-":
                    viewModel.Result = viewModel.Number1 - viewModel.Number2;
                    break;
                case "*":
                    viewModel.Result = viewModel.Number1 * viewModel.Number2;
                    break;
                case "/":
                    viewModel.Result = viewModel.Number1 / viewModel.Number2;
                    break;
            }

            return View(viewModel);
        }
    }
}

