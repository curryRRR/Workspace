using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookMS.User_Page
{
    //本窗体用来查看已借阅的图书信息 归还图书
    public partial class User_Still : Form
    {
        public User_Still()
        {
            InitializeComponent();
        }

        private void User_Still_Load(object sender, EventArgs e)
        {
            Init_Tab();
        }

        void Init_Tab()
        {
            dataGridView1.Rows.Clear();//清除旧的数据
            string sql = $"select * from borrowBook_Info where [user_id] = '{Data.UID}'";
            IDataReader idr = Data.dao.Read(sql);
            while (idr.Read())
            {
                dataGridView1.Rows.Add(idr[1].ToString(), idr[2].ToString(), idr[3].ToString());
            }
            idr.Close();
            Data.dao.DB_Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //归还图书
            string id = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string sql = $"delete borrowBook_Info where book_id = {id};update books_Info set number = number + 1 where id = {id}";
            if (Data.dao.Execute(sql) > 1)
            {
                MessageBox.Show(Data.UName + " 归还成功 ");
                Init_Tab();
            }
            else
            {
                MessageBox.Show("归还失败");
            }
        }
    }
}
