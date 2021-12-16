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
    public partial class FormSelccla : Form
    {
      


        string sql;
        string selecsubCode;//记录选择的课程号subcode
        string techcode;
        string claname;//记录选择的课程名字
        DBHelper helper;
        DbDataReader reader;



        int idx;//记录当前修改的操作员在DataGridVIew的位置
       


        public FormSelccla()
        {
            InitializeComponent();
        }

        private void FormSelccla_Load(object sender, EventArgs e)
        {
           

            sql = "select subcode,subname,teachname,subtime,credit,alltime from seleclass where stdcode = '" + textdeliver2.Text + "'";
            helper = new DBHelper("mysql");
            DataTable table = helper.FillTable(sql);
            //取得老师的号码和学生班级名字

            string sql2 = "select techcode,claname from seleclass where stdcode = '" + textdeliver2.Text + "'";
              reader= helper.DataRead(sql2);
            if (reader != null && reader.Read() )
            {
            
                techcode = reader.GetString(0);
                claname = reader.GetString(1);
                
            }
            reader.Close();





            dtGrid2.DataSource = table;
            string sql1 = "select subname,teachname,subtime,credit,alltime from stdclass where stdcode = '" + textdeliver2.Text + "'";
            DataTable table1 = helper.FillTable(sql1);
            dtGrid3.DataSource = table1;
            //取消dataGridview一开始的选中状态
            if (dtGrid2.SelectedRows.Count >0)
            {
                dtGrid2.Rows[0].Selected = false;
                dtGrid3.Rows[0].Selected = false;

            }







        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //测试
            //MessageBox.Show(dtGrid2.SelectedRows[0].Cells[0].Value.ToString());


            if (dtGrid2.SelectedRows.Count<1)
            {
                
                MessageBox.Show("请选择课程！");
            }
            else
            {
                idx = dtGrid2.CurrentRow.Index;
                selecsubCode = dtGrid2.Rows[idx].Cells[0].Value.ToString();
                bool success = false;
                if (MessageBox.Show("是否确认选择该课？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    //删除左边的选课内容

                    sql = "delete from seleclass where subcode = '" + selecsubCode + "'";
                    idx = dtGrid2.CurrentRow.Index;//得到当前行的索引值
                    //MessageBox.Show("" + dtGrid2.Rows[idx].Cells[0].Value);
                    //增加到已选课右边
                    string sql1 = "insert into stdclass  values ('" + textdeliver2.Text + "','" + textdeliver.Text + "','" + dtGrid2.Rows[idx].Cells[1].Value + "','" + dtGrid2.Rows[idx].Cells[2].Value + "','" + dtGrid2.Rows[idx].Cells[3].Value + "','" + dtGrid2.Rows[idx].Cells[4].Value + "','" + dtGrid2.Rows[idx].Cells[5].Value + "','" + techcode + "','" + claname + "','" + textdeliver3.Text + "')";



                    helper = new DBHelper("mysql");
                    if (helper.Update(sql) > 0 & helper.Update(sql1) > 0)//同时执行两条sql语句
                    {
                        success = true;
                    }
                    else
                    {
                        success = false;
                    }
                    if (success)
                    {
                        MessageBox.Show("恭喜选课成功！");
                        FormSelccla_Load(sender, e);

                    }
                    else
                    {
                        MessageBox.Show("选课失败");
                        this.Close();
                    }



                }
            }
        }
    }
}

