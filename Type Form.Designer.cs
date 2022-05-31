namespace Project
{
    partial class Type_Form
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
            this.btn_type_cancel = new System.Windows.Forms.Button();
            this.btn_save_type = new System.Windows.Forms.Button();
            this.note_type = new System.Windows.Forms.RichTextBox();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbel2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_company_Name = new System.Windows.Forms.ComboBox();
            this.errorType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_type_cancel
            // 
            this.btn_type_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_type_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_type_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_type_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_type_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_type_cancel.Image = global::Project.Properties.Resources.delete;
            this.btn_type_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_type_cancel.Location = new System.Drawing.Point(851, 537);
            this.btn_type_cancel.Name = "btn_type_cancel";
            this.btn_type_cancel.Size = new System.Drawing.Size(126, 43);
            this.btn_type_cancel.TabIndex = 133;
            this.btn_type_cancel.Text = "Cancel";
            this.btn_type_cancel.UseVisualStyleBackColor = false;
            this.btn_type_cancel.Click += new System.EventHandler(this.btn_type_cancel_Click);
            // 
            // btn_save_type
            // 
            this.btn_save_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save_type.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_save_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_type.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save_type.Image = global::Project.Properties.Resources.Treetog_I_Floppy_Small___Copy;
            this.btn_save_type.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save_type.Location = new System.Drawing.Point(1027, 537);
            this.btn_save_type.Name = "btn_save_type";
            this.btn_save_type.Size = new System.Drawing.Size(118, 43);
            this.btn_save_type.TabIndex = 131;
            this.btn_save_type.Text = "  Save";
            this.btn_save_type.UseVisualStyleBackColor = false;
            this.btn_save_type.Click += new System.EventHandler(this.btn_save_type_Click);
            // 
            // note_type
            // 
            this.note_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.note_type.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.note_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note_type.Location = new System.Drawing.Point(279, 324);
            this.note_type.Name = "note_type";
            this.note_type.Size = new System.Drawing.Size(720, 130);
            this.note_type.TabIndex = 29;
            this.note_type.Text = "";
            this.note_type.TextChanged += new System.EventHandler(this.note_type_TextChanged);
            // 
            // txt_type
            // 
            this.txt_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_type.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.txt_type.Location = new System.Drawing.Point(279, 242);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(716, 28);
            this.txt_type.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(171, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "Notes :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(73, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Company Name :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(118, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Type Name :";
            // 
            // lbel2
            // 
            this.lbel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbel2.AutoSize = true;
            this.lbel2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbel2.ForeColor = System.Drawing.Color.Gray;
            this.lbel2.Location = new System.Drawing.Point(61, 69);
            this.lbel2.Name = "lbel2";
            this.lbel2.Size = new System.Drawing.Size(636, 18);
            this.lbel2.TabIndex = 23;
            this.lbel2.Text = "This is basic horizontal form with labels on left and cost estimation form is the" +
    " default position.";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "Types Form";
            // 
            // combo_company_Name
            // 
            this.combo_company_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_company_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_company_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.combo_company_Name.FormattingEnabled = true;
            this.combo_company_Name.Location = new System.Drawing.Point(279, 186);
            this.combo_company_Name.Name = "combo_company_Name";
            this.combo_company_Name.Size = new System.Drawing.Size(716, 37);
            this.combo_company_Name.TabIndex = 27;
            // 
            // errorType
            // 
            this.errorType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.errorType.AutoSize = true;
            this.errorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.errorType.ForeColor = System.Drawing.Color.Red;
            this.errorType.Location = new System.Drawing.Point(276, 288);
            this.errorType.Name = "errorType";
            this.errorType.Size = new System.Drawing.Size(0, 17);
            this.errorType.TabIndex = 33;
            // 
            // Type_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1157, 628);
            this.Controls.Add(this.errorType);
            this.Controls.Add(this.combo_company_Name);
            this.Controls.Add(this.btn_type_cancel);
            this.Controls.Add(this.btn_save_type);
            this.Controls.Add(this.note_type);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Type_Form";
            this.Text = "Type_Form";
            this.Load += new System.EventHandler(this.Type_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_type_cancel;
        private System.Windows.Forms.Button btn_save_type;
        private System.Windows.Forms.RichTextBox note_type;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_company_Name;
        private System.Windows.Forms.Label errorType;
    }
}