﻿using System;
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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void picShow_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_show.Checked)
            {
                txtPass.PasswordChar = '\0';

            }
            else
            {
                txtPass.PasswordChar = '*';
            }

        }
    }
}
