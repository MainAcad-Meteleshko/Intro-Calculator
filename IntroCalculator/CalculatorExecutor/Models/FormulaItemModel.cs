using Calculator.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
	public abstract class FormulaItemModel
	{
		public FormulaItemModel(FormulaItemType type) {
			Type = type;
		}

		public FormulaItemType Type { get; }

		public abstract object GetValue();
	}
}
