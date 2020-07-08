using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang.View
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {

        }

        void bingling()
        {
            txtma.DataBindings.Clear();
            txtma.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "Manv");
            txtten.DataBindings.Clear();
            txtten.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "TenNhanVien");
            txtdiachi.DataBindings.Clear();
            txtdiachi.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "DiaChi");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "SDT");
            dtnamsinh.DataBindings.Clear();
            dtnamsinh.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "NamSinh");
            cmbgioitinh.DataBindings.Clear();
            cmbgioitinh.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "GioiTinh");
        }
    }
}
