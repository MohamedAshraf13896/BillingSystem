namespace Project
{
    partial class Unites_form
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
            this.noteunite_data = new System.Windows.Forms.RichTextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_c_cancel = new System.Windows.Forms.Button();
            this.txt_unite_data = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Error_Units = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // noteunite_data
            // 
            this.noteunite_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.noteunite_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteunite_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.noteunite_data.Location = new System.Drawing.Point(227, 321);
            this.noteunite_data.Name = "noteunite_data";
            this.noteunite_data.Size = new System.Drawing.Size(1003, 130);
            this.noteunite_data.TabIndex = 32;
            this.noteunite_data.Text = "";
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Image = global::Project.Properties.Resources.Treetog_I_Floppy_Small___Copy;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(1259, 514);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(118, 43);
            this.btn_save.TabIndex = 135;
            this.btn_save.Text = "   Save";
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
            this.btn_c_cancel.Location = new System.Drawing.Point(1070, 514);
            this.btn_c_cancel.Name = "btn_c_cancel";
            this.btn_c_cancel.Size = new System.Drawing.Size(126, 43);
            this.btn_c_cancel.TabIndex = 132;
            this.btn_c_cancel.Text = "Cancel";
            this.btn_c_cancel.UseVisualStyleBackColor = false;
            this.btn_c_cancel.Click += new System.EventHandler(this.btn_c_cancel_Click);
            // 
            // txt_unite_data
            // 
            this.txt_unite_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_unite_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_unite_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.txt_unite_data.Location = new System.Drawing.Point(227, 233);
            this.txt_unite_data.Name = "txt_unite_data";
            this.txt_unite_data.Size = new System.Drawing.Size(1003, 28);
            this.txt_unite_data.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(38, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Unite Name :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(98, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Notes :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(54, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(636, 18);
            this.label2.TabIndex = 26;
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
            this.label1.Location = new System.Drawing.Point(37, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Unites Form";
            // 
            // Error_Units
            // 
            this.Error_Units.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Error_Units.AutoSize = true;
            this.Error_Units.BackColor = System.Drawing.Color.LightGray;
            this.Error_Units.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Error_Units.ForeColor = System.Drawing.Color.Red;
            this.Error_Units.Location = new System.Drawing.Point(240, 281);
            this.Error_Units.Name = "Error_Units";
            this.Error_Units.Size = new System.Drawing.Size(0, 17);
            this.Error_Units.TabIndex = 33;
            // 
            // Unites_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1399, 688);
            this.Controls.Add(this.Error_Units);
            this.Controls.Add(this.noteunite_data);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_c_cancel);
            this.Controls.Add(this.txt_unite_data);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Unites_form";
            this.Text = "Item_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox noteunite_data;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_c_cancel;
        private System.Windows.Forms.TextBox txt_unite_data;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Error_Units;
    }
}