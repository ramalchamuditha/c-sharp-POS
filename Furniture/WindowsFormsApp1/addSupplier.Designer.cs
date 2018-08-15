namespace WindowsFormsApp1
{
    partial class addSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addSupplier));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_supNo = new System.Windows.Forms.TextBox();
            this.txt_Fname = new System.Windows.Forms.TextBox();
            this.txt_NIC = new System.Windows.Forms.TextBox();
            this.txt_add1 = new System.Windows.Forms.TextBox();
            this.txt_add2 = new System.Windows.Forms.TextBox();
            this.txt_add3 = new System.Windows.Forms.TextBox();
            this.txt_tele = new System.Windows.Forms.TextBox();
            this.txt_reg = new System.Windows.Forms.TextBox();
            this.txt_Lname = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "NIC Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 355);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contact Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 415);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Register Number";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_supNo
            // 
            this.txt_supNo.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_supNo.Location = new System.Drawing.Point(182, 69);
            this.txt_supNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_supNo.Multiline = true;
            this.txt_supNo.Name = "txt_supNo";
            this.txt_supNo.Size = new System.Drawing.Size(143, 31);
            this.txt_supNo.TabIndex = 7;
            // 
            // txt_Fname
            // 
            this.txt_Fname.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fname.Location = new System.Drawing.Point(182, 115);
            this.txt_Fname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Fname.Multiline = true;
            this.txt_Fname.Name = "txt_Fname";
            this.txt_Fname.Size = new System.Drawing.Size(143, 31);
            this.txt_Fname.TabIndex = 8;
            // 
            // txt_NIC
            // 
            this.txt_NIC.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NIC.Location = new System.Drawing.Point(182, 166);
            this.txt_NIC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_NIC.Multiline = true;
            this.txt_NIC.Name = "txt_NIC";
            this.txt_NIC.Size = new System.Drawing.Size(143, 31);
            this.txt_NIC.TabIndex = 9;
            // 
            // txt_add1
            // 
            this.txt_add1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_add1.Location = new System.Drawing.Point(182, 213);
            this.txt_add1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_add1.Multiline = true;
            this.txt_add1.Name = "txt_add1";
            this.txt_add1.Size = new System.Drawing.Size(188, 31);
            this.txt_add1.TabIndex = 10;
            // 
            // txt_add2
            // 
            this.txt_add2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_add2.Location = new System.Drawing.Point(182, 251);
            this.txt_add2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_add2.Multiline = true;
            this.txt_add2.Name = "txt_add2";
            this.txt_add2.Size = new System.Drawing.Size(188, 31);
            this.txt_add2.TabIndex = 11;
            // 
            // txt_add3
            // 
            this.txt_add3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_add3.Location = new System.Drawing.Point(182, 289);
            this.txt_add3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_add3.Multiline = true;
            this.txt_add3.Name = "txt_add3";
            this.txt_add3.Size = new System.Drawing.Size(188, 31);
            this.txt_add3.TabIndex = 12;
            // 
            // txt_tele
            // 
            this.txt_tele.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tele.Location = new System.Drawing.Point(182, 355);
            this.txt_tele.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_tele.Multiline = true;
            this.txt_tele.Name = "txt_tele";
            this.txt_tele.Size = new System.Drawing.Size(143, 31);
            this.txt_tele.TabIndex = 13;
            // 
            // txt_reg
            // 
            this.txt_reg.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reg.Location = new System.Drawing.Point(182, 415);
            this.txt_reg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_reg.Multiline = true;
            this.txt_reg.Name = "txt_reg";
            this.txt_reg.Size = new System.Drawing.Size(143, 31);
            this.txt_reg.TabIndex = 14;
            // 
            // txt_Lname
            // 
            this.txt_Lname.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Lname.Location = new System.Drawing.Point(472, 115);
            this.txt_Lname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Lname.Multiline = true;
            this.txt_Lname.Name = "txt_Lname";
            this.txt_Lname.Size = new System.Drawing.Size(143, 31);
            this.txt_Lname.TabIndex = 15;
            this.txt_Lname.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // btn_insert
            // 
            this.btn_insert.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Location = new System.Drawing.Point(251, 482);
            this.btn_insert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(91, 34);
            this.btn_insert.TabIndex = 16;
            this.btn_insert.Text = "Add";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(367, 482);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(91, 34);
            this.btn_clear.TabIndex = 16;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(482, 482);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(91, 34);
            this.btn_back.TabIndex = 16;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // addSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 544);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txt_Lname);
            this.Controls.Add(this.txt_reg);
            this.Controls.Add(this.txt_tele);
            this.Controls.Add(this.txt_add3);
            this.Controls.Add(this.txt_add2);
            this.Controls.Add(this.txt_add1);
            this.Controls.Add(this.txt_NIC);
            this.Controls.Add(this.txt_Fname);
            this.Controls.Add(this.txt_supNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "addSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Supplier";
            this.Load += new System.EventHandler(this.addSupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_supNo;
        private System.Windows.Forms.TextBox txt_Fname;
        private System.Windows.Forms.TextBox txt_NIC;
        private System.Windows.Forms.TextBox txt_add1;
        private System.Windows.Forms.TextBox txt_add2;
        private System.Windows.Forms.TextBox txt_add3;
        private System.Windows.Forms.TextBox txt_tele;
        private System.Windows.Forms.TextBox txt_reg;
        private System.Windows.Forms.TextBox txt_Lname;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_back;
    }
}