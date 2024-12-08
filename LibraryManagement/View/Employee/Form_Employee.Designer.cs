namespace LibraryManagement.View
{
    partial class Form_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Employee));
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel_left = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_Return = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_AddCustomer = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(311, 0);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1158, 759);
            this.panel_body.TabIndex = 9;
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel_left.Controls.Add(this.btn_search);
            this.panel_left.Controls.Add(this.btn_logout);
            this.panel_left.Controls.Add(this.btn_Return);
            this.panel_left.Controls.Add(this.btn_home);
            this.panel_left.Controls.Add(this.btn_AddCustomer);
            this.panel_left.Controls.Add(this.btn_Customer);
            this.panel_left.Controls.Add(this.pictureBox1);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(311, 759);
            this.panel_left.TabIndex = 8;
            // 
            // btn_search
            // 
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(0, 499);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(311, 49);
            this.btn_search.TabIndex = 7;
            this.btn_search.Text = "          Tìm kiếm sách";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(0, 573);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(311, 49);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "          Đăng xuất";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_Return
            // 
            this.btn_Return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return.Location = new System.Drawing.Point(0, 426);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(311, 49);
            this.btn_Return.TabIndex = 4;
            this.btn_Return.Text = "          Trả sách";
            this.btn_Return.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // btn_home
            // 
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Location = new System.Drawing.Point(0, 208);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(311, 49);
            this.btn_home.TabIndex = 3;
            this.btn_home.Text = "          Trang chủ";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_AddCustomer
            // 
            this.btn_AddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCustomer.Location = new System.Drawing.Point(0, 280);
            this.btn_AddCustomer.Name = "btn_AddCustomer";
            this.btn_AddCustomer.Size = new System.Drawing.Size(311, 49);
            this.btn_AddCustomer.TabIndex = 2;
            this.btn_AddCustomer.Text = "          Tạo thẻ khách hàng";
            this.btn_AddCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddCustomer.UseVisualStyleBackColor = true;
            this.btn_AddCustomer.Click += new System.EventHandler(this.btn_AddCustomer_Click);
            // 
            // btn_Customer
            // 
            this.btn_Customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer.Location = new System.Drawing.Point(0, 354);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(311, 49);
            this.btn_Customer.TabIndex = 1;
            this.btn_Customer.Text = "          Cho thuê sách";
            this.btn_Customer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Customer.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 759);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1469, 0);
            this.panel1.TabIndex = 10;
            // 
            // panel_Top
            // 
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1469, 0);
            this.panel_Top.TabIndex = 7;
            // 
            // Form_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 759);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_Top);
            this.Name = "Form_Employee";
            this.Text = "Form_Employee";
            this.panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_AddCustomer;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_search;
    }
}