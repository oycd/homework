using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 教务系统
{
    public partial class FormScorepb : Form
    {
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
    }
}
