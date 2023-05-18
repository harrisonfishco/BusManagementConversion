namespace Memoranda.Bus
{
    partial class BusDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusDialog));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.seatsField = new System.Windows.Forms.NumericUpDown();
            this.seatsLabel = new System.Windows.Forms.Label();
            this.idField = new System.Windows.Forms.NumericUpDown();
            this.idLabel = new System.Windows.Forms.Label();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatsField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idField)).BeginInit();
            this.footerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.headerPanel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.groupBox, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.footerPanel, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.34891F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.65109F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(343, 422);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.SystemColors.Window;
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerPanel.Location = new System.Drawing.Point(3, 3);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(337, 90);
            this.headerPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(144, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bus";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.seatsField);
            this.groupBox.Controls.Add(this.seatsLabel);
            this.groupBox.Controls.Add(this.idField);
            this.groupBox.Controls.Add(this.idLabel);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox.Location = new System.Drawing.Point(75, 121);
            this.groupBox.Margin = new System.Windows.Forms.Padding(75, 25, 75, 50);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.groupBox.Size = new System.Drawing.Size(193, 167);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            // 
            // seatsField
            // 
            this.seatsField.Dock = System.Windows.Forms.DockStyle.Top;
            this.seatsField.Location = new System.Drawing.Point(20, 128);
            this.seatsField.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.seatsField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seatsField.Name = "seatsField";
            this.seatsField.Size = new System.Drawing.Size(153, 26);
            this.seatsField.TabIndex = 4;
            this.seatsField.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // seatsLabel
            // 
            this.seatsLabel.AutoSize = true;
            this.seatsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.seatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatsLabel.Location = new System.Drawing.Point(20, 88);
            this.seatsLabel.Name = "seatsLabel";
            this.seatsLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.seatsLabel.Size = new System.Drawing.Size(144, 40);
            this.seatsLabel.TabIndex = 3;
            this.seatsLabel.Text = "Number of Seats";
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
            this.idField.Size = new System.Drawing.Size(153, 26);
            this.idField.TabIndex = 2;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.footerPanel.Location = new System.Drawing.Point(3, 341);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(337, 78);
            this.footerPanel.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(181, 25);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(130, 34);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancel);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(24, 25);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(130, 34);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.ok);
            // 
            // BusDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(343, 422);
            this.Controls.Add(this.tableLayoutPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(365, 478);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(365, 478);
            this.Name = "BusDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bus";
            this.TopMost = true;
            this.tableLayoutPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatsField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idField)).EndInit();
            this.footerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.NumericUpDown seatsField;
        private System.Windows.Forms.Label seatsLabel;
        private System.Windows.Forms.NumericUpDown idField;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
    }
}