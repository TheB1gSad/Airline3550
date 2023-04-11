namespace Airline3550
{
	partial class CustomerMenu
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			menuStrip1 = new MenuStrip();
			manageFlightsToolStripMenuItem = new ToolStripMenuItem();
			bookFlightToolStripMenuItem = new ToolStripMenuItem();
			logoutToolStripMenuItem = new ToolStripMenuItem();
			panel1 = new Panel();
			panel2 = new Panel();
			menuStrip1.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.BackColor = Color.LightGray;
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { manageFlightsToolStripMenuItem, bookFlightToolStripMenuItem, logoutToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(982, 28);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			menuStrip1.ItemClicked += menuStrip1_ItemClicked;
			// 
			// manageFlightsToolStripMenuItem
			// 
			manageFlightsToolStripMenuItem.Name = "manageFlightsToolStripMenuItem";
			manageFlightsToolStripMenuItem.Size = new Size(124, 24);
			manageFlightsToolStripMenuItem.Text = "Manage Flights";
			// 
			// bookFlightToolStripMenuItem
			// 
			bookFlightToolStripMenuItem.Name = "bookFlightToolStripMenuItem";
			bookFlightToolStripMenuItem.Size = new Size(98, 24);
			bookFlightToolStripMenuItem.Text = "Book Flight";
			// 
			// logoutToolStripMenuItem
			// 
			logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
			logoutToolStripMenuItem.Size = new Size(70, 24);
			logoutToolStripMenuItem.Text = "Logout";
			logoutToolStripMenuItem.Click += logout_Clicked;
			// 
			// panel1
			// 
			panel1.Controls.Add(panel2);
			panel1.Controls.Add(menuStrip1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(982, 453);
			panel1.TabIndex = 0;
			panel1.Paint += panel1_Paint;
			// 
			// panel2
			// 
			panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			panel2.BackColor = SystemColors.Control;
			panel2.Location = new Point(0, 31);
			panel2.Name = "panel2";
			panel2.Size = new Size(979, 410);
			panel2.TabIndex = 1;
			panel2.Paint += panel2_Paint;
			// 
			// CustomerMenu
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(982, 453);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MainMenuStrip = menuStrip1;
			Name = "CustomerMenu";
			Text = "Airline 3550";
			FormClosing += CustomerMenu_FormClosing;
			Load += MainMenu_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem manageFlightsToolStripMenuItem;
		private ToolStripMenuItem bookFlightToolStripMenuItem;
		private Panel panel1;
		private ToolStripMenuItem logoutToolStripMenuItem;
		private Panel panel2;
	}
}