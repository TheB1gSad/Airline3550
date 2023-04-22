namespace Airline3550
{
	partial class AccountCreation
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
			credentialsErrorMessage = new Label();
			button1 = new Button();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			passwordField = new TextBox();
			firstName = new TextBox();
			label4 = new Label();
			secondPasswordField = new TextBox();
			linkLabel1 = new LinkLabel();
			lastName = new TextBox();
			address = new TextBox();
			age = new TextBox();
			cardNumber = new TextBox();
			phoneNumber = new TextBox();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			SuspendLayout();
			// 
			// credentialsErrorMessage
			// 
			credentialsErrorMessage.ForeColor = Color.Firebrick;
			credentialsErrorMessage.Location = new Point(229, 85);
			credentialsErrorMessage.Name = "credentialsErrorMessage";
			credentialsErrorMessage.Size = new Size(375, 20);
			credentialsErrorMessage.TabIndex = 15;
			credentialsErrorMessage.TextAlign = ContentAlignment.MiddleCenter;
			credentialsErrorMessage.Click += credentialsErrorMessage_Click;
			// 
			// button1
			// 
			button1.BackColor = SystemColors.HighlightText;
			button1.Location = new Point(334, 691);
			button1.Margin = new Padding(3, 4, 3, 4);
			button1.Name = "button1";
			button1.Size = new Size(178, 40);
			button1.TabIndex = 9;
			button1.Text = "Create Account";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// label3
			// 
			label3.Dock = DockStyle.Top;
			label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(0, 0);
			label3.Name = "label3";
			label3.Size = new Size(842, 54);
			label3.TabIndex = 13;
			label3.Text = "Airline 3550";
			label3.TextAlign = ContentAlignment.TopCenter;
			label3.Resize += AccountCreation_Resized;
			// 
			// label2
			// 
			label2.Location = new Point(281, 481);
			label2.Name = "label2";
			label2.Size = new Size(70, 20);
			label2.TabIndex = 11;
			label2.Text = "Password";
			// 
			// label1
			// 
			label1.Location = new Point(281, 113);
			label1.Name = "label1";
			label1.Size = new Size(103, 20);
			label1.TabIndex = 10;
			label1.Text = "First Name";
			// 
			// passwordField
			// 
			passwordField.Location = new Point(281, 505);
			passwordField.Margin = new Padding(3, 4, 3, 4);
			passwordField.Name = "passwordField";
			passwordField.PasswordChar = '*';
			passwordField.Size = new Size(270, 27);
			passwordField.TabIndex = 6;
			// 
			// firstName
			// 
			firstName.Location = new Point(281, 143);
			firstName.Margin = new Padding(3, 4, 3, 4);
			firstName.Name = "firstName";
			firstName.Size = new Size(270, 27);
			firstName.TabIndex = 1;
			// 
			// label4
			// 
			label4.Location = new Point(281, 547);
			label4.Name = "label4";
			label4.Size = new Size(150, 20);
			label4.TabIndex = 17;
			label4.Text = "Re-Type Password";
			label4.Click += label4_Click;
			// 
			// secondPasswordField
			// 
			secondPasswordField.Location = new Point(281, 571);
			secondPasswordField.Margin = new Padding(3, 4, 3, 4);
			secondPasswordField.Name = "secondPasswordField";
			secondPasswordField.PasswordChar = '*';
			secondPasswordField.Size = new Size(270, 27);
			secondPasswordField.TabIndex = 7;
			secondPasswordField.TextChanged += textBox1_TextChanged;
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Location = new Point(292, 764);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(262, 20);
			linkLabel1.TabIndex = 18;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Already Have An Account? Login Here";
			linkLabel1.LinkClicked += linkLabel1_LinkClicked;
			// 
			// lastName
			// 
			lastName.Location = new Point(281, 216);
			lastName.Name = "lastName";
			lastName.Size = new Size(270, 27);
			lastName.TabIndex = 2;
			// 
			// address
			// 
			address.Location = new Point(281, 282);
			address.Name = "address";
			address.Size = new Size(270, 27);
			address.TabIndex = 3;
			// 
			// age
			// 
			age.Location = new Point(281, 353);
			age.Name = "age";
			age.Size = new Size(270, 27);
			age.TabIndex = 4;
			// 
			// cardNumber
			// 
			cardNumber.Location = new Point(281, 645);
			cardNumber.Name = "cardNumber";
			cardNumber.Size = new Size(270, 27);
			cardNumber.TabIndex = 8;
			cardNumber.TextChanged += cardNumber_TextChanged;
			// 
			// phoneNumber
			// 
			phoneNumber.Location = new Point(281, 429);
			phoneNumber.Name = "phoneNumber";
			phoneNumber.Size = new Size(270, 27);
			phoneNumber.TabIndex = 5;
			// 
			// label5
			// 
			label5.Location = new Point(281, 187);
			label5.Name = "label5";
			label5.Size = new Size(103, 20);
			label5.TabIndex = 23;
			label5.Text = "Last Name";
			// 
			// label6
			// 
			label6.Location = new Point(281, 255);
			label6.Name = "label6";
			label6.Size = new Size(93, 20);
			label6.TabIndex = 25;
			label6.Text = "Address";
			// 
			// label7
			// 
			label7.Location = new Point(281, 324);
			label7.Name = "label7";
			label7.Size = new Size(70, 20);
			label7.TabIndex = 26;
			label7.Text = "Age";
			// 
			// label8
			// 
			label8.Location = new Point(281, 400);
			label8.Name = "label8";
			label8.Size = new Size(135, 20);
			label8.TabIndex = 27;
			label8.Text = "Phone Number";
			// 
			// label9
			// 
			label9.Location = new Point(281, 622);
			label9.Name = "label9";
			label9.Size = new Size(150, 20);
			label9.TabIndex = 28;
			label9.Text = "Credit Card Number";
			// 
			// AccountCreation
			// 
			AcceptButton = button1;
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(842, 848);
			Controls.Add(label9);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(phoneNumber);
			Controls.Add(label5);
			Controls.Add(cardNumber);
			Controls.Add(age);
			Controls.Add(address);
			Controls.Add(lastName);
			Controls.Add(linkLabel1);
			Controls.Add(label4);
			Controls.Add(secondPasswordField);
			Controls.Add(credentialsErrorMessage);
			Controls.Add(button1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(passwordField);
			Controls.Add(firstName);
			Name = "AccountCreation";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Airline 3550";
			Activated += AccountCreation_Activated;
			FormClosing += AccountCreation_FormClosing;
			Load += AccountCreation_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label credentialsErrorMessage;
		private Button button1;
		private Label label3;
		private Label label2;
		private Label label1;
		private TextBox passwordField;
		private TextBox firstName;
		private Label label4;
		private TextBox secondPasswordField;
		private LinkLabel linkLabel1;
		private TextBox lastName;
		private TextBox address;
		private TextBox age;
		private TextBox cardNumber;
		private TextBox phoneNumber;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
	}
}