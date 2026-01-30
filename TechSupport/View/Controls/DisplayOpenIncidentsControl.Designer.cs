namespace TechSupport.View.Controls
{
    partial class DisplayOpenIncidentsControl
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
            openIncidentsListView = new ListView();
            incidentIDColumn = new ColumnHeader();
            titleColumn = new ColumnHeader();
            customerColumn = new ColumnHeader();
            productColumn = new ColumnHeader();
            technicianColumn = new ColumnHeader();
            dateOpenedColumn = new ColumnHeader();
            SuspendLayout();
            // 
            // openIncidentsListView
            // 
            openIncidentsListView.Columns.AddRange(new ColumnHeader[] { incidentIDColumn, titleColumn, customerColumn, productColumn, technicianColumn, dateOpenedColumn });
            openIncidentsListView.Dock = DockStyle.Fill;
            openIncidentsListView.FullRowSelect = true;
            openIncidentsListView.GridLines = true;
            openIncidentsListView.Location = new Point(0, 0);
            openIncidentsListView.Name = "openIncidentsListView";
            openIncidentsListView.Size = new Size(635, 394);
            openIncidentsListView.TabIndex = 0;
            openIncidentsListView.UseCompatibleStateImageBehavior = false;
            openIncidentsListView.View = System.Windows.Forms.View.Details;
            // 
            // incidentIDColumn
            // 
            incidentIDColumn.Text = "Incident ID";
            incidentIDColumn.Width = 80;
            // 
            // titleColumn
            // 
            titleColumn.Text = "Title";
            titleColumn.Width = 180;
            // 
            // customerColumn
            // 
            customerColumn.Text = "Customer";
            customerColumn.Width = 150;
            // 
            // productColumn
            // 
            productColumn.Text = "Product";
            productColumn.Width = 120;
            // 
            // technicianColumn
            // 
            technicianColumn.Text = "Technician";
            technicianColumn.Width = 150;
            // 
            // dateOpenedColumn
            // 
            dateOpenedColumn.Text = "Date Opened";
            dateOpenedColumn.Width = 120;
            // 
            // DisplayOpenIncidentsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(openIncidentsListView);
            Name = "DisplayOpenIncidentsControl";
            Size = new Size(635, 394);
            ResumeLayout(false);
        }

        #endregion

        private ListView openIncidentsListView;
        private ColumnHeader incidentIDColumn;
        private ColumnHeader titleColumn;
        private ColumnHeader customerColumn;
        private ColumnHeader productColumn;
        private ColumnHeader technicianColumn;
        private ColumnHeader dateOpenedColumn;
    }
}
