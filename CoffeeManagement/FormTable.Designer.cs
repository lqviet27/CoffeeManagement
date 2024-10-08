﻿namespace CoffeeManagement
{
    partial class FormTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTable));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_AddDrink = new System.Windows.Forms.Button();
            this.cb_Drink = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_NameTableAdd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.cb_DrinkType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_SwitchTable = new System.Windows.Forms.Button();
            this.grb_SwitchTable = new System.Windows.Forms.GroupBox();
            this.txt_FromTable = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_AcceptSwitch = new System.Windows.Forms.Button();
            this.cb_ToTable = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_deleteBill = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pn_Bill = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Purchase = new System.Windows.Forms.Button();
            this.txt_Total = new System.Windows.Forms.Label();
            this.txt_Status = new System.Windows.Forms.Label();
            this.txt_NameTable = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pn_Table = new System.Windows.Forms.Panel();
            this.printDialogBill = new System.Windows.Forms.PrintDialog();
            this.printDocumentBill = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.grb_SwitchTable.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1650, 814);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1650, 814);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.groupBox4);
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1650, 814);
            this.panel5.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.btn_SwitchTable);
            this.panel2.Controls.Add(this.grb_SwitchTable);
            this.panel2.Location = new System.Drawing.Point(353, 18);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 764);
            this.panel2.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btn_AddDrink);
            this.groupBox2.Controls.Add(this.cb_Drink);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txt_NameTableAdd);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.numericUpDownQuantity);
            this.groupBox2.Controls.Add(this.cb_DrinkType);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(23, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(408, 225);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Drink";
            // 
            // btn_AddDrink
            // 
            this.btn_AddDrink.Image = global::CoffeeManagement.Properties.Resources.icons8_add_32;
            this.btn_AddDrink.Location = new System.Drawing.Point(144, 178);
            this.btn_AddDrink.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddDrink.Name = "btn_AddDrink";
            this.btn_AddDrink.Size = new System.Drawing.Size(133, 41);
            this.btn_AddDrink.TabIndex = 10;
            this.btn_AddDrink.UseVisualStyleBackColor = true;
            this.btn_AddDrink.Click += new System.EventHandler(this.btn_AddDrink_Click);
            // 
            // cb_Drink
            // 
            this.cb_Drink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Drink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cb_Drink.FormattingEnabled = true;
            this.cb_Drink.Location = new System.Drawing.Point(127, 100);
            this.cb_Drink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Drink.Name = "cb_Drink";
            this.cb_Drink.Size = new System.Drawing.Size(253, 28);
            this.cb_Drink.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(15, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 20);
            this.label15.TabIndex = 8;
            this.label15.Text = "Drink :";
            // 
            // txt_NameTableAdd
            // 
            this.txt_NameTableAdd.Location = new System.Drawing.Point(127, 22);
            this.txt_NameTableAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NameTableAdd.Name = "txt_NameTableAdd";
            this.txt_NameTableAdd.ReadOnly = true;
            this.txt_NameTableAdd.Size = new System.Drawing.Size(253, 30);
            this.txt_NameTableAdd.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(15, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 20);
            this.label14.TabIndex = 6;
            this.label14.Text = "Table :";
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDownQuantity.Location = new System.Drawing.Point(127, 134);
            this.numericUpDownQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(255, 26);
            this.numericUpDownQuantity.TabIndex = 4;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cb_DrinkType
            // 
            this.cb_DrinkType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_DrinkType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cb_DrinkType.FormattingEnabled = true;
            this.cb_DrinkType.Items.AddRange(new object[] {
            "Type1",
            "Type2",
            "Type3",
            "Type4"});
            this.cb_DrinkType.Location = new System.Drawing.Point(127, 62);
            this.cb_DrinkType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_DrinkType.Name = "cb_DrinkType";
            this.cb_DrinkType.Size = new System.Drawing.Size(253, 28);
            this.cb_DrinkType.TabIndex = 2;
            this.cb_DrinkType.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrinkType_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(15, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Drink Type :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(15, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Quantity : ";
            // 
            // btn_SwitchTable
            // 
            this.btn_SwitchTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SwitchTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SwitchTable.Image = global::CoffeeManagement.Properties.Resources.icons8_switch_32_2;
            this.btn_SwitchTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SwitchTable.Location = new System.Drawing.Point(49, 370);
            this.btn_SwitchTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SwitchTable.Name = "btn_SwitchTable";
            this.btn_SwitchTable.Size = new System.Drawing.Size(237, 54);
            this.btn_SwitchTable.TabIndex = 8;
            this.btn_SwitchTable.Text = "      Switch Table";
            this.btn_SwitchTable.UseVisualStyleBackColor = true;
            this.btn_SwitchTable.Click += new System.EventHandler(this.btn_SwitchTable_Click);
            // 
            // grb_SwitchTable
            // 
            this.grb_SwitchTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grb_SwitchTable.Controls.Add(this.txt_FromTable);
            this.grb_SwitchTable.Controls.Add(this.label16);
            this.grb_SwitchTable.Controls.Add(this.btn_AcceptSwitch);
            this.grb_SwitchTable.Controls.Add(this.cb_ToTable);
            this.grb_SwitchTable.Controls.Add(this.label17);
            this.grb_SwitchTable.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grb_SwitchTable.Location = new System.Drawing.Point(23, 450);
            this.grb_SwitchTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_SwitchTable.Name = "grb_SwitchTable";
            this.grb_SwitchTable.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_SwitchTable.Size = new System.Drawing.Size(408, 164);
            this.grb_SwitchTable.TabIndex = 13;
            this.grb_SwitchTable.TabStop = false;
            this.grb_SwitchTable.Text = "Switch Table";
            this.grb_SwitchTable.Visible = false;
            // 
            // txt_FromTable
            // 
            this.txt_FromTable.Location = new System.Drawing.Point(75, 34);
            this.txt_FromTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_FromTable.Name = "txt_FromTable";
            this.txt_FromTable.ReadOnly = true;
            this.txt_FromTable.Size = new System.Drawing.Size(161, 30);
            this.txt_FromTable.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label16.Location = new System.Drawing.Point(5, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 20);
            this.label16.TabIndex = 6;
            this.label16.Text = "From: ";
            // 
            // btn_AcceptSwitch
            // 
            this.btn_AcceptSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AcceptSwitch.Image = global::CoffeeManagement.Properties.Resources.icons8_arrow_32;
            this.btn_AcceptSwitch.Location = new System.Drawing.Point(256, 34);
            this.btn_AcceptSwitch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AcceptSwitch.Name = "btn_AcceptSwitch";
            this.btn_AcceptSwitch.Size = new System.Drawing.Size(68, 82);
            this.btn_AcceptSwitch.TabIndex = 5;
            this.btn_AcceptSwitch.UseVisualStyleBackColor = true;
            this.btn_AcceptSwitch.Click += new System.EventHandler(this.btn_AcceptSwitch_Click);
            // 
            // cb_ToTable
            // 
            this.cb_ToTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ToTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cb_ToTable.FormattingEnabled = true;
            this.cb_ToTable.Location = new System.Drawing.Point(75, 87);
            this.cb_ToTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_ToTable.Name = "cb_ToTable";
            this.cb_ToTable.Size = new System.Drawing.Size(161, 28);
            this.cb_ToTable.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label17.Location = new System.Drawing.Point(5, 91);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 20);
            this.label17.TabIndex = 1;
            this.label17.Text = "To: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btn_deleteBill);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.pn_Bill);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.btn_Print);
            this.groupBox4.Controls.Add(this.btn_Purchase);
            this.groupBox4.Controls.Add(this.txt_Total);
            this.groupBox4.Controls.Add(this.txt_Status);
            this.groupBox4.Controls.Add(this.txt_NameTable);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox4.Location = new System.Drawing.Point(817, 18);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(821, 764);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bill";
            // 
            // btn_deleteBill
            // 
            this.btn_deleteBill.Image = global::CoffeeManagement.Properties.Resources.icons8_bin_32;
            this.btn_deleteBill.Location = new System.Drawing.Point(695, 18);
            this.btn_deleteBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_deleteBill.Name = "btn_deleteBill";
            this.btn_deleteBill.Size = new System.Drawing.Size(43, 47);
            this.btn_deleteBill.TabIndex = 30;
            this.btn_deleteBill.UseVisualStyleBackColor = true;
            this.btn_deleteBill.Click += new System.EventHandler(this.btn_deleteBill_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(637, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(505, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(351, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "ID            Drink                               Quantity";
            // 
            // pn_Bill
            // 
            this.pn_Bill.Location = new System.Drawing.Point(9, 105);
            this.pn_Bill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_Bill.Name = "pn_Bill";
            this.pn_Bill.Size = new System.Drawing.Size(801, 598);
            this.pn_Bill.TabIndex = 26;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(529, 719);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 22);
            this.label21.TabIndex = 25;
            this.label21.Text = "VND";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(71, 719);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 22);
            this.label19.TabIndex = 23;
            this.label19.Text = "Totals : ";
            // 
            // btn_Print
            // 
            this.btn_Print.Image = global::CoffeeManagement.Properties.Resources.icons8_print_32;
            this.btn_Print.Location = new System.Drawing.Point(743, 18);
            this.btn_Print.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(68, 49);
            this.btn_Print.TabIndex = 22;
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_Purchase
            // 
            this.btn_Purchase.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Purchase.Image = global::CoffeeManagement.Properties.Resources.icons8_purchase_32;
            this.btn_Purchase.Location = new System.Drawing.Point(717, 708);
            this.btn_Purchase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Purchase.Name = "btn_Purchase";
            this.btn_Purchase.Size = new System.Drawing.Size(96, 49);
            this.btn_Purchase.TabIndex = 21;
            this.btn_Purchase.UseVisualStyleBackColor = true;
            this.btn_Purchase.Click += new System.EventHandler(this.btn_Purchase_Click);
            // 
            // txt_Total
            // 
            this.txt_Total.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_Total.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total.Location = new System.Drawing.Point(363, 713);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(160, 36);
            this.txt_Total.TabIndex = 19;
            this.txt_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txt_Total.Click += new System.EventHandler(this.txt_Total_Click);
            // 
            // txt_Status
            // 
            this.txt_Status.AutoSize = true;
            this.txt_Status.Location = new System.Drawing.Point(253, 34);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(57, 22);
            this.txt_Status.TabIndex = 1;
            this.txt_Status.Text = "Status";
            // 
            // txt_NameTable
            // 
            this.txt_NameTable.AutoSize = true;
            this.txt_NameTable.Location = new System.Drawing.Point(69, 34);
            this.txt_NameTable.Name = "txt_NameTable";
            this.txt_NameTable.Size = new System.Drawing.Size(55, 22);
            this.txt_NameTable.TabIndex = 0;
            this.txt_NameTable.Text = "Table";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.pn_Table);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(344, 783);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Table";
            // 
            // pn_Table
            // 
            this.pn_Table.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pn_Table.AutoScroll = true;
            this.pn_Table.Location = new System.Drawing.Point(5, 37);
            this.pn_Table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_Table.Name = "pn_Table";
            this.pn_Table.Size = new System.Drawing.Size(333, 738);
            this.pn_Table.TabIndex = 1;
            // 
            // printDialogBill
            // 
            this.printDialogBill.UseEXDialog = true;
            // 
            // printDocumentBill
            // 
            this.printDocumentBill.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentBill_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // FormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1650, 814);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTable";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.grb_SwitchTable.ResumeLayout(false);
            this.grb_SwitchTable.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pn_Table;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_DrinkType;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_NameTableAdd;
        private System.Windows.Forms.ComboBox cb_Drink;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox grb_SwitchTable;
        private System.Windows.Forms.TextBox txt_FromTable;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_AcceptSwitch;
        private System.Windows.Forms.ComboBox cb_ToTable;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label txt_Status;
        private System.Windows.Forms.Label txt_NameTable;
        private System.Windows.Forms.Label txt_Total;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_Purchase;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel pn_Bill;
        private System.Windows.Forms.Button btn_AddDrink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_SwitchTable;
        private System.Windows.Forms.PrintDialog printDialogBill;
        private System.Drawing.Printing.PrintDocument printDocumentBill;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_deleteBill;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel panel2;
    }
}