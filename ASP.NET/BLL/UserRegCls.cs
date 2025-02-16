using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class UserRegCls
    {
        ConCls objdal = new ConCls();
        public int InsertDB(string na, int ag,string addr, string ph, string una, string pw)
        {
            string str = "insert into TowLayerTab values('" + na + "'," + ag + ",'" + addr + "','" + ph + "','" + una + "','" + pw + "');";
            int i = objdal.NonQuery_Fn(str);
            return i;
        }

    }
}
