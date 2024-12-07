namespace LibraryManagement.View
{
    partial class QLKH
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
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView_Cus = new System.Windows.Forms.DataGridView();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_ID_Cus = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dateTime_startdate = new System.Windows.Forms.DateTimePicker();
            this.txt_gender = new System.Windows.Forms.ComboBox();
            this.dateTime_dob = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cccd = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_Name_Cus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cus)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 16);
            this.label10.TabIndex = 146;
            this.label10.Text = "Danh sách khách hàng";
            // 
            // dataGridView_Cus
            // 
            this.dataGridView_Cus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Cus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Cus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Cus.Location = new System.Drawing.Point(-9, 299);
            this.dataGridView_Cus.Name = "dataGridView_Cus";
            this.dataGridView_Cus.ReadOnly = true;
            this.dataGridView_Cus.RowHeadersWidth = 51;
            this.dataGridView_Cus.RowTemplate.Height = 24;
            this.dataGridView_Cus.Size = new System.Drawing.Size(895, 390);
            this.dataGridView_Cus.TabIndex = 145;
            this.dataGridView_Cus.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Cus_RowHeaderMouseClick);
            // 
            // btn_sua
            // 
            this.btn_sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sua.Location = new System.Drawing.Point(715, 136);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(103, 36);
            this.btn_sua.TabIndex = 143;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Visible = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_xoa.Location = new System.Drawing.Point(715, 81);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(103, 32);
            this.btn_xoa.TabIndex = 144;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Visible = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_them.Location = new System.Drawing.Point(715, 198);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(103, 36);
            this.btn_them.TabIndex = 142;
            this.btn_them.Text = "Thêm mới ";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_ID_Cus
            // 
            this.txt_ID_Cus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_ID_Cus.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_ID_Cus.Location = new System.Drawing.Point(384, 223);
            this.txt_ID_Cus.Name = "txt_ID_Cus";
            this.txt_ID_Cus.ReadOnly = true;
            this.txt_ID_Cus.Size = new System.Drawing.Size(247, 22);
            this.txt_ID_Cus.TabIndex = 140;
            this.txt_ID_Cus.TabStop = false;
            this.txt_ID_Cus.Visible = false;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label17.Location = new System.Drawing.Point(381, 203);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 17);
            this.label17.TabIndex = 141;
            this.label17.Text = "Customer ID";
            this.label17.Visible = false;
            // 
            // dateTime_startdate
            // 
            this.dateTime_startdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dateTime_startdate.Location = new System.Drawing.Point(386, 165);
            this.dateTime_startdate.Name = "dateTime_startdate";
            this.dateTime_startdate.Size = new System.Drawing.Size(247, 22);
            this.dateTime_startdate.TabIndex = 133;
            // 
            // txt_gender
            // 
            this.txt_gender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_gender.FormattingEnabled = true;
            this.txt_gender.Items.AddRange(new object[] {
            "Nam",
            "Nữ ",
            "Khác"});
            this.txt_gender.Location = new System.Drawing.Point(47, 113);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(247, 24);
            this.txt_gender.TabIndex = 127;
            // 
            // dateTime_dob
            // 
            this.dateTime_dob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dateTime_dob.Location = new System.Drawing.Point(47, 165);
            this.dateTime_dob.Name = "dateTime_dob";
            this.dateTime_dob.Size = new System.Drawing.Size(247, 22);
            this.dateTime_dob.TabIndex = 128;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(383, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 16);
            this.label9.TabIndex = 139;
            this.label9.Text = "Date of issuance";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 16);
            this.label8.TabIndex = 138;
            this.label8.Text = "Citizen Identification";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 137;
            this.label7.Text = "Phone number";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 136;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 135;
            this.label5.Text = "Day of birth";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 134;
            this.label4.Text = "Gender";
            // 
            // txt_cccd
            // 
            this.txt_cccd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_cccd.Location = new System.Drawing.Point(384, 118);
            this.txt_cccd.Name = "txt_cccd";
            this.txt_cccd.Size = new System.Drawing.Size(247, 22);
            this.txt_cccd.TabIndex = 132;
            // 
            // txt_phone
            // 
            this.txt_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_phone.Location = new System.Drawing.Point(386, 67);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(247, 22);
            this.txt_phone.TabIndex = 131;
            // 
            // txt_address
            // 
            this.txt_address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_address.Location = new System.Drawing.Point(49, 223);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(245, 22);
            this.txt_address.TabIndex = 130;
            // 
            // txt_Name_Cus
            // 
            this.txt_Name_Cus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_Name_Cus.Location = new System.Drawing.Point(47, 64);
            this.txt_Name_Cus.Name = "txt_Name_Cus";
            this.txt_Name_Cus.Size = new System.Drawing.Size(247, 22);
            this.txt_Name_Cus.TabIndex = 126;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 129;
            this.label3.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 125;
            this.label1.Text = "Thông tin khách hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // QLKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 682);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView_Cus);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_ID_Cus);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dateTime_startdate);
            this.Controls.Add(this.txt_gender);
            this.Controls.Add(this.dateTime_dob);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_cccd);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_Name_Cus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "QLKH";
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.QLKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView_Cus;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_ID_Cus;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dateTime_startdate;
        private System.Windows.Forms.ComboBox txt_gender;
        private System.Windows.Forms.DateTimePicker dateTime_dob;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cccd;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_Name_Cus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}