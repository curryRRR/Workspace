using BookMS.User_Page;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookMS
{
    public partial class User_Success : Form
    {
        private string UserName;
        public User_Success()
        {
            InitializeComponent();
            
        }

        private void User_Success_Load(object sender, EventArgs e)
        {
            label1.Text = "欢迎您! " + Data.UName ;
        }

        private void 图书查看与借阅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Borrow ub = new User_Borrow();
            ub.ShowDialog();
        }

        private void 当前借阅的图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Still us = new User_Still();
            us.ShowDialog();
        }
    }
}
