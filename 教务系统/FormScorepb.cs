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
    public partial class FormScorepb : Form
    {
        string sql;

        DBHelper helper;
        DbDataReader reader;

        public FormScorepb()
        {
            InitializeComponent();
        }

        private void textCode_TextChanged(object sender, EventArgs e)
        {
            if(textCode.Text.Length>0)
            {
                btnSearch.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            textScore.Enabled = true;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            helper = new DBHelper("mysql");
            sql = "select stdname,claname,subname from stdclass where stdcode = '" + textCode.Text + "' and techcode = '"+ textdelive5.Text+"'";
            reader = helper.DataRead(sql);
            if (reader != null && reader.Read())
            {

                 textName.Text = reader.GetString(0);
                 textClass.Text= reader.GetString(1);
                textSubject.Text = reader.GetString(2);

            }
            else
            {
                MessageBox.Show("查无此人");
                textCode.Text = "";
                textCode.Focus();
            }
            reader.Close();
            textScore.Enabled = true;

        }

        private void btnPb_Click(object sender, EventArgs e)
        {
            //让输入的成绩合乎情理
            if (textScore.Text!= "")//判定成绩输入不能为空
            {
                int score = int.Parse(textScore.Text);
                
                if (score < 0 || score > 100)
                {
                    MessageBox.Show("请输入0-100之间的分数");
                    textScore.Text = "";
                    textScore.Focus();
                }
                else
                {
                    //进行判断是否成绩已存在
                    sql = "select stdname,claname,subname from stdscore where stdcode = '" + textCode.Text + "'";

                    reader = helper.DataRead(sql);
                    if (reader != null && reader.Read())
                    {
                        MessageBox.Show("成绩已存在");
                        textScore.Text = "";
                        textCode.Text = "";
                        textCode.Focus();



                    }
                    else
                    {

                        if (MessageBox.Show("是否发布成绩？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            sql = "insert into stdscore  values ('" + textCode.Text + "','" + textName.Text + "','" + textClass.Text + "','" + textScore.Text + "','" + textSubject.Text + "')";
                            helper = new DBHelper("mysql");
                            if (helper.Update(sql) > 0)
                            {
                                MessageBox.Show("成绩发布成功！");
                                textCode.Text = "";
                                textScore.Text = "";
                                textScore.Enabled = false;
                                btnSearch.Enabled = false;
                                textCode.Focus();
                            }
                            else
                            {
                                MessageBox.Show("成绩发布失败！");

                            }
                        }
                        else
                        {

                        }

                    }
                    reader.Close();


                }
            }
            else
            {
                MessageBox.Show("成绩不能为空");
            }
           
           

        }
    }
}
