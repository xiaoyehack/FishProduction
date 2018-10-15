using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FishProduction
{

    public partial class LoginForm : Form
    {
        public static string loginUserName;
        public static string loginPassword;

        /* 1:管理员权限  2：用户权限 默认用户权限*/
        public static int Jurisdiction = 2;


        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {


            if ("admin" == userTextbox.Text && "yunshen919" == passTextbox.Text)
            {
                try
                {
                    Jurisdiction = 1;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch
                {

                }


            }
            else if ("guest" == userTextbox.Text && "guest" == passTextbox.Text)
            {
                try
                {
                    Jurisdiction = 2;
  
                    this.DialogResult = DialogResult.OK;
                    this.Close();
 
                }
                catch
                {

                }

            }
            else
            {
                MessageBox.Show("用户名密码输入错误", "提示");
            }
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
            string connStr = "data source=" + System.Environment.CurrentDirectory+"\\" + ConfigurationManager.ConnectionStrings["ProductionInfo"].ConnectionString;
        }

    }
}

