using Calculator.Models;
using Calculator.Models.Enums;
using System;
using System.Collections.Generic;

namespace Calculator
{
	public class FormulaExecutor
	{
		private decimal? result = null;
		private List<FormulaItemModel> items;

		public OperatorType LastOperator { private get; set; }

		public FormulaExecutor()
		{
			items = new List<FormulaItemModel>();
		}

		public void AddItem(FormulaItemType type, object value)
		{
			if (type == FormulaItemType.Operand)
			{
				items.Add(new FormulaOperandModel(Convert.ToUInt32(value)));
			}
			else
			{
				items.Add(new FormulaOperatorModel((OperatorType)Enum.Parse(typeof(OperatorType), value.ToString())));
			}
		}

		private decimal CalculateByOperator(OperatorType type, uint value)
		{
			switch (type)
			{
				case OperatorType.Sum:
					if (!result.HasValue) result = 0;
					return result.Value + value;
				case OperatorType.Diff:
					if (!result.HasValue) result = value;
					else result = result.Value - value;
					return result.Value;
				case OperatorType.Mult:
					if (!result.HasValue) result = 1;
					return result.Value * value;
				case OperatorType.Div:
					if (!result.HasValue) result = value;
					else result = result.Value / value;
					return result.Value;
				default:
					return result.Value;
			}
		}

		public decimal Calculate()
		{
			result = null;
			AddItem(FormulaItemType.Operator, LastOperator);
			//TODO: Add validation and handle exceptions
			if (items.Count > 2)
			{
				uint temp = 0;
				foreach (var item in items)
				{
					switch (item.Type)
					{
						case FormulaItemType.Operand:
							temp = Convert.ToUInt32(item.GetValue());
							break;
						case FormulaItemType.Operator:
							result = CalculateByOperator((OperatorType)Enum.Parse(typeof(OperatorType), item.GetValue().ToString()), temp);
							break;
						default:
							throw new Exception("Ошибка в формуле!");
					}
				}
				items.Clear();
			}
			return result ?? 0;
		}
	}
}
