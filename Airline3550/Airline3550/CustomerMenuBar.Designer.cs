namespace Airline3550
{
	partial class CustomerMenuBar
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			menuStrip1 = new MenuStrip();
			viewFlightsToolStripMenuItem = new ToolStripMenuItem();
			bookFlightsToolStripMenuItem = new ToolStripMenuItem();
			manageAccountToolStripMenuItem = new ToolStripMenuItem();
			logoutToolStripMenuItem = new ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { viewFlightsToolStripMenuItem, bookFlightsToolStripMenuItem, manageAccountToolStripMenuItem, logoutToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(919, 28);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			menuStrip1.ItemClicked += menuStrip1_ItemClicked;
			// 
			// viewFlightsToolStripMenuItem
			// 
			viewFlightsToolStripMenuItem.Name = "viewFlightsToolStripMenuItem";
			viewFlightsToolStripMenuItem.Size = new Size(124, 24);
			viewFlightsToolStripMenuItem.Text = "Manage Flights";
			viewFlightsToolStripMenuItem.Click += viewFlightsToolStripMenuItem_Click;
			// 
			// bookFlightsToolStripMenuItem
			// 
			bookFlightsToolStripMenuItem.Name = "bookFlightsToolStripMenuItem";
			bookFlightsToolStripMenuItem.Size = new Size(104, 24);
			bookFlightsToolStripMenuItem.Text = "Book Flights";
			bookFlightsToolStripMenuItem.Click += bookFlightsToolStripMenuItem_Click;
			// 
			// manageAccountToolStripMenuItem
			// 
			manageAccountToolStripMenuItem.Name = "manageAccountToolStripMenuItem";
			manageAccountToolStripMenuItem.Size = new Size(135, 24);
			manageAccountToolStripMenuItem.Text = "Manage Account";
			manageAccountToolStripMenuItem.Click += manageAccountToolStripMenuItem_Click;
			// 
			// logoutToolStripMenuItem
			// 
			logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
			logoutToolStripMenuItem.Size = new Size(70, 24);
			logoutToolStripMenuItem.Text = "Logout";
			logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
			// 
			// CustomerMenus
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			BorderStyle = BorderStyle.FixedSingle;
			CausesValidation = false;
			Controls.Add(menuStrip1);
			Name = "CustomerMenus";
			Size = new Size(919, 30);
			Load += UserControl1_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private MenuStrip menuStrip1;
		private ToolStripMenuItem viewFlightsToolStripMenuItem;
		private ToolStripMenuItem bookFlightsToolStripMenuItem;
		private ToolStripMenuItem manageAccountToolStripMenuItem;
		private ToolStripMenuItem logoutToolStripMenuItem;
	}
}
