using Calculator.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
	public class FormulaOperatorModel : FormulaItemModel
	{
		private readonly OperatorType _type;
		public FormulaOperatorModel(OperatorType type) : base(FormulaItemType.Operator)
		{
			_type = type;
		}

		public override object GetValue() => _type;
	}
}
