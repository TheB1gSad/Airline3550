namespace Airline3550
{
	partial class userIDPopup
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
			button1 = new Button();
			userIdOut = new Label();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Dock = DockStyle.Top;
			label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ImageAlign = ContentAlignment.TopCenter;
			label1.Location = new Point(0, 0);
			label1.Name = "label1";
			label1.Size = new Size(535, 96);
			label1.TabIndex = 0;
			label1.Text = "Your User ID:";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			panel1.Controls.Add(button1);
			panel1.Controls.Add(userIdOut);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 96);
			panel1.Name = "panel1";
			panel1.Size = new Size(535, 219);
			panel1.TabIndex = 1;
			panel1.Paint += panel1_Paint;
			// 
			// button1
			// 
			button1.Location = new Point(90, 131);
			button1.Name = "button1";
			button1.Size = new Size(355, 29);
			button1.TabIndex = 1;
			button1.Text = "Press To Continue To Login Screen";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// userIdOut
			// 
			userIdOut.Dock = DockStyle.Top;
			userIdOut.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			userIdOut.Location = new Point(0, 0);
			userIdOut.Name = "userIdOut";
			userIdOut.Size = new Size(535, 69);
			userIdOut.TabIndex = 0;
			userIdOut.TextAlign = ContentAlignment.MiddleCenter;
			userIdOut.Click += userIdOut_Click;
			// 
			// userIDPopup
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(535, 315);
			ControlBox = false;
			Controls.Add(panel1);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "userIDPopup";
			Text = "Airline 3550";
			Load += Form1_Load;
			panel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private Panel panel1;
		private Label userIdOut;
		private Button button1;
	}
}