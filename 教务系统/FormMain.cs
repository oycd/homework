using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 教务系统
{
    public partial class FormMain : Form
    {
        string classCode;//班级编号
        string userid;//用户编号
        string picture;//图片编号
        string stdname;//学生名字





        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

            FormLogin frmLogin = new FormLogin();
            frmLogin.ShowDialog();
         
            this.WindowState = FormWindowState.Maximized;   //登录成功后最大化
            string sql;
            String userRole;
           
            if (frmLogin.UserCode != null)
            {

                //
                userid = frmLogin.UserCode.Trim();
                sql = "select role,pic,classcode,name from admin where code='" + frmLogin.UserCode.Trim() + "'";
                //Console.WriteLine(sql);
                //画课表表格
                int num, week; // 周数节数，第二步的时候用得到。
                string sum;
                DataTable dt = new DataTable("subject");

                //进行登录对话框

                DBHelper helper = new DBHelper("mysql");
                DbDataReader reader = helper.DataRead(sql);

                if (reader != null && reader.Read())
                {
                    userRole = reader.GetString(0);
                    picture = reader.GetString(1);
                    classCode = reader.GetString(2); //用于班级编号传递到学生选课界面
                     stdname = reader.GetString(3);//用于学生名字传递到学生选课界面
                    toolStripStatusLabel1.Text = userRole + "：" + frmLogin.UserName;

                    
                    //判定角色是否为老师
                    if (userRole.Equals("老师"))
                    {
                        this.btnSelcinform.Visible = true;//防止注销后之前为学生则该控件一直是visible为false
                        
                        this.btnSleccla.Visible = false;
                        this.btnScorepb.Visible = true;
                        this.btnSearchsco.Visible = false;
                        label3.Text = "所教专业";
                        label4.Text = "所教班级";
                        //不显示选课按钮
                        btnSleccla.Visible = false;
                        //加载个人信息
                        //加载老师头像
                        string filedir = "F:/C#大作业/教务系统/教务系统/images/" + picture + "";

                        this.selfPic.Image = Image.FromFile(filedir);

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
                        sql = "select name,code,major,class from admin where code='" + userid + "'";


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
                    //判定身份为学生
                    else
                    {
                        //加载学生个人信息
                        //加载学生头像
                        this.btnSleccla.Visible = true;//防止注销后之前为老师则该控件一直是visible为false
                        this.btnSelcinform.Visible = false;
                        string filedir = "F:/C#大作业/教务系统/教务系统/images/" + picture + "";

                        this.selfPic.Image = Image.FromFile(filedir);
                        this.btnScorepb.Visible = false;
                        this.btnSearchsco.Visible = true;

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
                                sql = "select subject ,teacher,room,weekstar_end from classes where num='" + num.ToString() + "' and week = '" + week.ToString() + "' and classcode = '" + classCode + "'";                                   //拼凑SQL语句。
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

                        sql = "select name,code,major,class from admin where code='" + userid + "'";


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


            }
        }




        private void btnLogout_Click(object sender, EventArgs e)//注销控件
        {
            
            
            this.FormMain_Load(sender,e);
            /*  FormMain frm = new FormMain();
             frm.FormMain_Load(sender,e);
             frm.Show();
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
              reader.Close();*/



        }
       
        private void btnSleccla_Click(object sender, EventArgs e)//学生选课控件
        {
            FormSelccla formSelccla = new FormSelccla();
            formSelccla.textdeliver.Text = classCode;//班级编号传递
            formSelccla.textdeliver2.Text = userid;//学生学号传递
            formSelccla.textdeliver3.Text = stdname;
            formSelccla.Show();

            



            //从数据库中读取记录

        }

        private void btnExit_Click(object sender, EventArgs e)//退出控件
        {
            this.Close();
        }

        private void btnSelcinform_Click(object sender, EventArgs e)
        {
            Formselecinform formselecinform = new Formselecinform();
            formselecinform.textdeliver4.Text = userid;
            formselecinform.Show();

        }

        private void btnScorepb_Click(object sender, EventArgs e)
        {
            FormScorepb formScorepb = new FormScorepb();
            formScorepb.Show();
        }
        //删掉


    }
}
