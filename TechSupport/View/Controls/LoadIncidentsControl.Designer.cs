namespace TechSupport.View.Controls
{
    partial class loadIncidentsControl
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
            loadIncidentControlLabel = new Label();
            incidentsDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)incidentsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // loadIncidentControlLabel
            // 
            loadIncidentControlLabel.AutoSize = true;
            loadIncidentControlLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadIncidentControlLabel.Location = new Point(3, 0);
            loadIncidentControlLabel.Name = "loadIncidentControlLabel";
            loadIncidentControlLabel.Size = new Size(105, 21);
            loadIncidentControlLabel.TabIndex = 1;
            loadIncidentControlLabel.Text = "All Incidents";
            // 
            // incidentsDataGridView
            // 
            incidentsDataGridView.AllowUserToAddRows = false;
            incidentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            incidentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            incidentsDataGridView.Dock = DockStyle.Fill;
            incidentsDataGridView.Location = new Point(0, 0);
            incidentsDataGridView.Name = "incidentsDataGridView";
            incidentsDataGridView.ReadOnly = true;
            incidentsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            incidentsDataGridView.Size = new Size(726, 548);
            incidentsDataGridView.TabIndex = 2;
            // 
            // loadIncidentsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(incidentsDataGridView);
            Controls.Add(loadIncidentControlLabel);
            Name = "loadIncidentsControl";
            Size = new Size(726, 548);
            ((System.ComponentModel.ISupportInitialize)incidentsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loadIncidentControlLabel;
        private DataGridView incidentsDataGridView;
    }
}
