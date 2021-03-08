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
    public partial class Login : Form
    {
          
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (text_ID.Text != "" && text_Pwd.Text != "")
            {
                Login_Check();
            }
            else
            {
                MessageBox.Show("用户名或密码不能为空 1");
            }
        }

        //Dao dao = new Dao(); //操作数据库的对象

        /// <summary>
        /// 登录验证
        /// </summary>
        /// <returns>是否成功</returns>
        public void Login_Check()
        {
            if (radio_User.Checked)
            {
                string sql = $"select * from user_Login where id = '{text_ID.Text}' and pwd = '{text_Pwd.Text}'";
                IDataReader dataReader = Data.dao.Read(sql);
                if (dataReader.Read())
                {
                    Data.UID = dataReader["id"].ToString();
                    Data.UName = dataReader["name"].ToString();
                    //通过id和pwd读取到了数据
                    MessageBox.Show("登录成功");
                    User_Success us = new User_Success();
                    this.Hide();
                    us.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登录失败");
                    text_ID.Clear();
                    text_Pwd.Clear();
                }
                dataReader.Close();
                Data.dao.DB_Close();
            }
            else if(radio_Admin.Checked)
            {
                string sql = $"select * from admin_Login where id = '{text_ID.Text}' and pwd = '{text_Pwd.Text}'";
                IDataReader dataReader = Data.dao.Read(sql);
                if (dataReader.Read())
                {
                    MessageBox.Show("登录成功");
                    Admin_Success adm = new Admin_Success();
                    this.Hide();
                    adm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登录失败");
                    text_ID.Clear();
                    text_Pwd.Clear();
                }
                dataReader.Close();
                Data.dao.DB_Close();
            }   
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
