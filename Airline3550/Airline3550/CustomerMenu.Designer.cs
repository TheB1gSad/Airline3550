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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMenu));
			panel2 = new Panel();
			menuStrip1 = new MenuStrip();
			manageFlightsToolStripMenuItem = new ToolStripMenuItem();
			bookFlightToolStripMenuItem = new ToolStripMenuItem();
			manageAccountToolStripMenuItem = new ToolStripMenuItem();
			logoutToolStripMenuItem = new ToolStripMenuItem();
			panel1 = new Panel();
			menuLabel = new Panel();
			label1 = new Label();
			menuStrip1.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel2
			// 
			panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			panel2.AutoSize = true;
			panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			panel2.BackColor = SystemColors.Control;
			panel2.BorderStyle = BorderStyle.FixedSingle;
			panel2.Location = new Point(0, 647);
			panel2.Name = "panel2";
			panel2.Size = new Size(2, 2);
			panel2.TabIndex = 1;
			panel2.Paint += panel2_Paint;
			// 
			// menuStrip1
			// 
			menuStrip1.BackColor = Color.White;
			menuStrip1.GripStyle = ToolStripGripStyle.Visible;
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { manageFlightsToolStripMenuItem, bookFlightToolStripMenuItem, manageAccountToolStripMenuItem, logoutToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(980, 28);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// manageFlightsToolStripMenuItem
			// 
			manageFlightsToolStripMenuItem.Name = "manageFlightsToolStripMenuItem";
			manageFlightsToolStripMenuItem.Size = new Size(124, 24);
			manageFlightsToolStripMenuItem.Text = "Manage Flights";
			manageFlightsToolStripMenuItem.Click += manageFlightsClick;
			// 
			// bookFlightToolStripMenuItem
			// 
			bookFlightToolStripMenuItem.Name = "bookFlightToolStripMenuItem";
			bookFlightToolStripMenuItem.Size = new Size(98, 24);
			bookFlightToolStripMenuItem.Text = "Book Flight";
			bookFlightToolStripMenuItem.Click += bookFlightClick;
			// 
			// manageAccountToolStripMenuItem
			// 
			manageAccountToolStripMenuItem.Name = "manageAccountToolStripMenuItem";
			manageAccountToolStripMenuItem.Size = new Size(135, 24);
			manageAccountToolStripMenuItem.Text = "Manage Account";
			manageAccountToolStripMenuItem.Click += manageAccountClicked;
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
			panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Controls.Add(menuLabel);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(menuStrip1);
			panel1.Controls.Add(panel2);
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(982, 663);
			panel1.TabIndex = 0;
			panel1.Paint += panel1_Paint;
			// 
			// menuLabel
			// 
			menuLabel.AutoSize = true;
			menuLabel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			menuLabel.BackgroundImage = (Image)resources.GetObject("menuLabel.BackgroundImage");
			menuLabel.BackgroundImageLayout = ImageLayout.Stretch;
			menuLabel.BorderStyle = BorderStyle.FixedSingle;
			menuLabel.Dock = DockStyle.Fill;
			menuLabel.Location = new Point(0, 28);
			menuLabel.MinimumSize = new Size(992, 591);
			menuLabel.Name = "menuLabel";
			menuLabel.Size = new Size(992, 591);
			menuLabel.TabIndex = 3;
			// 
			// label1
			// 
			label1.Dock = DockStyle.Bottom;
			label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(0, 619);
			label1.Name = "label1";
			label1.Size = new Size(980, 42);
			label1.TabIndex = 2;
			label1.Text = "Welcome To Airline 3550 ";
			// 
			// CustomerMenu
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(982, 664);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximumSize = new Size(1512, 1211);
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

		private Panel panel2;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem manageFlightsToolStripMenuItem;
		private ToolStripMenuItem bookFlightToolStripMenuItem;
		private ToolStripMenuItem logoutToolStripMenuItem;
		private Panel panel1;
		private Label label1;
		private ToolStripMenuItem manageAccountToolStripMenuItem;
		private Panel menuLabel;
	}
}