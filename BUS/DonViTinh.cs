using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class DonViTinh
    {
        private Data da = new Data();

        public DataTable HienThi_DVT()
        {
            String sql_HT = "Select * From Donvitinh";
            return da.GetTable(sql_HT);
        }

        public void ThemDVT(string ten)
        {
            String sql_add = $"Insert Into Donvitinh Values (N'{ten}')";
            da.ExecuteNonQuery(sql_add);
        }

        public void SuaDVT(string id, string Ten)
        {
            String sql_edit = $"Update Donvitinh Set TenDVT = N'{Ten}' Where Madonvitinh = '{id}'";
            da.ExecuteNonQuery(sql_edit);
        }

        public void XoaDVT(string k)
        {
            String sql_del = $"Delete From Donvitinh Where Madonvitinh = '{k}'";
            da.ExecuteNonQuery(sql_del);
        }
    }
}
