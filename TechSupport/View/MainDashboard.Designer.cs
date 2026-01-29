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
            logoutLinkLabel = new LinkLabel();
            addIncidentControl1 = new TechSupport.View.Controls.addIncidentControl();
            loadIncidentTabPage = new TabPage();
            loadIncidentsControl1 = new TechSupport.View.Controls.loadIncidentsControl();
            searchIncidentTabPage = new TabPage();
            searchIncidentControl1 = new TechSupport.View.Controls.SearchIncidentControl();
            mainTabControl.SuspendLayout();
            addIncidentTabPage.SuspendLayout();
            loadIncidentTabPage.SuspendLayout();
            searchIncidentTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(addIncidentTabPage);
            mainTabControl.Controls.Add(loadIncidentTabPage);
            mainTabControl.Controls.Add(searchIncidentTabPage);
            mainTabControl.Dock = DockStyle.Fill;
            mainTabControl.Location = new Point(0, 0);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(800, 450);
            mainTabControl.TabIndex = 0;
            mainTabControl.SelectedIndexChanged += MainTabControl_SelectedIndexChanged;
            // 
            // addIncidentTabPage
            // 
            addIncidentTabPage.Controls.Add(logoutLinkLabel);
            addIncidentTabPage.Controls.Add(addIncidentControl1);
            addIncidentTabPage.Location = new Point(4, 24);
            addIncidentTabPage.Name = "addIncidentTabPage";
            addIncidentTabPage.Size = new Size(792, 422);
            addIncidentTabPage.TabIndex = 0;
            addIncidentTabPage.Text = "Add Incident";
            addIncidentTabPage.UseVisualStyleBackColor = true;
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
            // addIncidentControl1
            // 
            addIncidentControl1.Dock = DockStyle.Fill;
            addIncidentControl1.Location = new Point(0, 0);
            addIncidentControl1.Name = "addIncidentControl1";
            addIncidentControl1.Size = new Size(792, 422);
            addIncidentControl1.TabIndex = 0;
            // 
            // loadIncidentTabPage
            // 
            loadIncidentTabPage.Controls.Add(loadIncidentsControl1);
            loadIncidentTabPage.Location = new Point(4, 24);
            loadIncidentTabPage.Name = "loadIncidentTabPage";
            loadIncidentTabPage.Size = new Size(792, 422);
            loadIncidentTabPage.TabIndex = 1;
            loadIncidentTabPage.Text = "Load All Incidents";
            loadIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // loadIncidentsControl1
            // 
            loadIncidentsControl1.Dock = DockStyle.Fill;
            loadIncidentsControl1.Location = new Point(0, 0);
            loadIncidentsControl1.Name = "loadIncidentsControl1";
            loadIncidentsControl1.Size = new Size(792, 422);
            loadIncidentsControl1.TabIndex = 0;
            // 
            // searchIncidentTabPage
            // 
            searchIncidentTabPage.Controls.Add(searchIncidentControl1);
            searchIncidentTabPage.Location = new Point(4, 24);
            searchIncidentTabPage.Name = "searchIncidentTabPage";
            searchIncidentTabPage.Size = new Size(792, 422);
            searchIncidentTabPage.TabIndex = 2;
            searchIncidentTabPage.Text = "Search Incident";
            searchIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // searchIncidentControl1
            // 
            searchIncidentControl1.Dock = DockStyle.Fill;
            searchIncidentControl1.Location = new Point(0, 0);
            searchIncidentControl1.Name = "searchIncidentControl1";
            searchIncidentControl1.Size = new Size(792, 422);
            searchIncidentControl1.TabIndex = 0;
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
            ResumeLayout(false);
        }

        #endregion

        private TabControl mainTabControl;
        private TabPage addIncidentTabPage;
        private TabPage loadIncidentTabPage;
        private TabPage searchIncidentTabPage;
        private Controls.addIncidentControl addIncidentControl1;
        private Controls.loadIncidentsControl loadIncidentsControl1;
        private Controls.SearchIncidentControl searchIncidentControl1;
        private LinkLabel logoutLinkLabel;
    }
}