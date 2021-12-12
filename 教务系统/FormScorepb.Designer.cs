
namespace 教务系统
{
    partial class FormScorepb
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
            this.label1 = new System.Windows.Forms.Label();
            this.textCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textClass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSubject = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textScore = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnPb = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号：";
            // 
            // textCode
            // 
            this.textCode.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textCode.Location = new System.Drawing.Point(151, 72);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(326, 62);
            this.textCode.TabIndex = 1;
            this.textCode.TextChanged += new System.EventHandler(this.textCode_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "班级：";
            // 
            // textClass
            // 
            this.textClass.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textClass.Location = new System.Drawing.Point(151, 221);
            this.textClass.Name = "textClass";
            this.textClass.ReadOnly = true;
            this.textClass.Size = new System.Drawing.Size(326, 62);
            this.textClass.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(502, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 48);
            this.label3.TabIndex = 4;
            this.label3.Text = "课程：";
            // 
            // textSubject
            // 
            this.textSubject.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textSubject.Location = new System.Drawing.Point(641, 221);
            this.textSubject.Name = "textSubject";
            this.textSubject.ReadOnly = true;
            this.textSubject.Size = new System.Drawing.Size(326, 62);
            this.textSubject.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 48);
            this.label4.TabIndex = 6;
            this.label4.Text = "成绩：";
            // 
            // textScore
            // 
            this.textScore.Enabled = false;
            this.textScore.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textScore.Location = new System.Drawing.Point(151, 394);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(326, 62);
            this.textScore.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(641, 59);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(238, 75);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEdit.Location = new System.Drawing.Point(641, 381);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(238, 75);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "开始输入";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnPb
            // 
            this.btnPb.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPb.Location = new System.Drawing.Point(239, 539);
            this.btnPb.Name = "btnPb";
            this.btnPb.Size = new System.Drawing.Size(238, 75);
            this.btnPb.TabIndex = 10;
            this.btnPb.Text = "发布";
            this.btnPb.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExit.Location = new System.Drawing.Point(510, 539);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(238, 75);
            this.btExit.TabIndex = 11;
            this.btExit.Text = "退出";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // FormScorepb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 688);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btnPb);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textSubject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCode);
            this.Controls.Add(this.label1);
            this.Name = "FormScorepb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成绩发布";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSubject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textScore;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnPb;
        private System.Windows.Forms.Button btExit;
    }
}