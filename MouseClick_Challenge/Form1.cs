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
using System.Diagnostics;

namespace MouseClick_Challenge
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private int Second;
        private int Min;
        private void generator()
        {
            lblMinute.Text = "00";
            lblSecond.Text = "00";
            timer1.Enabled = false;
            Random random = new Random();
            int blueButtonNumbers = 0;
            foreach (Button btn in panMain.Controls)
            {
                btn.Visible = true;
                btn.BackColor = Color.DimGray;
            }
            foreach (Button btn in panMain.Controls)
            {

                if (random.Next(0, 2) == 0)
                {
                    btn.BackColor = Color.Blue;
                    blueButtonNumbers++;
                }
            }
            lblCounter.Text = blueButtonNumbers.ToString();
        }

        private void btmMain_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;
            Console.Beep(963, 100);
            Button button = sender as Button;
            if (button.BackColor == Color.Blue)
            {
                button.Visible = false;
                lblCounter.Text = (Convert.ToInt32(lblCounter.Text) - 1).ToString();
                if (lblCounter.Text == "0")
                {
                    timer1.Enabled = false;
                    MessageBox.Show("برنده شدی رفت");
                }
            }
            else
            {
                timer1.Enabled = false;
                MessageBox.Show("شما باختی");
                //Process.Start("CMD.exe","shutdown");
                generator();
            }   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generator();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Second = Convert.ToInt32(lblSecond.Text);
            Min = Convert.ToInt32(lblMinute.Text);
            lblSecond.Text = (Second + 1).ToString();
            if (Second == 60)
            {
                timer1.Enabled = false;
                MessageBox.Show("شما باختی");
                generator();
            }
        }

        private void btnViewCode_Click(object sender, EventArgs e)
        {
            CodeView codeView = new CodeView();
            codeView.Show();
        }

        private void button209_Click(object sender, EventArgs e)
        {
            generator();
        }
    }
}
