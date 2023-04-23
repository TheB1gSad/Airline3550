using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline3550
{
	public partial class BookFlightMenu : Form
	{
		public BookFlightMenu()
		{
			InitializeComponent();
			tableLayoutPanel1.ColumnStyles[3].Width = 0;
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				tableLayoutPanel1.ColumnStyles[3].Width = 25;
				tableLayoutPanel4.Visible = true;
			}
			else
			{
				tableLayoutPanel1.ColumnStyles[3].Width = 0;
				tableLayoutPanel4.Visible = false;
			}
		}
	}
}
