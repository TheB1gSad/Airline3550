using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline3550
{
    public partial class CustomerMenu : Form
    {
        private LoginScreen login;
        public User.userData userData;
        private ManageAccount manageAccount;
        private ManageFlights_Customer manageFlights;
        private BookFlightMenu bookFlightMenu;
        //pass a userData struct from the User class that contains logged in user's credentials/username
        public CustomerMenu(User.userData thisUser, LoginScreen loginScreen)
        {
            login = loginScreen;
            userData = thisUser;
            manageAccount = new ManageAccount(userData);
            manageFlights = new ManageFlights_Customer(this);
            bookFlightMenu = new BookFlightMenu(this);
            InitializeComponent();


        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            label1.Text += userData.firstname;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logout_Clicked(object sender, EventArgs e)
        {
            login.Show();
            this.Close();

        }

        private void CustomerMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Check if the login screen is visible, if it's not then
            //the user must have closed the program so kill it
            if (!login.Visible)
                login.Close();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void manageAccountClicked(object sender, EventArgs e)
        {

            if (!manageAccount.Visible)
            {

                hideAllMenus();
                label1.Hide();
                manageAccount.TopLevel = false;
                menuLabel.Controls.Add(manageAccount);
                manageAccount.Dock = DockStyle.Fill;
                manageAccount.Show();
            }
            else
            {
                hideAllMenus();
                label1.Show();
            }

        }

        //When this method is called, all menus in the menu field will be hidden.
        private void hideAllMenus()
        {
            manageAccount.Hide();
            manageFlights.Hide();
            bookFlightMenu.Hide();
            userData = manageAccount.userData;
            label1.Text = "Welcome To Airline 3550 " + userData.firstname;
        }

        private void manageFlightsClick(object sender, EventArgs e)
        {
            if (!manageFlights.Visible)
            {

                hideAllMenus();
                label1.Hide();
                manageFlights.TopLevel = false;
                menuLabel.Controls.Add(manageFlights);
                manageFlights.Dock = DockStyle.Fill;
                manageFlights.Show();
            }
            else
            {
                hideAllMenus();
                label1.Show();
            }

        }

        private void bookFlightClick(object sender, EventArgs e)
        {
            if (!bookFlightMenu.Visible)
            {

                hideAllMenus();
                label1.Hide();
                bookFlightMenu.TopLevel = false;
                menuLabel.Controls.Add(bookFlightMenu);
                bookFlightMenu.Dock = DockStyle.Fill;
                bookFlightMenu.Show();
            }
            else
            {
                hideAllMenus();
                label1.Show();
            }
        }
    }
}
