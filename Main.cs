using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Windows.Forms;

namespace SimpleTaskManager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        List<int> dsprocess = new List<int>();

        public object VisualBasic { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            DSListProcess();
            progressBar1.Value = 100;
        }

        private void DSListProcess()
        {
            dsprocess = new List<int>();
            listBox1.Items.Clear();
            Process[] p = Process.GetProcesses();
            foreach (Process ct in p)
            {
                listBox1.Items.Add("Name: " + ct.ProcessName + " Id: " + ct.Id);
                dsprocess.Add(ct.Id);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndices.Count > 0)
            {
                progressBar1.Value = 0;
                int id = dsprocess[listBox1.SelectedIndex];
                Process.GetProcessById(id).Kill();
                progressBar1.Value = 100;
                DSListProcess();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           string path = Microsoft.VisualBasic.Interaction.InputBox("Введите новую задачу", "DSTask Beta test (By DSINC)", "", 350, 350);
            Process.Start(path);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TopMost = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button5.Enabled = true;
            button4.Enabled = false;
            MessageBox.Show("Функция поверх всех окон включена");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = false;
            MessageBox.Show("Функция поверх всех окон отключена");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор DesConnet(DSGame) VK: vk.com/endnet");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DSListProcess();
        }
    }
}
