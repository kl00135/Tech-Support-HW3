namespace TechSupport.View
{
    partial class MainDashboard
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
            mainTabControl = new TabControl();
            addIncidentTabPage = new TabPage();
            addIncidentControl = new TechSupport.View.Controls.addIncidentControl();
            logoutLinkLabel = new LinkLabel();
            loadIncidentTabPage = new TabPage();
            loadIncidentsControl = new TechSupport.View.Controls.loadIncidentsControl();
            searchIncidentTabPage = new TabPage();
            searchIncidentControl = new TechSupport.View.Controls.SearchIncidentControl();
            displayIncidentsTabPage = new TabPage();
            displayOpenIncidentsControl = new TechSupport.View.Controls.DisplayOpenIncidentsControl();
            mainTabControl.SuspendLayout();
            addIncidentTabPage.SuspendLayout();
            loadIncidentTabPage.SuspendLayout();
            searchIncidentTabPage.SuspendLayout();
            displayIncidentsTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(addIncidentTabPage);
            mainTabControl.Controls.Add(loadIncidentTabPage);
            mainTabControl.Controls.Add(searchIncidentTabPage);
            mainTabControl.Controls.Add(displayIncidentsTabPage);
            mainTabControl.Dock = DockStyle.Fill;
            mainTabControl.Location = new Point(0, 0);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(800, 450);
            mainTabControl.TabIndex = 0;
            mainTabControl.SelectedIndexChanged += mainTabControl_SelectedIndexChanged;
            // 
            // addIncidentTabPage
            // 
            addIncidentTabPage.Controls.Add(addIncidentControl);
            addIncidentTabPage.Controls.Add(logoutLinkLabel);
            addIncidentTabPage.Location = new Point(4, 24);
            addIncidentTabPage.Name = "addIncidentTabPage";
            addIncidentTabPage.Size = new Size(792, 422);
            addIncidentTabPage.TabIndex = 0;
            addIncidentTabPage.Text = "Add Incident";
            addIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // addIncidentControl
            // 
            addIncidentControl.Dock = DockStyle.Fill;
            addIncidentControl.Location = new Point(0, 0);
            addIncidentControl.Name = "addIncidentControl";
            addIncidentControl.Size = new Size(792, 422);
            addIncidentControl.TabIndex = 2;
            // 
            // logoutLinkLabel
            // 
            logoutLinkLabel.AutoSize = true;
            logoutLinkLabel.Location = new Point(8, 8);
            logoutLinkLabel.Name = "logoutLinkLabel";
            logoutLinkLabel.Size = new Size(45, 15);
            logoutLinkLabel.TabIndex = 1;
            logoutLinkLabel.TabStop = true;
            logoutLinkLabel.Text = "Logout";
            logoutLinkLabel.LinkClicked += LogoutLinkLabel_LinkClicked;
            // 
            // loadIncidentTabPage
            // 
            loadIncidentTabPage.Controls.Add(loadIncidentsControl);
            loadIncidentTabPage.Location = new Point(4, 24);
            loadIncidentTabPage.Name = "loadIncidentTabPage";
            loadIncidentTabPage.Size = new Size(792, 422);
            loadIncidentTabPage.TabIndex = 1;
            loadIncidentTabPage.Text = "Load All Incidents";
            loadIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // loadIncidentsControl
            // 
            loadIncidentsControl.Dock = DockStyle.Fill;
            loadIncidentsControl.Location = new Point(0, 0);
            loadIncidentsControl.Name = "loadIncidentsControl";
            loadIncidentsControl.Size = new Size(792, 422);
            loadIncidentsControl.TabIndex = 0;
            // 
            // searchIncidentTabPage
            // 
            searchIncidentTabPage.Controls.Add(searchIncidentControl);
            searchIncidentTabPage.Location = new Point(4, 24);
            searchIncidentTabPage.Name = "searchIncidentTabPage";
            searchIncidentTabPage.Size = new Size(792, 422);
            searchIncidentTabPage.TabIndex = 2;
            searchIncidentTabPage.Text = "Search Incident";
            searchIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // searchIncidentControl
            // 
            searchIncidentControl.Dock = DockStyle.Fill;
            searchIncidentControl.Location = new Point(0, 0);
            searchIncidentControl.Name = "searchIncidentControl";
            searchIncidentControl.Size = new Size(792, 422);
            searchIncidentControl.TabIndex = 0;
            // 
            // displayIncidentsTabPage
            // 
            displayIncidentsTabPage.Controls.Add(displayOpenIncidentsControl);
            displayIncidentsTabPage.Location = new Point(4, 24);
            displayIncidentsTabPage.Name = "displayIncidentsTabPage";
            displayIncidentsTabPage.Padding = new Padding(3);
            displayIncidentsTabPage.Size = new Size(792, 422);
            displayIncidentsTabPage.TabIndex = 3;
            displayIncidentsTabPage.Text = "Display Open Incidents";
            displayIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // displayOpenIncidentsControl
            // 
            displayOpenIncidentsControl.Dock = DockStyle.Fill;
            displayOpenIncidentsControl.Location = new Point(3, 3);
            displayOpenIncidentsControl.Name = "displayOpenIncidentsControl";
            displayOpenIncidentsControl.Size = new Size(786, 416);
            displayOpenIncidentsControl.TabIndex = 0;
            // 
            // MainDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainTabControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tech Support Dashboard";
            mainTabControl.ResumeLayout(false);
            addIncidentTabPage.ResumeLayout(false);
            addIncidentTabPage.PerformLayout();
            loadIncidentTabPage.ResumeLayout(false);
            searchIncidentTabPage.ResumeLayout(false);
            displayIncidentsTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl mainTabControl;
        private TabPage addIncidentTabPage;
        private TabPage loadIncidentTabPage;
        private TabPage searchIncidentTabPage;
        private TabPage displayOpenIncidentsTabPage;
        private Controls.addIncidentControl addIncidentControl1;
        private Controls.loadIncidentsControl loadIncidentsControl1;
        private Controls.SearchIncidentControl searchIncidentControl1;
        private LinkLabel logoutLinkLabel;
        private TabPage displayIncidentsTabPage;
        private Controls.addIncidentControl addIncidentControl2;
        private Controls.addIncidentControl addIncidentControl;
        private Controls.loadIncidentsControl loadIncidentsControl;
        private Controls.SearchIncidentControl searchIncidentControl;
        private Controls.DisplayOpenIncidentsControl displayOpenIncidentsControl;
    }
}