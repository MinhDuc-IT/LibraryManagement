namespace LibraryManagement
{
    partial class FormSearchBook
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(265, 83);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 36);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tìm kiếm sách";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(584, 83);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 36);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvBookList
            // 
            this.dgvBookList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookList.Location = new System.Drawing.Point(12, 207);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.RowHeadersWidth = 51;
            this.dgvBookList.RowTemplate.Height = 24;
            this.dgvBookList.Size = new System.Drawing.Size(674, 231);
            this.dgvBookList.TabIndex = 6;
            this.dgvBookList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookList_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhập từ khóa";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 165);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(169, 36);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Hiện thị tất cả";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FormSearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvBookList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Name = "FormSearchBook";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormSearchBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
    }
}