namespace PRL
{
    partial class FormHoaDon
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            grb_tthoadon = new GroupBox();
            cbb_MaKH = new ComboBox();
            dtp_NLHD = new DateTimePicker();
            cbb_MaNV = new ComboBox();
            tb_Macode = new TextBox();
            label16 = new Label();
            label15 = new Label();
            tb_Tennv = new TextBox();
            label14 = new Label();
            tb_DiachiNhan = new TextBox();
            label13 = new Label();
            tb_tenKH = new TextBox();
            label12 = new Label();
            textBox4 = new TextBox();
            label11 = new Label();
            label4 = new Label();
            label10 = new Label();
            label7 = new Label();
            label6 = new Label();
            label9 = new Label();
            label8 = new Label();
            label3 = new Label();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            grb_ttsanpham = new GroupBox();
            cbb_MaSP = new ComboBox();
            tb_Sl = new TextBox();
            tb_UuDai = new TextBox();
            tb_TenSP = new TextBox();
            tb_GiaBan = new TextBox();
            tb_thanhtien = new TextBox();
            dataGridView1 = new DataGridView();
            btn_ThemBill = new Button();
            btn_ThemSP = new Button();
            btn_Cancelbill = new Button();
            btn_XoaSp = new Button();
            grb_tthoadon.SuspendLayout();
            grb_ttsanpham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(424, 9);
            label1.Name = "label1";
            label1.Size = new Size(194, 28);
            label1.TabIndex = 0;
            label1.Text = "Hóa đơn bán hàng ";
            // 
            // grb_tthoadon
            // 
            grb_tthoadon.Controls.Add(cbb_MaKH);
            grb_tthoadon.Controls.Add(dtp_NLHD);
            grb_tthoadon.Controls.Add(cbb_MaNV);
            grb_tthoadon.Controls.Add(tb_Macode);
            grb_tthoadon.Controls.Add(label16);
            grb_tthoadon.Controls.Add(label15);
            grb_tthoadon.Controls.Add(tb_Tennv);
            grb_tthoadon.Controls.Add(label14);
            grb_tthoadon.Controls.Add(tb_DiachiNhan);
            grb_tthoadon.Controls.Add(label13);
            grb_tthoadon.Controls.Add(tb_tenKH);
            grb_tthoadon.Controls.Add(label12);
            grb_tthoadon.Controls.Add(textBox4);
            grb_tthoadon.Controls.Add(label11);
            grb_tthoadon.Controls.Add(label4);
            grb_tthoadon.Controls.Add(label10);
            grb_tthoadon.Location = new Point(12, 57);
            grb_tthoadon.Name = "grb_tthoadon";
            grb_tthoadon.Size = new Size(565, 382);
            grb_tthoadon.TabIndex = 1;
            grb_tthoadon.TabStop = false;
            grb_tthoadon.Text = "Thông tin hóa đơn ";
            // 
            // cbb_MaKH
            // 
            cbb_MaKH.FormattingEnabled = true;
            cbb_MaKH.Location = new Point(174, 241);
            cbb_MaKH.Name = "cbb_MaKH";
            cbb_MaKH.Size = new Size(366, 28);
            cbb_MaKH.TabIndex = 2;
            // 
            // dtp_NLHD
            // 
            dtp_NLHD.Location = new Point(174, 98);
            dtp_NLHD.Name = "dtp_NLHD";
            dtp_NLHD.Size = new Size(366, 27);
            dtp_NLHD.TabIndex = 3;
            dtp_NLHD.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // cbb_MaNV
            // 
            cbb_MaNV.FormattingEnabled = true;
            cbb_MaNV.Location = new Point(174, 153);
            cbb_MaNV.Name = "cbb_MaNV";
            cbb_MaNV.Size = new Size(366, 28);
            cbb_MaNV.TabIndex = 2;
            // 
            // tb_Macode
            // 
            tb_Macode.Location = new Point(176, 51);
            tb_Macode.Name = "tb_Macode";
            tb_Macode.PlaceholderText = "Nhập mã hóa đơn";
            tb_Macode.Size = new Size(364, 27);
            tb_Macode.TabIndex = 1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label16.Location = new Point(15, 55);
            label16.Name = "label16";
            label16.Size = new Size(78, 23);
            label16.TabIndex = 0;
            label16.Text = "Mã code";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label15.Location = new Point(15, 98);
            label15.Name = "label15";
            label15.Size = new Size(153, 23);
            label15.TabIndex = 0;
            label15.Text = "Ngày lập hóa đơn";
            // 
            // tb_Tennv
            // 
            tb_Tennv.Location = new Point(174, 192);
            tb_Tennv.Name = "tb_Tennv";
            tb_Tennv.Size = new Size(364, 27);
            tb_Tennv.TabIndex = 1;
            tb_Tennv.TextChanged += textBox5_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label14.Location = new Point(15, 336);
            label14.Name = "label14";
            label14.Size = new Size(114, 23);
            label14.TabIndex = 0;
            label14.Text = "Địa chỉ nhận ";
            // 
            // tb_DiachiNhan
            // 
            tb_DiachiNhan.Location = new Point(174, 332);
            tb_DiachiNhan.Name = "tb_DiachiNhan";
            tb_DiachiNhan.Size = new Size(364, 27);
            tb_DiachiNhan.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label13.Location = new Point(15, 289);
            label13.Name = "label13";
            label13.Size = new Size(139, 23);
            label13.TabIndex = 0;
            label13.Text = "Tên khách hàng ";
            // 
            // tb_tenKH
            // 
            tb_tenKH.Location = new Point(174, 285);
            tb_tenKH.Name = "tb_tenKH";
            tb_tenKH.Size = new Size(364, 27);
            tb_tenKH.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label12.Location = new Point(15, 148);
            label12.Name = "label12";
            label12.Size = new Size(122, 23);
            label12.TabIndex = 0;
            label12.Text = "Mã nhân viên ";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(174, 270);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(364, 27);
            textBox4.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label11.Location = new Point(15, 242);
            label11.Name = "label11";
            label11.Size = new Size(137, 23);
            label11.TabIndex = 0;
            label11.Text = "Mã khách hàng ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(15, 385);
            label4.Name = "label4";
            label4.Size = new Size(50, 28);
            label4.TabIndex = 0;
            label4.Text = "SĐT";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label10.Location = new Point(15, 196);
            label10.Name = "label10";
            label10.Size = new Size(119, 23);
            label10.TabIndex = 0;
            label10.Text = "Tên nhân viên";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.Location = new Point(600, 205);
            label7.Name = "label7";
            label7.Size = new Size(68, 23);
            label7.TabIndex = 0;
            label7.Text = "Ưu đãi ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(600, 253);
            label6.Name = "label6";
            label6.Size = new Size(129, 23);
            label6.TabIndex = 0;
            label6.Text = "Tên sản phẩm  ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label9.Location = new Point(600, 303);
            label9.Name = "label9";
            label9.Size = new Size(76, 23);
            label9.TabIndex = 0;
            label9.Text = "Giá bán ";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label8.Location = new Point(600, 346);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 0;
            label8.Text = "Thành tiền ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(600, 112);
            label3.Name = "label3";
            label3.Size = new Size(122, 23);
            label3.TabIndex = 0;
            label3.Text = "Mã sản phẩm ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(600, 159);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 0;
            label2.Text = "Số lượng ";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // grb_ttsanpham
            // 
            grb_ttsanpham.Controls.Add(dataGridView1);
            grb_ttsanpham.Location = new Point(15, 455);
            grb_ttsanpham.Name = "grb_ttsanpham";
            grb_ttsanpham.Size = new Size(1141, 226);
            grb_ttsanpham.TabIndex = 2;
            grb_ttsanpham.TabStop = false;
            grb_ttsanpham.Text = "Thông tin sản phẩm ";
            // 
            // cbb_MaSP
            // 
            cbb_MaSP.FormattingEnabled = true;
            cbb_MaSP.Location = new Point(728, 107);
            cbb_MaSP.Name = "cbb_MaSP";
            cbb_MaSP.Size = new Size(383, 28);
            cbb_MaSP.TabIndex = 4;
            // 
            // tb_Sl
            // 
            tb_Sl.Location = new Point(728, 151);
            tb_Sl.Name = "tb_Sl";
            tb_Sl.Size = new Size(383, 27);
            tb_Sl.TabIndex = 5;
            tb_Sl.TextChanged += textBox2_TextChanged;
            // 
            // tb_UuDai
            // 
            tb_UuDai.Location = new Point(728, 201);
            tb_UuDai.Name = "tb_UuDai";
            tb_UuDai.Size = new Size(383, 27);
            tb_UuDai.TabIndex = 5;
            // 
            // tb_TenSP
            // 
            tb_TenSP.Location = new Point(728, 249);
            tb_TenSP.Name = "tb_TenSP";
            tb_TenSP.Size = new Size(383, 27);
            tb_TenSP.TabIndex = 6;
            // 
            // tb_GiaBan
            // 
            tb_GiaBan.Location = new Point(728, 295);
            tb_GiaBan.Name = "tb_GiaBan";
            tb_GiaBan.Size = new Size(383, 27);
            tb_GiaBan.TabIndex = 7;
            tb_GiaBan.TextChanged += textBox9_TextChanged;
            // 
            // tb_thanhtien
            // 
            tb_thanhtien.Location = new Point(728, 342);
            tb_thanhtien.Name = "tb_thanhtien";
            tb_thanhtien.Size = new Size(383, 27);
            tb_thanhtien.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1119, 187);
            dataGridView1.TabIndex = 0;
            // 
            // btn_ThemBill
            // 
            btn_ThemBill.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_ThemBill.Location = new Point(600, 389);
            btn_ThemBill.Name = "btn_ThemBill";
            btn_ThemBill.Size = new Size(121, 40);
            btn_ThemBill.TabIndex = 9;
            btn_ThemBill.Text = "BILL Mới";
            btn_ThemBill.UseVisualStyleBackColor = true;
            // 
            // btn_ThemSP
            // 
            btn_ThemSP.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_ThemSP.Location = new Point(728, 389);
            btn_ThemSP.Name = "btn_ThemSP";
            btn_ThemSP.Size = new Size(139, 40);
            btn_ThemSP.TabIndex = 10;
            btn_ThemSP.Text = "Thêm Sản Phẩm ";
            btn_ThemSP.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelbill
            // 
            btn_Cancelbill.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Cancelbill.Location = new Point(868, 389);
            btn_Cancelbill.Name = "btn_Cancelbill";
            btn_Cancelbill.Size = new Size(116, 40);
            btn_Cancelbill.TabIndex = 11;
            btn_Cancelbill.Text = "CANCEL BILL";
            btn_Cancelbill.UseVisualStyleBackColor = true;
            // 
            // btn_XoaSp
            // 
            btn_XoaSp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_XoaSp.Location = new Point(990, 389);
            btn_XoaSp.Name = "btn_XoaSp";
            btn_XoaSp.Size = new Size(121, 40);
            btn_XoaSp.TabIndex = 12;
            btn_XoaSp.Text = "Xóa SP";
            btn_XoaSp.UseVisualStyleBackColor = true;
            // 
            // FormHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 693);
            Controls.Add(btn_XoaSp);
            Controls.Add(btn_Cancelbill);
            Controls.Add(btn_ThemSP);
            Controls.Add(btn_ThemBill);
            Controls.Add(tb_thanhtien);
            Controls.Add(tb_GiaBan);
            Controls.Add(tb_TenSP);
            Controls.Add(tb_UuDai);
            Controls.Add(tb_Sl);
            Controls.Add(cbb_MaSP);
            Controls.Add(grb_ttsanpham);
            Controls.Add(grb_tthoadon);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(label6);
            Name = "FormHoaDon";
            Text = "FormHoaDon";
            grb_tthoadon.ResumeLayout(false);
            grb_tthoadon.PerformLayout();
            grb_ttsanpham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox grb_tthoadon;
        private Label label7;
        private Label label6;
        private Label label9;
        private Label label8;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cbb_MaKH;
        private ComboBox cbb_MaNV;
        private TextBox tb_Macode;
        private TextBox tb_Tennv;
        private TextBox tb_DiachiNhan;
        private TextBox tb_tenKH;
        private TextBox textBox4;
        private ContextMenuStrip contextMenuStrip1;
        private DateTimePicker dtp_NLHD;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private GroupBox grb_ttsanpham;
        private ComboBox cbb_MaSP;
        private TextBox tb_Sl;
        private TextBox tb_UuDai;
        private TextBox tb_TenSP;
        private TextBox tb_GiaBan;
        private TextBox tb_thanhtien;
        private DataGridView dataGridView1;
        private Button btn_ThemBill;
        private Button btn_ThemSP;
        private Button btn_Cancelbill;
        private Button btn_XoaSp;
    }
}