
namespace 教务系统
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.dtGrd1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLogout1 = new System.Windows.Forms.Button();
            this.btnTeamanage = new System.Windows.Forms.Button();
            this.btnStdmanage = new System.Windows.Forms.Button();
            this.btnSearchsco = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnScorepb = new System.Windows.Forms.Button();
            this.selfPic = new System.Windows.Forms.PictureBox();
            this.textClass = new System.Windows.Forms.TextBox();
            this.textMajor = new System.Windows.Forms.TextBox();
            this.textCode = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSleccla = new System.Windows.Forms.Button();
            this.btnSelcinform = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrd1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selfPic)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 635);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1225, 31);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 24);
            this.toolStripStatusLabel1.Text = "        ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1225, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnLogout
            // 
            this.btnLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLogout.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(70, 25);
            this.btnLogout.Text = "注销";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dtGrd1
            // 
            this.dtGrd1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGrd1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrd1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGrd1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtGrd1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGrd1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGrd1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtGrd1.Location = new System.Drawing.Point(0, 52);
            this.dtGrd1.Name = "dtGrd1";
            this.dtGrd1.ReadOnly = true;
            this.dtGrd1.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrd1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGrd1.RowTemplate.Height = 30;
            this.dtGrd1.Size = new System.Drawing.Size(1225, 285);
            this.dtGrd1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtGrd1);
            this.groupBox1.Location = new System.Drawing.Point(0, 387);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1225, 252);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.btnLogout1);
            this.groupBox2.Controls.Add(this.btnTeamanage);
            this.groupBox2.Controls.Add(this.btnStdmanage);
            this.groupBox2.Controls.Add(this.btnSearchsco);
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnScorepb);
            this.groupBox2.Controls.Add(this.selfPic);
            this.groupBox2.Controls.Add(this.textClass);
            this.groupBox2.Controls.Add(this.textMajor);
            this.groupBox2.Controls.Add(this.textCode);
            this.groupBox2.Controls.Add(this.textName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnSleccla);
            this.groupBox2.Controls.Add(this.btnSelcinform);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(0, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1225, 353);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btnLogout1
            // 
            this.btnLogout1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogout1.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout1.Image")));
            this.btnLogout1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout1.Location = new System.Drawing.Point(1000, 212);
            this.btnLogout1.Name = "btnLogout1";
            this.btnLogout1.Size = new System.Drawing.Size(191, 55);
            this.btnLogout1.TabIndex = 18;
            this.btnLogout1.Text = "注销";
            this.btnLogout1.UseVisualStyleBackColor = true;
            this.btnLogout1.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnTeamanage
            // 
            this.btnTeamanage.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTeamanage.Image = ((System.Drawing.Image)(resources.GetObject("btnTeamanage.Image")));
            this.btnTeamanage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeamanage.Location = new System.Drawing.Point(1000, 135);
            this.btnTeamanage.Name = "btnTeamanage";
            this.btnTeamanage.Size = new System.Drawing.Size(191, 55);
            this.btnTeamanage.TabIndex = 17;
            this.btnTeamanage.Text = "老师管理";
            this.btnTeamanage.UseVisualStyleBackColor = true;
            this.btnTeamanage.Click += new System.EventHandler(this.btnTeamanage_Click);
            // 
            // btnStdmanage
            // 
            this.btnStdmanage.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStdmanage.Image = ((System.Drawing.Image)(resources.GetObject("btnStdmanage.Image")));
            this.btnStdmanage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStdmanage.Location = new System.Drawing.Point(1000, 55);
            this.btnStdmanage.Name = "btnStdmanage";
            this.btnStdmanage.Size = new System.Drawing.Size(191, 55);
            this.btnStdmanage.TabIndex = 16;
            this.btnStdmanage.Text = "学生管理";
            this.btnStdmanage.UseVisualStyleBackColor = true;
            this.btnStdmanage.Click += new System.EventHandler(this.btnStdmanage_Click);
            // 
            // btnSearchsco
            // 
            this.btnSearchsco.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearchsco.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchsco.Image")));
            this.btnSearchsco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchsco.Location = new System.Drawing.Point(756, 135);
            this.btnSearchsco.Name = "btnSearchsco";
            this.btnSearchsco.Size = new System.Drawing.Size(191, 55);
            this.btnSearchsco.TabIndex = 15;
            this.btnSearchsco.Text = "成绩查询";
            this.btnSearchsco.UseVisualStyleBackColor = true;
            this.btnSearchsco.Click += new System.EventHandler(this.btnSearchsco_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(756, 212);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(191, 55);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnScorepb
            // 
            this.btnScorepb.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnScorepb.Image = ((System.Drawing.Image)(resources.GetObject("btnScorepb.Image")));
            this.btnScorepb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScorepb.Location = new System.Drawing.Point(756, 135);
            this.btnScorepb.Name = "btnScorepb";
            this.btnScorepb.Size = new System.Drawing.Size(191, 55);
            this.btnScorepb.TabIndex = 13;
            this.btnScorepb.Text = "成绩发布";
            this.btnScorepb.UseVisualStyleBackColor = true;
            this.btnScorepb.Click += new System.EventHandler(this.btnScorepb_Click);
            // 
            // selfPic
            // 
            this.selfPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.selfPic.Location = new System.Drawing.Point(12, 27);
            this.selfPic.Name = "selfPic";
            this.selfPic.Size = new System.Drawing.Size(221, 269);
            this.selfPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.selfPic.TabIndex = 10;
            this.selfPic.TabStop = false;
            // 
            // textClass
            // 
            this.textClass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textClass.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textClass.Location = new System.Drawing.Point(428, 255);
            this.textClass.Name = "textClass";
            this.textClass.ReadOnly = true;
            this.textClass.Size = new System.Drawing.Size(282, 44);
            this.textClass.TabIndex = 9;
            // 
            // textMajor
            // 
            this.textMajor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textMajor.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textMajor.Location = new System.Drawing.Point(428, 178);
            this.textMajor.Name = "textMajor";
            this.textMajor.ReadOnly = true;
            this.textMajor.Size = new System.Drawing.Size(282, 42);
            this.textMajor.TabIndex = 8;
            // 
            // textCode
            // 
            this.textCode.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textCode.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textCode.Location = new System.Drawing.Point(428, 101);
            this.textCode.Name = "textCode";
            this.textCode.ReadOnly = true;
            this.textCode.Size = new System.Drawing.Size(282, 42);
            this.textCode.TabIndex = 7;
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textName.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textName.Location = new System.Drawing.Point(428, 27);
            this.textName.Name = "textName";
            this.textName.ReadOnly = true;
            this.textName.Size = new System.Drawing.Size(282, 39);
            this.textName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(246, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "专业名称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(246, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "班级名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(246, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "编    号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(246, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓    名：";
            // 
            // btnSleccla
            // 
            this.btnSleccla.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSleccla.Image = ((System.Drawing.Image)(resources.GetObject("btnSleccla.Image")));
            this.btnSleccla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSleccla.Location = new System.Drawing.Point(756, 55);
            this.btnSleccla.Name = "btnSleccla";
            this.btnSleccla.Size = new System.Drawing.Size(191, 55);
            this.btnSleccla.TabIndex = 19;
            this.btnSleccla.Text = "选课中心";
            this.btnSleccla.UseVisualStyleBackColor = true;
            this.btnSleccla.Click += new System.EventHandler(this.btnSleccla_Click);
            // 
            // btnSelcinform
            // 
            this.btnSelcinform.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelcinform.Image = ((System.Drawing.Image)(resources.GetObject("btnSelcinform.Image")));
            this.btnSelcinform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelcinform.Location = new System.Drawing.Point(756, 55);
            this.btnSelcinform.Name = "btnSelcinform";
            this.btnSelcinform.Size = new System.Drawing.Size(191, 55);
            this.btnSelcinform.TabIndex = 12;
            this.btnSelcinform.Text = "选课信息";
            this.btnSelcinform.UseVisualStyleBackColor = true;
            this.btnSelcinform.Click += new System.EventHandler(this.btnSelcinform_Click);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1225, 666);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "教务系统服务";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrd1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selfPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnLogout;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dtGrd1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textClass;
        private System.Windows.Forms.TextBox textMajor;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.PictureBox selfPic;
        private System.Windows.Forms.Button btnLogout1;
        private System.Windows.Forms.Button btnTeamanage;
        private System.Windows.Forms.Button btnStdmanage;
        private System.Windows.Forms.Button btnSearchsco;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnScorepb;
        private System.Windows.Forms.Button btnSelcinform;
        private System.Windows.Forms.Button btnSleccla;
    }
}