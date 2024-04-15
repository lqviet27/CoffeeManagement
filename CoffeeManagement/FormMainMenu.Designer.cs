namespace CoffeeManagement
{
    partial class FormMainMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_changeInfo = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_table = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.lb_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(199, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 94);
            this.panel1.TabIndex = 0;
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_title.Location = new System.Drawing.Point(272, 20);
            this.lb_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(117, 42);
            this.lb_title.TabIndex = 2;
            this.lb_title.Text = "Home";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(199, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(605, 356);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btn_changeInfo);
            this.panel3.Controls.Add(this.btn_logout);
            this.panel3.Controls.Add(this.btn_admin);
            this.panel3.Controls.Add(this.btn_table);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 450);
            this.panel3.TabIndex = 1;
            // 
            // btn_changeInfo
            // 
            this.btn_changeInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_changeInfo.Location = new System.Drawing.Point(0, 346);
            this.btn_changeInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_changeInfo.Name = "btn_changeInfo";
            this.btn_changeInfo.Size = new System.Drawing.Size(199, 76);
            this.btn_changeInfo.TabIndex = 5;
            this.btn_changeInfo.Text = "Thay Doi Thong Tin";
            this.btn_changeInfo.UseVisualStyleBackColor = true;
            this.btn_changeInfo.Click += new System.EventHandler(this.btn_changeInfo_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_logout.Location = new System.Drawing.Point(0, 264);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(199, 82);
            this.btn_logout.TabIndex = 4;
            this.btn_logout.Text = "Dang Xuat";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_admin.Location = new System.Drawing.Point(0, 179);
            this.btn_admin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(199, 85);
            this.btn_admin.TabIndex = 3;
            this.btn_admin.Text = "Admin";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // btn_table
            // 
            this.btn_table.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_table.Location = new System.Drawing.Point(0, 94);
            this.btn_table.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_table.Name = "btn_table";
            this.btn_table.Size = new System.Drawing.Size(199, 85);
            this.btn_table.TabIndex = 2;
            this.btn_table.Text = "Table";
            this.btn_table.UseVisualStyleBackColor = true;
            this.btn_table.Click += new System.EventHandler(this.btn_table_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(199, 94);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "PBL3 Coffee Shop";
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMainMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_changeInfo;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btn_table;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label label1;
    }
}