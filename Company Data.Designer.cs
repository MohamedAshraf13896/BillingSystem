namespace Project
{
    partial class Company_Data
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
            this.notecompany_data = new System.Windows.Forms.RichTextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_c_cancel = new System.Windows.Forms.Button();
            this.txt_company_data = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorCompany = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // notecompany_data
            // 
            this.notecompany_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.notecompany_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notecompany_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.notecompany_data.Location = new System.Drawing.Point(282, 278);
            this.notecompany_data.Name = "notecompany_data";
            this.notecompany_data.Size = new System.Drawing.Size(939, 124);
            this.notecompany_data.TabIndex = 24;
            this.notecompany_data.Text = "";
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Image = global::Project.Properties.Resources.Treetog_I_Floppy_Small;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(1155, 474);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(118, 43);
            this.btn_save.TabIndex = 23;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_c_cancel
            // 
            this.btn_c_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_c_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_c_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_c_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_c_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_c_cancel.Image = global::Project.Properties.Resources.delete;
            this.btn_c_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_c_cancel.Location = new System.Drawing.Point(991, 474);
            this.btn_c_cancel.Name = "btn_c_cancel";
            this.btn_c_cancel.Size = new System.Drawing.Size(126, 43);
            this.btn_c_cancel.TabIndex = 133;
            this.btn_c_cancel.Text = "Cancel";
            this.btn_c_cancel.UseVisualStyleBackColor = false;
            this.btn_c_cancel.Click += new System.EventHandler(this.btn_c_cancel_Click);
            // 
            // txt_company_data
            // 
            this.txt_company_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_company_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_company_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.txt_company_data.Location = new System.Drawing.Point(282, 187);
            this.txt_company_data.Name = "txt_company_data";
            this.txt_company_data.Size = new System.Drawing.Size(939, 28);
            this.txt_company_data.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(54, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Company Name :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(152, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Notes :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(55, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(636, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "This is basic horizontal form with labels on left and cost estimation form is the" +
    " default position.";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Company Date Form";
            // 
            // errorCompany
            // 
            this.errorCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.errorCompany.AutoSize = true;
            this.errorCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.errorCompany.ForeColor = System.Drawing.Color.Red;
            this.errorCompany.Location = new System.Drawing.Point(299, 239);
            this.errorCompany.Name = "errorCompany";
            this.errorCompany.Size = new System.Drawing.Size(0, 17);
            this.errorCompany.TabIndex = 25;
            // 
            // Company_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1315, 648);
            this.Controls.Add(this.errorCompany);
            this.Controls.Add(this.notecompany_data);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_c_cancel);
            this.Controls.Add(this.txt_company_data);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Company_Data";
            this.Text = "Company_Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox notecompany_data;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_c_cancel;
        private System.Windows.Forms.TextBox txt_company_data;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorCompany;
    }
}