namespace CoffeeManagement
{
    partial class FormEditInformation
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
            this.labelEditInfo = new System.Windows.Forms.Label();
            this.groupBoxChangePass = new System.Windows.Forms.GroupBox();
            this.btn_CancelChangePassword = new CustomControls.RJControls.RJButton();
            this.btn_ChangePassword = new CustomControls.RJControls.RJButton();
            this.tb_ComfirmPassword = new CustomControls.RJControls.RJTextBox();
            this.tb_NewPasword = new CustomControls.RJControls.RJTextBox();
            this.tb_OldPassword = new CustomControls.RJControls.RJTextBox();
            this.lb_OldPass = new System.Windows.Forms.Label();
            this.labelConfirmPass = new System.Windows.Forms.Label();
            this.labelNewPass = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_DisplayName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBoxChangePass.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.labelEditInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1645, 96);
            this.panel1.TabIndex = 0;
            // 
            // labelEditInfo
            // 
            this.labelEditInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEditInfo.AutoSize = true;
            this.labelEditInfo.Font = new System.Drawing.Font("Freestyle Script", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditInfo.Location = new System.Drawing.Point(533, 6);
            this.labelEditInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEditInfo.Name = "labelEditInfo";
            this.labelEditInfo.Size = new System.Drawing.Size(623, 89);
            this.labelEditInfo.TabIndex = 0;
            this.labelEditInfo.Text = "C H A N G E    I N F O ";
            // 
            // groupBoxChangePass
            // 
            this.groupBoxChangePass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxChangePass.Controls.Add(this.btn_CancelChangePassword);
            this.groupBoxChangePass.Controls.Add(this.btn_ChangePassword);
            this.groupBoxChangePass.Controls.Add(this.tb_ComfirmPassword);
            this.groupBoxChangePass.Controls.Add(this.tb_NewPasword);
            this.groupBoxChangePass.Controls.Add(this.tb_OldPassword);
            this.groupBoxChangePass.Controls.Add(this.lb_OldPass);
            this.groupBoxChangePass.Controls.Add(this.labelConfirmPass);
            this.groupBoxChangePass.Controls.Add(this.labelNewPass);
            this.groupBoxChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxChangePass.Location = new System.Drawing.Point(355, 150);
            this.groupBoxChangePass.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxChangePass.Name = "groupBoxChangePass";
            this.groupBoxChangePass.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxChangePass.Size = new System.Drawing.Size(907, 474);
            this.groupBoxChangePass.TabIndex = 2;
            this.groupBoxChangePass.TabStop = false;
            this.groupBoxChangePass.Text = "CHANGE PASSWORD";
            // 
            // btn_CancelChangePassword
            // 
            this.btn_CancelChangePassword.BackColor = System.Drawing.SystemColors.Control;
            this.btn_CancelChangePassword.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btn_CancelChangePassword.BorderColor = System.Drawing.Color.Aqua;
            this.btn_CancelChangePassword.BorderRadius = 15;
            this.btn_CancelChangePassword.BorderSize = 2;
            this.btn_CancelChangePassword.FlatAppearance.BorderSize = 0;
            this.btn_CancelChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_CancelChangePassword.ForeColor = System.Drawing.Color.Black;
            this.btn_CancelChangePassword.Location = new System.Drawing.Point(529, 353);
            this.btn_CancelChangePassword.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CancelChangePassword.Name = "btn_CancelChangePassword";
            this.btn_CancelChangePassword.Size = new System.Drawing.Size(128, 38);
            this.btn_CancelChangePassword.TabIndex = 60;
            this.btn_CancelChangePassword.Text = "Cancel";
            this.btn_CancelChangePassword.TextColor = System.Drawing.Color.Black;
            this.btn_CancelChangePassword.UseVisualStyleBackColor = false;
            this.btn_CancelChangePassword.Click += new System.EventHandler(this.btn_CancelChangePassword_Click);
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ChangePassword.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btn_ChangePassword.BorderColor = System.Drawing.Color.Aqua;
            this.btn_ChangePassword.BorderRadius = 15;
            this.btn_ChangePassword.BorderSize = 2;
            this.btn_ChangePassword.FlatAppearance.BorderSize = 0;
            this.btn_ChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ChangePassword.ForeColor = System.Drawing.Color.Black;
            this.btn_ChangePassword.Location = new System.Drawing.Point(176, 353);
            this.btn_ChangePassword.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            this.btn_ChangePassword.Size = new System.Drawing.Size(128, 38);
            this.btn_ChangePassword.TabIndex = 59;
            this.btn_ChangePassword.Text = "OK";
            this.btn_ChangePassword.TextColor = System.Drawing.Color.Black;
            this.btn_ChangePassword.UseVisualStyleBackColor = false;
            this.btn_ChangePassword.Click += new System.EventHandler(this.btn_ChangePassword_Click);
            // 
            // tb_ComfirmPassword
            // 
            this.tb_ComfirmPassword.BackColor = System.Drawing.SystemColors.Window;
            this.tb_ComfirmPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tb_ComfirmPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_ComfirmPassword.BorderRadius = 0;
            this.tb_ComfirmPassword.BorderSize = 2;
            this.tb_ComfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ComfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_ComfirmPassword.Location = new System.Drawing.Point(457, 242);
            this.tb_ComfirmPassword.Margin = new System.Windows.Forms.Padding(5);
            this.tb_ComfirmPassword.Multiline = false;
            this.tb_ComfirmPassword.Name = "tb_ComfirmPassword";
            this.tb_ComfirmPassword.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.tb_ComfirmPassword.PasswordChar = true;
            this.tb_ComfirmPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_ComfirmPassword.PlaceholderText = "Enter Confirm Password";
            this.tb_ComfirmPassword.Size = new System.Drawing.Size(333, 39);
            this.tb_ComfirmPassword.TabIndex = 7;
            this.tb_ComfirmPassword.Texts = "";
            this.tb_ComfirmPassword.UnderlinedStyle = false;
            // 
            // tb_NewPasword
            // 
            this.tb_NewPasword.BackColor = System.Drawing.SystemColors.Window;
            this.tb_NewPasword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tb_NewPasword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_NewPasword.BorderRadius = 0;
            this.tb_NewPasword.BorderSize = 2;
            this.tb_NewPasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NewPasword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_NewPasword.Location = new System.Drawing.Point(457, 154);
            this.tb_NewPasword.Margin = new System.Windows.Forms.Padding(5);
            this.tb_NewPasword.Multiline = false;
            this.tb_NewPasword.Name = "tb_NewPasword";
            this.tb_NewPasword.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.tb_NewPasword.PasswordChar = true;
            this.tb_NewPasword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_NewPasword.PlaceholderText = "Enter New Password";
            this.tb_NewPasword.Size = new System.Drawing.Size(333, 39);
            this.tb_NewPasword.TabIndex = 6;
            this.tb_NewPasword.Texts = "";
            this.tb_NewPasword.UnderlinedStyle = false;
            // 
            // tb_OldPassword
            // 
            this.tb_OldPassword.BackColor = System.Drawing.SystemColors.Window;
            this.tb_OldPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tb_OldPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tb_OldPassword.BorderRadius = 0;
            this.tb_OldPassword.BorderSize = 2;
            this.tb_OldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_OldPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_OldPassword.Location = new System.Drawing.Point(457, 60);
            this.tb_OldPassword.Margin = new System.Windows.Forms.Padding(5);
            this.tb_OldPassword.Multiline = false;
            this.tb_OldPassword.Name = "tb_OldPassword";
            this.tb_OldPassword.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.tb_OldPassword.PasswordChar = true;
            this.tb_OldPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tb_OldPassword.PlaceholderText = "Enter Password";
            this.tb_OldPassword.Size = new System.Drawing.Size(333, 39);
            this.tb_OldPassword.TabIndex = 5;
            this.tb_OldPassword.Texts = "";
            this.tb_OldPassword.UnderlinedStyle = false;
            // 
            // lb_OldPass
            // 
            this.lb_OldPass.AutoSize = true;
            this.lb_OldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_OldPass.Location = new System.Drawing.Point(49, 74);
            this.lb_OldPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_OldPass.Name = "lb_OldPass";
            this.lb_OldPass.Size = new System.Drawing.Size(130, 25);
            this.lb_OldPass.TabIndex = 0;
            this.lb_OldPass.Text = "PASSWORD";
            // 
            // labelConfirmPass
            // 
            this.labelConfirmPass.AutoSize = true;
            this.labelConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelConfirmPass.Location = new System.Drawing.Point(49, 256);
            this.labelConfirmPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConfirmPass.Name = "labelConfirmPass";
            this.labelConfirmPass.Size = new System.Drawing.Size(227, 25);
            this.labelConfirmPass.TabIndex = 0;
            this.labelConfirmPass.Text = "CONFIRM PASSWORD";
            // 
            // labelNewPass
            // 
            this.labelNewPass.AutoSize = true;
            this.labelNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelNewPass.Location = new System.Drawing.Point(49, 167);
            this.labelNewPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewPass.Name = "labelNewPass";
            this.labelNewPass.Size = new System.Drawing.Size(182, 25);
            this.labelNewPass.TabIndex = 0;
            this.labelNewPass.Text = "NEW PASSWORD";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.groupBoxChangePass);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 96);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1645, 718);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_DisplayName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_UserName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(87, 27);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1513, 63);
            this.panel2.TabIndex = 3;
            // 
            // txt_DisplayName
            // 
            this.txt_DisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_DisplayName.Location = new System.Drawing.Point(909, 17);
            this.txt_DisplayName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DisplayName.Name = "txt_DisplayName";
            this.txt_DisplayName.ReadOnly = true;
            this.txt_DisplayName.Size = new System.Drawing.Size(197, 34);
            this.txt_DisplayName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(720, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Display Name: ";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_UserName.Location = new System.Drawing.Point(501, 17);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.ReadOnly = true;
            this.txt_UserName.Size = new System.Drawing.Size(197, 34);
            this.txt_UserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(335, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // FormEditInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1645, 814);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEditInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxChangePass.ResumeLayout(false);
            this.groupBoxChangePass.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelEditInfo;
        private System.Windows.Forms.GroupBox groupBoxChangePass;
        private System.Windows.Forms.Label lb_OldPass;
        private System.Windows.Forms.Label labelConfirmPass;
        private System.Windows.Forms.Label labelNewPass;
        private System.Windows.Forms.Panel panel3;
        private CustomControls.RJControls.RJTextBox tb_ComfirmPassword;
        private CustomControls.RJControls.RJTextBox tb_NewPasword;
        private CustomControls.RJControls.RJTextBox tb_OldPassword;
        private CustomControls.RJControls.RJButton btn_CancelChangePassword;
        private CustomControls.RJControls.RJButton btn_ChangePassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_DisplayName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label1;
    }
}