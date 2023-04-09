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
			panel1 = new Panel();
			customerMenus1 = new CustomerMenuBar();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(customerMenus1);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(982, 453);
			panel1.TabIndex = 0;
			panel1.Paint += panel1_Paint;
			// 
			// customerMenus1
			// 
			customerMenus1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			customerMenus1.BackColor = SystemColors.Menu;
			customerMenus1.BorderStyle = BorderStyle.FixedSingle;
			customerMenus1.CausesValidation = false;
			customerMenus1.Dock = DockStyle.Top;
			customerMenus1.Location = new Point(0, 0);
			customerMenus1.Name = "customerMenus1";
			customerMenus1.Size = new Size(982, 33);
			customerMenus1.TabIndex = 1;
			customerMenus1.Load += customerMenus1_Load;
			// 
			// MainMenu
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(982, 453);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "MainMenu";
			Text = "Airline 3550";
			Load += MainMenu_Load;
			panel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private CustomerMenuBar customerMenus1;
	}
}