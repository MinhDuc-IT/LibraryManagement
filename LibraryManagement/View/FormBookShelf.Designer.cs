namespace LibraryManagement.View
{
    partial class FormBookShelf
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

        private System.Windows.Forms.ComboBox comboBox_Shelves;
        private System.Windows.Forms.DataGridView dataGridView_Books;

        private void InitializeComponent()
        {
            this.comboBox_Shelves = new System.Windows.Forms.ComboBox();
            this.dataGridView_Books = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Books)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Shelves
            // 
            this.comboBox_Shelves.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Shelves.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Shelves.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox_Shelves.FormattingEnabled = true;
            this.comboBox_Shelves.Location = new System.Drawing.Point(183, 49);
            this.comboBox_Shelves.Name = "comboBox_Shelves";
            this.comboBox_Shelves.Size = new System.Drawing.Size(244, 28);
            this.comboBox_Shelves.TabIndex = 0;
            this.comboBox_Shelves.SelectedIndexChanged += new System.EventHandler(this.comboBox_Shelves_SelectedIndexChanged);
            // 
            // dataGridView_Books
            // 
            this.dataGridView_Books.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Books.Cursor = System.Windows.Forms.Cursors.No;
            this.dataGridView_Books.Location = new System.Drawing.Point(-1, 150);
            this.dataGridView_Books.Name = "dataGridView_Books";
            this.dataGridView_Books.RowHeadersWidth = 51;
            this.dataGridView_Books.Size = new System.Drawing.Size(1141, 565);
            this.dataGridView_Books.TabIndex = 1;
            this.dataGridView_Books.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Books_CellContentClick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 22);
            this.label3.TabIndex = 158;
            this.label3.Text = "Tên kệ sách";
            // 
            // FormBookShelf
            // 
            this.ClientSize = new System.Drawing.Size(1140, 712);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Shelves);
            this.Controls.Add(this.dataGridView_Books);
            this.Name = "FormBookShelf";
            this.Text = "Danh sách sách theo kệ";
            this.Load += new System.EventHandler(this.FormBookShelf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Books)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // FormBookShelf
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(800, 450);
        //    this.Name = "FormBookShelf";
        //    this.Text = "FormBookShelf";
        //    this.Load += new System.EventHandler(this.FormBookShelf_Load);
        //    this.ResumeLayout(false);

        //}

        #endregion

        private System.Windows.Forms.Label label3;
    }
}