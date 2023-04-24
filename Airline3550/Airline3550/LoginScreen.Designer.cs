namespace Airline3550
{
	partial class LoginScreen
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
			usernameField.Location = new Point(246, 222);
			usernameField.Margin = new Padding(3, 4, 3, 4);
			usernameField.Name = "usernameField";
			usernameField.Size = new Size(270, 27);
			usernameField.TabIndex = 0;
			// 
			// passwordField
			// 
			passwordField.Location = new Point(246, 299);
			passwordField.Margin = new Padding(3, 4, 3, 4);
			passwordField.Name = "passwordField";
			passwordField.PasswordChar = '*';
			passwordField.Size = new Size(270, 27);
			passwordField.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(246, 198);
			label1.Name = "label1";
			label1.Size = new Size(75, 20);
			label1.TabIndex = 2;
			label1.Text = "Username";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(246, 275);
			label2.Name = "label2";
			label2.Size = new Size(70, 20);
			label2.TabIndex = 3;
			label2.Text = "Password";
			// 
			// createAccount
			// 
			createAccount.AutoSize = true;
			createAccount.Location = new Point(247, 347);
			createAccount.Name = "createAccount";
			createAccount.Size = new Size(269, 20);
			createAccount.TabIndex = 4;
			createAccount.TabStop = true;
			createAccount.Text = "New Customer? Make An Account Here";
			createAccount.LinkClicked += LinkLabel1_LinkClicked;
			// 
			// label3
			// 
			label3.Dock = DockStyle.Top;
			label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(0, 0);
			label3.Name = "label3";
			label3.Size = new Size(763, 54);
			label3.TabIndex = 5;
			label3.Text = "Airline 3550";
			label3.TextAlign = ContentAlignment.TopCenter;
			// 
			// button1
			// 
			button1.BackColor = SystemColors.HighlightText;
			button1.Location = new Point(292, 406);
			button1.Margin = new Padding(3, 4, 3, 4);
			button1.Name = "button1";
			button1.Size = new Size(178, 31);
			button1.TabIndex = 6;
			button1.Text = "Login";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// credentialsErrorMessage
			// 
			credentialsErrorMessage.Anchor = AnchorStyles.Top;
			credentialsErrorMessage.BackColor = SystemColors.Menu;
			credentialsErrorMessage.ForeColor = Color.Firebrick;
			credentialsErrorMessage.Location = new Point(246, 164);
			credentialsErrorMessage.Name = "credentialsErrorMessage";
			credentialsErrorMessage.Size = new Size(271, 28);
			credentialsErrorMessage.TabIndex = 7;
			credentialsErrorMessage.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// LoginScreen
			// 
			AcceptButton = button1;
			AccessibleDescription = "";
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Menu;
			ClientSize = new Size(763, 583);
			Controls.Add(credentialsErrorMessage);
			Controls.Add(button1);
			Controls.Add(label3);
			Controls.Add(createAccount);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(passwordField);
			Controls.Add(usernameField);
			Name = "LoginScreen";
			Text = "Airline 3550";
			Load += LoginScreen_Load;
			Resize += LoginScreen_Resize;
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