namespace TechSupport.View
{
    partial class SearchIncidentForm
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
            customerIdLabel = new Label();
            customerIdErrorLabel = new Label();
            customerIdTextBox = new TextBox();
            searchButton = new Button();
            closeButton = new Button();
            searchResultsDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)searchResultsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Location = new Point(258, 85);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new Size(76, 15);
            customerIdLabel.TabIndex = 0;
            customerIdLabel.Text = "Customer ID:";
            // 
            // customerIdErrorLabel
            // 
            customerIdErrorLabel.AutoSize = true;
            customerIdErrorLabel.ForeColor = Color.Red;
            customerIdErrorLabel.Location = new Point(306, 122);
            customerIdErrorLabel.Name = "customerIdErrorLabel";
            customerIdErrorLabel.Size = new Size(179, 15);
            customerIdErrorLabel.TabIndex = 1;
            customerIdErrorLabel.Text = "Customer ID must be an interger";
            customerIdErrorLabel.Visible = false;
            // 
            // customerIdTextBox
            // 
            customerIdTextBox.Location = new Point(366, 85);
            customerIdTextBox.Name = "customerIdTextBox";
            customerIdTextBox.Size = new Size(162, 23);
            customerIdTextBox.TabIndex = 2;
            customerIdTextBox.TextChanged += CustomerIdTextBox_TextChanged;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(258, 140);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 3;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += SearchButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(453, 140);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 4;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += CloseButton_Click;
            // 
            // searchResultsDataGridView
            // 
            searchResultsDataGridView.AllowUserToAddRows = false;
            searchResultsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            searchResultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchResultsDataGridView.Location = new Point(258, 169);
            searchResultsDataGridView.Name = "searchResultsDataGridView";
            searchResultsDataGridView.ReadOnly = true;
            searchResultsDataGridView.Size = new Size(270, 223);
            searchResultsDataGridView.TabIndex = 5;
            // 
            // SearchIncidentForm
            // 
            AcceptButton = searchButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = closeButton;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(searchResultsDataGridView);
            Controls.Add(closeButton);
            Controls.Add(searchButton);
            Controls.Add(customerIdTextBox);
            Controls.Add(customerIdErrorLabel);
            Controls.Add(customerIdLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SearchIncidentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Search Incidents";
            ((System.ComponentModel.ISupportInitialize)searchResultsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label customerIdLabel;
        private Label customerIdErrorLabel;
        private TextBox customerIdTextBox;
        private Button searchButton;
        private Button closeButton;
        private DataGridView searchResultsDataGridView;
    }
}