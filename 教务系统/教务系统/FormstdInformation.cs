using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//引用通用数据库访问命令空间
using System.Data.Common;

namespace 教务系统
{
    public partial class FormstdInformation : Form
    {
        string code;
        public FormstdInformation()
        {
            InitializeComponent();
        }

        private void FormstdInformation_Load(object sender, EventArgs e)
        {
            code =((FormMain)this.MdiParent).UserId;
            

            string sql;
            sql = "select * from students where stdcode='" + code + "'";
            Console.WriteLine(sql);
            DBHelper helper = new DBHelper("mysql");
            DbDataReader reader = helper.DataRead(sql);
            if (reader != null && reader.Read() )
            {
                textName.Text = reader.GetString(0);
                textCode.Text = reader.GetString(1);
                textMajor.Text = reader.GetString(2);
                textClass.Text = reader.GetString(3);

                
            }
            else
            {
                MessageBox.Show("用户信息读取失败");
                textCode.Focus();
            }
            reader.Close();
        }
    }
}
