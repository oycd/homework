using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 教务系统
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormLogin frmLogin = new FormLogin();
            frmLogin.ShowDialog();
            string sql;
            String userRole;
            sql = "select role from admin where id='" + frmLogin.UserCode.Trim() + "'";
            Console.WriteLine(sql);
            DBHelper helper = new DBHelper("mysql");
            DbDataReader reader = helper.DataRead(sql);
            if (reader != null && reader.Read())
            {
                userRole = reader.GetString(0);
               
                toolStripStatusLabel1.Text = userRole + "：" + frmLogin.UserName;

            }
            else
            {
                MessageBox.Show("未读到数据");
 
            }
            reader.Close();





        }
    }
}
