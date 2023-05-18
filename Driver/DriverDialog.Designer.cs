namespace Memoranda.Driver
{
    partial class DriverDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverDialog));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.idField = new System.Windows.Forms.NumericUpDown();
            this.nameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneField = new System.Windows.Forms.TextBox();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nameField = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.74882F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.25118F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(343, 506);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.SystemColors.Window;
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerPanel.Location = new System.Drawing.Point(3, 3);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(337, 90);
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
            this.headerLabel.Size = new System.Drawing.Size(174, 90);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Driver";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.phoneField);
            this.groupBox.Controls.Add(this.phoneLabel);
            this.groupBox.Controls.Add(this.nameField);
            this.groupBox.Controls.Add(this.nameLabel);
            this.groupBox.Controls.Add(this.idField);
            this.groupBox.Controls.Add(this.idLabel);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(75, 121);
            this.groupBox.Margin = new System.Windows.Forms.Padding(75, 25, 75, 50);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.groupBox.Size = new System.Drawing.Size(193, 251);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
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
            this.idField.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(20, 88);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.nameLabel.Size = new System.Drawing.Size(55, 40);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(20, 154);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.phoneLabel.Size = new System.Drawing.Size(127, 40);
            this.phoneLabel.TabIndex = 4;
            this.phoneLabel.Text = "Phone Number";
            // 
            // phoneField
            // 
            this.phoneField.Dock = System.Windows.Forms.DockStyle.Top;
            this.phoneField.Location = new System.Drawing.Point(20, 194);
            this.phoneField.Name = "phoneField";
            this.phoneField.Size = new System.Drawing.Size(153, 26);
            this.phoneField.TabIndex = 3;
            // 
            // footerPanel
            // 
            this.footerPanel.Controls.Add(this.cancelButton);
            this.footerPanel.Controls.Add(this.okButton);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footerPanel.Location = new System.Drawing.Point(3, 425);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(337, 78);
            this.footerPanel.TabIndex = 2;
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
            // nameField
            // 
            this.nameField.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameField.Location = new System.Drawing.Point(20, 128);
            this.nameField.MaxLength = 25;
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(153, 26);
            this.nameField.TabIndex = 2;
            // 
            // DriverDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(343, 506);
            this.Controls.Add(this.tableLayoutPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(365, 562);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(365, 562);
            this.Name = "DriverDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Driver";
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
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.NumericUpDown idField;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneField;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox nameField;
    }
}