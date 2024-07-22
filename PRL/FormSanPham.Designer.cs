namespace PRL
{
    partial class FormSanPham
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
            btn_ShowSP = new Button();
            btn_QLSP = new Button();
            tlp_SanPham = new TableLayoutPanel();
            lb_back = new Label();
            lb_page = new Label();
            lb_next = new Label();
            SuspendLayout();
            // 
            // btn_ShowSP
            // 
            btn_ShowSP.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_ShowSP.Location = new Point(12, 17);
            btn_ShowSP.Name = "btn_ShowSP";
            btn_ShowSP.Size = new Size(184, 65);
            btn_ShowSP.TabIndex = 0;
            btn_ShowSP.Text = "Hiển thị SP";
            btn_ShowSP.UseVisualStyleBackColor = true;
            // 
            // btn_QLSP
            // 
            btn_QLSP.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_QLSP.Location = new Point(12, 100);
            btn_QLSP.Name = "btn_QLSP";
            btn_QLSP.Size = new Size(184, 66);
            btn_QLSP.TabIndex = 0;
            btn_QLSP.Text = "Quản lý SP";
            btn_QLSP.UseVisualStyleBackColor = true;
            // 
            // tlp_SanPham
            // 
            tlp_SanPham.ColumnCount = 2;
            tlp_SanPham.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_SanPham.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_SanPham.Location = new Point(223, 17);
            tlp_SanPham.Name = "tlp_SanPham";
            tlp_SanPham.RowCount = 2;
            tlp_SanPham.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_SanPham.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_SanPham.Size = new Size(1110, 720);
            tlp_SanPham.TabIndex = 1;
            // 
            // lb_back
            // 
            lb_back.AutoSize = true;
            lb_back.Location = new Point(687, 749);
            lb_back.Name = "lb_back";
            lb_back.Size = new Size(39, 20);
            lb_back.TabIndex = 2;
            lb_back.Text = "<<<";
            // 
            // lb_page
            // 
            lb_page.AutoSize = true;
            lb_page.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lb_page.Location = new Point(767, 745);
            lb_page.Name = "lb_page";
            lb_page.Size = new Size(27, 31);
            lb_page.TabIndex = 2;
            lb_page.Text = "1";
            // 
            // lb_next
            // 
            lb_next.AutoSize = true;
            lb_next.Location = new Point(829, 751);
            lb_next.Name = "lb_next";
            lb_next.Size = new Size(39, 20);
            lb_next.TabIndex = 2;
            lb_next.Text = ">>>";
            // 
            // FormSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 786);
            Controls.Add(lb_next);
            Controls.Add(lb_page);
            Controls.Add(lb_back);
            Controls.Add(tlp_SanPham);
            Controls.Add(btn_QLSP);
            Controls.Add(btn_ShowSP);
            Name = "FormSanPham";
            Text = "FormSanPham";
            Load += FormSanPham_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ShowSP;
        private Button btn_QLSP;
        private TableLayoutPanel tlp_SanPham;
        private Label lb_back;
        private Label lb_page;
        private Label lb_next;
    }
}