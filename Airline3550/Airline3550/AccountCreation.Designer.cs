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
			usernameField = new TextBox();
			label4 = new Label();
			textBox1 = new TextBox();
			SuspendLayout();
			// 
			// credentialsErrorMessage
			// 
			credentialsErrorMessage.ForeColor = Color.Firebrick;
			credentialsErrorMessage.Location = new Point(260, 155);
			credentialsErrorMessage.Name = "credentialsErrorMessage";
			credentialsErrorMessage.Size = new Size(271, 28);
			credentialsErrorMessage.TabIndex = 15;
			credentialsErrorMessage.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			button1.BackColor = SystemColors.HighlightText;
			button1.Location = new Point(328, 418);
			button1.Margin = new Padding(3, 4, 3, 4);
			button1.Name = "button1";
			button1.Size = new Size(178, 31);
			button1.TabIndex = 14;
			button1.Text = "Login";
			button1.UseVisualStyleBackColor = false;
			// 
			// label3
			// 
			label3.Dock = DockStyle.Top;
			label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(0, 0);
			label3.Name = "label3";
			label3.Size = new Size(835, 54);
			label3.TabIndex = 13;
			label3.Text = "Airline 3550";
			label3.TextAlign = ContentAlignment.TopCenter;
			// 
			// label2
			// 
			label2.Location = new Point(282, 266);
			label2.Name = "label2";
			label2.Size = new Size(70, 20);
			label2.TabIndex = 11;
			label2.Text = "Password";
			// 
			// label1
			// 
			label1.Location = new Point(282, 189);
			label1.Name = "label1";
			label1.Size = new Size(75, 20);
			label1.TabIndex = 10;
			label1.Text = "Username";
			// 
			// passwordField
			// 
			passwordField.Location = new Point(282, 290);
			passwordField.Margin = new Padding(3, 4, 3, 4);
			passwordField.Name = "passwordField";
			passwordField.PasswordChar = '*';
			passwordField.Size = new Size(270, 27);
			passwordField.TabIndex = 9;
			// 
			// usernameField
			// 
			usernameField.Location = new Point(282, 213);
			usernameField.Margin = new Padding(3, 4, 3, 4);
			usernameField.Name = "usernameField";
			usernameField.Size = new Size(270, 27);
			usernameField.TabIndex = 8;
			// 
			// label4
			// 
			label4.Location = new Point(282, 328);
			label4.Name = "label4";
			label4.Size = new Size(70, 20);
			label4.TabIndex = 17;
			label4.Text = "Password";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(282, 352);
			textBox1.Margin = new Padding(3, 4, 3, 4);
			textBox1.Name = "textBox1";
			textBox1.PasswordChar = '*';
			textBox1.Size = new Size(270, 27);
			textBox1.TabIndex = 16;
			// 
			// AccountCreation
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(835, 591);
			Controls.Add(label4);
			Controls.Add(textBox1);
			Controls.Add(credentialsErrorMessage);
			Controls.Add(button1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(passwordField);
			Controls.Add(usernameField);
			Name = "AccountCreation";
			Text = "AccountCreation";
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
		private TextBox usernameField;
		private Label label4;
		private TextBox textBox1;
	}
}