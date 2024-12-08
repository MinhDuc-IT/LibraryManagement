namespace LibraryManagement.View.Admin
{
    partial class Form_Customer
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
            this.dataGridView_Cus = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cus)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Cus
            // 
            this.dataGridView_Cus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Cus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Cus.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView_Cus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Cus.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView_Cus.Location = new System.Drawing.Point(-1, 65);
            this.dataGridView_Cus.Name = "dataGridView_Cus";
            this.dataGridView_Cus.ReadOnly = true;
            this.dataGridView_Cus.RowHeadersWidth = 51;
            this.dataGridView_Cus.RowTemplate.Height = 24;
            this.dataGridView_Cus.Size = new System.Drawing.Size(1143, 650);
            this.dataGridView_Cus.TabIndex = 186;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 22);
            this.label3.TabIndex = 171;
            this.label3.Text = "Danh sách khách hàng trong hệ thống";
            // 
            // Form_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 712);
            this.Controls.Add(this.dataGridView_Cus);
            this.Controls.Add(this.label3);
            this.Name = "Form_Customer";
            this.Text = "Form_Customer";
            this.Load += new System.EventHandler(this.Form_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Cus;
        private System.Windows.Forms.Label label3;
    }
}