using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{ 
  
    public class Phieunhap
    {
        protected Data da = new Data();
        public DataTable Load_PhieuNhap()
        {
            string sql_HT = "Select * From phieunhap";
            return da.GetTable(sql_HT);
        }

        public void ThemPhieuNhap(string id, string date)
        {
            string sql = $"Insert Into Phieunhap Values ('{id}', N'{date}')";
            da.ExecuteNonQuery(sql);
        }

        public void XoaPhieuNhap(string id)
        {
            string sql = $"Delete From Phieunhap Where id = '{id}'";
            da.ExecuteNonQuery(sql);
        }

        public void SuaPhieuNhap(string id, string date)
        {
            string update = $"Update PhieuNhap set ngaynhap = N'{date}' where id = '{id}'";
            da.ExecuteNonQuery(update);

        }

        public DataTable Load_TTPhieuNhap()
        {
            string sql_HT = "Select * From Thongtinphieunhap";
            return da.GetTable(sql_HT);
        }

        public DataTable Get_CB_MaHang()
        {
            string sql = "Select MaHH From HangHoa";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);

            return dt;
        }

        public string Get_TenHang(string id)
        {
            string sql = $"Select TenHH From HangHoa Where MaHH = '{id}'";
            var rs = da.ExecuteScalar(sql);

            return rs != null ? rs.ToString() : "";
        }

        public string Get_NgayNhap(string id)
        {
            string sql = $"Select ngaynhap From phieunhap Where id = '{id}'";
            var rs = da.ExecuteScalar(sql);

            return rs != null ? rs.ToString() : "";
        }


        public string Get_TenNCC(string id)
        {
            string sql = $"Select TenNCC From NhaCungCap Where MaNCC = '{id}'";
            var rs = da.ExecuteScalar(sql);

            return rs != null ? rs.ToString() : "";
        }

     


        public DataTable Get_CB_NhaCungCap()
        {
            string sql = "Select maNCC, tenNCC From Nhacungcap";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);

            return dt;
        }

        public DataTable Get_CB_IdPhieuNhap()
        {
            string sql = "Select idphieunhap From phieunhap";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);

            return dt;
        }

        public void ThemTTPN(string id, string idnhap, string mahang, string ncc, int soluong, int gianhap, int giaban)
        {
            string sql = $"Insert into Thongtinphieunhap Values('{id}', '{mahang}', '{idnhap}', {gianhap}, {giaban}, {soluong}, '{ncc}')";
            da.ExecuteNonQuery(sql);
        }

        public void XoaTTPN(string key)
        {
            string del = $"Delete from Thongtinphieunhap Where Id = '{key}'";
            da.ExecuteNonQuery(del);
        }

        public void SuaTTPN(string id, string idnhap, string mahang, string ncc, int soluong, int gianhap, int giaban, string key)
        {
            string update = $"Update Thongtinphieunhap Set id = '{id}', MaHH = '{mahang}', Gianhap = {gianhap}, Soluong = {soluong}, MaNCC = '{ncc}', " +
                            $"idphieunhap = N'{idnhap}', giaban = {giaban}" +
                            $" Where id = '{key}' ";
            da.ExecuteNonQuery(update);
        }
    }
}
