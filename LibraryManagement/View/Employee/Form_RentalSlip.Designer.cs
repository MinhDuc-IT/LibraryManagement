
namespace LibraryManagement.View.Employee
{
    partial class Form_RentalSlip
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_BookID = new System.Windows.Forms.TextBox();
            this.txt_RentalFee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_AddRentalDetail = new System.Windows.Forms.Button();
            this.btn_DeleteRentalDetail = new System.Windows.Forms.Button();
            this.btn_EditRentalDetail = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_AddRentalSlip = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView_RentalDetails = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView_Books = new System.Windows.Forms.DataGridView();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_CustomerID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker_RentalDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_DueDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RentalDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Books)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách";
            // 
            // txt_BookID
            // 
            this.txt_BookID.Location = new System.Drawing.Point(15, 29);
            this.txt_BookID.Name = "txt_BookID";
            this.txt_BookID.Size = new System.Drawing.Size(162, 22);
            this.txt_BookID.TabIndex = 1;
            // 
            // txt_RentalFee
            // 
            this.txt_RentalFee.Location = new System.Drawing.Point(15, 147);
            this.txt_RentalFee.Name = "txt_RentalFee";
            this.txt_RentalFee.Size = new System.Drawing.Size(162, 22);
            this.txt_RentalFee.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cước phí thuê";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(15, 89);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(162, 22);
            this.txt_Quantity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lượng";
            // 
            // btn_AddRentalDetail
            // 
            this.btn_AddRentalDetail.Location = new System.Drawing.Point(238, 146);
            this.btn_AddRentalDetail.Name = "btn_AddRentalDetail";
            this.btn_AddRentalDetail.Size = new System.Drawing.Size(75, 23);
            this.btn_AddRentalDetail.TabIndex = 6;
            this.btn_AddRentalDetail.Text = "Thêm";
            this.btn_AddRentalDetail.UseVisualStyleBackColor = true;
            this.btn_AddRentalDetail.Click += new System.EventHandler(this.btn_AddRentalDetail_Click);
            // 
            // btn_DeleteRentalDetail
            // 
            this.btn_DeleteRentalDetail.Enabled = false;
            this.btn_DeleteRentalDetail.Location = new System.Drawing.Point(238, 28);
            this.btn_DeleteRentalDetail.Name = "btn_DeleteRentalDetail";
            this.btn_DeleteRentalDetail.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteRentalDetail.TabIndex = 7;
            this.btn_DeleteRentalDetail.Text = "Xóa";
            this.btn_DeleteRentalDetail.UseVisualStyleBackColor = true;
            this.btn_DeleteRentalDetail.Click += new System.EventHandler(this.btn_DeleteRentalDetail_Click);
            // 
            // btn_EditRentalDetail
            // 
            this.btn_EditRentalDetail.Enabled = false;
            this.btn_EditRentalDetail.Location = new System.Drawing.Point(238, 88);
            this.btn_EditRentalDetail.Name = "btn_EditRentalDetail";
            this.btn_EditRentalDetail.Size = new System.Drawing.Size(75, 23);
            this.btn_EditRentalDetail.TabIndex = 8;
            this.btn_EditRentalDetail.Text = "Sửa";
            this.btn_EditRentalDetail.UseVisualStyleBackColor = true;
            this.btn_EditRentalDetail.Click += new System.EventHandler(this.btn_EditRentalDetail_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(847, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ngày thuê";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(847, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày trả";
            // 
            // btn_AddRentalSlip
            // 
            this.btn_AddRentalSlip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddRentalSlip.Location = new System.Drawing.Point(850, 127);
            this.btn_AddRentalSlip.Name = "btn_AddRentalSlip";
            this.btn_AddRentalSlip.Size = new System.Drawing.Size(200, 42);
            this.btn_AddRentalSlip.TabIndex = 13;
            this.btn_AddRentalSlip.Text = "Thêm phiếu thuê mới";
            this.btn_AddRentalSlip.UseVisualStyleBackColor = true;
            this.btn_AddRentalSlip.Click += new System.EventHandler(this.btn_AddRentalSlip_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Danh sách sách thuê";
            // 
            // dataGridView_RentalDetails
            // 
            this.dataGridView_RentalDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_RentalDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_RentalDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RentalDetails.Location = new System.Drawing.Point(12, 231);
            this.dataGridView_RentalDetails.Name = "dataGridView_RentalDetails";
            this.dataGridView_RentalDetails.RowHeadersWidth = 51;
            this.dataGridView_RentalDetails.RowTemplate.Height = 24;
            this.dataGridView_RentalDetails.Size = new System.Drawing.Size(1038, 261);
            this.dataGridView_RentalDetails.TabIndex = 15;
            this.dataGridView_RentalDetails.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_RentalDetails_RowHeaderMouseClick);
            this.dataGridView_RentalDetails.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_RentalDetails_RowHeaderMouseDoubleClick);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 538);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Danh sách các quyển sách";
            // 
            // dataGridView_Books
            // 
            this.dataGridView_Books.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Books.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Books.Location = new System.Drawing.Point(12, 558);
            this.dataGridView_Books.Name = "dataGridView_Books";
            this.dataGridView_Books.RowHeadersWidth = 51;
            this.dataGridView_Books.RowTemplate.Height = 24;
            this.dataGridView_Books.Size = new System.Drawing.Size(1038, 391);
            this.dataGridView_Books.TabIndex = 17;
            this.dataGridView_Books.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Books_CellContentClick);
            this.dataGridView_Books.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Books_RowHeaderMouseClick);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(394, 87);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(162, 22);
            this.txt_Search.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(391, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Từ khóa tìm kiếm";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(593, 87);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 20;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_CustomerID
            // 
            this.txt_CustomerID.Location = new System.Drawing.Point(394, 29);
            this.txt_CustomerID.Name = "txt_CustomerID";
            this.txt_CustomerID.ReadOnly = true;
            this.txt_CustomerID.Size = new System.Drawing.Size(162, 22);
            this.txt_CustomerID.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(391, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Mã khách hàng";
            // 
            // dateTimePicker_RentalDate
            // 
            this.dateTimePicker_RentalDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_RentalDate.Location = new System.Drawing.Point(850, 29);
            this.dateTimePicker_RentalDate.Name = "dateTimePicker_RentalDate";
            this.dateTimePicker_RentalDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_RentalDate.TabIndex = 23;
            // 
            // dateTimePicker_DueDate
            // 
            this.dateTimePicker_DueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_DueDate.Location = new System.Drawing.Point(850, 89);
            this.dateTimePicker_DueDate.Name = "dateTimePicker_DueDate";
            this.dateTimePicker_DueDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_DueDate.TabIndex = 24;
            // 
            // Form_RentalSlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 961);
            this.Controls.Add(this.dateTimePicker_DueDate);
            this.Controls.Add(this.dateTimePicker_RentalDate);
            this.Controls.Add(this.txt_CustomerID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView_Books);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView_RentalDetails);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_AddRentalSlip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_EditRentalDetail);
            this.Controls.Add(this.btn_DeleteRentalDetail);
            this.Controls.Add(this.btn_AddRentalDetail);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_RentalFee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_BookID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_RentalSlip";
            this.Text = "Form_RentalSlip";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_RentalSlip_FormClosing);
            this.Load += new System.EventHandler(this.Form_RentalSlip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RentalDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Books)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_BookID;
        private System.Windows.Forms.TextBox txt_RentalFee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_AddRentalDetail;
        private System.Windows.Forms.Button btn_DeleteRentalDetail;
        private System.Windows.Forms.Button btn_EditRentalDetail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_AddRentalSlip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_RentalDetails;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView_Books;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_CustomerID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker_RentalDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DueDate;
    }
}