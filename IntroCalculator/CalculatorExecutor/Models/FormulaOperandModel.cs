using Calculator.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
	public class FormulaOperandModel : FormulaItemModel
	{
		private readonly uint _value;
		public FormulaOperandModel(uint value) : base(FormulaItemType.Operand)
		{
			_value = value;
		}

		public override object GetValue() => _value;
	}
}
