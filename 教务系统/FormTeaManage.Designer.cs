
namespace 教务系统
{
    partial class FormTeaManage
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
            this.grpCommand = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpData = new System.Windows.Forms.GroupBox();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.grpEditor = new System.Windows.Forms.GroupBox();
            this.textPwd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textClass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textMajor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textDpm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stdcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stddpm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdmajor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpCommand.SuspendLayout();
            this.grpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.grpEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCommand
            // 
            this.grpCommand.Controls.Add(this.btnClose);
            this.grpCommand.Controls.Add(this.btnDel);
            this.grpCommand.Controls.Add(this.btnEdit);
            this.grpCommand.Controls.Add(this.btnAdd);
            this.grpCommand.Location = new System.Drawing.Point(108, 56);
            this.grpCommand.Name = "grpCommand";
            this.grpCommand.Size = new System.Drawing.Size(1014, 167);
            this.grpCommand.TabIndex = 2;
            this.grpCommand.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(762, 45);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(229, 67);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "退出";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            this.btnDel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDel.Location = new System.Drawing.Point(515, 45);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(229, 67);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEdit.Location = new System.Drawing.Point(258, 45);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(229, 67);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(6, 45);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(229, 67);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.grdData);
            this.grpData.Location = new System.Drawing.Point(18, 241);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(1187, 752);
            this.grpData.TabIndex = 3;
            this.grpData.TabStop = false;
            // 
            // grdData
            // 
            this.grdData.AllowUserToAddRows = false;
            this.grdData.AllowUserToDeleteRows = false;
            this.grdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stdcode,
            this.name,
            this.stddpm,
            this.stdmajor,
            this.stdclass});
            this.grdData.Location = new System.Drawing.Point(3, 27);
            this.grdData.Name = "grdData";
            this.grdData.ReadOnly = true;
            this.grdData.RowHeadersWidth = 62;
            this.grdData.RowTemplate.Height = 27;
            this.grdData.Size = new System.Drawing.Size(1178, 725);
            this.grdData.TabIndex = 0;
            this.grdData.SelectionChanged += new System.EventHandler(this.grdData_SelectionChanged);
            // 
            // grpEditor
            // 
            this.grpEditor.Controls.Add(this.textPwd);
            this.grpEditor.Controls.Add(this.label6);
            this.grpEditor.Controls.Add(this.textClass);
            this.grpEditor.Controls.Add(this.label5);
            this.grpEditor.Controls.Add(this.textMajor);
            this.grpEditor.Controls.Add(this.label4);
            this.grpEditor.Controls.Add(this.textDpm);
            this.grpEditor.Controls.Add(this.label3);
            this.grpEditor.Controls.Add(this.btnCancel);
            this.grpEditor.Controls.Add(this.btnOK);
            this.grpEditor.Controls.Add(this.textName);
            this.grpEditor.Controls.Add(this.label2);
            this.grpEditor.Controls.Add(this.textCode);
            this.grpEditor.Controls.Add(this.label1);
            this.grpEditor.Location = new System.Drawing.Point(321, 229);
            this.grpEditor.Name = "grpEditor";
            this.grpEditor.Size = new System.Drawing.Size(574, 493);
            this.grpEditor.TabIndex = 4;
            this.grpEditor.TabStop = false;
            this.grpEditor.Visible = false;
            // 
            // textPwd
            // 
            this.textPwd.Location = new System.Drawing.Point(183, 322);
            this.textPwd.Name = "textPwd";
            this.textPwd.Size = new System.Drawing.Size(263, 28);
            this.textPwd.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "密码:";
            // 
            // textClass
            // 
            this.textClass.Location = new System.Drawing.Point(183, 273);
            this.textClass.Name = "textClass";
            this.textClass.Size = new System.Drawing.Size(263, 28);
            this.textClass.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "班级:";
            // 
            // textMajor
            // 
            this.textMajor.Location = new System.Drawing.Point(183, 218);
            this.textMajor.Name = "textMajor";
            this.textMajor.Size = new System.Drawing.Size(263, 28);
            this.textMajor.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "专业:";
            // 
            // textDpm
            // 
            this.textDpm.Location = new System.Drawing.Point(183, 163);
            this.textDpm.Name = "textDpm";
            this.textDpm.Size = new System.Drawing.Size(263, 28);
            this.textDpm.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "学院:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(303, 396);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 46);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(179, 396);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(104, 46);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(183, 108);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(263, 28);
            this.textName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名:";
            // 
            // textCode
            // 
            this.textCode.Location = new System.Drawing.Point(183, 53);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(263, 28);
            this.textCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "编号:";
            // 
            // stdcode
            // 
            this.stdcode.DataPropertyName = "code";
            this.stdcode.HeaderText = "老师学号";
            this.stdcode.MinimumWidth = 8;
            this.stdcode.Name = "stdcode";
            this.stdcode.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "老师姓名";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // stddpm
            // 
            this.stddpm.DataPropertyName = "dpm";
            this.stddpm.HeaderText = "所在院校";
            this.stddpm.MinimumWidth = 8;
            this.stddpm.Name = "stddpm";
            this.stddpm.ReadOnly = true;
            // 
            // stdmajor
            // 
            this.stdmajor.DataPropertyName = "major";
            this.stdmajor.HeaderText = "所教专业";
            this.stdmajor.MinimumWidth = 8;
            this.stdmajor.Name = "stdmajor";
            this.stdmajor.ReadOnly = true;
            // 
            // stdclass
            // 
            this.stdclass.DataPropertyName = "class";
            this.stdclass.HeaderText = "所教班级";
            this.stdclass.MinimumWidth = 8;
            this.stdclass.Name = "stdclass";
            this.stdclass.ReadOnly = true;
            // 
            // FormTeaManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 995);
            this.Controls.Add(this.grpEditor);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.grpCommand);
            this.Name = "FormTeaManage";
            this.Text = "FormTeaManage";
            this.Load += new System.EventHandler(this.FormTeaManage_Load);
            this.grpCommand.ResumeLayout(false);
            this.grpData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.grpEditor.ResumeLayout(false);
            this.grpEditor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCommand;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.GroupBox grpEditor;
        private System.Windows.Forms.TextBox textPwd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textMajor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDpm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn stddpm;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdmajor;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdclass;
    }
}