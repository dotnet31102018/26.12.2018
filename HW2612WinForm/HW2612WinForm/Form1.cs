using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2612WinForm
{
    public partial class myForm : Form
    {
        public myForm()
        {
            InitializeComponent();
        }

        private bool GetAB(out int a, out int b)
        {

            if (int.TryParse(aTxt.Text, out a) == false)
            {
                MessageBox.Show($"{aTxt.Text} is not an Integer number", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                b = 0;
                return false;
            }

            if (!int.TryParse(bTxt.Text, out b))
            {
                MessageBox.Show($"{bTxt.Text} is not an Integer number", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            resultsLst.Items.Clear();
            System.Diagnostics.Debug.WriteLine("User cleared the list");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int a, b;
            if (GetAB(out a, out b))
            {
                resultsLst.Items.Add($"{a} + {b} = {a + b}");
            }
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            int a, b;
            if (GetAB(out a, out b))
            {
                resultsLst.Items.Add($"{a} - {b} = {a - b}");
            }
        }

        private void mulBtn_Click(object sender, EventArgs e)
        {
            int a, b;
            if (GetAB(out a, out b))
            {
                resultsLst.Items.Add($"{a} * {b} = {a * b}");
            }
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            int a, b;
            if (GetAB(out a, out b))
            {
                if (b == 0)
                {
                    BackColor = Color.Red;
                    return;
                }
                else
                {
                    BackColor = SystemColors.Control;
                }
                resultsLst.Items.Add($"{a} / {b} = {a / (double)b}");
            }
        }

        private void powerBtn_Click(object sender, EventArgs e)
        {
            int a, b;
            if (GetAB(out a, out b))
            {
                resultsLst.Items.Add($"{a} ^ {b} = { (Math.Pow(a,b)) }");
            }
        }

        private void sqrtBtn_Click(object sender, EventArgs e)
        {
            int a, b;
            if (GetAB(out a, out b))
            {
                resultsLst.Items.Add($"{a} ^ {b} = { (Math.Pow(a, 1.0 / b)) }");
            }
        }

        private void randomBtn_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int randomNumberA = r.Next(101);
            aTxt.Text = $"{randomNumberA}"; // 1
            aTxt.Text = "" + randomNumberA; // 2
            aTxt.Text = randomNumberA.ToString(); // 3
            aTxt.Text = Convert.ToString(randomNumberA); // 4

            int randomNumberB = r.Next(101);
            bTxt.Text = $"{randomNumberB}"; // 1
            bTxt.Text = "" + randomNumberB; // 2
            bTxt.Text = randomNumberB.ToString(); // 3
            bTxt.Text = Convert.ToString(randomNumberB); // 4
        }
    }
}
