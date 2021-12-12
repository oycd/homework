
namespace 教务系统
{
    partial class Formselecinform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtGrid4 = new System.Windows.Forms.DataGridView();
            this.stdcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textdeliver4 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGrid4
            // 
            this.dtGrid4.AllowUserToAddRows = false;
            this.dtGrid4.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrid4.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtGrid4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtGrid4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrid4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGrid4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stdcode,
            this.stdname,
            this.stclass,
            this.claname});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrid4.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtGrid4.Location = new System.Drawing.Point(9, 27);
            this.dtGrid4.Name = "dtGrid4";
            this.dtGrid4.ReadOnly = true;
            this.dtGrid4.RowHeadersWidth = 62;
            this.dtGrid4.RowTemplate.Height = 30;
            this.dtGrid4.Size = new System.Drawing.Size(696, 410);
            this.dtGrid4.TabIndex = 0;
            // 
            // stdcode
            // 
            this.stdcode.DataPropertyName = "stdcode";
            this.stdcode.HeaderText = "学号";
            this.stdcode.MinimumWidth = 8;
            this.stdcode.Name = "stdcode";
            this.stdcode.ReadOnly = true;
            // 
            // stdname
            // 
            this.stdname.DataPropertyName = "stdname";
            this.stdname.HeaderText = "姓名";
            this.stdname.MinimumWidth = 8;
            this.stdname.Name = "stdname";
            this.stdname.ReadOnly = true;
            // 
            // stclass
            // 
            this.stclass.DataPropertyName = "claname";
            this.stclass.HeaderText = "班级";
            this.stclass.MinimumWidth = 8;
            this.stclass.Name = "stclass";
            this.stclass.ReadOnly = true;
            // 
            // claname
            // 
            this.claname.DataPropertyName = "subname";
            this.claname.HeaderText = "课程";
            this.claname.MinimumWidth = 8;
            this.claname.Name = "claname";
            this.claname.ReadOnly = true;
            // 
            // textdeliver4
            // 
            this.textdeliver4.Location = new System.Drawing.Point(12, 304);
            this.textdeliver4.Name = "textdeliver4";
            this.textdeliver4.Size = new System.Drawing.Size(100, 28);
            this.textdeliver4.TabIndex = 1;
            this.textdeliver4.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.dtGrid4);
            this.groupBox1.Location = new System.Drawing.Point(24, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 439);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(262, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "选课同学信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(230, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "总人数：";
            // 
            // textNum
            // 
            this.textNum.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textNum.Location = new System.Drawing.Point(363, 503);
            this.textNum.Name = "textNum";
            this.textNum.ReadOnly = true;
            this.textNum.Size = new System.Drawing.Size(59, 39);
            this.textNum.TabIndex = 5;
            // 
            // Formselecinform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 569);
            this.Controls.Add(this.textNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textdeliver4);
            this.MaximizeBox = false;
            this.Name = "Formselecinform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选课学生信息";
            this.Load += new System.EventHandler(this.Formselecinform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGrid4;
        public System.Windows.Forms.TextBox textdeliver4;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdname;
        private System.Windows.Forms.DataGridViewTextBoxColumn stclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn claname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNum;
    }
}