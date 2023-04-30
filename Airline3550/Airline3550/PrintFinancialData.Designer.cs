namespace Airline3550
{
	partial class PrintFinancialData
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
			tableLayoutPanel1 = new TableLayoutPanel();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			button1 = new Button();
			panel1 = new Panel();
			totalRevenue = new Label();
			label4 = new Label();
			panel2 = new Panel();
			tableLayoutPanel2 = new TableLayoutPanel();
			flightID = new Label();
			totalRevenueTable = new Label();
			percentageFullTable = new Label();
			panel3 = new Panel();
			label6 = new Label();
			label7 = new Label();
			tableLayoutPanel1.SuspendLayout();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 5;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.8899078F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.3302746F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.8990822F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.8807335F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 122F));
			tableLayoutPanel1.Controls.Add(label3, 1, 0);
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.Size = new Size(200, 100);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Dock = DockStyle.Top;
			label3.Location = new Point(16, 0);
			label3.Name = "label3";
			label3.Size = new Size(10, 100);
			label3.TabIndex = 1;
			label3.Text = "Arrival";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Dock = DockStyle.Fill;
			label2.Location = new Point(3, 0);
			label2.Name = "label2";
			label2.Size = new Size(7, 160);
			label2.TabIndex = 0;
			label2.Text = "Departure";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			label1.Dock = DockStyle.Top;
			label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(0, 0);
			label1.Name = "label1";
			label1.Size = new Size(974, 100);
			label1.TabIndex = 0;
			label1.Text = "Print Financial Data";
			label1.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// button1
			// 
			button1.Dock = DockStyle.Top;
			button1.Location = new Point(0, 100);
			button1.Name = "button1";
			button1.Size = new Size(974, 29);
			button1.TabIndex = 1;
			button1.Text = "Click To Print Data";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// panel1
			// 
			panel1.Controls.Add(totalRevenue);
			panel1.Controls.Add(label4);
			panel1.Dock = DockStyle.Bottom;
			panel1.Location = new Point(0, 429);
			panel1.Name = "panel1";
			panel1.Size = new Size(974, 115);
			panel1.TabIndex = 2;
			// 
			// totalRevenue
			// 
			totalRevenue.Dock = DockStyle.Fill;
			totalRevenue.Location = new Point(0, 20);
			totalRevenue.Name = "totalRevenue";
			totalRevenue.Size = new Size(974, 95);
			totalRevenue.TabIndex = 1;
			totalRevenue.Text = "Total Revenue:";
			totalRevenue.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			label4.BorderStyle = BorderStyle.FixedSingle;
			label4.Dock = DockStyle.Top;
			label4.Location = new Point(0, 0);
			label4.Name = "label4";
			label4.Size = new Size(974, 20);
			label4.TabIndex = 0;
			label4.Text = "Revenue Summary:";
			// 
			// panel2
			// 
			panel2.AutoScroll = true;
			panel2.AutoSize = true;
			panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			panel2.Controls.Add(tableLayoutPanel2);
			panel2.Controls.Add(panel3);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(0, 129);
			panel2.Name = "panel2";
			panel2.Size = new Size(974, 300);
			panel2.TabIndex = 3;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.AutoScroll = true;
			tableLayoutPanel2.AutoSize = true;
			tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			tableLayoutPanel2.ColumnCount = 3;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.91916F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.08084F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 332F));
			tableLayoutPanel2.Controls.Add(flightID, 0, 0);
			tableLayoutPanel2.Controls.Add(totalRevenueTable, 1, 0);
			tableLayoutPanel2.Controls.Add(percentageFullTable, 2, 0);
			tableLayoutPanel2.Dock = DockStyle.Top;
			tableLayoutPanel2.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
			tableLayoutPanel2.Location = new Point(0, 36);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.Size = new Size(974, 20);
			tableLayoutPanel2.TabIndex = 13;
			// 
			// flightID
			// 
			flightID.AutoSize = true;
			flightID.Dock = DockStyle.Fill;
			flightID.Location = new Point(3, 0);
			flightID.Name = "flightID";
			flightID.Size = new Size(211, 20);
			flightID.TabIndex = 1;
			flightID.Text = "Flight ID";
			// 
			// totalRevenueTable
			// 
			totalRevenueTable.AutoSize = true;
			totalRevenueTable.Dock = DockStyle.Fill;
			totalRevenueTable.Location = new Point(220, 0);
			totalRevenueTable.Name = "totalRevenueTable";
			totalRevenueTable.Size = new Size(418, 20);
			totalRevenueTable.TabIndex = 4;
			totalRevenueTable.Text = "Total Revenue";
			// 
			// percentageFullTable
			// 
			percentageFullTable.AutoSize = true;
			percentageFullTable.Dock = DockStyle.Fill;
			percentageFullTable.Location = new Point(644, 0);
			percentageFullTable.Name = "percentageFullTable";
			percentageFullTable.Size = new Size(327, 20);
			percentageFullTable.TabIndex = 5;
			percentageFullTable.Text = "Percentage Full";
			// 
			// panel3
			// 
			panel3.Dock = DockStyle.Top;
			panel3.Location = new Point(0, 0);
			panel3.Name = "panel3";
			panel3.Size = new Size(974, 36);
			panel3.TabIndex = 12;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(3, 0);
			label6.Name = "label6";
			label6.Size = new Size(1, 20);
			label6.TabIndex = 0;
			label6.Text = "Flight ID";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(340, 0);
			label7.Name = "label7";
			label7.Size = new Size(109, 20);
			label7.TabIndex = 1;
			label7.Text = "Percentage Full";
			// 
			// PrintFinancialData
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(974, 544);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Controls.Add(button1);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "PrintFinancialData";
			Text = "PrintManifestMenu";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private Label label3;
		private Label label2;
		private Label label1;
		private Button button1;
		private Panel panel1;
		private Label totalRevenue;
		private Label label4;
		private Panel panel2;
		private Panel panel3;
		private Label label6;
		private Label label7;
		private TableLayoutPanel tableLayoutPanel2;
		private Label flightID;
		private Label totalRevenueTable;
		private Label percentageFullTable;
	}
}