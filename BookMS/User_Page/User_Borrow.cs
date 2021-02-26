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
    //借书管理页面
    public partial class User_Borrow : Form
    {
        public User_Borrow()
        {
            InitializeComponent();
        }

        private void User_Borrow_Load(object sender, EventArgs e)
        {
            Init_Tab();
        }

        /// <summary>
        /// 初始化表格数据
        /// </summary>
        void Init_Tab()
        {
            dataGridView1.Rows.Clear();//清除旧的数据
            string sql = "select * from books_Info";
            IDataReader idr = Data.dao.Read(sql);
            while (idr.Read())
            {
                dataGridView1.Rows.Add(idr[0].ToString(), idr[1].ToString(), idr[2].ToString(), idr[3].ToString(), idr[4].ToString());
            }
            idr.Close();
            Data.dao.DB_Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string sql = $"insert into borrowBook_Info([user_id],book_id,[time])values('{Data.UID}','{id}',getdate());update books_Info set number = number - 1 where id = {id}";
            
            if (Data.dao.Execute(sql) > 1)
            {
                MessageBox.Show(Data.UName + " 借出成功 ");
                Init_Tab();
            }
            else
            {
                MessageBox.Show("借出失败");
            }
        }
    }
}
