﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishProduction
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm Login = new LoginForm();
            if(Login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainFrom()); 
            }
            //Application.Run(new LoginForm());


        }
    }
}
