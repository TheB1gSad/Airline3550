namespace Airline3550
{
	partial class LoadEngineerMenu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadEngineerMenu));
			this.panel2 = new Panel();
			this.menuStrip1 = new MenuStrip();
			this.planRoutesToolStripMenuItem = new ToolStripMenuItem();
			this.cancelFlightsToolStripMenuItem = new ToolStripMenuItem();
			this.manageAccountToolStripMenuItem = new ToolStripMenuItem();
			this.logoutToolStripMenuItem = new ToolStripMenuItem();
			this.panel1 = new Panel();
			this.menuLabel = new Panel();
			this.label1 = new Label();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.panel2.AutoSize = true;
			this.panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.panel2.BackColor = SystemColors.Control;
			this.panel2.BorderStyle = BorderStyle.FixedSingle;
			this.panel2.Location = new Point(0, 647);
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size(2, 2);
			this.panel2.TabIndex = 1;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = Color.White;
			this.menuStrip1.GripStyle = ToolStripGripStyle.Visible;
			this.menuStrip1.ImageScalingSize = new Size(20, 20);
			this.menuStrip1.Items.AddRange(new ToolStripItem[] { this.planRoutesToolStripMenuItem, this.cancelFlightsToolStripMenuItem, this.manageAccountToolStripMenuItem, this.logoutToolStripMenuItem });
			this.menuStrip1.Location = new Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new Size(980, 28);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// planRoutesToolStripMenuItem
			// 
			this.planRoutesToolStripMenuItem.Name = "planRoutesToolStripMenuItem";
			this.planRoutesToolStripMenuItem.Size = new Size(100, 24);
			this.planRoutesToolStripMenuItem.Text = "Plan Routes";
			this.planRoutesToolStripMenuItem.Click += this.planRouteClicked;
			// 
			// cancelFlightsToolStripMenuItem
			// 
			this.cancelFlightsToolStripMenuItem.Name = "cancelFlightsToolStripMenuItem";
			this.cancelFlightsToolStripMenuItem.Size = new Size(114, 24);
			this.cancelFlightsToolStripMenuItem.Text = "Cancel Flights";
			// 
			// manageAccountToolStripMenuItem
			// 
			this.manageAccountToolStripMenuItem.Name = "manageAccountToolStripMenuItem";
			this.manageAccountToolStripMenuItem.Size = new Size(135, 24);
			this.manageAccountToolStripMenuItem.Text = "Manage Account";
			this.manageAccountToolStripMenuItem.Click += this.manageAccountClicked;
			// 
			// logoutToolStripMenuItem
			// 
			this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
			this.logoutToolStripMenuItem.Size = new Size(70, 24);
			this.logoutToolStripMenuItem.Text = "Logout";
			this.logoutToolStripMenuItem.Click += this.logout_Clicked;
			// 
			// panel1
			// 
			this.panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.panel1.BorderStyle = BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.menuLabel);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.menuStrip1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(982, 663);
			this.panel1.TabIndex = 0;
			// 
			// menuLabel
			// 
			this.menuLabel.AutoSize = true;
			this.menuLabel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.menuLabel.BackgroundImage = (Image)resources.GetObject("menuLabel.BackgroundImage");
			this.menuLabel.BackgroundImageLayout = ImageLayout.Stretch;
			this.menuLabel.BorderStyle = BorderStyle.FixedSingle;
			this.menuLabel.Dock = DockStyle.Fill;
			this.menuLabel.Location = new Point(0, 28);
			this.menuLabel.MinimumSize = new Size(992, 591);
			this.menuLabel.Name = "menuLabel";
			this.menuLabel.Size = new Size(992, 591);
			this.menuLabel.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Dock = DockStyle.Bottom;
			this.label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			this.label1.Location = new Point(0, 619);
			this.label1.Name = "label1";
			this.label1.Size = new Size(980, 42);
			this.label1.TabIndex = 2;
			this.label1.Text = "Welcome To Airline 3550 ";
			// 
			// LoadEngineerMenu
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(982, 664);
			Controls.Add(this.panel1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "LoadEngineerMenu";
			Text = "Airline 3550";
			FormClosing += LoadEngineerMenu_FormClosing;
			Load += MainMenu_Load;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel2;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem logoutToolStripMenuItem;
		private Panel panel1;
		private Label label1;
		private ToolStripMenuItem manageAccountToolStripMenuItem;
		private Panel menuLabel;
		private ToolStripMenuItem planRoutesToolStripMenuItem;
		private ToolStripMenuItem cancelFlightsToolStripMenuItem;
	}
}