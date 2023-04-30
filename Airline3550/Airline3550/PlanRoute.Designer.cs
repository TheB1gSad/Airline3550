namespace Airline3550
{
	partial class PlanRoute
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
			panel2 = new Panel();
			button1 = new Button();
			tableLayoutPanel1 = new TableLayoutPanel();
			label5 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label1 = new Label();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(panel2);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(974, 544);
			panel1.TabIndex = 0;
			// 
			// panel2
			// 
			panel2.Controls.Add(button1);
			panel2.Controls.Add(tableLayoutPanel1);
			panel2.Controls.Add(label1);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(0, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(974, 544);
			panel2.TabIndex = 0;
			// 
			// button1
			// 
			button1.Dock = DockStyle.Bottom;
			button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button1.Location = new Point(0, 487);
			button1.Name = "button1";
			button1.Size = new Size(974, 57);
			button1.TabIndex = 2;
			button1.Text = "Confirm Route";
			button1.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 4;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 196F));
			tableLayoutPanel1.Controls.Add(label5, 3, 0);
			tableLayoutPanel1.Controls.Add(label2, 0, 0);
			tableLayoutPanel1.Controls.Add(label3, 1, 0);
			tableLayoutPanel1.Controls.Add(label4, 2, 0);
			tableLayoutPanel1.Dock = DockStyle.Top;
			tableLayoutPanel1.Location = new Point(0, 100);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.Size = new Size(974, 82);
			tableLayoutPanel1.TabIndex = 1;
			// 
			// label5
			// 
			label5.Dock = DockStyle.Fill;
			label5.Location = new Point(781, 0);
			label5.Name = "label5";
			label5.Size = new Size(190, 33);
			label5.TabIndex = 4;
			label5.Text = "Departure Date";
			label5.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.Dock = DockStyle.Fill;
			label2.Location = new Point(3, 0);
			label2.Name = "label2";
			label2.Size = new Size(124, 33);
			label2.TabIndex = 0;
			label2.Text = "Departure City";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			label3.Dock = DockStyle.Fill;
			label3.Location = new Point(133, 0);
			label3.Name = "label3";
			label3.Size = new Size(318, 33);
			label3.TabIndex = 1;
			label3.Text = "Arrival City";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			label4.Dock = DockStyle.Fill;
			label4.Location = new Point(457, 0);
			label4.Name = "label4";
			label4.Size = new Size(318, 33);
			label4.TabIndex = 2;
			label4.Text = "Departure Time";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			label1.BorderStyle = BorderStyle.FixedSingle;
			label1.Dock = DockStyle.Top;
			label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(0, 0);
			label1.Name = "label1";
			label1.Size = new Size(974, 100);
			label1.TabIndex = 0;
			label1.Text = "Plan Route";
			label1.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// PlanRoute
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			ClientSize = new Size(974, 544);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "PlanRoute";
			Text = "PlanRoute";
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private TableLayoutPanel tableLayoutPanel1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label1;
		private Button button1;
		private Label label5;
	}
}