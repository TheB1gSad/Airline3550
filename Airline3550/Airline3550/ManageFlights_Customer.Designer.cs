namespace Airline3550
{
    partial class ManageFlights_Customer
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
            label1 = new Label();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            upComingFlightsWindow = new TabPage();
            upcomingFlightsTable = new TableLayoutPanel();
            previousFlightsWindow = new TabPage();
            previousFlightsTable = new TableLayoutPanel();
            panel2 = new Panel();

            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            upComingFlightsWindow.SuspendLayout();
            previousFlightsWindow.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 8, 0, 0);
            label1.Size = new Size(868, 76);
            label1.TabIndex = 1;
            label1.Text = "Manage Flights";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControl1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 76);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 367);
            panel1.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(upComingFlightsWindow);
            tabControl1.Controls.Add(previousFlightsWindow);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(494, 367);
            tabControl1.TabIndex = 0;
            // 
            // upComingFlightsWindow
            // 
            upComingFlightsWindow.AutoScroll = true;
            upComingFlightsWindow.Controls.Add(upcomingFlightsTable);
            upComingFlightsWindow.Location = new Point(4, 24);
            upComingFlightsWindow.Margin = new Padding(3, 2, 3, 2);
            upComingFlightsWindow.Name = "upComingFlightsWindow";
            upComingFlightsWindow.Padding = new Padding(3, 2, 3, 2);
            upComingFlightsWindow.Size = new Size(486, 339);
            upComingFlightsWindow.TabIndex = 0;
            upComingFlightsWindow.Text = "Upcoming Flights";
            upComingFlightsWindow.UseVisualStyleBackColor = true;
            // 
            // upcomingFlightsTable
            // 
            upcomingFlightsTable.AutoSize = true;
            upcomingFlightsTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            upcomingFlightsTable.ColumnCount = 1;
            upcomingFlightsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            upcomingFlightsTable.Dock = DockStyle.Top;
            upcomingFlightsTable.Location = new Point(3, 2);
            upcomingFlightsTable.Margin = new Padding(3, 2, 3, 2);
            upcomingFlightsTable.Name = "upcomingFlightsTable";
            upcomingFlightsTable.RowCount = 1;
            upcomingFlightsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            upcomingFlightsTable.Size = new Size(480, 18);
            upcomingFlightsTable.TabIndex = 1;
            // 
            // previousFlightsWindow
            // 
            previousFlightsWindow.AutoScroll = true;
            previousFlightsWindow.Controls.Add(previousFlightsTable);
            previousFlightsWindow.Location = new Point(4, 24);
            previousFlightsWindow.Margin = new Padding(3, 2, 3, 2);
            previousFlightsWindow.Name = "previousFlightsWindow";
            previousFlightsWindow.Padding = new Padding(3, 2, 3, 2);
            previousFlightsWindow.Size = new Size(486, 339);
            previousFlightsWindow.TabIndex = 1;
            previousFlightsWindow.Text = "Previous Flights";
            previousFlightsWindow.UseVisualStyleBackColor = true;
            // 
            // previousFlightsTable
            // 
            previousFlightsTable.AutoSize = true;
            previousFlightsTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            previousFlightsTable.ColumnCount = 1;
            previousFlightsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            previousFlightsTable.Dock = DockStyle.Top;
            previousFlightsTable.Location = new Point(3, 2);
            previousFlightsTable.Margin = new Padding(3, 2, 3, 2);
            previousFlightsTable.Name = "previousFlightsTable";
            previousFlightsTable.RowCount = 1;
            previousFlightsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            previousFlightsTable.Size = new Size(480, 18);
            previousFlightsTable.TabIndex = 2;
            // 
            // panel2
            // 

            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(494, 76);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(374, 367);
            panel2.TabIndex = 3;
            // 
            // ManageFlights_Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 443);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManageFlights_Customer";
            Text = "ManageFlights_Customer";
            VisibleChanged += manageFlightsLoade;
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            upComingFlightsWindow.ResumeLayout(false);
            upComingFlightsWindow.PerformLayout();
            previousFlightsWindow.ResumeLayout(false);
            previousFlightsWindow.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

		private Label label1;
		private Panel panel1;
		private TabPage upComingFlightsWindow;
		private TabPage previousFlightsWindow;
		private TableLayoutPanel upcomingFlightsTable;
		public TabControl tabControl1;
		public TableLayoutPanel previousFlightsTable;
		private Panel panel2;
	}
}