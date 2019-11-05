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
    public partial class ThemNhom : Form
    {
        public ThemNhom()
        {
            InitializeComponent();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            Nhom.ThemNhomDatabase(textBox_tenNhom.Text);
            DialogResult = DialogResult.OK;
        }
    }
}
