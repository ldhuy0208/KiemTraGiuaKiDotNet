using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhBa.DAL
{
    public class LienLac
    {
        public int MaLienLac { get; set; }
        public string TenLienLac { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }

        public static LienLac ParseLienLac(DataRowView row)
        {
            if (row==null || row["MaLienHe"] == null || row["TenLienHe"] == null
                    || row["Email"] == null || row["SoDienThoai"] == null
                    || row["DiaChi"] == null)
                return null;

            LienLac lienLac = new LienLac
            {
                MaLienLac = (int)row["MaLienHe"],
                TenLienLac = row["TenLienHe"].ToString(),
                Email = row["Email"].ToString(),
                SoDienThoai = row["SoDienThoai"].ToString(),
                DiaChi = row["DiaChi"].ToString()
            };
            return lienLac;
        }

        public static DataTable layDanhSachLienHe(int maNhom)
        {
            string query = string.Format("EXECUTE LienHe_LayDanhSachLienHe {0}", maNhom);
            return DataProvider.ExecuteQuery(query);
        }

        public static DataTable timKiem(string key)
        {
            string query = string.Format("EXECUTE LienHe_TimKiem N'{0}'", key);
            return DataProvider.ExecuteQuery(query);
        }

        public static void themLienLac(string tenLienLac, string email, string soDienThoai, string diaChi, int[] danhSachMaNhom)
        {
            string query = string.Format("EXECUTE LienHe_ThemLienHe N'{0}', '{1}', '{2}', N'{3}'", tenLienLac, email, soDienThoai, diaChi);
            DataTable result = DataProvider.ExecuteQuery(query);
            foreach (int maNhom in danhSachMaNhom) {
                query = string.Format("EXECUTE Nhom_LienHe_Them {0}, {1}", maNhom, result.Rows[0]["MaLienHe"]);
                DataProvider.ExecuteQuery(query);
            }
        }
    }
}