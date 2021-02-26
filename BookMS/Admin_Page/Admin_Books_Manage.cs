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
    public partial class Admin_Books_Manage : Form
    {
        public Admin_Books_Manage()
        {
            InitializeComponent();
        }

        private void Admin_Books_Manage_Load(object sender, EventArgs e)
        {
            Init_Tab();
            label_book.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }


        //Dao dao = new Dao();
        /// <summary>
        /// 初始化表格显示的数据
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

        /// <summary>
        /// 根据id来显示表格数据
        /// </summary>
        void Init_Tab_ID()
        {
            dataGridView1.Rows.Clear();//清除旧的数据
            string sql = $"select * from books_Info where id ='{text_id.Text}'";
            IDataReader idr = Data.dao.Read(sql);
            while (idr.Read())
            {
                dataGridView1.Rows.Add(idr[0].ToString(), idr[1].ToString(), idr[2].ToString(), idr[3].ToString(), idr[4].ToString());
            }
            idr.Close();
            Data.dao.DB_Close();
        }
        /// <summary>
        /// 根据 书名 来显示表格数据
        /// </summary>
        void Init_Tab_Name()
        {
            dataGridView1.Rows.Clear();//清除旧的数据
            string sql = $"select * from books_Info where [name] like '%{text_name.Text}%'";
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
            Admin_Books_Add abd = new Admin_Books_Add();
            abd.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                //获取到被选中项的id   删除图书
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                
                DialogResult dr = MessageBox.Show("是否确认删除!", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    string sql = $"delete from books_Info where id = '{id}'";
                    int num = Data.dao.Execute(sql);
                    if (num > 0)
                    {
                        MessageBox.Show("删除成功");
                        Init_Tab();
                        label_book.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                    Data.dao.DB_Close();
                }
            }
            catch
            { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Init_Tab();
            label_book.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            MessageBox.Show("刷新成功");
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label_book.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string author = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string press = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string number = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                Admin_Books_Update abu = new Admin_Books_Update(id, name, author, press, number);
                abu.ShowDialog();
                Init_Tab();
            }
            catch
            { }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Init_Tab_ID();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Init_Tab_Name();
        }
    }
}
