namespace Airline3550
{
	partial class ManageFlights_Customer
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
			label1 = new Label();
			panel1 = new Panel();
			tabControl1 = new TabControl();
			upComingFlights = new TabPage();
			vScrollBar2 = new VScrollBar();
			previousFlights = new TabPage();
			vScrollBar1 = new VScrollBar();
			panel2 = new Panel();
			sideMenu = new Label();
			panel1.SuspendLayout();
			tabControl1.SuspendLayout();
			upComingFlights.SuspendLayout();
			previousFlights.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.BorderStyle = BorderStyle.FixedSingle;
			label1.Dock = DockStyle.Top;
			label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(0, 0);
			label1.Name = "label1";
			label1.Padding = new Padding(0, 10, 0, 0);
			label1.Size = new Size(992, 100);
			label1.TabIndex = 1;
			label1.Text = "Manage Flights";
			label1.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			panel1.Controls.Add(tabControl1);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 100);
			panel1.Name = "panel1";
			panel1.Size = new Size(564, 491);
			panel1.TabIndex = 2;
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(upComingFlights);
			tabControl1.Controls.Add(previousFlights);
			tabControl1.Dock = DockStyle.Fill;
			tabControl1.Location = new Point(0, 0);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(564, 491);
			tabControl1.TabIndex = 0;
			// 
			// upComingFlights
			// 
			upComingFlights.Controls.Add(vScrollBar2);
			upComingFlights.Location = new Point(4, 29);
			upComingFlights.Name = "upComingFlights";
			upComingFlights.Padding = new Padding(3);
			upComingFlights.Size = new Size(556, 458);
			upComingFlights.TabIndex = 0;
			upComingFlights.Text = "Upcoming Flights";
			upComingFlights.UseVisualStyleBackColor = true;
			upComingFlights.Click += tabPage1_Click;
			// 
			// vScrollBar2
			// 
			vScrollBar2.Dock = DockStyle.Right;
			vScrollBar2.Location = new Point(527, 3);
			vScrollBar2.Name = "vScrollBar2";
			vScrollBar2.Size = new Size(26, 452);
			vScrollBar2.TabIndex = 0;
			// 
			// previousFlights
			// 
			previousFlights.AutoScroll = true;
			previousFlights.Controls.Add(vScrollBar1);
			previousFlights.Location = new Point(4, 29);
			previousFlights.Name = "previousFlights";
			previousFlights.Padding = new Padding(3);
			previousFlights.Size = new Size(556, 483);
			previousFlights.TabIndex = 1;
			previousFlights.Text = "Previous Flights";
			previousFlights.UseVisualStyleBackColor = true;
			// 
			// vScrollBar1
			// 
			vScrollBar1.Dock = DockStyle.Right;
			vScrollBar1.Location = new Point(527, 3);
			vScrollBar1.Name = "vScrollBar1";
			vScrollBar1.Size = new Size(26, 477);
			vScrollBar1.TabIndex = 0;
			// 
			// panel2
			// 
			panel2.Controls.Add(sideMenu);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(564, 100);
			panel2.Name = "panel2";
			panel2.Size = new Size(428, 491);
			panel2.TabIndex = 3;
			// 
			// sideMenu
			// 
			sideMenu.Dock = DockStyle.Fill;
			sideMenu.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			sideMenu.Location = new Point(0, 0);
			sideMenu.Name = "sideMenu";
			sideMenu.Size = new Size(428, 491);
			sideMenu.TabIndex = 0;
			sideMenu.Text = "Click A Flight To View It";
			sideMenu.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// ManageFlights_Customer
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(992, 591);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.None;
			KeyPreview = true;
			Name = "ManageFlights_Customer";
			Text = "ManageFlights_Customer";
			panel1.ResumeLayout(false);
			tabControl1.ResumeLayout(false);
			upComingFlights.ResumeLayout(false);
			previousFlights.ResumeLayout(false);
			panel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private Panel panel1;
		private TabControl tabControl1;
		private TabPage upComingFlights;
		private TabPage previousFlights;
		private Panel panel2;
		private VScrollBar vScrollBar1;
		private Label sideMenu;
		private VScrollBar vScrollBar2;
	}
}