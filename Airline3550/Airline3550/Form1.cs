namespace Airline3550
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{

		}



		private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (usernameField.Text == "" && passwordField.Text == "")
			{
				credentialsErrorMessage.Text = "Please Enter Username and Password";
			}
			else if (usernameField.Text == "")
			{
				credentialsErrorMessage.Text = "Please Enter Username";
			}
			else if (passwordField.Text == "")
			{
				credentialsErrorMessage.Text = "Please Enter Password";
			}
			else
			{
				//If we made it here there is some text in both username and password
				//Begin Checking credentials
			}
		}


	}
}