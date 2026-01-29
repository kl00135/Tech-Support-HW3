namespace TechSupport.View
{
    partial class MainForm
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
            usernameLabel = new Label();
            logoutLinkLabel = new LinkLabel();
            addIncidentButton = new Button();
            searchIncedentButton = new Button();
            incidentDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)incidentDataGridView).BeginInit();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(659, 25);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(38, 15);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "label1";
            // 
            // logoutLinkLabel
            // 
            logoutLinkLabel.AutoSize = true;
            logoutLinkLabel.Location = new Point(659, 53);
            logoutLinkLabel.Name = "logoutLinkLabel";
            logoutLinkLabel.Size = new Size(45, 15);
            logoutLinkLabel.TabIndex = 1;
            logoutLinkLabel.TabStop = true;
            logoutLinkLabel.Text = "Logout";
            logoutLinkLabel.LinkClicked += LogoutLinkLabel_LinkClicked;
            // 
            // addIncidentButton
            // 
            addIncidentButton.Location = new Point(258, 129);
            addIncidentButton.Name = "addIncidentButton";
            addIncidentButton.Size = new Size(108, 30);
            addIncidentButton.TabIndex = 2;
            addIncidentButton.Text = "Add Incident";
            addIncidentButton.UseVisualStyleBackColor = true;
            addIncidentButton.Click += AddIncidentButton_Click;
            // 
            // searchIncedentButton
            // 
            searchIncedentButton.Location = new Point(441, 129);
            searchIncedentButton.Name = "searchIncedentButton";
            searchIncedentButton.Size = new Size(108, 30);
            searchIncedentButton.TabIndex = 3;
            searchIncedentButton.Text = "Search Incident";
            searchIncedentButton.UseVisualStyleBackColor = true;
            searchIncedentButton.Click += SearchIncidentButton_Click;
            // 
            // incidentDataGridView
            // 
            incidentDataGridView.AllowUserToAddRows = false;
            incidentDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            incidentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            incidentDataGridView.Location = new Point(258, 189);
            incidentDataGridView.Name = "incidentDataGridView";
            incidentDataGridView.ReadOnly = true;
            incidentDataGridView.Size = new Size(291, 223);
            incidentDataGridView.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(incidentDataGridView);
            Controls.Add(searchIncedentButton);
            Controls.Add(addIncidentButton);
            Controls.Add(logoutLinkLabel);
            Controls.Add(usernameLabel);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tech Support";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)incidentDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernameLabel;
        private LinkLabel logoutLinkLabel;
        private Button addIncidentButton;
        private Button searchIncedentButton;
        private DataGridView incidentDataGridView;
    }
}