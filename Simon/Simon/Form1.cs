using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void startGameBtn_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            int MAX = 10;
            Color pressColor = Color.Black;
            int sleep = 750;

            int[] colors = new int[MAX];

            for (int i = 0; i < MAX; i++)
            {
                colors[i] = r.Next(4);
            }

            new Thread(() =>
           {
               int steps = 4;
               for (int i = 0; i < steps; i++)
               {
                   switch (colors[i])
                   {
                       case 0:
                           redPanel0.BackColor = pressColor;
                           break;
                       case 1:
                           yellowPanel1.BackColor = pressColor;
                           break;
                       case 2:
                           bluePanel2.BackColor = pressColor;
                           break;
                       case 3:
                           greenPanel3.BackColor = pressColor;
                           break;
                   }

                   Thread.Sleep(sleep);

                   redPanel0.BackColor = Color.Red;
                   yellowPanel1.BackColor = Color.Yellow;
                   bluePanel2.BackColor = Color.Blue;
                   greenPanel3.BackColor = Color.Lime;

                   Thread.Sleep(100);
               }
           }).Start();
        }
    }
}
