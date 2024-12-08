namespace LibraryManagement.View.Admin
{
    partial class Form_Shelf
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
            this.dataGridView_Shelf = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_Shelf_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Shelf_ID = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Shelf)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Shelf
            // 
            this.dataGridView_Shelf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Shelf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Shelf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Shelf.Location = new System.Drawing.Point(-1, 150);
            this.dataGridView_Shelf.Name = "dataGridView_Shelf";
            this.dataGridView_Shelf.RowHeadersWidth = 51;
            this.dataGridView_Shelf.RowTemplate.Height = 24;
            this.dataGridView_Shelf.Size = new System.Drawing.Size(1141, 565);
            this.dataGridView_Shelf.TabIndex = 158;
            this.dataGridView_Shelf.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Shelf_RowHeaderMouseClick);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Location = new System.Drawing.Point(870, 13);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(103, 43);
            this.btn_add.TabIndex = 152;
            this.btn_add.Text = "Thêm mới ";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_Shelf_Name
            // 
            this.txt_Shelf_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_Shelf_Name.Location = new System.Drawing.Point(114, 23);
            this.txt_Shelf_Name.Name = "txt_Shelf_Name";
            this.txt_Shelf_Name.Size = new System.Drawing.Size(718, 22);
            this.txt_Shelf_Name.TabIndex = 150;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 157;
            this.label3.Text = "Tên kệ sách";
            // 
            // txt_Shelf_ID
            // 
            this.txt_Shelf_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_Shelf_ID.Location = new System.Drawing.Point(114, 69);
            this.txt_Shelf_ID.Name = "txt_Shelf_ID";
            this.txt_Shelf_ID.ReadOnly = true;
            this.txt_Shelf_ID.Size = new System.Drawing.Size(181, 22);
            this.txt_Shelf_ID.TabIndex = 153;
            this.txt_Shelf_ID.Visible = false;
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.Location = new System.Drawing.Point(870, 78);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(103, 43);
            this.btn_delete.TabIndex = 159;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Edit.Location = new System.Drawing.Point(1025, 13);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(103, 43);
            this.btn_Edit.TabIndex = 160;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.Location = new System.Drawing.Point(1025, 78);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(103, 43);
            this.btn_refresh.TabIndex = 161;
            this.btn_refresh.Text = "Làm mới";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Form_Shelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 712);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dataGridView_Shelf);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_Shelf_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Shelf_ID);
            this.Name = "Form_Shelf";
            this.Text = "Form_Shelf";
            this.Load += new System.EventHandler(this.Form_Shelf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Shelf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_Shelf;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_Shelf_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Shelf_ID;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_refresh;
    }
}