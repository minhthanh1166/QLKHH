using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class HangHoa
    {
        private Data da = new Data();

        public DataTable HT_HangHoa()
        {
            string sql_HT = "Select * From HangHoa";
            return da.GetTable(sql_HT);
        }

        public DataTable Get_CB_Loai()
        {
            string sql = "Select maloai, tenloai From Loaihang";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);

            return dt;
        }

       

        public DataTable Get_CB_NhaCungCap()
        {
            string sql = "Select maNCC, tenNCC From Nhacungcap";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);

            return dt;
        }

        public DataTable GetCb_Donvitinh()
        {
            string sql = "Select Madonvitinh From Donvitinh";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);

            return dt;
        }

        public void ThemHang(string mahang, string tenhang, string loai, string ncc, int dvt)
        {
            string sql = $"Insert into HangHoa values ('{mahang}', N'{tenhang}', '{ncc}', '{loai}', {dvt})";
            da.ExecuteNonQuery(sql);
        }

        public void XoaHang(string key)
        {
            string del = $"Delete from HangHoa Where MaHH = '{key}'";
            da.ExecuteNonQuery(del);
        }

        public void SuaHang(string mahang, string tenhang, string ncc, string loai, int dvt, string k)
        {
            string update = $"Update HangHoa set MaHH = '{mahang}', TenHH = N'{tenhang}', MaNCC = '{ncc}', Maloai = '{loai}', MaDVT = {dvt} " +
                            $"Where MaHH = '{k}'";
            da.ExecuteNonQuery(update);
        }
    }
}
