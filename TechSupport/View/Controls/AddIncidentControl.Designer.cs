namespace TechSupport.View.Controls
{
    partial class addIncidentControl
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
            cancelButton = new Button();
            addButton = new Button();
            customerIdErrorLabel = new Label();
            descriptionErrorLabel = new Label();
            titleErrorLabel = new Label();
            customerIdTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            titleTextBox = new TextBox();
            customerIdLabel = new Label();
            descriptionLabel = new Label();
            titleLabel = new Label();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(434, 313);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 21;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(219, 313);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 20;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // customerIdErrorLabel
            // 
            customerIdErrorLabel.AutoSize = true;
            customerIdErrorLabel.ForeColor = Color.Red;
            customerIdErrorLabel.Location = new Point(277, 286);
            customerIdErrorLabel.Name = "customerIdErrorLabel";
            customerIdErrorLabel.Size = new Size(178, 15);
            customerIdErrorLabel.TabIndex = 19;
            customerIdErrorLabel.Text = "Customer ID must be an integer.";
            customerIdErrorLabel.Visible = false;
            // 
            // descriptionErrorLabel
            // 
            descriptionErrorLabel.AutoSize = true;
            descriptionErrorLabel.ForeColor = Color.Red;
            descriptionErrorLabel.Location = new Point(305, 262);
            descriptionErrorLabel.Name = "descriptionErrorLabel";
            descriptionErrorLabel.Size = new Size(128, 15);
            descriptionErrorLabel.TabIndex = 18;
            descriptionErrorLabel.Text = "Description is required.";
            descriptionErrorLabel.Visible = false;
            // 
            // titleErrorLabel
            // 
            titleErrorLabel.AutoSize = true;
            titleErrorLabel.ForeColor = Color.Red;
            titleErrorLabel.Location = new Point(319, 235);
            titleErrorLabel.Name = "titleErrorLabel";
            titleErrorLabel.Size = new Size(90, 15);
            titleErrorLabel.TabIndex = 17;
            titleErrorLabel.Text = "Title is required.";
            titleErrorLabel.Visible = false;
            // 
            // customerIdTextBox
            // 
            customerIdTextBox.Location = new Point(385, 194);
            customerIdTextBox.Name = "customerIdTextBox";
            customerIdTextBox.Size = new Size(100, 23);
            customerIdTextBox.TabIndex = 16;
            customerIdTextBox.TextChanged += CustomerIdTextBox_TextChanged;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(385, 145);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(100, 23);
            descriptionTextBox.TabIndex = 15;
            descriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(385, 94);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(100, 23);
            titleTextBox.TabIndex = 14;
            titleTextBox.TextChanged += TitleTextBox_TextChanged;
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Location = new Point(258, 197);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new Size(76, 15);
            customerIdLabel.TabIndex = 13;
            customerIdLabel.Text = "Customer ID:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(258, 145);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(70, 15);
            descriptionLabel.TabIndex = 12;
            descriptionLabel.Text = "Description:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(277, 97);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(32, 15);
            titleLabel.TabIndex = 11;
            titleLabel.Text = "Title:";
            // 
            // addIncidentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Name = "addIncidentControl";
            Size = new Size(731, 552);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button cancelButton;
        private Button addButton;
        private Label customerIdErrorLabel;
        private Label descriptionErrorLabel;
        private Label titleErrorLabel;
        private TextBox customerIdTextBox;
        private TextBox descriptionTextBox;
        private TextBox titleTextBox;
        private Label customerIdLabel;
        private Label descriptionLabel;
        private Label titleLabel;
    }
}
