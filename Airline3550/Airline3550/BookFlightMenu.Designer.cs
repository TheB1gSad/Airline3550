namespace Airline3550
{
	partial class BookFlightMenu
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
			tableLayoutPanel1 = new TableLayoutPanel();
			label3 = new Label();
			label2 = new Label();
			departure = new TextBox();
			arrival = new TextBox();
			departureDate = new TextBox();
			arrivalDate = new TextBox();
			label4 = new Label();
			label5 = new Label();
			label11 = new Label();
			checkBox1 = new CheckBox();
			panel1 = new Panel();
			departureTable = new TableLayoutPanel();
			label7 = new Label();
			label6 = new Label();
			label8 = new Label();
			label10 = new Label();
			label9 = new Label();
			label14 = new Label();
			departureTableLabel = new Label();
			panel2 = new Panel();
			returnTable = new TableLayoutPanel();
			label16 = new Label();
			label15 = new Label();
			label17 = new Label();
			label18 = new Label();
			label19 = new Label();
			label20 = new Label();
			returnTableLabel = new Label();
			tableLayoutPanel3 = new TableLayoutPanel();
			label12 = new Label();
			label13 = new Label();
			button1 = new Button();
			errorMessage = new Label();
			tableLayoutPanel1.SuspendLayout();
			panel1.SuspendLayout();
			departureTable.SuspendLayout();
			panel2.SuspendLayout();
			returnTable.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.BorderStyle = BorderStyle.FixedSingle;
			label1.Dock = DockStyle.Top;
			label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(0, 0);
			label1.Name = "label1";
			label1.Size = new Size(992, 58);
			label1.TabIndex = 0;
			label1.Text = "Book Flight";
			label1.TextAlign = ContentAlignment.MiddleLeft;
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
			tableLayoutPanel1.Controls.Add(label2, 0, 0);
			tableLayoutPanel1.Controls.Add(departure, 0, 1);
			tableLayoutPanel1.Controls.Add(arrival, 1, 1);
			tableLayoutPanel1.Controls.Add(departureDate, 2, 1);
			tableLayoutPanel1.Controls.Add(arrivalDate, 3, 1);
			tableLayoutPanel1.Controls.Add(label4, 2, 0);
			tableLayoutPanel1.Controls.Add(label5, 3, 0);
			tableLayoutPanel1.Controls.Add(label11, 4, 0);
			tableLayoutPanel1.Controls.Add(checkBox1, 4, 1);
			tableLayoutPanel1.Dock = DockStyle.Top;
			tableLayoutPanel1.Location = new Point(0, 58);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 46.07843F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 53.92157F));
			tableLayoutPanel1.Size = new Size(992, 69);
			tableLayoutPanel1.TabIndex = 1;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Dock = DockStyle.Top;
			label3.Location = new Point(158, 0);
			label3.Name = "label3";
			label3.Size = new Size(179, 20);
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
			label2.Size = new Size(149, 31);
			label2.TabIndex = 0;
			label2.Text = "Departure";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// departure
			// 
			departure.Dock = DockStyle.Fill;
			departure.Location = new Point(3, 34);
			departure.Name = "departure";
			departure.Size = new Size(149, 27);
			departure.TabIndex = 2;
			// 
			// arrival
			// 
			arrival.Dock = DockStyle.Fill;
			arrival.Location = new Point(158, 34);
			arrival.Name = "arrival";
			arrival.Size = new Size(179, 27);
			arrival.TabIndex = 3;
			// 
			// departureDate
			// 
			departureDate.Dock = DockStyle.Fill;
			departureDate.Location = new Point(343, 34);
			departureDate.Name = "departureDate";
			departureDate.Size = new Size(245, 27);
			departureDate.TabIndex = 4;
			// 
			// arrivalDate
			// 
			arrivalDate.Dock = DockStyle.Fill;
			arrivalDate.Location = new Point(594, 34);
			arrivalDate.Name = "arrivalDate";
			arrivalDate.Size = new Size(271, 27);
			arrivalDate.TabIndex = 5;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Dock = DockStyle.Fill;
			label4.Location = new Point(343, 0);
			label4.Name = "label4";
			label4.Size = new Size(245, 31);
			label4.TabIndex = 6;
			label4.Text = "Departure Date mm/dd/yyyy";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Dock = DockStyle.Fill;
			label5.Location = new Point(594, 0);
			label5.Name = "label5";
			label5.Size = new Size(271, 31);
			label5.TabIndex = 7;
			label5.Text = "Return Date mm/dd/yyyy";
			label5.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Dock = DockStyle.Fill;
			label11.Location = new Point(871, 0);
			label11.Name = "label11";
			label11.Size = new Size(118, 31);
			label11.TabIndex = 8;
			label11.Text = "Round Trip?";
			label11.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.CheckAlign = ContentAlignment.MiddleCenter;
			checkBox1.Dock = DockStyle.Fill;
			checkBox1.Location = new Point(871, 34);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(118, 32);
			checkBox1.TabIndex = 9;
			checkBox1.TextAlign = ContentAlignment.MiddleCenter;
			checkBox1.UseVisualStyleBackColor = true;
			checkBox1.CheckedChanged += checkBox1_CheckedChanged;
			// 
			// panel1
			// 
			panel1.AutoScroll = true;
			panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			panel1.Controls.Add(departureTable);
			panel1.Controls.Add(departureTableLabel);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 127);
			panel1.Name = "panel1";
			panel1.Size = new Size(992, 200);
			panel1.TabIndex = 3;
			// 
			// departureTable
			// 
			departureTable.AutoScroll = true;
			departureTable.AutoSize = true;
			departureTable.ColumnCount = 6;
			departureTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
			departureTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.181818F));
			departureTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.181818F));
			departureTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.181818F));
			departureTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.181818F));
			departureTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.181818F));
			departureTable.Controls.Add(label7, 2, 0);
			departureTable.Controls.Add(label6, 1, 0);
			departureTable.Controls.Add(label8, 3, 0);
			departureTable.Controls.Add(label10, 5, 0);
			departureTable.Controls.Add(label9, 4, 0);
			departureTable.Controls.Add(label14, 0, 0);
			departureTable.Dock = DockStyle.Top;
			departureTable.Location = new Point(0, 35);
			departureTable.Name = "departureTable";
			departureTable.RowCount = 1;
			departureTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			departureTable.Size = new Size(992, 20);
			departureTable.TabIndex = 12;
			departureTable.Visible = false;
			// 
			// label7
			// 
			label7.Dock = DockStyle.Fill;
			label7.Location = new Point(273, 0);
			label7.Name = "label7";
			label7.Size = new Size(174, 20);
			label7.TabIndex = 1;
			label7.Text = "Price";
			label7.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			label6.Dock = DockStyle.Fill;
			label6.Location = new Point(93, 0);
			label6.Name = "label6";
			label6.Size = new Size(174, 20);
			label6.TabIndex = 0;
			label6.Text = "Route";
			label6.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			label8.Dock = DockStyle.Fill;
			label8.Location = new Point(453, 0);
			label8.Name = "label8";
			label8.Size = new Size(174, 20);
			label8.TabIndex = 2;
			label8.Text = "Departure Time";
			label8.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			label10.Dock = DockStyle.Fill;
			label10.Location = new Point(813, 0);
			label10.Name = "label10";
			label10.Size = new Size(176, 20);
			label10.TabIndex = 4;
			label10.Text = "Flight Number";
			label10.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			label9.Dock = DockStyle.Fill;
			label9.Location = new Point(633, 0);
			label9.Name = "label9";
			label9.Size = new Size(174, 20);
			label9.TabIndex = 3;
			label9.Text = "Arrival Time";
			label9.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label14
			// 
			label14.Dock = DockStyle.Fill;
			label14.Location = new Point(3, 0);
			label14.Name = "label14";
			label14.Size = new Size(84, 20);
			label14.TabIndex = 5;
			label14.Text = "Select";
			label14.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// departureTableLabel
			// 
			departureTableLabel.Dock = DockStyle.Top;
			departureTableLabel.ForeColor = SystemColors.ControlText;
			departureTableLabel.Location = new Point(0, 0);
			departureTableLabel.Name = "departureTableLabel";
			departureTableLabel.Size = new Size(992, 35);
			departureTableLabel.TabIndex = 11;
			departureTableLabel.Text = "Departure";
			departureTableLabel.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			panel2.AutoScroll = true;
			panel2.Controls.Add(returnTable);
			panel2.Controls.Add(returnTableLabel);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(0, 327);
			panel2.Name = "panel2";
			panel2.Size = new Size(992, 228);
			panel2.TabIndex = 15;
			// 
			// returnTable
			// 
			returnTable.AutoScroll = true;
			returnTable.AutoSize = true;
			returnTable.ColumnCount = 6;
			returnTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
			returnTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.181818F));
			returnTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.181818F));
			returnTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.181818F));
			returnTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.181818F));
			returnTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.181818F));
			returnTable.Controls.Add(label16, 2, 0);
			returnTable.Controls.Add(label15, 1, 0);
			returnTable.Controls.Add(label17, 3, 0);
			returnTable.Controls.Add(label18, 4, 0);
			returnTable.Controls.Add(label19, 5, 0);
			returnTable.Controls.Add(label20, 0, 0);
			returnTable.Dock = DockStyle.Top;
			returnTable.Location = new Point(0, 45);
			returnTable.Name = "returnTable";
			returnTable.RowCount = 1;
			returnTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			returnTable.Size = new Size(992, 20);
			returnTable.TabIndex = 16;
			returnTable.Visible = false;
			// 
			// label16
			// 
			label16.Dock = DockStyle.Fill;
			label16.Location = new Point(273, 0);
			label16.Name = "label16";
			label16.Size = new Size(174, 20);
			label16.TabIndex = 1;
			label16.Text = "Price";
			label16.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label15
			// 
			label15.Dock = DockStyle.Fill;
			label15.Location = new Point(93, 0);
			label15.Name = "label15";
			label15.Size = new Size(174, 20);
			label15.TabIndex = 0;
			label15.Text = "Route";
			label15.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label17
			// 
			label17.Dock = DockStyle.Fill;
			label17.Location = new Point(453, 0);
			label17.Name = "label17";
			label17.Size = new Size(174, 20);
			label17.TabIndex = 2;
			label17.Text = "Departure Time";
			label17.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label18
			// 
			label18.Dock = DockStyle.Fill;
			label18.Location = new Point(633, 0);
			label18.Name = "label18";
			label18.Size = new Size(174, 20);
			label18.TabIndex = 3;
			label18.Text = "Arrival Time";
			label18.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label19
			// 
			label19.Dock = DockStyle.Fill;
			label19.Location = new Point(813, 0);
			label19.Name = "label19";
			label19.Size = new Size(176, 20);
			label19.TabIndex = 4;
			label19.Text = "Flight Number";
			label19.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label20
			// 
			label20.Dock = DockStyle.Fill;
			label20.Location = new Point(3, 0);
			label20.Name = "label20";
			label20.Size = new Size(84, 20);
			label20.TabIndex = 5;
			label20.Text = "Select";
			label20.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// returnTableLabel
			// 
			returnTableLabel.Dock = DockStyle.Top;
			returnTableLabel.Location = new Point(0, 0);
			returnTableLabel.Name = "returnTableLabel";
			returnTableLabel.Size = new Size(992, 45);
			returnTableLabel.TabIndex = 15;
			returnTableLabel.Text = "Return";
			returnTableLabel.TextAlign = ContentAlignment.MiddleLeft;
			returnTableLabel.Visible = false;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.AutoScroll = true;
			tableLayoutPanel3.ColumnCount = 6;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanel3.Controls.Add(label12, 0, 0);
			tableLayoutPanel3.Location = new Point(0, 0);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 1;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel3.Size = new Size(200, 100);
			tableLayoutPanel3.TabIndex = 0;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Dock = DockStyle.Fill;
			label12.Location = new Point(3, 0);
			label12.Name = "label12";
			label12.Size = new Size(27, 100);
			label12.TabIndex = 0;
			label12.Text = "Route";
			label12.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Dock = DockStyle.Fill;
			label13.Location = new Point(168, 0);
			label13.Name = "label13";
			label13.Size = new Size(159, 591);
			label13.TabIndex = 1;
			label13.Text = "Price";
			label13.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			button1.Dock = DockStyle.Bottom;
			button1.Location = new Point(0, 555);
			button1.Name = "button1";
			button1.Size = new Size(992, 36);
			button1.TabIndex = 6;
			button1.Text = "Confirm Selection";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// errorMessage
			// 
			errorMessage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			errorMessage.AutoSize = true;
			errorMessage.ForeColor = Color.Red;
			errorMessage.Location = new Point(544, 24);
			errorMessage.Name = "errorMessage";
			errorMessage.Size = new Size(0, 20);
			errorMessage.TabIndex = 0;
			errorMessage.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// BookFlightMenu
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			ClientSize = new Size(992, 591);
			Controls.Add(panel2);
			Controls.Add(button1);
			Controls.Add(panel1);
			Controls.Add(errorMessage);
			Controls.Add(tableLayoutPanel1);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.None;
			KeyPreview = true;
			Name = "BookFlightMenu";
			Text = "BookFlightMenu";
			KeyDown += keyDown;
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			departureTable.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			returnTable.ResumeLayout(false);
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel3.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TableLayoutPanel tableLayoutPanel1;
		private Label label2;
		private Label label3;
		private TextBox departure;
		private TextBox arrival;
		private TextBox departureDate;
		private TextBox arrivalDate;
		private Label label4;
		private Label label5;
		private Panel panel1;
		private Label label11;
		private CheckBox checkBox1;
		private TableLayoutPanel tableLayoutPanel3;
		private Label label12;
		private Label label13;
		private Button button1;
		private Label errorMessage;
		private Panel panel2;
		private TableLayoutPanel departureTable;
		private Label label7;
		private Label label6;
		private Label label8;
		private Label label10;
		private Label label9;
		private Label departureTableLabel;
		private Label label14;
		private TableLayoutPanel returnTable;
		private Label label16;
		private Label label15;
		private Label label17;
		private Label label18;
		private Label label19;
		private Label label20;
		private Label returnTableLabel;
	}
}