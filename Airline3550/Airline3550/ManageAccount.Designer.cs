namespace Airline3550
{
	partial class ManageAccount
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
			label1 = new Label();
			panel2 = new Panel();
			label2 = new Label();
			panel3 = new Panel();
			label3 = new Label();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(992, 99);
			panel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.Dock = DockStyle.Fill;
			label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(0, 0);
			label1.Name = "label1";
			label1.Size = new Size(992, 99);
			label1.TabIndex = 0;
			label1.Text = "Manage Account Details";
			label1.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			panel2.Controls.Add(label2);
			panel2.Dock = DockStyle.Left;
			panel2.Location = new Point(0, 99);
			panel2.Name = "panel2";
			panel2.Size = new Size(493, 492);
			panel2.TabIndex = 1;
			// 
			// label2
			// 
			label2.Dock = DockStyle.Top;
			label2.Location = new Point(0, 0);
			label2.Name = "label2";
			label2.Size = new Size(493, 20);
			label2.TabIndex = 0;
			label2.Text = "Personal Info";
			label2.TextAlign = ContentAlignment.TopCenter;
			// 
			// panel3
			// 
			panel3.Controls.Add(label3);
			panel3.Dock = DockStyle.Right;
			panel3.Location = new Point(499, 99);
			panel3.Name = "panel3";
			panel3.Size = new Size(493, 492);
			panel3.TabIndex = 2;
			// 
			// label3
			// 
			label3.Dock = DockStyle.Top;
			label3.Location = new Point(0, 0);
			label3.Name = "label3";
			label3.Size = new Size(493, 20);
			label3.TabIndex = 1;
			label3.Text = "Security And Payment";
			label3.TextAlign = ContentAlignment.TopCenter;
			// 
			// ManageAccount
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			ClientSize = new Size(992, 591);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "ManageAccount";
			Text = "ManageAccount";
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel3.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Panel panel2;
		private Panel panel3;
		private Label label2;
		private Label label3;
	}
}