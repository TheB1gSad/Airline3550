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
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
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
			label1.BorderStyle = BorderStyle.FixedSingle;
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
			panel2.BorderStyle = BorderStyle.FixedSingle;
			panel2.Controls.Add(label8);
			panel2.Controls.Add(label7);
			panel2.Controls.Add(label6);
			panel2.Controls.Add(label5);
			panel2.Controls.Add(label4);
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
			label2.Size = new Size(491, 20);
			label2.TabIndex = 0;
			label2.Text = "Personal Info";
			label2.TextAlign = ContentAlignment.TopCenter;
			// 
			// panel3
			// 
			panel3.BorderStyle = BorderStyle.FixedSingle;
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
			label3.Size = new Size(491, 20);
			label3.TabIndex = 0;
			label3.Text = "Security And Payment";
			label3.TextAlign = ContentAlignment.TopCenter;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Dock = DockStyle.Top;
			label4.Location = new Point(0, 20);
			label4.Name = "label4";
			label4.Padding = new Padding(15, 70, 0, 0);
			label4.Size = new Size(95, 90);
			label4.TabIndex = 1;
			label4.Text = "First Name";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Dock = DockStyle.Top;
			label5.Location = new Point(0, 110);
			label5.Name = "label5";
			label5.Padding = new Padding(15, 30, 0, 0);
			label5.Size = new Size(94, 50);
			label5.TabIndex = 2;
			label5.Text = "Last Name";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Dock = DockStyle.Top;
			label6.Location = new Point(0, 160);
			label6.Name = "label6";
			label6.Padding = new Padding(15, 30, 0, 0);
			label6.Size = new Size(51, 50);
			label6.TabIndex = 3;
			label6.Text = "Age";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Dock = DockStyle.Top;
			label7.Location = new Point(0, 210);
			label7.Name = "label7";
			label7.Padding = new Padding(15, 30, 0, 0);
			label7.Size = new Size(77, 50);
			label7.TabIndex = 4;
			label7.Text = "Address";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Dock = DockStyle.Top;
			label8.Location = new Point(0, 260);
			label8.Name = "label8";
			label8.Padding = new Padding(15, 30, 0, 0);
			label8.Size = new Size(123, 50);
			label8.TabIndex = 5;
			label8.Text = "Phone Number";
			// 
			// ManageAccount
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
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
			panel2.PerformLayout();
			panel3.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Panel panel2;
		private Label label2;
		private Panel panel3;
		private Label label3;
		private Label label8;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label4;
	}
}