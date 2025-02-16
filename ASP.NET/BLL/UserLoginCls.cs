using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class UserLoginCls
    {
        ConCls objdal = new ConCls();
        public string LoginDB(string una,string pw)
        {
            string str = "select count(id) from TowlayerTab where username='" + una + "' and password='" + pw + "';";
            string cid = objdal.Scalar_Fn(str);
            return cid;
        }
        public string GetUserId(string una, string pw)
        {
            string str = "select id from TowlayerTab where username='" + una + "' and password='" + pw + "';";
            string id = objdal.Scalar_Fn(str);
            return id;
        }
    }
}
