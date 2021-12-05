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
    public partial class FormLogin : Form
    {
        string userName;
        string userCode;
        public string UserName
        {
            get
            {
                return userName;
            }
        }
        public string UserCode
        {
            get
            {
                return userCode;
            }
        }
        public FormLogin()
        {
            InitializeComponent();
        }


        private void btnSure_Click(object sender, System.EventArgs e)
        {

            string sql;
            sql = "select id,name,pwd,role from admin where id='" + textCode.Text.Trim() + "'";
            Console.WriteLine(sql);
            DBHelper helper = new DBHelper("mysql");
            if (helper.Connection())
            {
                MessageBox.Show("已连接数据库");

            }
            else
            {
                MessageBox.Show("未成功连接数据库");
            }
            DbDataReader reader = helper.DataRead(sql);

            if (reader != null && reader.Read() && reader.GetString(2) == textPwd.Text)
            {
                userCode = reader.GetString(0);
                userName = reader.GetString(1);
                Close();
            }
            else
            {
                MessageBox.Show("登录失败，请输入正确的用户信息！");
                textCode.Focus();
            }
            reader.Close();

        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
