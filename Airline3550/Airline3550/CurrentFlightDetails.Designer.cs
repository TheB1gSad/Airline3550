namespace Airline3550
{
	partial class CurrentFlightDetails
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panel1 = new Panel();
			buttonPanel = new Panel();
			cancelFlight = new Button();
			printBoardingPass = new Button();
			panel2 = new Panel();
			textBox = new RichTextBox();
			panel1.SuspendLayout();
			buttonPanel.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(buttonPanel);
			panel1.Dock = DockStyle.Bottom;
			panel1.Location = new Point(0, 440);
			panel1.Name = "panel1";
			panel1.Size = new Size(427, 50);
			panel1.TabIndex = 0;
			// 
			// buttonPanel
			// 
			buttonPanel.AutoSize = true;
			buttonPanel.Controls.Add(cancelFlight);
			buttonPanel.Controls.Add(printBoardingPass);
			buttonPanel.Dock = DockStyle.Fill;
			buttonPanel.Location = new Point(0, 0);
			buttonPanel.Name = "buttonPanel";
			buttonPanel.Size = new Size(427, 50);
			buttonPanel.TabIndex = 0;
			// 
			// cancelFlight
			// 
			cancelFlight.Dock = DockStyle.Fill;
			cancelFlight.Location = new Point(219, 0);
			cancelFlight.Name = "cancelFlight";
			cancelFlight.Size = new Size(208, 50);
			cancelFlight.TabIndex = 1;
			cancelFlight.Text = "Cancel Flight";
			cancelFlight.UseVisualStyleBackColor = true;
			// 
			// printBoardingPass
			// 
			printBoardingPass.Dock = DockStyle.Left;
			printBoardingPass.Location = new Point(0, 0);
			printBoardingPass.Name = "printBoardingPass";
			printBoardingPass.Size = new Size(219, 50);
			printBoardingPass.TabIndex = 0;
			printBoardingPass.Text = "Print Boarding Pass";
			printBoardingPass.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			panel2.Controls.Add(textBox);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(0, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(427, 440);
			panel2.TabIndex = 1;
			// 
			// textBox
			// 
			textBox.Dock = DockStyle.Fill;
			textBox.Location = new Point(0, 0);
			textBox.Name = "textBox";
			textBox.Size = new Size(427, 440);
			textBox.TabIndex = 0;
			textBox.Text = "";
			// 
			// CurrentFlightDetails
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "CurrentFlightDetails";
			Size = new Size(427, 490);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			buttonPanel.ResumeLayout(false);
			panel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel buttonPanel;
		private Button cancelFlight;
		private Button printBoardingPass;
		private Panel panel2;
		private RichTextBox textBox;
	}
}
