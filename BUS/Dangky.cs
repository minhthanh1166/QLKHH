using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class Dangky
    {
        private Data da = new Data();
        public void checkDk(String username, String password)
        {
            String sql = $"Insert Into TaiKhoan Values ('{username}', '{password}')";
            da.ExecuteNonQuery(sql);
        }
    }
}
