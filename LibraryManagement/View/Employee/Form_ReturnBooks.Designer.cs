namespace LibraryManagement.View.Employee
{
    partial class Form_ReturnBooks
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_cccd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_searchInput = new System.Windows.Forms.TextBox();
            this.pb_book = new System.Windows.Forms.PictureBox();
            this.btn_return = new System.Windows.Forms.Button();
            this.nud_quantity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_fine = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_overdue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1141, 468);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // txt_cccd
            // 
            this.txt_cccd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cccd.Location = new System.Drawing.Point(108, 40);
            this.txt_cccd.Name = "txt_cccd";
            this.txt_cccd.Size = new System.Drawing.Size(182, 22);
            this.txt_cccd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã CCCD";
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(296, 27);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 46);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_searchInput
            // 
            this.txt_searchInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_searchInput.Location = new System.Drawing.Point(108, 214);
            this.txt_searchInput.Name = "txt_searchInput";
            this.txt_searchInput.Size = new System.Drawing.Size(177, 22);
            this.txt_searchInput.TabIndex = 4;
            this.txt_searchInput.TextChanged += new System.EventHandler(this.txt_searchInput_TextChanged);
            // 
            // pb_book
            // 
            this.pb_book.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_book.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_book.Location = new System.Drawing.Point(421, 29);
            this.pb_book.Name = "pb_book";
            this.pb_book.Size = new System.Drawing.Size(192, 182);
            this.pb_book.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_book.TabIndex = 5;
            this.pb_book.TabStop = false;
            // 
            // btn_return
            // 
            this.btn_return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_return.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.Location = new System.Drawing.Point(1005, 29);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(103, 44);
            this.btn_return.TabIndex = 6;
            this.btn_return.Text = "Trả";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // nud_quantity
            // 
            this.nud_quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_quantity.Location = new System.Drawing.Point(785, 36);
            this.nud_quantity.Name = "nud_quantity";
            this.nud_quantity.Size = new System.Drawing.Size(165, 22);
            this.nud_quantity.TabIndex = 7;
            this.nud_quantity.ValueChanged += new System.EventHandler(this.nud_quantity_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(645, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "số lượng";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(645, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Thành tiền";
            // 
            // txt_total
            // 
            this.txt_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(785, 183);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(165, 22);
            this.txt_total.TabIndex = 10;
            // 
            // txt_fine
            // 
            this.txt_fine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_fine.Enabled = false;
            this.txt_fine.Location = new System.Drawing.Point(785, 134);
            this.txt_fine.Name = "txt_fine";
            this.txt_fine.Size = new System.Drawing.Size(165, 22);
            this.txt_fine.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(645, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "số ngày quá hạn";
            // 
            // txt_overdue
            // 
            this.txt_overdue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_overdue.Enabled = false;
            this.txt_overdue.Location = new System.Drawing.Point(785, 85);
            this.txt_overdue.Name = "txt_overdue";
            this.txt_overdue.Size = new System.Drawing.Size(165, 22);
            this.txt_overdue.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(645, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tiền phạt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tên sách";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(1005, 89);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(103, 44);
            this.btn_refresh.TabIndex = 16;
            this.btn_refresh.Text = "Làm mới";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Form_ReturnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 712);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_overdue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_fine);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nud_quantity);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.pb_book);
            this.Controls.Add(this.txt_searchInput);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cccd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_ReturnBooks";
            this.Text = "Form_ReturnBooks";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_cccd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_searchInput;
        private System.Windows.Forms.PictureBox pb_book;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.NumericUpDown nud_quantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_fine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_overdue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_refresh;
    }
}