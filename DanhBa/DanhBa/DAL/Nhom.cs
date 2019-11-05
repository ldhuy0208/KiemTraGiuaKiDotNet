using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhBa.DAL
{
    public class Nhom
    {
        public int MaNhom { get; set; }
        public string TenNhom { get; set; }

        public static Nhom ParseNhom(DataRowView row)
        {
            if (row == null || row["MaNhom"] == null || row["TenNhom"] == null)
                return null;

            Nhom nhom= new Nhom
            {
                MaNhom = (int)row["MaNhom"],
                TenNhom = row["TenNhom"].ToString(), 
            };
            return nhom;
        }

        public static DataTable LayDanhSachNhomDatabase()
        {
            
            return DataProvider.ExecuteQuery("EXECUTE Nhom_LayDanhSachNhom");
        }

        public static void ThemNhomDatabase(string tenNhom)
        {
            string query = String.Format("EXECUTE Nhom_ThemNhom N'{0}'", tenNhom);
            DataProvider.ExecuteQuery(query);
        }

        public static void xoaNhomDatabase(int maNhom)
        {
            string query = string.Format("EXECUTE Nhom_XoaNhom {0}", maNhom);
            DataProvider.ExecuteQuery(query);
        }

        public static void xoaLienHeDatabase(int maLienLac)
        {
            string query = string.Format("EXECUTE LienHe_XoaLienHe {0}", maLienLac);
            DataProvider.ExecuteQuery(query);
        }
    }
}
