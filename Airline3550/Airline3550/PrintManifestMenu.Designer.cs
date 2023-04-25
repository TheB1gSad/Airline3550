namespace Airline3550
{
	partial class PrintManifestMenu
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
			tableLayoutPanel3 = new TableLayoutPanel();
			seatNumberText = new Label();
			passengerNameText = new Label();
			userIDText = new Label();
			tableLayoutPanel2 = new TableLayoutPanel();
			ErrorMessage = new Label();
			label5 = new Label();
			flightIDInput = new TextBox();
			searchButton = new Button();
			label1 = new Label();
			tableLayoutPanel1 = new TableLayoutPanel();
			label3 = new Label();
			label2 = new Label();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(panel2);
			panel1.Controls.Add(tableLayoutPanel2);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(974, 544);
			panel1.TabIndex = 0;
			// 
			// panel2
			// 
			panel2.AutoScroll = true;
			panel2.Controls.Add(tableLayoutPanel3);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(0, 170);
			panel2.Name = "panel2";
			panel2.Size = new Size(974, 374);
			panel2.TabIndex = 3;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.AutoScroll = true;
			tableLayoutPanel3.AutoSize = true;
			tableLayoutPanel3.ColumnCount = 3;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.34228F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.65772F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 337F));
			tableLayoutPanel3.Controls.Add(seatNumberText, 0, 0);
			tableLayoutPanel3.Controls.Add(passengerNameText, 1, 0);
			tableLayoutPanel3.Controls.Add(userIDText, 2, 0);
			tableLayoutPanel3.Dock = DockStyle.Fill;
			tableLayoutPanel3.Location = new Point(0, 0);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 1;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Size = new Size(974, 374);
			tableLayoutPanel3.TabIndex = 0;
			// 
			// seatNumberText
			// 
			seatNumberText.Dock = DockStyle.Fill;
			seatNumberText.Location = new Point(3, 0);
			seatNumberText.Name = "seatNumberText";
			seatNumberText.Size = new Size(257, 374);
			seatNumberText.TabIndex = 0;
			seatNumberText.Text = "Seat Number";
			// 
			// passengerNameText
			// 
			passengerNameText.Dock = DockStyle.Fill;
			passengerNameText.Location = new Point(266, 0);
			passengerNameText.Name = "passengerNameText";
			passengerNameText.Size = new Size(367, 374);
			passengerNameText.TabIndex = 1;
			passengerNameText.Text = "Passenger Name";
			// 
			// userIDText
			// 
			userIDText.Dock = DockStyle.Fill;
			userIDText.Location = new Point(639, 0);
			userIDText.Name = "userIDText";
			userIDText.Size = new Size(332, 374);
			userIDText.TabIndex = 2;
			userIDText.Text = "Passenger UID";
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.8899078F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.3302746F));
			tableLayoutPanel2.Controls.Add(ErrorMessage, 1, 0);
			tableLayoutPanel2.Controls.Add(label5, 0, 0);
			tableLayoutPanel2.Controls.Add(flightIDInput, 0, 1);
			tableLayoutPanel2.Controls.Add(searchButton, 1, 1);
			tableLayoutPanel2.Dock = DockStyle.Top;
			tableLayoutPanel2.Location = new Point(0, 101);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 2;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 46.07843F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 53.92157F));
			tableLayoutPanel2.Size = new Size(974, 69);
			tableLayoutPanel2.TabIndex = 2;
			// 
			// ErrorMessage
			// 
			ErrorMessage.Dock = DockStyle.Fill;
			ErrorMessage.ForeColor = Color.Red;
			ErrorMessage.Location = new Point(447, 0);
			ErrorMessage.Name = "ErrorMessage";
			ErrorMessage.Size = new Size(524, 31);
			ErrorMessage.TabIndex = 1;
			ErrorMessage.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Dock = DockStyle.Fill;
			label5.Location = new Point(3, 0);
			label5.Name = "label5";
			label5.Size = new Size(438, 31);
			label5.TabIndex = 0;
			label5.Text = "Flight ID";
			label5.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// flightIDInput
			// 
			flightIDInput.Dock = DockStyle.Fill;
			flightIDInput.Location = new Point(3, 34);
			flightIDInput.Name = "flightIDInput";
			flightIDInput.Size = new Size(438, 27);
			flightIDInput.TabIndex = 2;
			// 
			// searchButton
			// 
			searchButton.Dock = DockStyle.Fill;
			searchButton.Location = new Point(447, 34);
			searchButton.Name = "searchButton";
			searchButton.Size = new Size(524, 32);
			searchButton.TabIndex = 3;
			searchButton.Text = "Print Manifest";
			searchButton.UseVisualStyleBackColor = true;
			searchButton.Click += searchButton_Click;
			// 
			// label1
			// 
			label1.BorderStyle = BorderStyle.FixedSingle;
			label1.Dock = DockStyle.Top;
			label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(0, 0);
			label1.Name = "label1";
			label1.Size = new Size(974, 101);
			label1.TabIndex = 0;
			label1.Text = "Print Flight Manifest";
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
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.Size = new Size(200, 100);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Dock = DockStyle.Top;
			label3.Location = new Point(16, 0);
			label3.Name = "label3";
			label3.Size = new Size(10, 120);
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
			// PrintManifestMenu
			// 
			AcceptButton = searchButton;
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(974, 544);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "PrintManifestMenu";
			Text = "PrintManifestMenu";
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private TableLayoutPanel tableLayoutPanel1;
		private Label label3;
		private Label label2;
		private Panel panel2;
		private TableLayoutPanel tableLayoutPanel2;
		private Label label5;
		private TextBox flightIDInput;
		private Button searchButton;
		private Label ErrorMessage;
		private TableLayoutPanel tableLayoutPanel3;
		private Label seatNumberText;
		private Label passengerNameText;
		private Label userIDText;
	}
}