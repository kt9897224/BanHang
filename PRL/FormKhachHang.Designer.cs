namespace PRL
{
    partial class FormKhachHang
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tb_ID = new TextBox();
            tb_tenKH = new TextBox();
            rdo_Nam = new RadioButton();
            rdo_Nu = new RadioButton();
            tb_SDT = new TextBox();
            tb_diaChi = new TextBox();
            dtp_NgaySinhKH = new DateTimePicker();
            tb_TimKiemKH = new TextBox();
            btn_themKH = new Button();
            btn_UpdateKH = new Button();
            btn_clearKH = new Button();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(393, 9);
            label1.Name = "label1";
            label1.Size = new Size(334, 38);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_clearKH);
            groupBox1.Controls.Add(btn_UpdateKH);
            groupBox1.Controls.Add(btn_themKH);
            groupBox1.Controls.Add(tb_TimKiemKH);
            groupBox1.Controls.Add(dtp_NgaySinhKH);
            groupBox1.Controls.Add(tb_diaChi);
            groupBox1.Controls.Add(tb_SDT);
            groupBox1.Controls.Add(rdo_Nu);
            groupBox1.Controls.Add(rdo_Nam);
            groupBox1.Controls.Add(tb_tenKH);
            groupBox1.Controls.Add(tb_ID);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(7, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1143, 295);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin khách hàng ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(9, 39);
            label2.Name = "label2";
            label2.Size = new Size(131, 23);
            label2.TabIndex = 0;
            label2.Text = "ID Khách hàng ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(6, 95);
            label3.Name = "label3";
            label3.Size = new Size(134, 23);
            label3.TabIndex = 1;
            label3.Text = "Tên khách hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(9, 153);
            label4.Name = "label4";
            label4.Size = new Size(88, 23);
            label4.TabIndex = 2;
            label4.Text = "Giới Tính ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.Location = new Point(542, 39);
            label6.Name = "label6";
            label6.Size = new Size(97, 23);
            label6.TabIndex = 4;
            label6.Text = "Ngày Sinh ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label7.Location = new Point(542, 95);
            label7.Name = "label7";
            label7.Size = new Size(43, 23);
            label7.TabIndex = 5;
            label7.Text = "SĐT";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label8.Location = new Point(542, 153);
            label8.Name = "label8";
            label8.Size = new Size(73, 23);
            label8.TabIndex = 6;
            label8.Text = "Địa Chỉ ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label9.Location = new Point(9, 233);
            label9.Name = "label9";
            label9.Size = new Size(88, 28);
            label9.TabIndex = 7;
            label9.Text = "SEARCH";
            // 
            // tb_ID
            // 
            tb_ID.Location = new Point(146, 35);
            tb_ID.Name = "tb_ID";
            tb_ID.Size = new Size(355, 27);
            tb_ID.TabIndex = 8;
            // 
            // tb_tenKH
            // 
            tb_tenKH.Location = new Point(146, 91);
            tb_tenKH.Name = "tb_tenKH";
            tb_tenKH.Size = new Size(355, 27);
            tb_tenKH.TabIndex = 9;
            // 
            // rdo_Nam
            // 
            rdo_Nam.AutoSize = true;
            rdo_Nam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            rdo_Nam.Location = new Point(146, 146);
            rdo_Nam.Name = "rdo_Nam";
            rdo_Nam.Size = new Size(75, 32);
            rdo_Nam.TabIndex = 10;
            rdo_Nam.TabStop = true;
            rdo_Nam.Text = "Nam";
            rdo_Nam.UseVisualStyleBackColor = true;
            // 
            // rdo_Nu
            // 
            rdo_Nu.AutoSize = true;
            rdo_Nu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            rdo_Nu.Location = new Point(353, 144);
            rdo_Nu.Name = "rdo_Nu";
            rdo_Nu.Size = new Size(60, 32);
            rdo_Nu.TabIndex = 11;
            rdo_Nu.TabStop = true;
            rdo_Nu.Text = "Nữ";
            rdo_Nu.UseVisualStyleBackColor = true;
            // 
            // tb_SDT
            // 
            tb_SDT.Location = new Point(645, 91);
            tb_SDT.Name = "tb_SDT";
            tb_SDT.Size = new Size(467, 27);
            tb_SDT.TabIndex = 13;
            // 
            // tb_diaChi
            // 
            tb_diaChi.Location = new Point(645, 144);
            tb_diaChi.Name = "tb_diaChi";
            tb_diaChi.Size = new Size(467, 27);
            tb_diaChi.TabIndex = 14;
            // 
            // dtp_NgaySinhKH
            // 
            dtp_NgaySinhKH.Location = new Point(645, 39);
            dtp_NgaySinhKH.Name = "dtp_NgaySinhKH";
            dtp_NgaySinhKH.Size = new Size(461, 27);
            dtp_NgaySinhKH.TabIndex = 15;
            // 
            // tb_TimKiemKH
            // 
            tb_TimKiemKH.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            tb_TimKiemKH.Location = new Point(110, 227);
            tb_TimKiemKH.Name = "tb_TimKiemKH";
            tb_TimKiemKH.Size = new Size(391, 34);
            tb_TimKiemKH.TabIndex = 16;
            // 
            // btn_themKH
            // 
            btn_themKH.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn_themKH.Location = new Point(542, 224);
            btn_themKH.Name = "btn_themKH";
            btn_themKH.Size = new Size(148, 38);
            btn_themKH.TabIndex = 17;
            btn_themKH.Text = "Thêm KH";
            btn_themKH.UseVisualStyleBackColor = true;
            // 
            // btn_UpdateKH
            // 
            btn_UpdateKH.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn_UpdateKH.Location = new Point(747, 224);
            btn_UpdateKH.Name = "btn_UpdateKH";
            btn_UpdateKH.Size = new Size(148, 38);
            btn_UpdateKH.TabIndex = 18;
            btn_UpdateKH.Text = "UPDATE";
            btn_UpdateKH.UseVisualStyleBackColor = true;
            // 
            // btn_clearKH
            // 
            btn_clearKH.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn_clearKH.Location = new Point(970, 224);
            btn_clearKH.Name = "btn_clearKH";
            btn_clearKH.Size = new Size(148, 38);
            btn_clearKH.TabIndex = 19;
            btn_clearKH.Text = "CLEAR";
            btn_clearKH.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(12, 387);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1138, 311);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khách hàng ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1114, 268);
            dataGridView1.TabIndex = 0;
            // 
            // FormKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 710);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FormKhachHang";
            Text = "FormKhachHang";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox tb_tenKH;
        private TextBox tb_ID;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private RadioButton rdo_Nu;
        private RadioButton rdo_Nam;
        private DateTimePicker dtp_NgaySinhKH;
        private TextBox tb_diaChi;
        private TextBox tb_SDT;
        private Button btn_clearKH;
        private Button btn_UpdateKH;
        private Button btn_themKH;
        private TextBox tb_TimKiemKH;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
    }
}