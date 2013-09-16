using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

public delegate void SelectTabHandler(object sender, EventArgs e);

namespace TabControls
{

    

    public partial class FormTabs : Form
    {
        public FormTabs()
        {
            InitializeComponent();
        }

        SelectTabHandler SelectTabDelegate = new SelectTabHandler(SelectTab);

        public static void FODA(object sender, EventArgs e)
        { 
            TabControl1
        }
       

        private void SelectTab(object sender, EventArgs e)
        {
            TabControl1.SelectedTab = tabPage2;
        }
    }
}
