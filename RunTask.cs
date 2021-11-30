using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SimpleTaskManager
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("regedit.exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("taskmgr.exe");
        }
    }
}
