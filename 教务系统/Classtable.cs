using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace 教务系统
{
    class Classtable
    {
      
        DataTable dt = new DataTable("subject");
        public  DataTable BuildTable()
        {
            dt.Columns.Add("       周数/节数", typeof(string));                           //添加列集，下面都是
            dt.Columns.Add("         周一", typeof(string));
            dt.Columns.Add("         周二", typeof(string));
            dt.Columns.Add("         周三", typeof(string));
            dt.Columns.Add("         周四", typeof(string));
            dt.Columns.Add("         周五", typeof(string));
            dt.Columns.Add("         周六", typeof(string));
            dt.Columns.Add("         周日", typeof(string));

            for (int i = 0; i < 4; i++)                                                      //用循环添加4个行集~
            {
                DataRow dr = dt.NewRow();

                dt.Rows.Add(dr);
            }

            dt.Rows[0][0] = "第1节";                                                      //向第一行里的第一个格中添加一个“第1节”
            dt.Rows[1][0] = "第2节";                                                      //向第二行里的第一个格中添加一个“第 2 节”
            dt.Rows[2][0] = "第3节";                                                      //向第三行里的第一个格中添加一个“第3节”
            dt.Rows[3][0] = "第4节";
           return dt;
        }

    }
}
