using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caclucaltor
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
		private void button1_Click(object sender, EventArgs e)
		{
			this.CalcText.Text = this.CalcText.Text + "1";
		}
		private void Button2_Click(object sender, EventArgs e)
		{
			this.CalcText.Text = this.CalcText.Text + "2";
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			this.CalcText.Text = this.CalcText.Text + "3";
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			this.CalcText.Text = this.CalcText.Text + "4";
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			this.CalcText.Text = this.CalcText.Text + "5";
		}

		private void Button6_Click(object sender, EventArgs e)
		{
			this.CalcText.Text = this.CalcText.Text + "6";
		}


		private void Button7_Click(object sender, EventArgs e)
		{
			this.CalcText.Text = this.CalcText.Text + "7";
		}

		private void Button8_Click(object sender, EventArgs e)
		{
			this.CalcText.Text = this.CalcText.Text + "8";
		}

		private void Button9_Click(object sender, EventArgs e)
		{
			this.CalcText.Text = this.CalcText.Text + "9";
		}

		private void Button0_Click(object sender, EventArgs e)
		{
			this.CalcText.Text = this.CalcText.Text + "0";
		}

		private void ButtonClear_Click(object sender, EventArgs e)
		{
			this.CalcText.Clear();
		}

		public bool SymbolCheck()
		{
			return !this.CalcText.Text.EndsWith("+") && !this.CalcText.Text.EndsWith("-") && !this.CalcText.Text.EndsWith("x") && !this.CalcText.Text.EndsWith("÷") && !this.CalcText.Text.EndsWith(".") && !(this.CalcText.Text == "");
		}

		private void ButtonPlus_Click(object sender, EventArgs e)
		{
			if (this.SymbolCheck())
			{
				this.CalcText.Text = this.CalcText.Text + "+";
			}
		}

		private void ButtonMinus_Click(object sender, EventArgs e)
		{
			if (this.SymbolCheck())
			{
				this.CalcText.Text = this.CalcText.Text + "-";
			}
		}

		private void ButtonTimes_Click(object sender, EventArgs e)
		{
			if (this.SymbolCheck())
			{
				this.CalcText.Text = this.CalcText.Text + "x";
			}
		}

		private void ButtonDivide_Click(object sender, EventArgs e)
		{
			if (this.SymbolCheck())
			{
				this.CalcText.Text = this.CalcText.Text + "÷";
			}
		}

		private void ButtonDecimal_Click(object sender, EventArgs e)
		{
			if (this.SymbolCheck())
			{
				this.CalcText.Text = this.CalcText.Text + ".";
			}
		}

		public void Analyse()
		{
			string text = this.CalcText.Text;
			if (text.Contains("+"))
			{
				string[] array = text.Split(new char[]
				{
					'+'
				});
				int value = Convert.ToInt32(array[0]) + Convert.ToInt32(array[1]);
				this.CalcText.Text = Convert.ToString(value);
			}
			if (text.Contains("-"))
			{
				string[] array = text.Split(new char[]
				{
					'-'
				});
				int value = Convert.ToInt32(array[0]) - Convert.ToInt32(array[1]);
				this.CalcText.Text = Convert.ToString(value);
			}
			if (text.Contains("x"))
			{
				string[] array = text.Split(new char[]
				{
					'x'
				});
				double value2 = Convert.ToDouble(array[0]) * Convert.ToDouble(array[1]);
				this.CalcText.Text = Convert.ToString(value2);
			}
			if (text.Contains("÷"))
			{
				string[] array = text.Split(new char[]
				{
					'÷'
				});
				double value2 = Convert.ToDouble(array[0]) / Convert.ToDouble(array[1]);
				this.CalcText.Text = Convert.ToString(value2);
			}
		}

		private void ButtonEqual_Click(object sender, EventArgs e)
		{
			if (this.SymbolCheck())
			{
				this.Analyse();
			}
		}
	}
}
