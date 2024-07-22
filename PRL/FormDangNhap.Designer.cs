namespace PRL
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            picShow = new PictureBox();
            picHide = new PictureBox();
            label2 = new Label();
            btnCancel = new Button();
            btnLogin = new Button();
            txtPass = new TextBox();
            txtUser = new TextBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // picShow
            // 
            picShow.Image = (Image)resources.GetObject("picShow.Image");
            picShow.Location = new Point(509, 368);
            picShow.Name = "picShow";
            picShow.Size = new Size(17, 14);
            picShow.SizeMode = PictureBoxSizeMode.StretchImage;
            picShow.TabIndex = 59;
            picShow.TabStop = false;
            // 
            // picHide
            // 
            picHide.Image = (Image)resources.GetObject("picHide.Image");
            picHide.Location = new Point(509, 368);
            picHide.Name = "picHide";
            picHide.Size = new Size(17, 14);
            picHide.SizeMode = PictureBoxSizeMode.StretchImage;
            picHide.TabIndex = 58;
            picHide.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(221, 19);
            label2.Name = "label2";
            label2.Size = new Size(260, 54);
            label2.TabIndex = 57;
            label2.Text = "Đăng nhập";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.Highlight;
            btnCancel.ForeColor = SystemColors.ActiveCaptionText;
            btnCancel.Location = new Point(397, 434);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(164, 55);
            btnCancel.TabIndex = 56;
            btnCancel.Text = "Thoát";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Highlight;
            btnLogin.Location = new Point(131, 434);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(164, 55);
            btnLogin.TabIndex = 55;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(174, 357);
            txtPass.Multiline = true;
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(362, 36);
            txtPass.TabIndex = 54;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(174, 302);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(362, 36);
            txtUser.TabIndex = 53;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(105, 357);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(45, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 52;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(105, 302);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 51;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 112);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 50;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(201, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(298, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 509);
            Controls.Add(picShow);
            Controls.Add(picHide);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormDangNhap";
            Text = "FormDangNhap";
            ((System.ComponentModel.ISupportInitialize)picShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picShow;
        private PictureBox picHide;
        private Label label2;
        private Button btnCancel;
        private Button btnLogin;
        private TextBox txtPass;
        private TextBox txtUser;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox1;
    }
}