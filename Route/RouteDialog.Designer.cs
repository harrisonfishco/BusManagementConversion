namespace Memoranda.Route
{
    partial class RouteDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteDialog));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.fieldBox = new System.Windows.Forms.GroupBox();
            this.durationField = new System.Windows.Forms.TextBox();
            this.durationLabel = new System.Windows.Forms.Label();
            this.distanceField = new System.Windows.Forms.TextBox();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.mapLabel = new System.Windows.Forms.Label();
            this.mapPanel = new System.Windows.Forms.Panel();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.fieldBox.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.headerPanel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.fieldBox, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.mapLabel, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.mapPanel, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.footerPanel, 0, 4);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.86421F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.13579F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1221, 1152);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.SystemColors.Window;
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerPanel.Location = new System.Drawing.Point(3, 3);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1215, 78);
            this.headerPanel.TabIndex = 0;
            // 
            // headerLabel
            // 
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.Maroon;
            this.headerLabel.Image = ((System.Drawing.Image)(resources.GetObject("headerLabel.Image")));
            this.headerLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.headerLabel.Location = new System.Drawing.Point(0, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.headerLabel.Size = new System.Drawing.Size(181, 78);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Route";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fieldBox
            // 
            this.fieldBox.Controls.Add(this.durationField);
            this.fieldBox.Controls.Add(this.durationLabel);
            this.fieldBox.Controls.Add(this.distanceField);
            this.fieldBox.Controls.Add(this.distanceLabel);
            this.fieldBox.Controls.Add(this.nameField);
            this.fieldBox.Controls.Add(this.nameLabel);
            this.fieldBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fieldBox.Location = new System.Drawing.Point(500, 109);
            this.fieldBox.Margin = new System.Windows.Forms.Padding(500, 25, 500, 25);
            this.fieldBox.Name = "fieldBox";
            this.fieldBox.Padding = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.fieldBox.Size = new System.Drawing.Size(221, 250);
            this.fieldBox.TabIndex = 1;
            this.fieldBox.TabStop = false;
            // 
            // durationField
            // 
            this.durationField.Dock = System.Windows.Forms.DockStyle.Top;
            this.durationField.Enabled = false;
            this.durationField.Location = new System.Drawing.Point(20, 194);
            this.durationField.Name = "durationField";
            this.durationField.Size = new System.Drawing.Size(181, 26);
            this.durationField.TabIndex = 5;
            this.durationField.Text = "0";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.durationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationLabel.Location = new System.Drawing.Point(20, 154);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.durationLabel.Size = new System.Drawing.Size(158, 40);
            this.durationLabel.TabIndex = 4;
            this.durationLabel.Text = "Duration (Minutes)";
            // 
            // distanceField
            // 
            this.distanceField.Dock = System.Windows.Forms.DockStyle.Top;
            this.distanceField.Enabled = false;
            this.distanceField.Location = new System.Drawing.Point(20, 128);
            this.distanceField.Name = "distanceField";
            this.distanceField.Size = new System.Drawing.Size(181, 26);
            this.distanceField.TabIndex = 3;
            this.distanceField.Text = "0";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.distanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceLabel.Location = new System.Drawing.Point(20, 88);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.distanceLabel.Size = new System.Drawing.Size(138, 40);
            this.distanceLabel.TabIndex = 2;
            this.distanceLabel.Text = "Distance (Miles)";
            // 
            // nameField
            // 
            this.nameField.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameField.Location = new System.Drawing.Point(20, 62);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(181, 26);
            this.nameField.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(20, 22);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.nameLabel.Size = new System.Drawing.Size(55, 40);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // mapLabel
            // 
            this.mapLabel.AutoSize = true;
            this.mapLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapLabel.Location = new System.Drawing.Point(3, 384);
            this.mapLabel.Name = "mapLabel";
            this.mapLabel.Size = new System.Drawing.Size(1215, 30);
            this.mapLabel.TabIndex = 2;
            this.mapLabel.Text = "Map - Select Two Points";
            this.mapLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mapPanel
            // 
            this.mapPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapPanel.Location = new System.Drawing.Point(3, 417);
            this.mapPanel.Name = "mapPanel";
            this.mapPanel.Size = new System.Drawing.Size(1215, 667);
            this.mapPanel.TabIndex = 3;
            // 
            // footerPanel
            // 
            this.footerPanel.Controls.Add(this.cancelButton);
            this.footerPanel.Controls.Add(this.okButton);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footerPanel.Location = new System.Drawing.Point(3, 1090);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(1215, 59);
            this.footerPanel.TabIndex = 4;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(1076, 16);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(130, 34);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancel);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(940, 16);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(130, 34);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.ok);
            // 
            // RouteDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(1221, 1152);
            this.Controls.Add(this.tableLayoutPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1243, 1208);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1243, 1208);
            this.Name = "RouteDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RouteDialog_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.fieldBox.ResumeLayout(false);
            this.fieldBox.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.GroupBox fieldBox;
        private System.Windows.Forms.TextBox durationField;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.TextBox distanceField;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label mapLabel;
        private System.Windows.Forms.Panel mapPanel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
    }
}