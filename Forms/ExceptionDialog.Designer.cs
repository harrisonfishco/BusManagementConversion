namespace Memoranda.Forms
{
    partial class ExceptionDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExceptionDialog));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.header2Panel = new System.Windows.Forms.Panel();
            this.header2Label = new System.Windows.Forms.Label();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionText = new System.Windows.Forms.Label();
            this.stacktraceLabel = new System.Windows.Forms.Label();
            this.stacktraceField = new System.Windows.Forms.RichTextBox();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.header2Panel.SuspendLayout();
            this.bodyPanel.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.headerPanel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.header2Panel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.bodyPanel, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.footerPanel, 0, 3);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(612, 826);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.SystemColors.Window;
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerPanel.Location = new System.Drawing.Point(3, 3);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(606, 74);
            this.headerPanel.TabIndex = 0;
            // 
            // headerLabel
            // 
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Image = ((System.Drawing.Image)(resources.GetObject("headerLabel.Image")));
            this.headerLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.headerLabel.Location = new System.Drawing.Point(0, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.headerLabel.Size = new System.Drawing.Size(293, 74);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Problem Occured";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // header2Panel
            // 
            this.header2Panel.BackColor = System.Drawing.SystemColors.Window;
            this.header2Panel.Controls.Add(this.header2Label);
            this.header2Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.header2Panel.Location = new System.Drawing.Point(3, 83);
            this.header2Panel.Name = "header2Panel";
            this.header2Panel.Size = new System.Drawing.Size(606, 84);
            this.header2Panel.TabIndex = 1;
            // 
            // header2Label
            // 
            this.header2Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.header2Label.Location = new System.Drawing.Point(0, 0);
            this.header2Label.Name = "header2Label";
            this.header2Label.Size = new System.Drawing.Size(606, 84);
            this.header2Label.TabIndex = 0;
            this.header2Label.Text = resources.GetString("header2Label.Text");
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.stacktraceField);
            this.bodyPanel.Controls.Add(this.stacktraceLabel);
            this.bodyPanel.Controls.Add(this.descriptionText);
            this.bodyPanel.Controls.Add(this.descriptionLabel);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(3, 173);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(606, 586);
            this.bodyPanel.TabIndex = 2;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(0, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.descriptionLabel.Size = new System.Drawing.Size(105, 40);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "Description:";
            // 
            // descriptionText
            // 
            this.descriptionText.AutoSize = true;
            this.descriptionText.Dock = System.Windows.Forms.DockStyle.Top;
            this.descriptionText.Location = new System.Drawing.Point(0, 40);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(181, 20);
            this.descriptionText.TabIndex = 1;
            this.descriptionText.Text = "ERROR DESCRIPTION";
            // 
            // stacktraceLabel
            // 
            this.stacktraceLabel.AutoSize = true;
            this.stacktraceLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.stacktraceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stacktraceLabel.Location = new System.Drawing.Point(0, 60);
            this.stacktraceLabel.Name = "stacktraceLabel";
            this.stacktraceLabel.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.stacktraceLabel.Size = new System.Drawing.Size(110, 50);
            this.stacktraceLabel.TabIndex = 2;
            this.stacktraceLabel.Text = "Stack Trace:";
            // 
            // stacktraceField
            // 
            this.stacktraceField.AcceptsTab = true;
            this.stacktraceField.BackColor = System.Drawing.SystemColors.Window;
            this.stacktraceField.Cursor = System.Windows.Forms.Cursors.Default;
            this.stacktraceField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stacktraceField.Location = new System.Drawing.Point(0, 110);
            this.stacktraceField.Name = "stacktraceField";
            this.stacktraceField.ReadOnly = true;
            this.stacktraceField.Size = new System.Drawing.Size(606, 476);
            this.stacktraceField.TabIndex = 3;
            this.stacktraceField.Text = "";
            // 
            // footerPanel
            // 
            this.footerPanel.Controls.Add(this.closeButton);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footerPanel.Location = new System.Drawing.Point(3, 765);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(606, 58);
            this.footerPanel.TabIndex = 3;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(467, 15);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(130, 34);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeClick);
            // 
            // ExceptionDialog
            // 
            this.AcceptButton = this.closeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(612, 826);
            this.Controls.Add(this.tableLayoutPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(634, 882);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(634, 882);
            this.Name = "ExceptionDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exception Thrown";
            this.TopMost = true;
            this.tableLayoutPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.header2Panel.ResumeLayout(false);
            this.bodyPanel.ResumeLayout(false);
            this.bodyPanel.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel header2Panel;
        private System.Windows.Forms.Label header2Label;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label stacktraceLabel;
        private System.Windows.Forms.Label descriptionText;
        private System.Windows.Forms.RichTextBox stacktraceField;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Button closeButton;
    }
}