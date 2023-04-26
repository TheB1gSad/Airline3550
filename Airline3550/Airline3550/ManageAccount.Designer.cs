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
			personalInfoerrorLabel = new Label();
			phoneField = new TextBox();
			addressField = new TextBox();
			ageField = new TextBox();
			lastNameField = new TextBox();
			firstNameField = new TextBox();
			phoneLabel = new Label();
			addressLabel = new Label();
			ageLabel = new Label();
			lastLabel = new Label();
			firstLabel = new Label();
			label2 = new Label();
			panel3 = new Panel();
			cardNumberField = new TextBox();
			newPassword2 = new TextBox();
			newPassword = new TextBox();
			currPassword = new TextBox();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			label5 = new Label();
			totalPoints = new Label();
			cardLabel = new Label();
			userLabel = new Label();
			securityErrorMessage = new Label();
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
			label1.BorderStyle = BorderStyle.FixedSingle;
			label1.Dock = DockStyle.Fill;
			label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(0, 0);
			label1.Name = "label1";
			label1.Padding = new Padding(0, 11, 0, 0);
			label1.Size = new Size(992, 99);
			label1.TabIndex = 0;
			label1.Text = "Manage Account Details";
			label1.TextAlign = ContentAlignment.MiddleLeft;
			label1.Click += label1_Click;
			// 
			// panel2
			// 
			panel2.BorderStyle = BorderStyle.FixedSingle;
			panel2.Controls.Add(personalInfoerrorLabel);
			panel2.Controls.Add(phoneField);
			panel2.Controls.Add(addressField);
			panel2.Controls.Add(ageField);
			panel2.Controls.Add(lastNameField);
			panel2.Controls.Add(firstNameField);
			panel2.Controls.Add(phoneLabel);
			panel2.Controls.Add(addressLabel);
			panel2.Controls.Add(ageLabel);
			panel2.Controls.Add(lastLabel);
			panel2.Controls.Add(firstLabel);
			panel2.Controls.Add(label2);
			panel2.Dock = DockStyle.Left;
			panel2.Location = new Point(0, 99);
			panel2.Name = "panel2";
			panel2.Size = new Size(493, 492);
			panel2.TabIndex = 1;
			// 
			// personalInfoerrorLabel
			// 
			personalInfoerrorLabel.Dock = DockStyle.Top;
			personalInfoerrorLabel.ForeColor = Color.Red;
			personalInfoerrorLabel.Location = new Point(0, 36);
			personalInfoerrorLabel.Name = "personalInfoerrorLabel";
			personalInfoerrorLabel.Size = new Size(491, 29);
			personalInfoerrorLabel.TabIndex = 16;
			personalInfoerrorLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// phoneField
			// 
			phoneField.Location = new Point(262, 291);
			phoneField.Name = "phoneField";
			phoneField.Size = new Size(212, 27);
			phoneField.TabIndex = 5;
			// 
			// addressField
			// 
			addressField.Location = new Point(262, 239);
			addressField.Name = "addressField";
			addressField.Size = new Size(212, 27);
			addressField.TabIndex = 4;
			// 
			// ageField
			// 
			ageField.Location = new Point(262, 187);
			ageField.Name = "ageField";
			ageField.Size = new Size(212, 27);
			ageField.TabIndex = 3;
			// 
			// lastNameField
			// 
			lastNameField.Location = new Point(262, 135);
			lastNameField.Name = "lastNameField";
			lastNameField.Size = new Size(212, 27);
			lastNameField.TabIndex = 2;
			// 
			// firstNameField
			// 
			firstNameField.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			firstNameField.Location = new Point(262, 82);
			firstNameField.Name = "firstNameField";
			firstNameField.Size = new Size(212, 27);
			firstNameField.TabIndex = 1;
			// 
			// phoneLabel
			// 
			phoneLabel.AutoSize = true;
			phoneLabel.Location = new Point(1, 291);
			phoneLabel.Name = "phoneLabel";
			phoneLabel.Padding = new Padding(5, 0, 0, 0);
			phoneLabel.Size = new Size(120, 20);
			phoneLabel.TabIndex = 5;
			phoneLabel.Text = "Phone Number: ";
			// 
			// addressLabel
			// 
			addressLabel.AutoSize = true;
			addressLabel.Location = new Point(1, 239);
			addressLabel.Name = "addressLabel";
			addressLabel.Padding = new Padding(5, 0, 0, 0);
			addressLabel.Size = new Size(74, 20);
			addressLabel.TabIndex = 4;
			addressLabel.Text = "Address: ";
			// 
			// ageLabel
			// 
			ageLabel.AutoSize = true;
			ageLabel.Location = new Point(1, 187);
			ageLabel.Name = "ageLabel";
			ageLabel.Padding = new Padding(5, 0, 0, 0);
			ageLabel.Size = new Size(48, 20);
			ageLabel.TabIndex = 3;
			ageLabel.Text = "Age: ";
			// 
			// lastLabel
			// 
			lastLabel.AutoSize = true;
			lastLabel.Location = new Point(1, 135);
			lastLabel.Name = "lastLabel";
			lastLabel.Padding = new Padding(5, 0, 0, 0);
			lastLabel.Size = new Size(91, 20);
			lastLabel.TabIndex = 2;
			lastLabel.Text = "Last Name: ";
			// 
			// firstLabel
			// 
			firstLabel.AutoSize = true;
			firstLabel.Location = new Point(0, 83);
			firstLabel.Name = "firstLabel";
			firstLabel.Padding = new Padding(5, 0, 0, 0);
			firstLabel.Size = new Size(92, 20);
			firstLabel.TabIndex = 1;
			firstLabel.Text = "First Name: ";
			// 
			// label2
			// 
			label2.Dock = DockStyle.Top;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(0, 0);
			label2.Name = "label2";
			label2.Size = new Size(491, 36);
			label2.TabIndex = 0;
			label2.Text = "Personal Info";
			label2.TextAlign = ContentAlignment.TopCenter;
			// 
			// panel3
			// 
			panel3.BorderStyle = BorderStyle.FixedSingle;
			panel3.Controls.Add(cardNumberField);
			panel3.Controls.Add(newPassword2);
			panel3.Controls.Add(newPassword);
			panel3.Controls.Add(currPassword);
			panel3.Controls.Add(label6);
			panel3.Controls.Add(label7);
			panel3.Controls.Add(label8);
			panel3.Controls.Add(label5);
			panel3.Controls.Add(totalPoints);
			panel3.Controls.Add(cardLabel);
			panel3.Controls.Add(userLabel);
			panel3.Controls.Add(securityErrorMessage);
			panel3.Controls.Add(label3);
			panel3.Dock = DockStyle.Fill;
			panel3.Location = new Point(493, 99);
			panel3.Name = "panel3";
			panel3.Size = new Size(499, 492);
			panel3.TabIndex = 2;
			// 
			// cardNumberField
			// 
			cardNumberField.Location = new Point(209, 135);
			cardNumberField.Name = "cardNumberField";
			cardNumberField.Size = new Size(257, 27);
			cardNumberField.TabIndex = 6;
			// 
			// newPassword2
			// 
			newPassword2.Location = new Point(207, 371);
			newPassword2.Name = "newPassword2";
			newPassword2.Size = new Size(258, 27);
			newPassword2.TabIndex = 9;
			newPassword2.UseSystemPasswordChar = true;
			// 
			// newPassword
			// 
			newPassword.Location = new Point(208, 315);
			newPassword.Name = "newPassword";
			newPassword.Size = new Size(257, 27);
			newPassword.TabIndex = 8;
			newPassword.UseSystemPasswordChar = true;
			// 
			// currPassword
			// 
			currPassword.Location = new Point(209, 260);
			currPassword.Name = "currPassword";
			currPassword.Size = new Size(257, 27);
			currPassword.TabIndex = 7;
			currPassword.UseSystemPasswordChar = true;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(3, 377);
			label6.Name = "label6";
			label6.Size = new Size(162, 20);
			label6.TabIndex = 36;
			label6.Text = "Re-Type New Password";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(3, 323);
			label7.Name = "label7";
			label7.Size = new Size(104, 20);
			label7.TabIndex = 35;
			label7.Text = "New Password";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(3, 267);
			label8.Name = "label8";
			label8.Size = new Size(122, 20);
			label8.TabIndex = 34;
			label8.Text = "Current Password";
			// 
			// label5
			// 
			label5.Dock = DockStyle.Top;
			label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(0, 199);
			label5.Name = "label5";
			label5.Size = new Size(497, 31);
			label5.TabIndex = 29;
			label5.Text = "Change Password";
			label5.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// totalPoints
			// 
			totalPoints.Dock = DockStyle.Top;
			totalPoints.Location = new Point(0, 152);
			totalPoints.Name = "totalPoints";
			totalPoints.Padding = new Padding(0, 20, 0, 10);
			totalPoints.Size = new Size(497, 47);
			totalPoints.TabIndex = 28;
			totalPoints.Text = "Total Points: ";
			// 
			// cardLabel
			// 
			cardLabel.AutoSize = true;
			cardLabel.Dock = DockStyle.Top;
			cardLabel.Location = new Point(0, 105);
			cardLabel.Name = "cardLabel";
			cardLabel.Padding = new Padding(0, 20, 0, 7);
			cardLabel.Size = new Size(105, 47);
			cardLabel.TabIndex = 27;
			cardLabel.Text = "Card Number: ";
			// 
			// userLabel
			// 
			userLabel.AutoSize = true;
			userLabel.Dock = DockStyle.Top;
			userLabel.Location = new Point(0, 65);
			userLabel.Name = "userLabel";
			userLabel.Padding = new Padding(0, 20, 0, 0);
			userLabel.Size = new Size(64, 40);
			userLabel.TabIndex = 26;
			userLabel.Text = "User ID: ";
			// 
			// securityErrorMessage
			// 
			securityErrorMessage.BackColor = SystemColors.Control;
			securityErrorMessage.Dock = DockStyle.Top;
			securityErrorMessage.ForeColor = Color.Red;
			securityErrorMessage.Location = new Point(0, 36);
			securityErrorMessage.Name = "securityErrorMessage";
			securityErrorMessage.Size = new Size(497, 29);
			securityErrorMessage.TabIndex = 1;
			securityErrorMessage.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			label3.Dock = DockStyle.Top;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(0, 0);
			label3.Name = "label3";
			label3.Size = new Size(497, 36);
			label3.TabIndex = 0;
			label3.Text = "Security And Payment";
			label3.TextAlign = ContentAlignment.TopCenter;
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
			KeyPreview = true;
			Name = "ManageAccount";
			Text = "ManageAccount";
			VisibleChanged += formLoaded;
			KeyDown += keyPressed;
			Resize += formResized;
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Panel panel2;
		private Label label2;
		private Panel panel3;
		private Label label3;
		private Label phoneLabel;
		private Label addressLabel;
		private Label ageLabel;
		private Label lastLabel;
		private Label firstLabel;
		private TextBox phoneField;
		private TextBox addressField;
		private TextBox ageField;
		private TextBox lastNameField;
		private TextBox firstNameField;
		private Label personalInfoerrorLabel;
		private Label securityErrorMessage;
		private Label cardLabel;
		private Label userLabel;
		private TextBox newPassword2;
		private TextBox newPassword;
		private TextBox currPassword;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label5;
		private Label totalPoints;
		private TextBox cardNumberField;
	}
}