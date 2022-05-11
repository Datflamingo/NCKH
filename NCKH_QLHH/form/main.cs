using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCKH_QLHH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_quanli_Click(object sender, EventArgs e)
        {
            QuanLi f3 = new QuanLi();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }

        private void btn_chinhsua_Click(object sender, EventArgs e)
        {
            Them f3 = new Them();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }
    }
}
