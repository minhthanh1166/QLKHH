using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class KhachHang
    {
        private Data da = new Data();


        public DataTable HienThi_KH()
        {
            string sql = $"Select * From KhachHang";
            return da.GetTable(sql);
        }



        public void ThemKH(string makh, string hoten, string gioitinh, string diachi, string email, string sdt)
        {
            string sql_add = $"Insert Into KhachHang Values ('{makh}', N'{hoten}', '{email}', '{sdt}', N'{gioitinh}', N'{diachi}')";
            da.ExecuteNonQuery(sql_add);
        }

        public void XoaKH(String ma)
        {
            String sql_delete = "Delete From KhachHang where MakH = '" + ma + "'";
            da.ExecuteNonQuery(sql_delete);
        }


        public void SuaKH(string ma, string hoten, string gioitinh, string diachi, string email, string sdt, string key)
        {
            String sql_edit = $"Update KhachHang Set MakH = '{ma}', TenKh =  N'{hoten}', " +
                              $" gioitinh = N'{gioitinh}' , Email = '{email}', Sodienthoai = '{sdt}', diachi = '{diachi}' " +
                              $"Where MakH = '{key}'";
            da.ExecuteNonQuery(sql_edit);
        }

        public DataTable Search(String ma)
        {
            String sql_search = $"Select * from KhachHang where MakH = '{ma}' or TenKh like N'%{ma}%'";

            return da.GetTable(sql_search);

        }
    }
}
