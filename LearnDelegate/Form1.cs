using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using LearnDelegate;
using TabControls;


namespace LearnDelegate
{
    public partial class FormButtons : Form
    {
        public FormButtons()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LearnDelegate.Program.Hello("Porra");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TabControl NewTab = new TabControl();
        }
    }
}
