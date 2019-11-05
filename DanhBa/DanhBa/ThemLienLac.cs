using DanhBa.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanhBa
{
    public partial class ThemLienLac : Form
    {
        DataTable nhom;
        public ThemLienLac(DataTable nhom)
        {
            InitializeComponent();
            
            this.nhom = nhom;
            
            loadNhom();  
        }

        void loadNhom()
        {
            ((ListBox)checkedListBox_nhom).DataSource = nhom;
            ((ListBox)checkedListBox_nhom).ValueMember = "MaNhom";
            ((ListBox)checkedListBox_nhom).DisplayMember = "TenNhom";
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            List<int> danhSachNhom = new List<int>();
            foreach (DataRowView row in checkedListBox_nhom.CheckedItems)
            {
                Nhom nhom = Nhom.ParseNhom(row);
                danhSachNhom.Add(nhom.MaNhom);
            }
            LienLac.themLienLac(textBox_tenLienLac.Text, textBox_email.Text, textBox_soDienThoai.Text, textBox_diaChi.Text, danhSachNhom.ToArray());
            DialogResult = DialogResult.OK;
        }
    }
}
