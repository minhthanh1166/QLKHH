using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class LoaiSP
    {
        private Data da = new Data();

        public DataTable HienThi_Loai()
        {
            String sql_HT = "Select * From LoaiHang";
            return da.GetTable(sql_HT);
        }

        public void ThemLoaiSP(string maLoai, string tenLoai)
        {
            String sql_add = $"Insert Into LoaiHang Values ('{maLoai}', N'{tenLoai}')";
            da.ExecuteNonQuery(sql_add);
        }

        public void SuaLoaiSP(string Maloai, string Tenloai)
        {
            String sql_edit = $"Update Loaihang Set Tenloai = N'{Tenloai}' Where Maloai = '{Maloai}'";
            da.ExecuteNonQuery(sql_edit);
        }

        public void XoaLoaiSP(string Maloai)
        {
            String sql_del = $"Delete From LoaiHang Where Maloai = '{Maloai}'";
            da.ExecuteNonQuery(sql_del);
        }

    }
}
