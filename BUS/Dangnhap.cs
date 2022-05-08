using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class Dangnhap
    {
        private Data da = new Data();

        public bool Check(string u, string p)
        {
            string sql = $"Select TenDN, MatKhau From TaiKhoan Where TenDN = '{u}' and MatKhau = '{p}'";
            if (da.ExecuteScalar(sql) != null)
            {
                return true;
            }

            return false;
        }
    }
}
