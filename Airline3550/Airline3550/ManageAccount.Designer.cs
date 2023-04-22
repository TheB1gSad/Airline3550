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
			panel5 = new Panel();
			button1 = new Button();
			cardLabel = new Label();
			userLabel = new Label();
			label3 = new Label();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
			panel5.SuspendLayout();
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
			// phoneField
			// 
			phoneField.Location = new Point(262, 291);
			phoneField.Name = "phoneField";
			phoneField.Size = new Size(212, 27);
			phoneField.TabIndex = 15;
			// 
			// addressField
			// 
			addressField.Location = new Point(262, 241);
			addressField.Name = "addressField";
			addressField.Size = new Size(212, 27);
			addressField.TabIndex = 14;
			// 
			// ageField
			// 
			ageField.Location = new Point(262, 191);
			ageField.Name = "ageField";
			ageField.Size = new Size(212, 27);
			ageField.TabIndex = 13;
			// 
			// lastNameField
			// 
			lastNameField.Location = new Point(262, 141);
			lastNameField.Name = "lastNameField";
			lastNameField.Size = new Size(212, 27);
			lastNameField.TabIndex = 12;
			// 
			// firstNameField
			// 
			firstNameField.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			firstNameField.Location = new Point(262, 83);
			firstNameField.Name = "firstNameField";
			firstNameField.Size = new Size(212, 27);
			firstNameField.TabIndex = 11;
			// 
			// phoneLabel
			// 
			phoneLabel.Anchor = AnchorStyles.Left;
			phoneLabel.AutoSize = true;
			phoneLabel.Location = new Point(1, 294);
			phoneLabel.Name = "phoneLabel";
			phoneLabel.Padding = new Padding(5, 0, 0, 0);
			phoneLabel.Size = new Size(120, 20);
			phoneLabel.TabIndex = 5;
			phoneLabel.Text = "Phone Number: ";
			// 
			// addressLabel
			// 
			addressLabel.Anchor = AnchorStyles.Left;
			addressLabel.AutoSize = true;
			addressLabel.Location = new Point(1, 244);
			addressLabel.Name = "addressLabel";
			addressLabel.Padding = new Padding(5, 0, 0, 0);
			addressLabel.Size = new Size(74, 20);
			addressLabel.TabIndex = 4;
			addressLabel.Text = "Address: ";
			// 
			// ageLabel
			// 
			ageLabel.Anchor = AnchorStyles.Left;
			ageLabel.AutoSize = true;
			ageLabel.Location = new Point(1, 194);
			ageLabel.Name = "ageLabel";
			ageLabel.Padding = new Padding(5, 0, 0, 0);
			ageLabel.Size = new Size(48, 20);
			ageLabel.TabIndex = 3;
			ageLabel.Text = "Age: ";
			// 
			// lastLabel
			// 
			lastLabel.Anchor = AnchorStyles.Left;
			lastLabel.AutoSize = true;
			lastLabel.Location = new Point(1, 144);
			lastLabel.Name = "lastLabel";
			lastLabel.Padding = new Padding(5, 0, 0, 0);
			lastLabel.Size = new Size(91, 20);
			lastLabel.TabIndex = 2;
			lastLabel.Text = "Last Name: ";
			// 
			// firstLabel
			// 
			firstLabel.Anchor = AnchorStyles.Left;
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
			panel3.Controls.Add(panel5);
			panel3.Controls.Add(cardLabel);
			panel3.Controls.Add(userLabel);
			panel3.Controls.Add(label3);
			panel3.Dock = DockStyle.Fill;
			panel3.Location = new Point(493, 99);
			panel3.Name = "panel3";
			panel3.Size = new Size(499, 492);
			panel3.TabIndex = 2;
			// 
			// panel5
			// 
			panel5.Controls.Add(button1);
			panel5.Dock = DockStyle.Fill;
			panel5.Location = new Point(0, 176);
			panel5.Name = "panel5";
			panel5.Padding = new Padding(0, 40, 0, 0);
			panel5.Size = new Size(497, 314);
			panel5.TabIndex = 4;
			// 
			// button1
			// 
			button1.Dock = DockStyle.Top;
			button1.Location = new Point(0, 40);
			button1.Name = "button1";
			button1.Size = new Size(497, 29);
			button1.TabIndex = 0;
			button1.Text = "Click Here To Change Password";
			button1.UseVisualStyleBackColor = true;
			// 
			// cardLabel
			// 
			cardLabel.AutoSize = true;
			cardLabel.Dock = DockStyle.Top;
			cardLabel.Location = new Point(0, 126);
			cardLabel.Name = "cardLabel";
			cardLabel.Padding = new Padding(15, 30, 0, 0);
			cardLabel.Size = new Size(120, 50);
			cardLabel.TabIndex = 3;
			cardLabel.Text = "Card Number: ";
			// 
			// userLabel
			// 
			userLabel.AutoSize = true;
			userLabel.Dock = DockStyle.Top;
			userLabel.Location = new Point(0, 36);
			userLabel.Name = "userLabel";
			userLabel.Padding = new Padding(15, 70, 0, 0);
			userLabel.Size = new Size(79, 90);
			userLabel.TabIndex = 2;
			userLabel.Text = "User ID: ";
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
			Load += formLoaded;
			KeyDown += keyPressed;
			Resize += formResized;
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			panel5.ResumeLayout(false);
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
		private Label cardLabel;
		private Label userLabel;
		private Panel panel5;
		private Button button1;
		private TextBox phoneField;
		private TextBox addressField;
		private TextBox ageField;
		private TextBox lastNameField;
		private TextBox firstNameField;
	}
}