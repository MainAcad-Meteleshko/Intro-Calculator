using Calculator;
using Calculator.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormCalculator
{
	public partial class Form1 : Form
	{
		private FormulaExecutor calculator;
		public Form1()
		{
			InitializeComponent();
			calculator = new FormulaExecutor();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			value.Text += "4";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			value.Text += "1";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			value.Text += "2";	
		}

		private void button3_Click(object sender, EventArgs e)
		{
			value.Text += "3";
		}

		private void button5_Click(object sender, EventArgs e)
		{
			value.Text += "5";
		}

		private void button6_Click(object sender, EventArgs e)
		{
			value.Text += "6";
		}

		private void button7_Click(object sender, EventArgs e)
		{
			value.Text += "7";
		}

		private void button8_Click(object sender, EventArgs e)
		{
			value.Text += "8";
		}

		private void button9_Click(object sender, EventArgs e)
		{
			value.Text += "9";
		}

		private void button10_Click(object sender, EventArgs e)
		{
			value.Text += "0";
		}

		private void button11_Click(object sender, EventArgs e)
		{
			calculator.AddItem(FormulaItemType.Operand, value.Text);
			calculator.AddItem(FormulaItemType.Operator, OperatorType.Sum);
			calculator.LastOperator = OperatorType.Sum;
			value.Clear();
		}

		private void button12_Click(object sender, EventArgs e)
		{
			calculator.AddItem(FormulaItemType.Operand, value.Text);
			calculator.AddItem(FormulaItemType.Operator, OperatorType.Diff);
			calculator.LastOperator = OperatorType.Diff;
			value.Clear();
		}

		private void button13_Click(object sender, EventArgs e)
		{
			calculator.AddItem(FormulaItemType.Operand, value.Text);
			calculator.AddItem(FormulaItemType.Operator, OperatorType.Div);
			calculator.LastOperator = OperatorType.Div;
			value.Clear();
		}

		private void button14_Click(object sender, EventArgs e)
		{
			calculator.AddItem(FormulaItemType.Operand, value.Text);
			calculator.AddItem(FormulaItemType.Operator, OperatorType.Mult);
			calculator.LastOperator = OperatorType.Mult;
			value.Clear();
		}

		private void button15_Click(object sender, EventArgs e)
		{
			var result = calculator.Calculate();
			this.result.Text = $"Результат = {result}";
			value.Clear();
		}
	}
}
