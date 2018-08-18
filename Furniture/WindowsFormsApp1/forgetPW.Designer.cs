namespace WindowsFormsApp1
{
    partial class forgetPW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forgetPW));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_npw = new System.Windows.Forms.TextBox();
            this.txt_cpw = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Confirm Password";
            // 
            // txt_npw
            // 
            this.txt_npw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_npw.Location = new System.Drawing.Point(256, 46);
            this.txt_npw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_npw.Multiline = true;
            this.txt_npw.Name = "txt_npw";
            this.txt_npw.PasswordChar = '*';
            this.txt_npw.Size = new System.Drawing.Size(164, 31);
            this.txt_npw.TabIndex = 1;
            // 
            // txt_cpw
            // 
            this.txt_cpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cpw.Location = new System.Drawing.Point(256, 113);
            this.txt_cpw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_cpw.Multiline = true;
            this.txt_cpw.Name = "txt_cpw";
            this.txt_cpw.PasswordChar = '*';
            this.txt_cpw.Size = new System.Drawing.Size(164, 31);
            this.txt_cpw.TabIndex = 1;
            // 
            // txt_username
            // 
            this.txt_username.Enabled = false;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(268, 60);
            this.txt_username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(164, 31);
            this.txt_username.TabIndex = 1;
            this.txt_username.UseSystemPasswordChar = true;
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(171, 189);
            this.btn_apply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(98, 28);
            this.btn_apply.TabIndex = 2;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(302, 189);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(98, 28);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(437, 189);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(98, 28);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_npw);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_back);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_apply);
            this.groupBox1.Controls.Add(this.txt_cpw);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 231);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter New Password";
            // 
            // forgetPW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "forgetPW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Reset Password";
            this.Load += new System.EventHandler(this.forgetPW_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_npw;
        private System.Windows.Forms.TextBox txt_cpw;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}