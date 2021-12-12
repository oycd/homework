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
    public partial class FormScoreselc : Form
    {
        string sql;

        DBHelper helper;
        DataTable table;
        DbDataReader reader;
        public FormScoreselc()
        {
            InitializeComponent();
        }

        private void FormScoreselc_Load(object sender, EventArgs e)
        {
            helper = new DBHelper("mysql");
            sql = "select stdcode,stdname,claname from stdscore where stdcode = '" + textdelive6.Text + "'";
            reader = helper.DataRead(sql);

            if (reader != null && reader.Read())
            {

                 textCode.Text= reader.GetString(0);
                textName.Text = reader.GetString(1);
                 textClass.Text= reader.GetString(2);
                sql = "select subname,score from stdscore where stdcode = '" + textdelive6.Text + "'";
                helper = new DBHelper("mysql");
                table = helper.FillTable(sql);
                dtGrid5.DataSource = table;
            }
            else
            {
                MessageBox.Show("未查到你的成绩!");

            }
            reader.Close();

        }
    }
}
