
namespace 教务系统
{
    partial class FormScoreselc
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtGrid5 = new System.Windows.Forms.DataGridView();
            this.subname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textCode = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textClass = new System.Windows.Forms.TextBox();
            this.textdelive6 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "成绩结果：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtGrid5);
            this.groupBox1.Location = new System.Drawing.Point(164, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(909, 539);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dtGrid5
            // 
            this.dtGrid5.AllowUserToAddRows = false;
            this.dtGrid5.AllowUserToDeleteRows = false;
            this.dtGrid5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGrid5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrid5.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGrid5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subname,
            this.score});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGrid5.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtGrid5.Location = new System.Drawing.Point(0, 21);
            this.dtGrid5.Name = "dtGrid5";
            this.dtGrid5.ReadOnly = true;
            this.dtGrid5.RowHeadersWidth = 62;
            this.dtGrid5.RowTemplate.Height = 30;
            this.dtGrid5.Size = new System.Drawing.Size(903, 512);
            this.dtGrid5.TabIndex = 0;
            // 
            // subname
            // 
            this.subname.DataPropertyName = "subname";
            this.subname.HeaderText = "课程名";
            this.subname.MinimumWidth = 8;
            this.subname.Name = "subname";
            this.subname.ReadOnly = true;
            // 
            // score
            // 
            this.score.DataPropertyName = "score";
            this.score.HeaderText = "成绩";
            this.score.MinimumWidth = 8;
            this.score.Name = "score";
            this.score.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(75, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "学号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(466, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(857, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "班级：";
            // 
            // textCode
            // 
            this.textCode.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textCode.Location = new System.Drawing.Point(192, 195);
            this.textCode.Name = "textCode";
            this.textCode.ReadOnly = true;
            this.textCode.Size = new System.Drawing.Size(210, 42);
            this.textCode.TabIndex = 5;
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textName.Location = new System.Drawing.Point(583, 195);
            this.textName.Name = "textName";
            this.textName.ReadOnly = true;
            this.textName.Size = new System.Drawing.Size(210, 42);
            this.textName.TabIndex = 6;
            // 
            // textClass
            // 
            this.textClass.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textClass.Location = new System.Drawing.Point(974, 195);
            this.textClass.Name = "textClass";
            this.textClass.ReadOnly = true;
            this.textClass.Size = new System.Drawing.Size(210, 42);
            this.textClass.TabIndex = 7;
            // 
            // textdelive6
            // 
            this.textdelive6.Location = new System.Drawing.Point(29, 430);
            this.textdelive6.Name = "textdelive6";
            this.textdelive6.Size = new System.Drawing.Size(100, 28);
            this.textdelive6.TabIndex = 8;
            this.textdelive6.Visible = false;
            // 
            // FormScoreselc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1218, 879);
            this.Controls.Add(this.textdelive6);
            this.Controls.Add(this.textClass);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormScoreselc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成绩结果";
            this.Load += new System.EventHandler(this.FormScoreselc_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtGrid5;
        private System.Windows.Forms.DataGridViewTextBoxColumn subname;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textClass;
        public System.Windows.Forms.TextBox textdelive6;
    }
}