namespace Airline3550
{
    partial class CustomerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMenu));
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            manageFlightsToolStripMenuItem = new ToolStripMenuItem();
            bookFlightToolStripMenuItem = new ToolStripMenuItem();
            manageAccountToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            menuLabel = new Panel();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoSize = true;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = SystemColors.Control;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(0, 485);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(2, 2);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { manageFlightsToolStripMenuItem, bookFlightToolStripMenuItem, manageAccountToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(858, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // manageFlightsToolStripMenuItem
            // 
            manageFlightsToolStripMenuItem.Name = "manageFlightsToolStripMenuItem";
            manageFlightsToolStripMenuItem.Size = new Size(100, 20);
            manageFlightsToolStripMenuItem.Text = "Manage Flights";
            manageFlightsToolStripMenuItem.Click += manageFlightsClick;
            // 
            // bookFlightToolStripMenuItem
            // 
            bookFlightToolStripMenuItem.Name = "bookFlightToolStripMenuItem";
            bookFlightToolStripMenuItem.Size = new Size(79, 20);
            bookFlightToolStripMenuItem.Text = "Book Flight";
            bookFlightToolStripMenuItem.Click += bookFlightClick;
            // 
            // manageAccountToolStripMenuItem
            // 
            manageAccountToolStripMenuItem.Name = "manageAccountToolStripMenuItem";
            manageAccountToolStripMenuItem.Size = new Size(110, 20);
            manageAccountToolStripMenuItem.Text = "Manage Account";
            manageAccountToolStripMenuItem.Click += manageAccountClicked;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(57, 20);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logout_Clicked;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(menuLabel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menuStrip1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 498);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // menuLabel
            // 
            menuLabel.AutoSize = true;
            menuLabel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            menuLabel.BackgroundImage = (Image)resources.GetObject("menuLabel.BackgroundImage");
            menuLabel.BackgroundImageLayout = ImageLayout.Stretch;
            menuLabel.BorderStyle = BorderStyle.FixedSingle;
            menuLabel.Dock = DockStyle.Fill;
            menuLabel.Location = new Point(0, 24);
            menuLabel.Margin = new Padding(3, 2, 3, 2);
            menuLabel.MinimumSize = new Size(868, 444);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(868, 444);
            menuLabel.TabIndex = 3;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 464);
            label1.Name = "label1";
            label1.Size = new Size(858, 32);
            label1.TabIndex = 2;
            label1.Text = "Welcome To Airline 3550 ";
            // 
            // CustomerMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 498);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(1325, 918);
            Name = "CustomerMenu";
            Text = "Airline 3550";
            FormClosing += CustomerMenu_FormClosing;
            Load += MainMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem manageFlightsToolStripMenuItem;
        private ToolStripMenuItem bookFlightToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private Panel panel1;
        private Label label1;
        private ToolStripMenuItem manageAccountToolStripMenuItem;
        private Panel menuLabel;
    }
}