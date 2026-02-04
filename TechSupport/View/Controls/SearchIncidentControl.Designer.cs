namespace TechSupport.View.Controls
{
    partial class SearchIncidentControl
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
            searchResultsDataGridView = new DataGridView();
            closeButton = new Button();
            searchButton = new Button();
            customerIdTextBox = new TextBox();
            customerIdLabel = new Label();
            customerIdErrorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)searchResultsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // searchResultsDataGridView
            // 
            searchResultsDataGridView.AllowUserToAddRows = false;
            searchResultsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            searchResultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchResultsDataGridView.Location = new Point(126, 87);
            searchResultsDataGridView.Name = "searchResultsDataGridView";
            searchResultsDataGridView.ReadOnly = true;
            searchResultsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            searchResultsDataGridView.Size = new Size(534, 287);
            searchResultsDataGridView.TabIndex = 11;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(448, 58);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 10;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += CloseButton_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(253, 58);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 9;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += SearchButton_Click;
            // 
            // customerIdTextBox
            // 
            customerIdTextBox.Location = new Point(361, 3);
            customerIdTextBox.Name = "customerIdTextBox";
            customerIdTextBox.Size = new Size(162, 23);
            customerIdTextBox.TabIndex = 8;
            customerIdTextBox.TextChanged += CustomerIdTextBox_TextChanged;
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Location = new Point(253, 3);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new Size(76, 15);
            customerIdLabel.TabIndex = 6;
            customerIdLabel.Text = "Customer ID:";
            // 
            // customerIdErrorLabel
            // 
            customerIdErrorLabel.AutoSize = true;
            customerIdErrorLabel.ForeColor = Color.Red;
            customerIdErrorLabel.Location = new Point(301, 40);
            customerIdErrorLabel.Name = "customerIdErrorLabel";
            customerIdErrorLabel.Size = new Size(176, 15);
            customerIdErrorLabel.TabIndex = 12;
            customerIdErrorLabel.Text = "Customer ID must be a number.";
            customerIdErrorLabel.Visible = false;
            // 
            // SearchIncidentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(customerIdErrorLabel);
            Controls.Add(searchResultsDataGridView);
            Controls.Add(closeButton);
            Controls.Add(searchButton);
            Controls.Add(customerIdTextBox);
            Controls.Add(customerIdLabel);
            Name = "SearchIncidentControl";
            Size = new Size(737, 550);
            ((System.ComponentModel.ISupportInitialize)searchResultsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView searchResultsDataGridView;
        private Button closeButton;
        private Button searchButton;
        private TextBox customerIdTextBox;
        private Label customerIdLabel;
        private Label customerIdErrorLabel;
    }
}
