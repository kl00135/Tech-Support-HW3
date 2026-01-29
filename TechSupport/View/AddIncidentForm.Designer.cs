namespace TechSupport.View
{
    partial class AddIncidentForm
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
            titleLabel = new Label();
            descriptionLabel = new Label();
            customerIdLabel = new Label();
            titleTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            customerIdTextBox = new TextBox();
            titleErrorLabel = new Label();
            descriptionErrorLabel = new Label();
            customerIdErrorLabel = new Label();
            addButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(304, 110);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(32, 15);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Title:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(285, 158);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(70, 15);
            descriptionLabel.TabIndex = 1;
            descriptionLabel.Text = "Description:";
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Location = new Point(285, 210);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new Size(76, 15);
            customerIdLabel.TabIndex = 2;
            customerIdLabel.Text = "Customer ID:";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(412, 107);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(100, 23);
            titleTextBox.TabIndex = 3;
            titleTextBox.TextChanged += TitleTextBox_TextChanged;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(412, 158);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(100, 23);
            descriptionTextBox.TabIndex = 4;
            descriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // customerIdTextBox
            // 
            customerIdTextBox.Location = new Point(412, 207);
            customerIdTextBox.Name = "customerIdTextBox";
            customerIdTextBox.Size = new Size(100, 23);
            customerIdTextBox.TabIndex = 5;
            customerIdTextBox.TextChanged += CustomerIdTextBox_TextChanged;
            // 
            // titleErrorLabel
            // 
            titleErrorLabel.AutoSize = true;
            titleErrorLabel.ForeColor = Color.Red;
            titleErrorLabel.Location = new Point(346, 248);
            titleErrorLabel.Name = "titleErrorLabel";
            titleErrorLabel.Size = new Size(90, 15);
            titleErrorLabel.TabIndex = 6;
            titleErrorLabel.Text = "Title is required.";
            // 
            // descriptionErrorLabel
            // 
            descriptionErrorLabel.AutoSize = true;
            descriptionErrorLabel.ForeColor = Color.Red;
            descriptionErrorLabel.Location = new Point(332, 275);
            descriptionErrorLabel.Name = "descriptionErrorLabel";
            descriptionErrorLabel.Size = new Size(128, 15);
            descriptionErrorLabel.TabIndex = 7;
            descriptionErrorLabel.Text = "Description is required.";
            // 
            // customerIdErrorLabel
            // 
            customerIdErrorLabel.AutoSize = true;
            customerIdErrorLabel.ForeColor = Color.Red;
            customerIdErrorLabel.Location = new Point(304, 299);
            customerIdErrorLabel.Name = "customerIdErrorLabel";
            customerIdErrorLabel.Size = new Size(178, 15);
            customerIdErrorLabel.TabIndex = 8;
            customerIdErrorLabel.Text = "Customer ID must be an integer.";
            // 
            // addButton
            // 
            addButton.Location = new Point(246, 326);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 9;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(461, 326);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 10;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // AddIncidentForm
            // 
            AcceptButton = addButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(cancelButton);
            Controls.Add(addButton);
            Controls.Add(customerIdErrorLabel);
            Controls.Add(descriptionErrorLabel);
            Controls.Add(titleErrorLabel);
            Controls.Add(customerIdTextBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(customerIdLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddIncidentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Incident";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label descriptionLabel;
        private Label customerIdLabel;
        private TextBox titleTextBox;
        private TextBox descriptionTextBox;
        private TextBox customerIdTextBox;
        private Label titleErrorLabel;
        private Label descriptionErrorLabel;
        private Label customerIdErrorLabel;
        private Button addButton;
        private Button cancelButton;
    }
}