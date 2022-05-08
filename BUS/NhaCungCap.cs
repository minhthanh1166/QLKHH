using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class NhaCungCap
    {
        private Data da = new Data();

        public DataTable HT_NhaCungCap()
        {
            string sql_HT = "Select * From NhaCungCap";
            return da.GetTable(sql_HT);
        }

        public void ThemNCC(string maNCC, string tenNCC, string diachi, string email, string sdt)
        {
            string sql_add = $"Insert Into NhaCungCap Values ('{maNCC}', N'{tenNCC}', N'{diachi}', '{email}', '{sdt}')";
            da.ExecuteNonQuery(sql_add);
        }

        public void SuaNCC(string maNCC, string tenNCC, string diachi, string email, string sdt, string k)
        {
            string sql_edit = $"Update Nhacungcap Set MaNCC = '{maNCC}', TenNCC = N'{tenNCC}', Diachi = N'{diachi}', Email = '{email}', Sodienthoai = '{sdt}' " +
                              $" Where MaNCC = '{k}'";
            da.ExecuteNonQuery(sql_edit);
        }

        public void XoaNCC(string maNCC)
        {
            string sql_del = $"Delete From Nhacungcap Where MaNCC = '{maNCC}'";
            da.ExecuteNonQuery(sql_del);
        }
    }
}
