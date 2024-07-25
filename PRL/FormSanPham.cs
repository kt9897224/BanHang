using BUS.Servies;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL
{
    public partial class FormSanPham : Form
    {
        List<SanPham> sanPhams;
        SanPhamSevies sevies;
        public FormSanPham()
        {
            sevies = new SanPhamSevies();
            sanPhams = sevies.GetAll();
            InitializeComponent();
        }
        public void LoadSpToPanel(int page)
        {
            tlp_SanPham.Controls.Clear();
            int numberofpage = (int)Math.Ceiling((decimal)sanPhams.Count / 4);
            if (page < 1 || page > numberofpage)
            {
                return;
            }
            else
            {
                if (page * 4 - 4 < sanPhams.Count)
                {
                    Panel s1 = CreatePanelSP(sanPhams[page * 4 - 3]);
                }
            }
        }
        public Panel CreatePanelSP(SanPham sp)           
        {
            Panel p = new Panel(); p.Size = new Size(555, 360);
            p.Name = sp.Idsp.ToString(); // gán ID thành tên panel để khi chọn 1 nút trên panel sẽ lấy được ID
            PictureBox ptb = new PictureBox(); ptb.Size = new Size(297, 287);
            ptb.Image = Image.FromFile(sp.Mota); // gán hình ảnh của picturebox = URL ảnh của sản phẩm
            ptb.Location = new Point(14, 12);
            ptb.SizeMode = PictureBoxSizeMode.StretchImage;
            Label lbTen = new Label(); lbTen.Text = "Tên sản phẩm";
            lbTen.Location = new Point(331, 14);
            Label lbTenValue = new Label(); lbTenValue.Text = sp.TenSp; // Gán tên sản phẩm cho label này
            lbTenValue.Location = new Point(332, 47);
            Label lbGia = new Label(); lbGia.Text = "Gia sản phẩm";
            lbGia.Location = new Point(331, 87);
            Label lbGiaValue = new Label(); lbGiaValue.Text = sp.Gia + "";
            lbGiaValue.Location = new Point(332, 123);
            Label lbSL = new Label(); lbSL.Text = "Số lượng sản phẩm";
            lbSL.Location = new Point(332, 165);
            Label lbSLValue = new Label(); lbSLValue.Text = sp.Soluong + "";
            lbSLValue.Name = "Soluong"; // Gán tên để lát lấy data
            lbSLValue.Location = new Point(332, 198);
            Label lbMua = new Label(); lbMua.Text = "Số lượng mua";
            lbMua.Location = new Point(332, 232);
            Button btnMua = new Button();
            btnMua.Location = new Point(442, 263);
            btnMua.Size = new Size(83, 39); btnMua.Text = "MUA";
            btnMua.MouseClick += BtnMua_MouseClick;
            TextBox tbSoLuong = new TextBox(); tbSoLuong.PlaceholderText = "Nhập";
            tbSoLuong.Location = new Point(332, 268); tbSoLuong.Size = new Size(83, 34);
            tbSoLuong.Name = "tbSoLuong";
            p.Controls.Add(ptb); p.Controls.Add(lbTen); p.Controls.Add(lbTenValue); p.Controls.Add(lbGia);
            p.Controls.Add(lbGiaValue); p.Controls.Add(lbSL); p.Controls.Add(lbSLValue); p.Controls.Add(lbMua);
            p.Controls.Add(btnMua); p.Controls.Add(tbSoLuong);
            return p;
        }

        public void BtnMua_MouseClick(object sender, MouseEventArgs e)
        {

        }


            private void FormSanPham_Load(object sender, EventArgs e)
            {

            }

            private void btn_ShowSP_Click(object sender, EventArgs e)
            {
                tlp_SanPham.Controls.Clear();
                tlp_SanPham.ColumnCount = 2;
                tlp_SanPham.RowCount = 2;
                LoadSpToPanel(Convert.ToInt32(lb_page.Text));
            }
        }
    }

