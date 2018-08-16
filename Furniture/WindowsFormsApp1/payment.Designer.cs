namespace WindowsFormsApp1
{
    partial class payment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payment));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_makePayment = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_addSalesReport = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.btn_makePayment);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(542, 257);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 262);
            this.panel3.TabIndex = 10;
            // 
            // btn_makePayment
            // 
            this.btn_makePayment.BackColor = System.Drawing.Color.DarkGray;
            this.btn_makePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_makePayment.ForeColor = System.Drawing.Color.Black;
            this.btn_makePayment.Location = new System.Drawing.Point(0, 192);
            this.btn_makePayment.Margin = new System.Windows.Forms.Padding(4);
            this.btn_makePayment.Name = "btn_makePayment";
            this.btn_makePayment.Size = new System.Drawing.Size(233, 43);
            this.btn_makePayment.TabIndex = 1;
            this.btn_makePayment.Text = "Make Payment\r\n";
            this.btn_makePayment.UseVisualStyleBackColor = false;
            this.btn_makePayment.Click += new System.EventHandler(this.btn_purchaseOrder_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1, 21);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(233, 163);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btn_addSalesReport);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(111, 257);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 262);
            this.panel1.TabIndex = 11;
            // 
            // btn_addSalesReport
            // 
            this.btn_addSalesReport.BackColor = System.Drawing.Color.DarkGray;
            this.btn_addSalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addSalesReport.ForeColor = System.Drawing.Color.Black;
            this.btn_addSalesReport.Location = new System.Drawing.Point(0, 192);
            this.btn_addSalesReport.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addSalesReport.Name = "btn_addSalesReport";
            this.btn_addSalesReport.Size = new System.Drawing.Size(233, 43);
            this.btn_addSalesReport.TabIndex = 1;
            this.btn_addSalesReport.Text = "Add Sales Order";
            this.btn_addSalesReport.UseVisualStyleBackColor = false;
            this.btn_addSalesReport.Click += new System.EventHandler(this.btn_salesReport_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "payment";
            this.Size = new System.Drawing.Size(957, 750);
            this.Load += new System.EventHandler(this.payment_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_makePayment;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_addSalesReport;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
