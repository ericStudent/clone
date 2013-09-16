using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public delegate void HelloDelgate(string Message);

namespace LearnDelegate
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            HelloDelgate Delegar = new HelloDelgate(Hello);
            Delegar("putaquepariuvesefuncionaessamerda");

            Application.Run(new FormButtons());
  
  
        }
        
        public static void Hello(string StrMessage)
        {
            MessageBox.Show(StrMessage);

        }
    }
}

