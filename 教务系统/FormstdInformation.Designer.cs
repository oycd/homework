
namespace 教务系统
{
    partial class FormstdInformation
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textName1 = new System.Windows.Forms.TextBox();
            this.textCode1 = new System.Windows.Forms.TextBox();
            this.textMajor1 = new System.Windows.Forms.TextBox();
            this.textClass1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(158, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(158, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "学生编号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(158, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "专业名称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(158, 487);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "班级名称：";
            // 
            // textName1
            // 
            this.textName1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textName1.Location = new System.Drawing.Point(359, 93);
            this.textName1.Name = "textName1";
            this.textName1.ReadOnly = true;
            this.textName1.Size = new System.Drawing.Size(356, 42);
            this.textName1.TabIndex = 4;
            // 
            // textCode1
            // 
            this.textCode1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textCode1.Location = new System.Drawing.Point(359, 218);
            this.textCode1.Name = "textCode1";
            this.textCode1.ReadOnly = true;
            this.textCode1.Size = new System.Drawing.Size(356, 42);
            this.textCode1.TabIndex = 5;
            // 
            // textMajor1
            // 
            this.textMajor1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textMajor1.Location = new System.Drawing.Point(359, 344);
            this.textMajor1.Name = "textMajor1";
            this.textMajor1.ReadOnly = true;
            this.textMajor1.Size = new System.Drawing.Size(356, 42);
            this.textMajor1.TabIndex = 6;
            // 
            // textClass1
            // 
            this.textClass1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textClass1.Location = new System.Drawing.Point(359, 489);
            this.textClass1.Name = "textClass1";
            this.textClass1.ReadOnly = true;
            this.textClass1.Size = new System.Drawing.Size(356, 39);
            this.textClass1.TabIndex = 7;
            // 
            // FormstdInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(877, 682);
            this.Controls.Add(this.textClass1);
            this.Controls.Add(this.textMajor1);
            this.Controls.Add(this.textCode1);
            this.Controls.Add(this.textName1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormstdInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "基本信息";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormstdInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textName1;
        private System.Windows.Forms.TextBox textCode1;
        private System.Windows.Forms.TextBox textMajor1;
        private System.Windows.Forms.TextBox textClass1;
    }
}