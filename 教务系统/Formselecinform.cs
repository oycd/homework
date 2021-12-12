using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 教务系统
{
    public partial class Formselecinform : Form
    {
        string sql;

        DBHelper helper;
        DataTable table;
  
        public Formselecinform()
        {
            InitializeComponent();
        }

        private void Formselecinform_Load(object sender, EventArgs e)
        {
            sql = "select stdcode,stdname,claname,subname from stdclass where techcode = '" + textdeliver4.Text + "'";
            helper = new DBHelper("mysql");
            table = helper.FillTable(sql);
            dtGrid4.DataSource = table;

            textNum.Text = dtGrid4.Rows.Count.ToString();

        }


    }
}
