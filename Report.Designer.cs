namespace Project
{
    partial class Report
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_report_cancel = new System.Windows.Forms.Button();
            this.btn_save_report = new System.Windows.Forms.Button();
            this.from_date = new System.Windows.Forms.DateTimePicker();
            this.to_date = new System.Windows.Forms.DateTimePicker();
            this.dvg_report = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_report)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(42, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 23);
            this.label3.TabIndex = 43;
            this.label3.Text = "Choice A Period To :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(13, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 23);
            this.label4.TabIndex = 42;
            this.label4.Text = "Choice A Period  From:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(51, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(636, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "This is basic horizontal form with labels on left and cost estimation form is the" +
    " default position.";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 40;
            this.label1.Text = "Sales Report ";
            // 
            // btn_report_cancel
            // 
            this.btn_report_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_report_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_report_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_report_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report_cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_report_cancel.Image = global::Project.Properties.Resources.delete;
            this.btn_report_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_report_cancel.Location = new System.Drawing.Point(650, 258);
            this.btn_report_cancel.Name = "btn_report_cancel";
            this.btn_report_cancel.Size = new System.Drawing.Size(126, 43);
            this.btn_report_cancel.TabIndex = 134;
            this.btn_report_cancel.Text = "Cancel";
            this.btn_report_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_save_report
            // 
            this.btn_save_report.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save_report.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_save_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_report.ForeColor = System.Drawing.Color.White;
            this.btn_save_report.Image = global::Project.Properties.Resources.Treetog_I_Floppy_Small___Copy;
            this.btn_save_report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save_report.Location = new System.Drawing.Point(824, 258);
            this.btn_save_report.Name = "btn_save_report";
            this.btn_save_report.Size = new System.Drawing.Size(118, 43);
            this.btn_save_report.TabIndex = 133;
            this.btn_save_report.Text = "      Report";
            this.btn_save_report.UseVisualStyleBackColor = false;
            this.btn_save_report.Click += new System.EventHandler(this.btn_save_report_Click);
            // 
            // from_date
            // 
            this.from_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.from_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.from_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.from_date.Location = new System.Drawing.Point(293, 119);
            this.from_date.Name = "from_date";
            this.from_date.Size = new System.Drawing.Size(563, 31);
            this.from_date.TabIndex = 135;
            // 
            // to_date
            // 
            this.to_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.to_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.to_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.to_date.Location = new System.Drawing.Point(299, 185);
            this.to_date.Name = "to_date";
            this.to_date.Size = new System.Drawing.Size(563, 31);
            this.to_date.TabIndex = 136;
            // 
            // dvg_report
            // 
            this.dvg_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_report.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dvg_report.Location = new System.Drawing.Point(0, 307);
            this.dvg_report.Name = "dvg_report";
            this.dvg_report.Size = new System.Drawing.Size(979, 150);
            this.dvg_report.TabIndex = 50;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(979, 457);
            this.Controls.Add(this.dvg_report);
            this.Controls.Add(this.to_date);
            this.Controls.Add(this.from_date);
            this.Controls.Add(this.btn_report_cancel);
            this.Controls.Add(this.btn_save_report);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_report_cancel;
        private System.Windows.Forms.Button btn_save_report;
        private System.Windows.Forms.DateTimePicker from_date;
        private System.Windows.Forms.DateTimePicker to_date;
        private System.Windows.Forms.DataGridView dvg_report;
    }
}