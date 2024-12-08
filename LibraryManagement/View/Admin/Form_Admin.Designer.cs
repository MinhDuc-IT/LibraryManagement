namespace LibraryManagement.View
{
    partial class Form_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Admin));
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel_left = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_statistical = new System.Windows.Forms.Button();
            this.btn_shelf = new System.Windows.Forms.Button();
            this.btn_Book = new System.Windows.Forms.Button();
            this.btn_DashBoard = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel_body.TabIndex = 5;
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel_left.Controls.Add(this.btn_logout);
            this.panel_left.Controls.Add(this.btn_statistical);
            this.panel_left.Controls.Add(this.btn_shelf);
            this.panel_left.Controls.Add(this.btn_Book);
            this.panel_left.Controls.Add(this.btn_DashBoard);
            this.panel_left.Controls.Add(this.button1);
            this.panel_left.Controls.Add(this.btn_Customer);
            this.panel_left.Controls.Add(this.pictureBox1);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(311, 759);
            this.panel_left.TabIndex = 4;
            // 
            // btn_logout
            // 
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(0, 647);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(311, 49);
            this.btn_logout.TabIndex = 7;
            this.btn_logout.Text = "          Đăng xuất";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_statistical
            // 
            this.btn_statistical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_statistical.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_statistical.Location = new System.Drawing.Point(0, 572);
            this.btn_statistical.Name = "btn_statistical";
            this.btn_statistical.Size = new System.Drawing.Size(311, 49);
            this.btn_statistical.TabIndex = 6;
            this.btn_statistical.Text = "          Thống kê";
            this.btn_statistical.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_statistical.UseVisualStyleBackColor = true;
            this.btn_statistical.Click += new System.EventHandler(this.btn_statistical_Click);
            // 
            // btn_shelf
            // 
            this.btn_shelf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_shelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shelf.Location = new System.Drawing.Point(0, 498);
            this.btn_shelf.Name = "btn_shelf";
            this.btn_shelf.Size = new System.Drawing.Size(311, 49);
            this.btn_shelf.TabIndex = 5;
            this.btn_shelf.Text = "          Quản lý kệ sách";
            this.btn_shelf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_shelf.UseVisualStyleBackColor = true;
            this.btn_shelf.Click += new System.EventHandler(this.btn_shelf_Click);
            // 
            // btn_Book
            // 
            this.btn_Book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Book.Location = new System.Drawing.Point(0, 426);
            this.btn_Book.Name = "btn_Book";
            this.btn_Book.Size = new System.Drawing.Size(311, 49);
            this.btn_Book.TabIndex = 4;
            this.btn_Book.Text = "          Quản lý sách";
            this.btn_Book.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Book.UseVisualStyleBackColor = true;
            this.btn_Book.Click += new System.EventHandler(this.btn_Book_Click);
            // 
            // btn_DashBoard
            // 
            this.btn_DashBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DashBoard.Location = new System.Drawing.Point(0, 208);
            this.btn_DashBoard.Name = "btn_DashBoard";
            this.btn_DashBoard.Size = new System.Drawing.Size(311, 49);
            this.btn_DashBoard.TabIndex = 3;
            this.btn_DashBoard.Text = "          Trang chủ";
            this.btn_DashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DashBoard.UseVisualStyleBackColor = true;
            this.btn_DashBoard.Click += new System.EventHandler(this.btn_DashBoard_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(311, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "          Quản lý người dùng";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Customer
            // 
            this.btn_Customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer.Location = new System.Drawing.Point(0, 354);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(311, 49);
            this.btn_Customer.TabIndex = 1;
            this.btn_Customer.Text = "          Quản lý khách hàng";
            this.btn_Customer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Customer.UseVisualStyleBackColor = true;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
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
            // panel_Top
            // 
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1469, 0);
            this.panel_Top.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(311, 759);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 0);
            this.panel1.TabIndex = 6;
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 759);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.panel_Top);
            this.Name = "Form_Admin";
            this.Text = "Form_Admin";
            this.panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Button btn_shelf;
        private System.Windows.Forms.Button btn_Book;
        private System.Windows.Forms.Button btn_DashBoard;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_statistical;
        private System.Windows.Forms.Button btn_logout;
    }
}