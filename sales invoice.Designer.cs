namespace Project
{
    partial class sales_invoice
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
            this.btn_save = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_per_discoun = new System.Windows.Forms.NumericUpDown();
            this.txt_paid = new System.Windows.Forms.TextBox();
            this.txt_billstotal = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_rest = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_net = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_valuediscount = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dvg_sales = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_numbersales = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_unites_cancel = new System.Windows.Forms.Button();
            this.cb_sales_clientname = new System.Windows.Forms.ComboBox();
            this.btn_save_item = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.date_now = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_total_sales = new System.Windows.Forms.TextBox();
            this.cb_sales_itemname = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_sellingprice_sales = new System.Windows.Forms.TextBox();
            this.txt_quatity_sales = new System.Windows.Forms.NumericUpDown();
            this.cb_employeename = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_per_discoun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_sales)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quatity_sales)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Image = global::Project.Properties.Resources.Treetog_I_Floppy_Small___Copy;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(1123, 1028);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(118, 43);
            this.btn_save.TabIndex = 158;
            this.btn_save.Text = "   Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DimGray;
            this.label18.Location = new System.Drawing.Point(131, 940);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(227, 29);
            this.label18.TabIndex = 155;
            this.label18.Text = "Employee Name :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_per_discoun);
            this.panel2.Controls.Add(this.txt_paid);
            this.panel2.Controls.Add(this.txt_billstotal);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.txt_rest);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txt_net);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txt_valuediscount);
            this.panel2.Location = new System.Drawing.Point(7, 642);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1596, 277);
            this.panel2.TabIndex = 153;
            // 
            // txt_per_discoun
            // 
            this.txt_per_discoun.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_per_discoun.Location = new System.Drawing.Point(401, 49);
            this.txt_per_discoun.Name = "txt_per_discoun";
            this.txt_per_discoun.Size = new System.Drawing.Size(804, 31);
            this.txt_per_discoun.TabIndex = 161;
            this.txt_per_discoun.ValueChanged += new System.EventHandler(this.txt_per_discoun_ValueChanged);
            // 
            // txt_paid
            // 
            this.txt_paid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paid.Location = new System.Drawing.Point(401, 160);
            this.txt_paid.Name = "txt_paid";
            this.txt_paid.Size = new System.Drawing.Size(804, 31);
            this.txt_paid.TabIndex = 115;
            this.txt_paid.TextChanged += new System.EventHandler(this.txt_paid_TextChanged);
            // 
            // txt_billstotal
            // 
            this.txt_billstotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_billstotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_billstotal.Location = new System.Drawing.Point(401, 12);
            this.txt_billstotal.Name = "txt_billstotal";
            this.txt_billstotal.Size = new System.Drawing.Size(804, 31);
            this.txt_billstotal.TabIndex = 114;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label19.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkGray;
            this.label19.Location = new System.Drawing.Point(20, 246);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(179, 25);
            this.label19.TabIndex = 113;
            this.label19.Text = "Request A form";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(216, 198);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 29);
            this.label15.TabIndex = 112;
            this.label15.Text = "The Rest :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Location = new System.Drawing.Point(229, 163);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 29);
            this.label16.TabIndex = 111;
            this.label16.Text = "Paid Up :";
            // 
            // txt_rest
            // 
            this.txt_rest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_rest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rest.Location = new System.Drawing.Point(401, 198);
            this.txt_rest.Name = "txt_rest";
            this.txt_rest.Size = new System.Drawing.Size(804, 31);
            this.txt_rest.TabIndex = 105;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(69, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 29);
            this.label8.TabIndex = 104;
            this.label8.Text = "Percentage Discount :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(203, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 29);
            this.label12.TabIndex = 103;
            this.label12.Text = "Bills Total :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(224, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 29);
            this.label13.TabIndex = 102;
            this.label13.Text = "The Net  :";
            // 
            // txt_net
            // 
            this.txt_net.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_net.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_net.Location = new System.Drawing.Point(401, 123);
            this.txt_net.Name = "txt_net";
            this.txt_net.Size = new System.Drawing.Size(804, 31);
            this.txt_net.TabIndex = 101;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(137, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(217, 29);
            this.label14.TabIndex = 99;
            this.label14.Text = "Value Discount :";
            // 
            // txt_valuediscount
            // 
            this.txt_valuediscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_valuediscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valuediscount.Location = new System.Drawing.Point(401, 86);
            this.txt_valuediscount.Name = "txt_valuediscount";
            this.txt_valuediscount.Size = new System.Drawing.Size(804, 31);
            this.txt_valuediscount.TabIndex = 98;
            this.txt_valuediscount.TextChanged += new System.EventHandler(this.txt_valuediscount_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label20.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DarkGray;
            this.label20.Location = new System.Drawing.Point(44, 613);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(156, 25);
            this.label20.TabIndex = 152;
            this.label20.Text = "Other Details";
            // 
            // dvg_sales
            // 
            this.dvg_sales.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dvg_sales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvg_sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_sales.Location = new System.Drawing.Point(21, 485);
            this.dvg_sales.Name = "dvg_sales";
            this.dvg_sales.Size = new System.Drawing.Size(1191, 125);
            this.dvg_sales.TabIndex = 151;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(37, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "Item Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(166, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 29);
            this.label5.TabIndex = 66;
            this.label5.Text = "Client Name :";
            // 
            // txt_numbersales
            // 
            this.txt_numbersales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_numbersales.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numbersales.Location = new System.Drawing.Point(387, 52);
            this.txt_numbersales.Name = "txt_numbersales";
            this.txt_numbersales.Size = new System.Drawing.Size(818, 31);
            this.txt_numbersales.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(155, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 29);
            this.label3.TabIndex = 63;
            this.label3.Text = "Bills Number :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(200, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 29);
            this.label4.TabIndex = 62;
            this.label4.Text = "Bills Date :";
            // 
            // btn_unites_cancel
            // 
            this.btn_unites_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_unites_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_unites_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_unites_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_unites_cancel.Image = global::Project.Properties.Resources.delete;
            this.btn_unites_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_unites_cancel.Location = new System.Drawing.Point(956, 1028);
            this.btn_unites_cancel.Name = "btn_unites_cancel";
            this.btn_unites_cancel.Size = new System.Drawing.Size(126, 43);
            this.btn_unites_cancel.TabIndex = 159;
            this.btn_unites_cancel.Text = "Cancel";
            this.btn_unites_cancel.UseVisualStyleBackColor = false;
            this.btn_unites_cancel.Click += new System.EventHandler(this.btn_unites_cancel_Click);
            // 
            // cb_sales_clientname
            // 
            this.cb_sales_clientname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_sales_clientname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sales_clientname.FormattingEnabled = true;
            this.cb_sales_clientname.Location = new System.Drawing.Point(387, 93);
            this.cb_sales_clientname.Name = "cb_sales_clientname";
            this.cb_sales_clientname.Size = new System.Drawing.Size(818, 32);
            this.cb_sales_clientname.TabIndex = 67;
            // 
            // btn_save_item
            // 
            this.btn_save_item.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_save_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_item.ForeColor = System.Drawing.Color.White;
            this.btn_save_item.Image = global::Project.Properties.Resources.add_icon_icons_com_74429;
            this.btn_save_item.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save_item.Location = new System.Drawing.Point(1102, 437);
            this.btn_save_item.Name = "btn_save_item";
            this.btn_save_item.Size = new System.Drawing.Size(110, 42);
            this.btn_save_item.TabIndex = 150;
            this.btn_save_item.Text = "     Add";
            this.btn_save_item.UseVisualStyleBackColor = false;
            this.btn_save_item.Click += new System.EventHandler(this.btn_save_item_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(170, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 29);
            this.label11.TabIndex = 149;
            this.label11.Text = "Selling Price :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.date_now);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cb_sales_clientname);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_numbersales);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(7, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1589, 173);
            this.panel1.TabIndex = 139;
            // 
            // date_now
            // 
            this.date_now.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_now.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_now.Location = new System.Drawing.Point(387, 14);
            this.date_now.Name = "date_now";
            this.date_now.Size = new System.Drawing.Size(818, 31);
            this.date_now.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 140;
            this.label1.Text = "Sales Invoice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(87, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 141;
            this.label2.Text = "Bills Details";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(176, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 29);
            this.label9.TabIndex = 148;
            this.label9.Text = "Items Name :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(256, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 29);
            this.label10.TabIndex = 147;
            this.label10.Text = "Total  :";
            // 
            // txt_total_sales
            // 
            this.txt_total_sales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_total_sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_sales.Location = new System.Drawing.Point(394, 391);
            this.txt_total_sales.Name = "txt_total_sales";
            this.txt_total_sales.Size = new System.Drawing.Size(818, 31);
            this.txt_total_sales.TabIndex = 146;
            // 
            // cb_sales_itemname
            // 
            this.cb_sales_itemname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_sales_itemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sales_itemname.FormattingEnabled = true;
            this.cb_sales_itemname.Location = new System.Drawing.Point(394, 278);
            this.cb_sales_itemname.Name = "cb_sales_itemname";
            this.cb_sales_itemname.Size = new System.Drawing.Size(818, 32);
            this.cb_sales_itemname.TabIndex = 145;
            this.cb_sales_itemname.SelectionChangeCommitted += new System.EventHandler(this.cb_sales_itemname_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(216, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 29);
            this.label7.TabIndex = 144;
            this.label7.Text = "Quantity :";
            // 
            // txt_sellingprice_sales
            // 
            this.txt_sellingprice_sales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_sellingprice_sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sellingprice_sales.Location = new System.Drawing.Point(394, 317);
            this.txt_sellingprice_sales.Name = "txt_sellingprice_sales";
            this.txt_sellingprice_sales.Size = new System.Drawing.Size(818, 31);
            this.txt_sellingprice_sales.TabIndex = 142;
            // 
            // txt_quatity_sales
            // 
            this.txt_quatity_sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quatity_sales.Location = new System.Drawing.Point(394, 354);
            this.txt_quatity_sales.Name = "txt_quatity_sales";
            this.txt_quatity_sales.Size = new System.Drawing.Size(818, 31);
            this.txt_quatity_sales.TabIndex = 160;
            this.txt_quatity_sales.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_quatity_sales.ValueChanged += new System.EventHandler(this.txt_quatity_sales_ValueChanged);
            // 
            // cb_employeename
            // 
            this.cb_employeename.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_employeename.FormattingEnabled = true;
            this.cb_employeename.Location = new System.Drawing.Point(408, 936);
            this.cb_employeename.Name = "cb_employeename";
            this.cb_employeename.Size = new System.Drawing.Size(804, 33);
            this.cb_employeename.TabIndex = 161;
            // 
            // sales_invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1404, 1100);
            this.Controls.Add(this.cb_employeename);
            this.Controls.Add(this.txt_quatity_sales);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.dvg_sales);
            this.Controls.Add(this.btn_unites_cancel);
            this.Controls.Add(this.btn_save_item);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_total_sales);
            this.Controls.Add(this.cb_sales_itemname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_sellingprice_sales);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sales_invoice";
            this.Text = "sales_invoice";
            this.Load += new System.EventHandler(this.sales_invoice_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_per_discoun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_sales)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quatity_sales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_paid;
        private System.Windows.Forms.TextBox txt_billstotal;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_rest;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_net;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_valuediscount;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dvg_sales;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_numbersales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_unites_cancel;
        private System.Windows.Forms.ComboBox cb_sales_clientname;
        private System.Windows.Forms.Button btn_save_item;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_total_sales;
        private System.Windows.Forms.ComboBox cb_sales_itemname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_sellingprice_sales;
        private System.Windows.Forms.DateTimePicker date_now;
        private System.Windows.Forms.NumericUpDown txt_quatity_sales;
        private System.Windows.Forms.NumericUpDown txt_per_discoun;
        private System.Windows.Forms.ComboBox cb_employeename;
    }
}