using Calculator;
using Calculator.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetCalculator.Controllers
{
	public class HomeController : Controller
	{
		private static FormulaExecutor calculator = new FormulaExecutor();
		public ActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public ActionResult AddData(string formulaOperator, string formulaOperand)
		{
			calculator.AddItem(FormulaItemType.Operand, formulaOperand);
			calculator.AddItem(FormulaItemType.Operator, formulaOperator);
			calculator.LastOperator = (OperatorType)Enum.Parse(typeof(OperatorType), formulaOperator);
			return new EmptyResult();
		}

		[HttpPost]
		public ActionResult Calculate()
		{
			return Content($"Результат = {calculator.Calculate()}");
		}
	}
}