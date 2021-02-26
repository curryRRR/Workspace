using System;

namespace BookMS
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_ID = new System.Windows.Forms.TextBox();
            this.text_Pwd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radio_User = new System.Windows.Forms.RadioButton();
            this.radio_Admin = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(150, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "图书管理系统";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "密  码";
            // 
            // text_ID
            // 
            this.text_ID.Location = new System.Drawing.Point(209, 121);
            this.text_ID.Name = "text_ID";
            this.text_ID.Size = new System.Drawing.Size(145, 21);
            this.text_ID.TabIndex = 3;
            // 
            // text_Pwd
            // 
            this.text_Pwd.Location = new System.Drawing.Point(209, 160);
            this.text_Pwd.Name = "text_Pwd";
            this.text_Pwd.Size = new System.Drawing.Size(145, 21);
            this.text_Pwd.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // radio_User
            // 
            this.radio_User.AutoSize = true;
            this.radio_User.Checked = true;
            this.radio_User.Location = new System.Drawing.Point(209, 196);
            this.radio_User.Name = "radio_User";
            this.radio_User.Size = new System.Drawing.Size(47, 16);
            this.radio_User.TabIndex = 7;
            this.radio_User.TabStop = true;
            this.radio_User.Text = "用户";
            this.radio_User.UseVisualStyleBackColor = true;
            // 
            // radio_Admin
            // 
            this.radio_Admin.AutoSize = true;
            this.radio_Admin.Location = new System.Drawing.Point(295, 196);
            this.radio_Admin.Name = "radio_Admin";
            this.radio_Admin.Size = new System.Drawing.Size(59, 16);
            this.radio_Admin.TabIndex = 8;
            this.radio_Admin.TabStop = true;
            this.radio_Admin.Text = "管理员";
            this.radio_Admin.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 391);
            this.Controls.Add(this.radio_Admin);
            this.Controls.Add(this.radio_User);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_Pwd);
            this.Controls.Add(this.text_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_ID;
        private System.Windows.Forms.TextBox text_Pwd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radio_User;
        private System.Windows.Forms.RadioButton radio_Admin;
    }
}

