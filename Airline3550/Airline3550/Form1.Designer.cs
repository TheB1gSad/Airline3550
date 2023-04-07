namespace Airline3550
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			usernameField = new TextBox();
			passwordField = new TextBox();
			label1 = new Label();
			label2 = new Label();
			createAccount = new LinkLabel();
			label3 = new Label();
			button1 = new Button();
			credentialsErrorMessage = new Label();
			SuspendLayout();
			// 
			// usernameField
			// 
			usernameField.Location = new Point(205, 218);
			usernameField.Name = "usernameField";
			usernameField.Size = new Size(237, 23);
			usernameField.TabIndex = 0;
			usernameField.TextChanged += textBox1_TextChanged;
			// 
			// passwordField
			// 
			passwordField.Location = new Point(205, 276);
			passwordField.Name = "passwordField";
			passwordField.PasswordChar = '*';
			passwordField.Size = new Size(237, 23);
			passwordField.TabIndex = 1;
			passwordField.TextChanged += textBox1_TextChanged_1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(205, 200);
			label1.Name = "label1";
			label1.Size = new Size(60, 15);
			label1.TabIndex = 2;
			label1.Text = "Username";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(205, 258);
			label2.Name = "label2";
			label2.Size = new Size(57, 15);
			label2.TabIndex = 3;
			label2.Text = "Password";
			// 
			// createAccount
			// 
			createAccount.AutoSize = true;
			createAccount.Location = new Point(215, 312);
			createAccount.Name = "createAccount";
			createAccount.Size = new Size(217, 15);
			createAccount.TabIndex = 4;
			createAccount.TabStop = true;
			createAccount.Text = "New Customer? Make An Account Here";
			createAccount.LinkClicked += LinkLabel1_LinkClicked;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(229, 76);
			label3.Name = "label3";
			label3.Size = new Size(188, 45);
			label3.TabIndex = 5;
			label3.Text = "Airline 3550";
			// 
			// button1
			// 
			button1.BackColor = SystemColors.HighlightText;
			button1.Location = new Point(245, 356);
			button1.Name = "button1";
			button1.Size = new Size(156, 23);
			button1.TabIndex = 6;
			button1.Text = "Login";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// credentialsErrorMessage
			// 
			credentialsErrorMessage.ForeColor = Color.IndianRed;
			credentialsErrorMessage.Location = new Point(205, 175);
			credentialsErrorMessage.Name = "credentialsErrorMessage";
			credentialsErrorMessage.Size = new Size(237, 21);
			credentialsErrorMessage.TabIndex = 7;
			credentialsErrorMessage.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			AcceptButton = button1;
			AccessibleDescription = "";
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Menu;
			ClientSize = new Size(668, 437);
			Controls.Add(credentialsErrorMessage);
			Controls.Add(button1);
			Controls.Add(label3);
			Controls.Add(createAccount);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(passwordField);
			Controls.Add(usernameField);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Margin = new Padding(3, 2, 3, 2);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox usernameField;
		private TextBox passwordField;
		private Label label1;
		private Label label2;
		private LinkLabel createAccount;
		private Label label3;
		private Button button1;
		private Label credentialsErrorMessage;
	}
}