namespace WindowsFormsApp1
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Movingpanel = new System.Windows.Forms.Panel();
            this.btn_payment = new System.Windows.Forms.Button();
            this.btn_Reports = new System.Windows.Forms.Button();
            this.btn_Supplier = new System.Windows.Forms.Button();
            this.btn_Products = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reports1 = new WindowsFormsApp1.reports();
            this.products1 = new WindowsFormsApp1.products();
            this.supplier1 = new WindowsFormsApp1.supplier();
            this.payment1 = new WindowsFormsApp1.payment();
            this.home1 = new WindowsFormsApp1.Home();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.Movingpanel);
            this.panel1.Controls.Add(this.btn_payment);
            this.panel1.Controls.Add(this.btn_Reports);
            this.panel1.Controls.Add(this.btn_Supplier);
            this.panel1.Controls.Add(this.btn_Products);
            this.panel1.Controls.Add(this.btn_Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 750);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Movingpanel
            // 
            this.Movingpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Movingpanel.Location = new System.Drawing.Point(3, 414);
            this.Movingpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Movingpanel.Name = "Movingpanel";
            this.Movingpanel.Size = new System.Drawing.Size(11, 57);
            this.Movingpanel.TabIndex = 1;
            // 
            // btn_payment
            // 
            this.btn_payment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_payment.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_payment.FlatAppearance.BorderSize = 0;
            this.btn_payment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_payment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_payment.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payment.Image = ((System.Drawing.Image)(resources.GetObject("btn_payment.Image")));
            this.btn_payment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_payment.Location = new System.Drawing.Point(25, 327);
            this.btn_payment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(200, 62);
            this.btn_payment.TabIndex = 0;
            this.btn_payment.Text = "      Payments";
            this.btn_payment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_payment.UseVisualStyleBackColor = true;
            this.btn_payment.Click += new System.EventHandler(this.btn_payment_Click);
            // 
            // btn_Reports
            // 
            this.btn_Reports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Reports.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Reports.FlatAppearance.BorderSize = 0;
            this.btn_Reports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Reports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_Reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reports.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reports.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reports.Image")));
            this.btn_Reports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reports.Location = new System.Drawing.Point(25, 409);
            this.btn_Reports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Reports.Name = "btn_Reports";
            this.btn_Reports.Size = new System.Drawing.Size(200, 62);
            this.btn_Reports.TabIndex = 0;
            this.btn_Reports.Text = "   Reports";
            this.btn_Reports.UseVisualStyleBackColor = true;
            this.btn_Reports.Click += new System.EventHandler(this.btn_Reports_Click);
            // 
            // btn_Supplier
            // 
            this.btn_Supplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Supplier.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Supplier.FlatAppearance.BorderSize = 0;
            this.btn_Supplier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Supplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_Supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Supplier.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Supplier.Image = ((System.Drawing.Image)(resources.GetObject("btn_Supplier.Image")));
            this.btn_Supplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Supplier.Location = new System.Drawing.Point(25, 246);
            this.btn_Supplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Supplier.Name = "btn_Supplier";
            this.btn_Supplier.Size = new System.Drawing.Size(200, 62);
            this.btn_Supplier.TabIndex = 0;
            this.btn_Supplier.Text = "    Supplier";
            this.btn_Supplier.UseVisualStyleBackColor = true;
            this.btn_Supplier.Click += new System.EventHandler(this.btn_Supplier_Click);
            // 
            // btn_Products
            // 
            this.btn_Products.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Products.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Products.FlatAppearance.BorderSize = 0;
            this.btn_Products.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Products.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_Products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Products.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Products.Image = ((System.Drawing.Image)(resources.GetObject("btn_Products.Image")));
            this.btn_Products.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Products.Location = new System.Drawing.Point(25, 164);
            this.btn_Products.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Products.Name = "btn_Products";
            this.btn_Products.Size = new System.Drawing.Size(200, 62);
            this.btn_Products.TabIndex = 0;
            this.btn_Products.Text = "      Products";
            this.btn_Products.UseVisualStyleBackColor = true;
            this.btn_Products.Click += new System.EventHandler(this.btn_Products_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Home.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("btn_Home.Image")));
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(25, 84);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(200, 62);
            this.btn_Home.TabIndex = 0;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.home1);
            this.panel2.Controls.Add(this.reports1);
            this.panel2.Controls.Add(this.products1);
            this.panel2.Controls.Add(this.supplier1);
            this.panel2.Controls.Add(this.payment1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(225, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 750);
            this.panel2.TabIndex = 1;
            // 
            // reports1
            // 
            this.reports1.Location = new System.Drawing.Point(-1, -5);
            this.reports1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reports1.Name = "reports1";
            this.reports1.Size = new System.Drawing.Size(992, 750);
            this.reports1.TabIndex = 3;
            // 
            // products1
            // 
            this.products1.BackColor = System.Drawing.Color.Transparent;
            this.products1.Location = new System.Drawing.Point(-1, -1);
            this.products1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.products1.Name = "products1";
            this.products1.Size = new System.Drawing.Size(957, 750);
            this.products1.TabIndex = 2;
            // 
            // supplier1
            // 
            this.supplier1.Location = new System.Drawing.Point(-1, -1);
            this.supplier1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.supplier1.Name = "supplier1";
            this.supplier1.Size = new System.Drawing.Size(957, 750);
            this.supplier1.TabIndex = 1;
            // 
            // payment1
            // 
            this.payment1.Location = new System.Drawing.Point(-1, -1);
            this.payment1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.payment1.Name = "payment1";
            this.payment1.Size = new System.Drawing.Size(957, 750);
            this.payment1.TabIndex = 0;
            // 
            // home1
            // 
            this.home1.Location = new System.Drawing.Point(-1, 3);
            this.home1.Margin = new System.Windows.Forms.Padding(4);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(982, 746);
            this.home1.TabIndex = 4;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1207, 750);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Furniture";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Supplier;
        private System.Windows.Forms.Button btn_Products;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_Reports;
        private System.Windows.Forms.Button btn_payment;
        private System.Windows.Forms.Panel panel2;
        private supplier supplier1;
        private payment payment1;
        private products products1;
        private reports reports1;
        private System.Windows.Forms.Panel Movingpanel;
        private Home home1;
    }
}