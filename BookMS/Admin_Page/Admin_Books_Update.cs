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
    //修改图书信息
    public partial class Admin_Books_Update : Form
    {
        public Admin_Books_Update()
        {
            InitializeComponent();
        }
        string ID = "";

        public Admin_Books_Update(string id, string name, string author, string press, string number)
        {
            InitializeComponent();
            this.ID = id;
            text_BookId.Text = id;
            text_BookName.Text = name;
            text_BookAuthor.Text = author;
            text_BookPress.Text = press;
            text_BookNumber.Text = number;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //修改图书信息
            string id = text_BookId.Text;
            string name = text_BookName.Text;
            string author = text_BookAuthor.Text;
            string press = text_BookPress.Text;
            string number = text_BookNumber.Text;
            string sql = $"update books_Info set id='{id}',[name]='{name}',author='{author}',press='{press}',number={number} where id = '{this.ID}'";
            int num = Data.dao.Execute(sql);
            if (num > 0)
            {
                MessageBox.Show("修改成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }
    }
}
