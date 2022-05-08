using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class Phieuxuat
    {
        private Data data = new Data();

        public DataTable Load_PhieuXuat()
        {
            string sql_HT = "Select * From phieuxuat";
            return data.GetTable(sql_HT);
        }

        public void ThemPhieuXuat(string id, string date)
        {
            string sql = $"Insert Into Phieuxuat Values ('{id}', N'{date}')";
            data.ExecuteNonQuery(sql);
        }

        public void XoaPhieuXuat(string id)
        {
            string sql = $"Delete From Phieuxuat Where id = '{id}'";
            data.ExecuteNonQuery(sql);
        }

        public void SuaPhieuXuat(string id, string date)
        {
            string update = $"Update PhieuXuat set ngayxuat = '{date}' where id = '{id}'";
            data.ExecuteNonQuery(update);

        }


        public DataTable Load_TTPhieuXuat()
        {
            string sql_HT = "Select * From Thongtinphieuxuat";
            return data.GetTable(sql_HT);
        }


        public void ThemTTPX(string id, string mahang, int sl, string kh, string idxuat)
        {
            string sql = $"Insert into Thongtinphieuxuat Values('{id}', '{mahang}', {sl}, '{kh}', '{idxuat}')";
            data.ExecuteNonQuery(sql);
        }

        public void XoaTTPX(string key)
        {
            string del = $"Delete from Thongtinphieuxuat Where Id = '{key}'";
            data.ExecuteNonQuery(del);
        }

        public void SuaTTPX(string id, string mahang, string kh, int soluong, string idxuat, string key)
        {
            string update = $"Update Thongtinphieuxuat Set id = '{id}', MaHH = '{mahang}', " +
                            $"Soluong = {soluong}, MaKh = '{kh}', idphieuxuat = '{idxuat}'" +
                            $" Where id = '{key}' ";
            data.ExecuteNonQuery(update);
        }

        public DataTable Get_CB_IDPhieuXuat()
        {
            string sql = "Select Id From Phieuxuat";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);

            return dt;
        }


        public DataTable Get_CB_MaHang()
        {
            string sql = $"Select MaHH From HangHoa";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);

            return dt;
        }

        public DataTable Get_CB_KhachHang()
        {
            string sql = $"Select MakH From KhachHang";
            DataTable dt = new DataTable();
            dt = data.GetTable(sql);

            return dt;
        }

     

    }
}
