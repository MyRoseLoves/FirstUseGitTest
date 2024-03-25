using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemManege
{
    public partial class MenuManege : Form
    {
        public MenuManege()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Assembly currentAssem = Assembly.GetExecutingAssembly();

            this.Close();
        }
    }
}
