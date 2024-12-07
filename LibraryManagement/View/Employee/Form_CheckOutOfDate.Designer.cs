
namespace LibraryManagement.View.Employee
{
    partial class Form_CheckOutOfDate
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
            this.txt_CustomerID = new System.Windows.Forms.TextBox();
            this.btn_MakeRentalSlip = new System.Windows.Forms.Button();
            this.dataGridView_ListRentalSlips = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label_OverDue = new System.Windows.Forms.Label();
            this.label_OnTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListRentalSlips)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số thẻ";
            // 
            // txt_CustomerID
            // 
            this.txt_CustomerID.Location = new System.Drawing.Point(123, 35);
            this.txt_CustomerID.Name = "txt_CustomerID";
            this.txt_CustomerID.Size = new System.Drawing.Size(175, 22);
            this.txt_CustomerID.TabIndex = 1;
            // 
            // btn_MakeRentalSlip
            // 
            this.btn_MakeRentalSlip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MakeRentalSlip.Location = new System.Drawing.Point(708, 25);
            this.btn_MakeRentalSlip.Name = "btn_MakeRentalSlip";
            this.btn_MakeRentalSlip.Size = new System.Drawing.Size(154, 34);
            this.btn_MakeRentalSlip.TabIndex = 2;
            this.btn_MakeRentalSlip.Text = "Lập phiếu thuê";
            this.btn_MakeRentalSlip.UseVisualStyleBackColor = true;
            this.btn_MakeRentalSlip.Click += new System.EventHandler(this.btn_MakeRentalSlip_Click);
            // 
            // dataGridView_ListRentalSlips
            // 
            this.dataGridView_ListRentalSlips.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ListRentalSlips.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ListRentalSlips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListRentalSlips.Location = new System.Drawing.Point(4, 155);
            this.dataGridView_ListRentalSlips.Name = "dataGridView_ListRentalSlips";
            this.dataGridView_ListRentalSlips.RowHeadersWidth = 51;
            this.dataGridView_ListRentalSlips.RowTemplate.Height = 24;
            this.dataGridView_ListRentalSlips.Size = new System.Drawing.Size(912, 452);
            this.dataGridView_ListRentalSlips.TabIndex = 3;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(335, 28);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(82, 29);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label_OverDue
            // 
            this.label_OverDue.AutoSize = true;
            this.label_OverDue.Location = new System.Drawing.Point(24, 131);
            this.label_OverDue.Name = "label_OverDue";
            this.label_OverDue.Size = new System.Drawing.Size(254, 21);
            this.label_OverDue.TabIndex = 5;
            this.label_OverDue.Text = "Danh sách phiếu thuê quá hạn";
            this.label_OverDue.Visible = false;
            // 
            // label_OnTime
            // 
            this.label_OnTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_OnTime.AutoSize = true;
            this.label_OnTime.Location = new System.Drawing.Point(269, 131);
            this.label_OnTime.Name = "label_OnTime";
            this.label_OnTime.Size = new System.Drawing.Size(386, 17);
            this.label_OnTime.TabIndex = 6;
            this.label_OnTime.Text = "Không có phiếu thuê quá hạn, có thể tiếp tục lập phiếu thuê";
            this.label_OnTime.Visible = false;
            // 
            // Form_CheckOutOfDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 616);
            this.Controls.Add(this.label_OnTime);
            this.Controls.Add(this.label_OverDue);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dataGridView_ListRentalSlips);
            this.Controls.Add(this.btn_MakeRentalSlip);
            this.Controls.Add(this.txt_CustomerID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_CheckOutOfDate";
            this.Text = "Form_CheckOutOfDate";
            this.Load += new System.EventHandler(this.Form_CheckOutOfDate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListRentalSlips)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CustomerID;
        private System.Windows.Forms.Button btn_MakeRentalSlip;
        private System.Windows.Forms.DataGridView dataGridView_ListRentalSlips;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label_OverDue;
        private System.Windows.Forms.Label label_OnTime;
    }
}