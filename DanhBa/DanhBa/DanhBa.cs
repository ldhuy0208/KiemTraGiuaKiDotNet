using DanhBa.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanhBa
{
    public partial class DanhBa : Form
    {
        public DanhBa()
        {
            InitializeComponent();

            dataGridView_lienLac.AutoGenerateColumns = false;
            loadNhom();
            
        }
        void loadNhom()
        {
            bindingSource_nhom.DataSource = Nhom.LayDanhSachNhomDatabase();
            dataGridView_nhom.DataSource = bindingSource_nhom;
        }

        void loadDanhSachLienLac(DataTable source)
        {
            bindingSource_lienLac.DataSource = source;
            dataGridView_lienLac.DataSource = bindingSource_lienLac;
        }

        private void dataGridView_nhom_SelectionChanged(object sender, EventArgs e)
        {
            DataRowView nhom = (bindingSource_nhom.Current as DataRowView);
            if (nhom == null)
                return;
            loadDanhSachLienLac(LienLac.layDanhSachLienHe((int)nhom["MaNhom"]));
        }

        private void dataGridView_lienLac_SelectionChanged(object sender, EventArgs e)
        {
            LienLac lienLac = LienLac.ParseLienLac(bindingSource_lienLac.Current as DataRowView);
            if (lienLac == null)
            {
                textBox_ten.Text = "";
                textBox_email.Text = "";
                textBox_soDienThoai.Text = "";
                textBox_diaChi.Text = "";
            }
            else
            {
                textBox_ten.Text = lienLac.TenLienLac;
                textBox_email.Text = lienLac.Email;
                textBox_soDienThoai.Text = lienLac.SoDienThoai;
                textBox_diaChi.Text = lienLac.DiaChi;
            }
        }

        private void toolStripButton_xoaNhom_Click(object sender, EventArgs e)
        {
            Nhom nhom = Nhom.ParseNhom(bindingSource_nhom.Current as DataRowView);
            if (MessageBox.Show("Bạn có muốn xóa nhóm \"" + nhom.TenNhom+"\" không?", "Xóa nhóm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bindingSource_nhom.RemoveCurrent();
                Nhom.xoaNhomDatabase(nhom.MaNhom);   
            }
        }

        private void toolStripButton_xoaLienLac_Click(object sender, EventArgs e)
        {
            LienLac lienLac = LienLac.ParseLienLac(bindingSource_lienLac.Current as DataRowView);
            if (MessageBox.Show("Bạn có muốn xóa liên lạc \"" + lienLac.TenLienLac + "\" không?", "Xóa liên lạc", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bindingSource_lienLac.RemoveCurrent();
                Nhom.xoaLienHeDatabase(lienLac.MaLienLac);
            }
        }

        private void toolStripButton_themLienLac_Click(object sender, EventArgs e)
        {
            ThemLienLac f = new ThemLienLac(bindingSource_nhom.DataSource as DataTable);
            f.ShowDialog();
            loadNhom();
            
        }

        private void toolStripButton_themNhom_Click(object sender, EventArgs e)
        {
            ThemNhom f = new ThemNhom();
            f.ShowDialog();
            loadNhom();
        }

        private void toolStripTextBox_timKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadDanhSachLienLac(LienLac.timKiem(toolStripTextBox_timKiem.Text));
            }
        }
    }
}
