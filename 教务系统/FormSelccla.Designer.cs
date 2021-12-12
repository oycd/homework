
namespace 教务系统
{
    partial class FormSelccla
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
            this.dtGrid2 = new System.Windows.Forms.DataGridView();
            this.selcecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alltime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textdeliver = new System.Windows.Forms.TextBox();
            this.textdeliver2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtGrid3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textdeliver3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGrid2
            // 
            this.dtGrid2.AllowUserToAddRows = false;
            this.dtGrid2.AllowUserToDeleteRows = false;
            this.dtGrid2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGrid2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selcecode,
            this.code,
            this.teacher,
            this.time,
            this.credit,
            this.alltime});
            this.dtGrid2.Location = new System.Drawing.Point(0, 77);
            this.dtGrid2.MultiSelect = false;
            this.dtGrid2.Name = "dtGrid2";
            this.dtGrid2.ReadOnly = true;
            this.dtGrid2.RowHeadersWidth = 62;
            this.dtGrid2.RowTemplate.Height = 30;
            this.dtGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrid2.Size = new System.Drawing.Size(672, 237);
            this.dtGrid2.TabIndex = 0;
            // 
            // selcecode
            // 
            this.selcecode.DataPropertyName = "subcode";
            this.selcecode.HeaderText = "课程编号";
            this.selcecode.MinimumWidth = 8;
            this.selcecode.Name = "selcecode";
            this.selcecode.ReadOnly = true;
            this.selcecode.Width = 116;
            // 
            // code
            // 
            this.code.DataPropertyName = "subname";
            this.code.HeaderText = "课程名称";
            this.code.MinimumWidth = 8;
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Width = 116;
            // 
            // teacher
            // 
            this.teacher.DataPropertyName = "teachname";
            this.teacher.HeaderText = "老师";
            this.teacher.MinimumWidth = 8;
            this.teacher.Name = "teacher";
            this.teacher.ReadOnly = true;
            this.teacher.Width = 80;
            // 
            // time
            // 
            this.time.DataPropertyName = "subtime";
            this.time.HeaderText = "时间";
            this.time.MinimumWidth = 8;
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 80;
            // 
            // credit
            // 
            this.credit.DataPropertyName = "credit";
            this.credit.HeaderText = "学分";
            this.credit.MinimumWidth = 8;
            this.credit.Name = "credit";
            this.credit.ReadOnly = true;
            this.credit.Width = 80;
            // 
            // alltime
            // 
            this.alltime.DataPropertyName = "alltime";
            this.alltime.HeaderText = "学时";
            this.alltime.MinimumWidth = 8;
            this.alltime.Name = "alltime";
            this.alltime.ReadOnly = true;
            this.alltime.Width = 80;
            // 
            // textdeliver
            // 
            this.textdeliver.Location = new System.Drawing.Point(13, 13);
            this.textdeliver.Name = "textdeliver";
            this.textdeliver.Size = new System.Drawing.Size(100, 28);
            this.textdeliver.TabIndex = 1;
            this.textdeliver.Visible = false;
            // 
            // textdeliver2
            // 
            this.textdeliver2.Location = new System.Drawing.Point(13, 47);
            this.textdeliver2.Name = "textdeliver2";
            this.textdeliver2.Size = new System.Drawing.Size(100, 28);
            this.textdeliver2.TabIndex = 2;
            this.textdeliver2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "可选课程:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(421, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 62);
            this.button1.TabIndex = 4;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(716, 383);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 62);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "已选课程:";
            // 
            // dtGrid3
            // 
            this.dtGrid3.AllowUserToAddRows = false;
            this.dtGrid3.AllowUserToDeleteRows = false;
            this.dtGrid3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGrid3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGrid3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dtGrid3.Location = new System.Drawing.Point(6, 75);
            this.dtGrid3.MultiSelect = false;
            this.dtGrid3.Name = "dtGrid3";
            this.dtGrid3.ReadOnly = true;
            this.dtGrid3.RowHeadersWidth = 62;
            this.dtGrid3.RowTemplate.Height = 30;
            this.dtGrid3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrid3.Size = new System.Drawing.Size(557, 234);
            this.dtGrid3.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "subname";
            this.dataGridViewTextBoxColumn1.HeaderText = "课程名称";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 116;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "teachname";
            this.dataGridViewTextBoxColumn2.HeaderText = "老师";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "subtime";
            this.dataGridViewTextBoxColumn3.HeaderText = "时间";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "credit";
            this.dataGridViewTextBoxColumn4.HeaderText = "学分";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "alltime";
            this.dataGridViewTextBoxColumn5.HeaderText = "学时";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.Controls.Add(this.dtGrid2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 308);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox2.Controls.Add(this.dtGrid3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(679, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 315);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // textdeliver3
            // 
            this.textdeliver3.Location = new System.Drawing.Point(1235, 480);
            this.textdeliver3.Name = "textdeliver3";
            this.textdeliver3.Size = new System.Drawing.Size(75, 23);
            this.textdeliver3.TabIndex = 4;
            this.textdeliver3.UseVisualStyleBackColor = true;
            this.textdeliver3.Visible = false;
            // 
            // FormSelccla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 506);
            this.Controls.Add(this.textdeliver3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textdeliver2);
            this.Controls.Add(this.textdeliver);
            this.Name = "FormSelccla";
            this.Text = "选课界面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormSelccla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrid2;
        public System.Windows.Forms.TextBox textdeliver;
        public System.Windows.Forms.TextBox textdeliver2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtGrid3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn selcecode;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn alltime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        public System.Windows.Forms.Button textdeliver3;
    }
}