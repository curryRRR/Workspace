using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookMS
{
    public partial class Admin_Books_Add : Form
    {
        public Admin_Books_Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = text_BookId.Text;
            string name = text_BookName.Text;
            string author = text_BookAuthor.Text;
            string press = text_BookPress.Text;
            string number = text_BookNumber.Text;
            if (id != "" && name != "" && author != "" && press != "" && number != "")
            {
                string sql = $"insert into books_Info values('{id}', '{name}', '{author}', '{press}', {number})";
                int num = Data.dao.Execute(sql);
                if (num > 0)
                {
                    MessageBox.Show("添加成功");
                }
                else
                {
                    MessageBox.Show("添加失败");
                }

                Data.dao.DB_Close();
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
