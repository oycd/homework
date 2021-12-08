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
        FormstdInformation formstdinf;
        string userid;
        public string UserId
        {
            get
            {
                return userid;
            }
        }
 
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //画课表表格
            int num, week; // 周数节数，第二步的时候用得到。
            string sum;
            DataTable dt = new DataTable("subject");
           
            //进行登录对话框
            FormLogin frmLogin = new FormLogin();
            frmLogin.ShowDialog();
            string sql;
            String userRole;
            userid = frmLogin.UserCode.Trim();
            sql = "select role from admin where id='" + frmLogin.UserCode.Trim() + "'";
            Console.WriteLine(sql);
            DBHelper helper = new DBHelper("mysql");
            DbDataReader reader = helper.DataRead(sql);
            if (reader != null && reader.Read())
            {
                userRole = reader.GetString(0);
               
                toolStripStatusLabel1.Text = userRole + "：" + frmLogin.UserName;
               
                
                //判定角色是否为老师
                if (userRole.Equals("老师"))
                {
                    label3.Text = "所教专业";
                    label4.Text = "所教班级";
                    //加载个人信息

                    reader.Close();
                   
                    //课表显示
                    Classtable classtable = new Classtable();
                     dt = classtable.BuildTable();

                    for (int i = 0; i < 4; i++)                                                //一共有四行，在课程表里 i 应该表示的是节数。

                    {
                        for (int j = 1; j < 8; j++)                                        //每行有7列需要添加数据，在课程表中，J 表示的应该是周数。
                        {
                            num = i + 1;
                            week = j;
                            sql = "select subject ,teacher,room,weekstar_end from classes where num='" + num.ToString() + "' and week = '" + week.ToString() + "'" + " and tecode = '" + userid + "'";                             //拼凑SQL语句。
                            
                            reader = helper.DataRead(sql);



                            while (reader.Read())
                            {
                                sum = reader.GetValue(0).ToString() + "\n" + reader.GetValue(1).ToString() + "\n" + reader.GetValue(2).ToString() + "\r\n" + reader.GetValue(3).ToString();
                                //如上图，一个格子里头有好几个信息。比如教师，教室，课程名。这里把从数据库中取出的数据拼在一起。放在变量SUM里。 

                                dt.Rows[i][j] = sum;                  //把Sum 添加到datatable的小格子里。
                            }
                            reader.Close();                              //关闭数据库连接。



                        }
                    }

                    dtGrd1.DataSource = dt;
                    for (int i = 0; i < this.dtGrd1.Columns.Count; i++)
                    {
                        this.dtGrd1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                    sql = "select * from teacher where tecode='" + userid + "'";


                    reader = helper.DataRead(sql);
                    if (reader != null && reader.Read())
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
                else
                {
                    //加载个人信息

                   
                    reader.Close();
                    //课表显示
                    Classtable classtable = new Classtable();
                    dt = classtable.BuildTable();

                    for (int i = 0; i < 4; i++)                                                //一共有四行，在课程表里 i 应该表示的是节数。

                    {
                        for (int j = 1; j < 8; j++)                                        //每行有7列需要添加数据，在课程表中，J 表示的应该是周数。
                        {
                            num = i + 1;
                            week = j;
                            sql = "select subject ,teacher,room,weekstar_end from classes where num='" + num.ToString() + "' and week = '" + week.ToString() + "'";                                      //拼凑SQL语句。
                            helper = new DBHelper("mysql");
                            reader = helper.DataRead(sql);



                            while (reader.Read())
                            {
                                sum = reader.GetValue(0).ToString() + "\n" + reader.GetValue(1).ToString() + "\n" + reader.GetValue(2).ToString() + "\r\n" + reader.GetValue(3).ToString();
                                //如上图，一个格子里头有好几个信息。比如教师，教室，课程名。这里把从数据库中取出的数据拼在一起。放在变量SUM里。 

                                dt.Rows[i][j] = sum;                  //把Sum 添加到datatable的小格子里。
                            }
                            reader.Close();                              //关闭数据库连接。



                        }
                    }

                    dtGrd1.DataSource = dt;
                    for (int i = 0; i < this.dtGrd1.Columns.Count; i++)
                    {
                        this.dtGrd1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                    }

                    //填充个人信息

                    sql = "select * from students where stdcode='" + userid + "'";
                    

                    reader = helper.DataRead(sql);
                    if (reader!= null && reader.Read())
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
            else
            {
                MessageBox.Show("未读到数据");
 
            }
        }



        private void btnLogout_Click(object sender, EventArgs e)
        { 
            FormMain frm = new FormMain();
            frm.FormMain_Load(sender,e);
            FormLogin frmLogin = new FormLogin();
           
            frmLogin.ShowDialog();
            string sql;
            String userRole;
            userid = frmLogin.UserCode.Trim();
            sql = "select role from admin where id='" + frmLogin.UserCode.Trim() + "'";
            
            Console.WriteLine(sql);
            DBHelper helper = new DBHelper("mysql");
            DbDataReader reader = helper.DataRead(sql);
            if (reader != null && reader.Read())
            {
                userRole = reader.GetString(0);

                toolStripStatusLabel1.Text = userRole + "：" + frmLogin.UserName;
                //判定角色是否为老师
                if (userRole.Equals("老师"))
                {
                    label3.Text = "所教专业";
                    label4.Text = "所教班级";
                    reader.Close();

                    //加载老师信息
                    sql = "select * from teacher where tecode='" + userid + "'";


                    reader = helper.DataRead(sql);
                    if (reader != null && reader.Read())
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
                else
                {
                    //加载学生信息

                    reader.Close();


                    sql = "select * from students where stdcode='" + userid + "'";


                    reader = helper.DataRead(sql);
                    if (reader != null && reader.Read())
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


            else
            {
                MessageBox.Show("未读到数据");

            }
            reader.Close();
            
            

        }

        private void selfInform_Click(object sender, EventArgs e)
        {
            FormMain frm = new FormMain();

            formstdinf = new FormstdInformation();
            formstdinf.MdiParent = this;
            formstdinf.BringToFront();
            formstdinf.Show();
        }
    }
}
