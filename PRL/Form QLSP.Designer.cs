namespace PRL
{
    partial class Form_QLSP
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
            ptb_Mota = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tb_Ten = new TextBox();
            tb_Gia = new TextBox();
            cbb_Trangthai = new ComboBox();
            tb_Soluong = new TextBox();
            btn_Them = new Button();
            Btn_Sua = new Button();
            button3 = new Button();
            tbt_Timkiem = new TextBox();
            dtg_AllSP = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ptb_Mota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_AllSP).BeginInit();
            SuspendLayout();
            // 
            // ptb_Mota
            // 
            ptb_Mota.BackColor = Color.FromArgb(255, 128, 0);
            ptb_Mota.Location = new Point(12, 24);
            ptb_Mota.Name = "ptb_Mota";
            ptb_Mota.Size = new Size(261, 269);
            ptb_Mota.TabIndex = 0;
            ptb_Mota.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(303, 24);
            label1.Name = "label1";
            label1.Size = new Size(45, 28);
            label1.TabIndex = 1;
            label1.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(303, 92);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 2;
            label2.Text = "Số lượng ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(303, 156);
            label3.Name = "label3";
            label3.Size = new Size(43, 28);
            label3.TabIndex = 3;
            label3.Text = "Giá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(303, 225);
            label4.Name = "label4";
            label4.Size = new Size(114, 28);
            label4.TabIndex = 4;
            label4.Text = "Trạng thái ";
            // 
            // tb_Ten
            // 
            tb_Ten.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tb_Ten.Location = new Point(447, 24);
            tb_Ten.Name = "tb_Ten";
            tb_Ten.PlaceholderText = "Nhập tên";
            tb_Ten.Size = new Size(508, 34);
            tb_Ten.TabIndex = 5;
            // 
            // tb_Gia
            // 
            tb_Gia.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tb_Gia.Location = new Point(447, 150);
            tb_Gia.Name = "tb_Gia";
            tb_Gia.PlaceholderText = "Nhập giá";
            tb_Gia.Size = new Size(508, 34);
            tb_Gia.TabIndex = 5;
            // 
            // cbb_Trangthai
            // 
            cbb_Trangthai.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cbb_Trangthai.FormattingEnabled = true;
            cbb_Trangthai.Location = new Point(447, 217);
            cbb_Trangthai.Name = "cbb_Trangthai";
            cbb_Trangthai.Size = new Size(508, 36);
            cbb_Trangthai.TabIndex = 6;
            cbb_Trangthai.Text = "Chọn trạng thái ";
            // 
            // tb_Soluong
            // 
            tb_Soluong.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tb_Soluong.Location = new Point(447, 86);
            tb_Soluong.Name = "tb_Soluong";
            tb_Soluong.PlaceholderText = "Nhập số lượng ";
            tb_Soluong.Size = new Size(508, 34);
            tb_Soluong.TabIndex = 5;
            // 
            // btn_Them
            // 
            btn_Them.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_Them.Location = new Point(303, 293);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(202, 51);
            btn_Them.TabIndex = 7;
            btn_Them.Text = "Thêm mới";
            btn_Them.UseVisualStyleBackColor = true;
            // 
            // Btn_Sua
            // 
            Btn_Sua.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Btn_Sua.Location = new Point(532, 293);
            Btn_Sua.Name = "Btn_Sua";
            Btn_Sua.Size = new Size(202, 51);
            Btn_Sua.TabIndex = 7;
            Btn_Sua.Text = "Sửa";
            Btn_Sua.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.Location = new Point(753, 293);
            button3.Name = "button3";
            button3.Size = new Size(202, 51);
            button3.TabIndex = 7;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            // 
            // tbt_Timkiem
            // 
            tbt_Timkiem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tbt_Timkiem.Location = new Point(12, 350);
            tbt_Timkiem.Name = "tbt_Timkiem";
            tbt_Timkiem.PlaceholderText = "Nhập sản phẩm để tìm kiếm ";
            tbt_Timkiem.Size = new Size(943, 34);
            tbt_Timkiem.TabIndex = 8;
            // 
            // dtg_AllSP
            // 
            dtg_AllSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_AllSP.Location = new Point(12, 403);
            dtg_AllSP.Name = "dtg_AllSP";
            dtg_AllSP.RowHeadersWidth = 51;
            dtg_AllSP.Size = new Size(943, 288);
            dtg_AllSP.TabIndex = 9;
            // 
            // Form_QLSP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(967, 703);
            Controls.Add(dtg_AllSP);
            Controls.Add(tbt_Timkiem);
            Controls.Add(button3);
            Controls.Add(Btn_Sua);
            Controls.Add(btn_Them);
            Controls.Add(cbb_Trangthai);
            Controls.Add(tb_Gia);
            Controls.Add(tb_Soluong);
            Controls.Add(tb_Ten);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ptb_Mota);
            Name = "Form_QLSP";
            Text = "Form_QLSP";
            ((System.ComponentModel.ISupportInitialize)ptb_Mota).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_AllSP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ptb_Mota;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tb_Ten;
        private TextBox tb_Gia;
        private ComboBox cbb_Trangthai;
        private TextBox tb_Soluong;
        private Button btn_Them;
        private Button Btn_Sua;
        private Button button3;
        private TextBox tbt_Timkiem;
        private DataGridView dtg_AllSP;
    }
}