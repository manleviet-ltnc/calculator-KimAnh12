using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool isTypingNumber = false;
        private void NhapSo(object sender, EventArgs e)
        {
            string so = ((Button)sender).Text;
            NhapSo(so);

                }
        private void NhapSo(string so)
        {
            if (isTypingNumber)
                lblHienThi.Text = lblHienThi.Text + so ;
            else
            {
                lblHienThi.Text = so ;
                isTypingNumber = true;
            }
        }
    }
}
