using System.Windows.Forms;

namespace LibraryManagement.View
{
    partial class Form_DashBoard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_monthRevenue = new System.Windows.Forms.Label();
            this.lb_weekRevenue = new System.Windows.Forms.Label();
            this.lb_dayRevenue = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_EmployeeNum = new System.Windows.Forms.Label();
            this.lb_AdminNum = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_userNum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_cusInMonth = new System.Windows.Forms.Label();
            this.lb_CusInWeek = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lb_CusNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_BookTitleNum = new System.Windows.Forms.Label();
            this.lb_BookNumOnLoan = new System.Windows.Forms.Label();
            this.lb_BookNum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(1, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1138, 485);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.Controls.Add(this.lb_monthRevenue);
            this.panel4.Controls.Add(this.lb_weekRevenue);
            this.panel4.Controls.Add(this.lb_dayRevenue);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(831, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(307, 170);
            this.panel4.TabIndex = 3;
            // 
            // lb_monthRevenue
            // 
            this.lb_monthRevenue.AutoSize = true;
            this.lb_monthRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_monthRevenue.Location = new System.Drawing.Point(136, 117);
            this.lb_monthRevenue.Name = "lb_monthRevenue";
            this.lb_monthRevenue.Size = new System.Drawing.Size(2, 18);
            this.lb_monthRevenue.TabIndex = 11;
            // 
            // lb_weekRevenue
            // 
            this.lb_weekRevenue.AutoSize = true;
            this.lb_weekRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_weekRevenue.Location = new System.Drawing.Point(136, 68);
            this.lb_weekRevenue.Name = "lb_weekRevenue";
            this.lb_weekRevenue.Size = new System.Drawing.Size(2, 18);
            this.lb_weekRevenue.TabIndex = 10;
            // 
            // lb_dayRevenue
            // 
            this.lb_dayRevenue.AutoSize = true;
            this.lb_dayRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_dayRevenue.Location = new System.Drawing.Point(136, 18);
            this.lb_dayRevenue.Name = "lb_dayRevenue";
            this.lb_dayRevenue.Size = new System.Drawing.Size(2, 18);
            this.lb_dayRevenue.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = " Doanh thu trong tháng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = " Doanh thu trong tuần";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = " Doanh thu trong ngày";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.lb_EmployeeNum);
            this.panel2.Controls.Add(this.lb_AdminNum);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lb_userNum);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(555, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 170);
            this.panel2.TabIndex = 2;
            // 
            // lb_EmployeeNum
            // 
            this.lb_EmployeeNum.AutoSize = true;
            this.lb_EmployeeNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_EmployeeNum.Location = new System.Drawing.Point(168, 66);
            this.lb_EmployeeNum.Name = "lb_EmployeeNum";
            this.lb_EmployeeNum.Size = new System.Drawing.Size(2, 18);
            this.lb_EmployeeNum.TabIndex = 8;
            // 
            // lb_AdminNum
            // 
            this.lb_AdminNum.AutoSize = true;
            this.lb_AdminNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_AdminNum.Location = new System.Drawing.Point(168, 115);
            this.lb_AdminNum.Name = "lb_AdminNum";
            this.lb_AdminNum.Size = new System.Drawing.Size(2, 18);
            this.lb_AdminNum.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Số lượng nhân viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Số lượng Admin";
            // 
            // lb_userNum
            // 
            this.lb_userNum.AutoSize = true;
            this.lb_userNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_userNum.Location = new System.Drawing.Point(168, 18);
            this.lb_userNum.Name = "lb_userNum";
            this.lb_userNum.Size = new System.Drawing.Size(2, 18);
            this.lb_userNum.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng người dùng";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.lb_cusInMonth);
            this.panel3.Controls.Add(this.lb_CusInWeek);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.lb_CusNum);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(279, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 170);
            this.panel3.TabIndex = 2;
            // 
            // lb_cusInMonth
            // 
            this.lb_cusInMonth.AutoSize = true;
            this.lb_cusInMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_cusInMonth.Location = new System.Drawing.Point(186, 115);
            this.lb_cusInMonth.Name = "lb_cusInMonth";
            this.lb_cusInMonth.Size = new System.Drawing.Size(2, 18);
            this.lb_cusInMonth.TabIndex = 9;
            // 
            // lb_CusInWeek
            // 
            this.lb_CusInWeek.AutoSize = true;
            this.lb_CusInWeek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_CusInWeek.Location = new System.Drawing.Point(186, 65);
            this.lb_CusInWeek.Name = "lb_CusInWeek";
            this.lb_CusInWeek.Size = new System.Drawing.Size(2, 18);
            this.lb_CusInWeek.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(193, 16);
            this.label14.TabIndex = 7;
            this.label14.Text = "Số lượng khách mới trong tháng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(185, 16);
            this.label13.TabIndex = 6;
            this.label13.Text = "Số lượng khách mới trong tuần";
            // 
            // lb_CusNum
            // 
            this.lb_CusNum.AutoSize = true;
            this.lb_CusNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_CusNum.Location = new System.Drawing.Point(185, 18);
            this.lb_CusNum.Name = "lb_CusNum";
            this.lb_CusNum.Size = new System.Drawing.Size(2, 18);
            this.lb_CusNum.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng khách hàng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.lb_BookTitleNum);
            this.panel1.Controls.Add(this.lb_BookNumOnLoan);
            this.panel1.Controls.Add(this.lb_BookNum);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 170);
            this.panel1.TabIndex = 1;
            // 
            // lb_BookTitleNum
            // 
            this.lb_BookTitleNum.AutoSize = true;
            this.lb_BookTitleNum.BackColor = System.Drawing.Color.Tomato;
            this.lb_BookTitleNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_BookTitleNum.Location = new System.Drawing.Point(177, 117);
            this.lb_BookTitleNum.Name = "lb_BookTitleNum";
            this.lb_BookTitleNum.Size = new System.Drawing.Size(2, 18);
            this.lb_BookTitleNum.TabIndex = 5;
            // 
            // lb_BookNumOnLoan
            // 
            this.lb_BookNumOnLoan.AutoSize = true;
            this.lb_BookNumOnLoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_BookNumOnLoan.Location = new System.Drawing.Point(176, 67);
            this.lb_BookNumOnLoan.Name = "lb_BookNumOnLoan";
            this.lb_BookNumOnLoan.Size = new System.Drawing.Size(2, 18);
            this.lb_BookNumOnLoan.TabIndex = 4;
            // 
            // lb_BookNum
            // 
            this.lb_BookNum.AutoSize = true;
            this.lb_BookNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_BookNum.Location = new System.Drawing.Point(176, 16);
            this.lb_BookNum.Name = "lb_BookNum";
            this.lb_BookNum.Size = new System.Drawing.Size(2, 18);
            this.lb_BookNum.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tổng số lượng đầu sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số lượng sách cho mượn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng số lượng sách";
            // 
            // flowPanel
            // 
            this.flowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPanel.BackColor = System.Drawing.Color.White;
            this.flowPanel.Controls.Add(this.panel1);
            this.flowPanel.Controls.Add(this.panel3);
            this.flowPanel.Controls.Add(this.panel2);
            this.flowPanel.Controls.Add(this.panel4);
            this.flowPanel.Location = new System.Drawing.Point(1, -2);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(1138, 177);
            this.flowPanel.TabIndex = 4;
            this.flowPanel.WrapContents = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Danh sách được mượn gần đây";
            // 
            // Form_DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 712);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_DashBoard";
            this.Text = "Form_DashBoard";
            this.Load += new System.EventHandler(this.Form_DashBoard_Load);
            this.Resize += new System.EventHandler(this.Form_DashBoard_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_BookNum;
        private Label lb_userNum;
        private Label lb_EmployeeNum;
        private Label lb_AdminNum;
        private Label label9;
        private Label label8;
        private Label lb_monthRevenue;
        private Label lb_weekRevenue;
        private Label lb_dayRevenue;
        private Label label11;
        private Label label10;
        private Label label14;
        private Label label13;
        private Label lb_cusInMonth;
        private Label lb_CusInWeek;
        private Label lb_CusNum;
        private Label lb_BookNumOnLoan;
        private Label lb_BookTitleNum;
    }
}