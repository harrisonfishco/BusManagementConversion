namespace Memoranda.Tour
{
    partial class TourDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TourDialog));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.routeField = new System.Windows.Forms.ComboBox();
            this.routeLabel = new System.Windows.Forms.Label();
            this.busField = new System.Windows.Forms.ComboBox();
            this.busLabel = new System.Windows.Forms.Label();
            this.driverField = new System.Windows.Forms.ComboBox();
            this.driverLabel = new System.Windows.Forms.Label();
            this.timeField = new System.Windows.Forms.DateTimePicker();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateField = new System.Windows.Forms.MonthCalendar();
            this.dateLabel = new System.Windows.Forms.Label();
            this.idField = new System.Windows.Forms.NumericUpDown();
            this.idLabel = new System.Windows.Forms.Label();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idField)).BeginInit();
            this.footerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.headerPanel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.groupBox, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.footerPanel, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(482, 872);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.SystemColors.Window;
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerPanel.Location = new System.Drawing.Point(3, 3);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(476, 78);
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
            this.headerLabel.Size = new System.Drawing.Size(167, 78);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Tour";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.routeField);
            this.groupBox.Controls.Add(this.routeLabel);
            this.groupBox.Controls.Add(this.busField);
            this.groupBox.Controls.Add(this.busLabel);
            this.groupBox.Controls.Add(this.driverField);
            this.groupBox.Controls.Add(this.driverLabel);
            this.groupBox.Controls.Add(this.timeField);
            this.groupBox.Controls.Add(this.timeLabel);
            this.groupBox.Controls.Add(this.dateField);
            this.groupBox.Controls.Add(this.dateLabel);
            this.groupBox.Controls.Add(this.idField);
            this.groupBox.Controls.Add(this.idLabel);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(65, 109);
            this.groupBox.Margin = new System.Windows.Forms.Padding(65, 25, 65, 25);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.groupBox.Size = new System.Drawing.Size(352, 674);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            // 
            // routeField
            // 
            this.routeField.Dock = System.Windows.Forms.DockStyle.Top;
            this.routeField.FormattingEnabled = true;
            this.routeField.Location = new System.Drawing.Point(20, 623);
            this.routeField.Name = "routeField";
            this.routeField.Size = new System.Drawing.Size(312, 28);
            this.routeField.TabIndex = 11;
            // 
            // routeLabel
            // 
            this.routeLabel.AutoSize = true;
            this.routeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.routeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routeLabel.Location = new System.Drawing.Point(20, 583);
            this.routeLabel.Name = "routeLabel";
            this.routeLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.routeLabel.Size = new System.Drawing.Size(58, 40);
            this.routeLabel.TabIndex = 10;
            this.routeLabel.Text = "Route";
            // 
            // busField
            // 
            this.busField.Dock = System.Windows.Forms.DockStyle.Top;
            this.busField.FormattingEnabled = true;
            this.busField.Location = new System.Drawing.Point(20, 555);
            this.busField.Name = "busField";
            this.busField.Size = new System.Drawing.Size(312, 28);
            this.busField.TabIndex = 9;
            // 
            // busLabel
            // 
            this.busLabel.AutoSize = true;
            this.busLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.busLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busLabel.Location = new System.Drawing.Point(20, 515);
            this.busLabel.Name = "busLabel";
            this.busLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.busLabel.Size = new System.Drawing.Size(40, 40);
            this.busLabel.TabIndex = 8;
            this.busLabel.Text = "Bus";
            // 
            // driverField
            // 
            this.driverField.Dock = System.Windows.Forms.DockStyle.Top;
            this.driverField.FormattingEnabled = true;
            this.driverField.Location = new System.Drawing.Point(20, 487);
            this.driverField.Name = "driverField";
            this.driverField.Size = new System.Drawing.Size(312, 28);
            this.driverField.TabIndex = 7;
            // 
            // driverLabel
            // 
            this.driverLabel.AutoSize = true;
            this.driverLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.driverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverLabel.Location = new System.Drawing.Point(20, 447);
            this.driverLabel.Name = "driverLabel";
            this.driverLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.driverLabel.Size = new System.Drawing.Size(56, 40);
            this.driverLabel.TabIndex = 6;
            this.driverLabel.Text = "Driver";
            // 
            // timeField
            // 
            this.timeField.CustomFormat = "h:mm tt";
            this.timeField.Dock = System.Windows.Forms.DockStyle.Top;
            this.timeField.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeField.Location = new System.Drawing.Point(20, 421);
            this.timeField.Name = "timeField";
            this.timeField.ShowUpDown = true;
            this.timeField.Size = new System.Drawing.Size(312, 26);
            this.timeField.TabIndex = 5;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(20, 381);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.timeLabel.Size = new System.Drawing.Size(47, 40);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "Time";
            // 
            // dateField
            // 
            this.dateField.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateField.Location = new System.Drawing.Point(20, 128);
            this.dateField.MaxSelectionCount = 1;
            this.dateField.MinDate = new System.DateTime(2023, 5, 17, 0, 0, 0, 0);
            this.dateField.Name = "dateField";
            this.dateField.TabIndex = 3;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(20, 88);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.dateLabel.Size = new System.Drawing.Size(48, 40);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Date";
            // 
            // idField
            // 
            this.idField.Dock = System.Windows.Forms.DockStyle.Top;
            this.idField.Location = new System.Drawing.Point(20, 62);
            this.idField.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(312, 26);
            this.idField.TabIndex = 1;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(20, 22);
            this.idLabel.Name = "idLabel";
            this.idLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.idLabel.Size = new System.Drawing.Size(28, 40);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID";
            // 
            // footerPanel
            // 
            this.footerPanel.Controls.Add(this.cancelButton);
            this.footerPanel.Controls.Add(this.okButton);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footerPanel.Location = new System.Drawing.Point(3, 811);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(476, 58);
            this.footerPanel.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(337, 15);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(130, 34);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(201, 15);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(130, 34);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // TourDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(482, 872);
            this.Controls.Add(this.tableLayoutPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(504, 928);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(504, 928);
            this.Name = "TourDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tour";
            this.TopMost = true;
            this.tableLayoutPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idField)).EndInit();
            this.footerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.NumericUpDown idField;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.DateTimePicker timeField;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.MonthCalendar dateField;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.ComboBox driverField;
        private System.Windows.Forms.Label driverLabel;
        private System.Windows.Forms.Label routeLabel;
        private System.Windows.Forms.ComboBox busField;
        private System.Windows.Forms.Label busLabel;
        private System.Windows.Forms.ComboBox routeField;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
    }
}