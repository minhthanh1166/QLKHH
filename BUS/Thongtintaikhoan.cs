using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class Thongtintaikhoan
    {
        private Data da = new Data();

        public DataTable HT_TaiKhoan()
        {
            string sql_HT = "Select * From Taikhoan";
            return da.GetTable(sql_HT);
        }

        public void ThemTaiKhoang(string TenDN, string MatKhau)
        {
            string sql = $"Insert into TaiKhoan values ('{TenDN}', N'{MatKhau}')";
            da.ExecuteNonQuery(sql);
        }

        public void XoaTaiKhoan(string key)
        {
            string del = $"Delete from Taikhoan Where TenDN = '{key}'";
            da.ExecuteNonQuery(del);
        }

        public void Suataikhoan(string TenDN, string MatKhau, string k)
        {
            string update = $"Update TaiKHoan set TenDN = '{TenDN}', MatKhau = N'{MatKhau}'" +
                            $"Where TenDN = '{k}'";
            da.ExecuteNonQuery(update);
        }
    }
}
