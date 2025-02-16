using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class UserProfileViewCls
    {
        ConCls objdal = new ConCls();
        public SqlDataReader UserProfileView_Data(int uid)
        {
            string str = "select * from TowLayerTab where id=" + uid + ";";
            SqlDataReader dr = objdal.Reader_Fn(str);
            return dr;
        }

    }
}
