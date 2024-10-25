using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYaris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int yarisNo = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dataGridView1.Columns.Add("Kazanan" , "Kazanan");
            dataGridView1.Columns.Add("Yarış No", "Yarış No");
            dataGridView1.Columns.Add("Yarış Saati", "Yarış Saati");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int s1 = r.Next(25,45);
            int s2 = r.Next(25, 45);

            pictureBox1.Left += s1;
            label1.Left += s1;
            pictureBox2.Left += s2;
            label3.Left += s2;
            
            if(pictureBox1.Right >= this.Width || pictureBox2.Right >= this.Width)
            {
                timer1.Stop();
                if(pictureBox1.Right > pictureBox2.Right)
                {
                    dataGridView1.Rows.Add(label1.Text, yarisNo, DateTime.Now);
                }
                else
                {
                    dataGridView1.Rows.Add(label3.Text, yarisNo, DateTime.Now);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            label1.Left = 0;
            label3.Left = 0;
            yarisNo++;
        }
    }
}
