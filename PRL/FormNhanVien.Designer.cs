namespace PRL
{
    partial class FormNhanVien
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            aaa = new Label();
            bbb = new Label();
            lb_GioiTinh = new Label();
            lb_NgaySinh = new Label();
            lb_SDT = new Label();
            lb_DiaChi = new Label();
            btn_themNV = new Button();
            btn_Nhanvien = new Button();
            tb_MaNv = new TextBox();
            tb_TenNv = new TextBox();
            tb_SDT = new TextBox();
            tb_DiaChi = new TextBox();
            dtp_NgaySinhNv = new DateTimePicker();
            rdo_Nam = new RadioButton();
            rdo_Nu = new RadioButton();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdo_Nu);
            groupBox1.Controls.Add(rdo_Nam);
            groupBox1.Controls.Add(dtp_NgaySinhNv);
            groupBox1.Controls.Add(tb_DiaChi);
            groupBox1.Controls.Add(tb_SDT);
            groupBox1.Controls.Add(tb_TenNv);
            groupBox1.Controls.Add(tb_MaNv);
            groupBox1.Controls.Add(btn_Nhanvien);
            groupBox1.Controls.Add(btn_themNV);
            groupBox1.Controls.Add(lb_DiaChi);
            groupBox1.Controls.Add(lb_SDT);
            groupBox1.Controls.Add(lb_NgaySinh);
            groupBox1.Controls.Add(lb_GioiTinh);
            groupBox1.Controls.Add(bbb);
            groupBox1.Controls.Add(aaa);
            groupBox1.Location = new Point(12, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1112, 244);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin nhân viên ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(410, 21);
            label1.Name = "label1";
            label1.Size = new Size(312, 38);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ NHÂN VIÊN ";
            // 
            // aaa
            // 
            aaa.AutoSize = true;
            aaa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            aaa.Location = new Point(6, 35);
            aaa.Name = "aaa";
            aaa.Size = new Size(141, 28);
            aaa.TabIndex = 0;
            aaa.Text = "Mã nhân viên";
            // 
            // bbb
            // 
            bbb.AutoSize = true;
            bbb.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            bbb.Location = new Point(6, 83);
            bbb.Name = "bbb";
            bbb.Size = new Size(150, 28);
            bbb.TabIndex = 1;
            bbb.Text = "Tên nhân viên ";
            // 
            // lb_GioiTinh
            // 
            lb_GioiTinh.AutoSize = true;
            lb_GioiTinh.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_GioiTinh.Location = new Point(6, 127);
            lb_GioiTinh.Name = "lb_GioiTinh";
            lb_GioiTinh.Size = new Size(105, 28);
            lb_GioiTinh.TabIndex = 2;
            lb_GioiTinh.Text = "Giới Tính ";
            // 
            // lb_NgaySinh
            // 
            lb_NgaySinh.AutoSize = true;
            lb_NgaySinh.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_NgaySinh.Location = new Point(6, 170);
            lb_NgaySinh.Name = "lb_NgaySinh";
            lb_NgaySinh.Size = new Size(115, 28);
            lb_NgaySinh.TabIndex = 3;
            lb_NgaySinh.Text = "Ngày Sinh ";
            // 
            // lb_SDT
            // 
            lb_SDT.AutoSize = true;
            lb_SDT.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_SDT.Location = new Point(618, 37);
            lb_SDT.Name = "lb_SDT";
            lb_SDT.Size = new Size(50, 28);
            lb_SDT.TabIndex = 4;
            lb_SDT.Text = "SĐT";
            // 
            // lb_DiaChi
            // 
            lb_DiaChi.AutoSize = true;
            lb_DiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_DiaChi.Location = new Point(588, 100);
            lb_DiaChi.Name = "lb_DiaChi";
            lb_DiaChi.Size = new Size(80, 28);
            lb_DiaChi.TabIndex = 5;
            lb_DiaChi.Text = "Địa Chỉ";
            // 
            // btn_themNV
            // 
            btn_themNV.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            btn_themNV.Location = new Point(588, 170);
            btn_themNV.Name = "btn_themNV";
            btn_themNV.Size = new Size(194, 53);
            btn_themNV.TabIndex = 6;
            btn_themNV.Text = "Thêm Nhân Viên ";
            btn_themNV.UseVisualStyleBackColor = true;
            // 
            // btn_Nhanvien
            // 
            btn_Nhanvien.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            btn_Nhanvien.Location = new Point(846, 170);
            btn_Nhanvien.Name = "btn_Nhanvien";
            btn_Nhanvien.Size = new Size(218, 53);
            btn_Nhanvien.TabIndex = 7;
            btn_Nhanvien.Text = "Xóa Nhân Viên ";
            btn_Nhanvien.UseVisualStyleBackColor = true;
            // 
            // tb_MaNv
            // 
            tb_MaNv.Location = new Point(163, 37);
            tb_MaNv.Name = "tb_MaNv";
            tb_MaNv.Size = new Size(387, 27);
            tb_MaNv.TabIndex = 8;
            // 
            // tb_TenNv
            // 
            tb_TenNv.Location = new Point(165, 88);
            tb_TenNv.Name = "tb_TenNv";
            tb_TenNv.Size = new Size(385, 27);
            tb_TenNv.TabIndex = 9;
            // 
            // tb_SDT
            // 
            tb_SDT.Location = new Point(677, 35);
            tb_SDT.Name = "tb_SDT";
            tb_SDT.Size = new Size(387, 27);
            tb_SDT.TabIndex = 10;
            // 
            // tb_DiaChi
            // 
            tb_DiaChi.Location = new Point(677, 100);
            tb_DiaChi.Name = "tb_DiaChi";
            tb_DiaChi.Size = new Size(387, 27);
            tb_DiaChi.TabIndex = 11;
            // 
            // dtp_NgaySinhNv
            // 
            dtp_NgaySinhNv.Location = new Point(167, 173);
            dtp_NgaySinhNv.Name = "dtp_NgaySinhNv";
            dtp_NgaySinhNv.Size = new Size(383, 27);
            dtp_NgaySinhNv.TabIndex = 12;
            // 
            // rdo_Nam
            // 
            rdo_Nam.AutoSize = true;
            rdo_Nam.Location = new Point(165, 134);
            rdo_Nam.Name = "rdo_Nam";
            rdo_Nam.Size = new Size(62, 24);
            rdo_Nam.TabIndex = 13;
            rdo_Nam.TabStop = true;
            rdo_Nam.Text = "Nam";
            rdo_Nam.UseVisualStyleBackColor = true;
            // 
            // rdo_Nu
            // 
            rdo_Nu.AutoSize = true;
            rdo_Nu.Location = new Point(417, 134);
            rdo_Nu.Name = "rdo_Nu";
            rdo_Nu.Size = new Size(50, 24);
            rdo_Nu.TabIndex = 14;
            rdo_Nu.TabStop = true;
            rdo_Nu.Text = "Nữ";
            rdo_Nu.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(18, 347);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1106, 248);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1091, 202);
            dataGridView1.TabIndex = 0;
            // 
            // FormNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 607);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "FormNhanVien";
            Text = "FormNhanVien";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lb_DiaChi;
        private Label lb_SDT;
        private Label lb_NgaySinh;
        private Label lb_GioiTinh;
        private Label bbb;
        private Label aaa;
        private Label label1;
        private Button btn_Nhanvien;
        private Button btn_themNV;
        private RadioButton rdo_Nu;
        private RadioButton rdo_Nam;
        private DateTimePicker dtp_NgaySinhNv;
        private TextBox tb_DiaChi;
        private TextBox tb_SDT;
        private TextBox tb_TenNv;
        private TextBox tb_MaNv;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
    }
}