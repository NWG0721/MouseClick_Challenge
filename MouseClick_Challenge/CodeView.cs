using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseClick_Challenge
{
    public partial class CodeView : Form
    {
        public CodeView()
        {
            InitializeComponent();
        }

        private void CodeView_Load(object sender, EventArgs e)
        {
            txtMainForm.Text = "using System;\r\nusing System.Collections.Generic;\r\nusing System.ComponentModel;\r\nusing System.Data;\r\nusing System.Drawing;\r\nusing System.Linq;\r\nusing System.Text;\r\nusing System.Threading;\r\nusing System.Threading.Tasks;\r\nusing System.Windows.Forms;\r\nusing System.Diagnostics;\r\n\r\nnamespace MouseClick_Challenge\r\n{\r\n    public partial class MainForm : Form\r\n    {\r\n        public MainForm()\r\n        {\r\n            InitializeComponent();\r\n        }\r\n        private int Second;\r\n        private int Min;\r\n        private void generator()\r\n        {\r\n            Random random = new Random();\r\n            int blueButtonNumbers = 0;\r\n            foreach (Button btn in panMain.Controls)\r\n            {\r\n                btn.Visible = true;\r\n                btn.BackColor = Color.DimGray;\r\n            }\r\n            foreach (Button btn in panMain.Controls)\r\n            {\r\n\r\n                if (random.Next(0, 2) == 0)\r\n                {\r\n                    btn.BackColor = Color.Blue;\r\n                    blueButtonNumbers++;\r\n                }\r\n            }\r\n            lblCounter.Text = blueButtonNumbers.ToString();\r\n        }\r\n\r\n        private void btmMain_MouseClick(object sender, MouseEventArgs e)\r\n        {\r\n            timer1.Enabled = true;\r\n            Console.Beep(963, 100);\r\n            Button button = sender as Button;\r\n            if (button.BackColor == Color.Blue)\r\n            {\r\n                button.Visible = false;\r\n                lblCounter.Text = (Convert.ToInt32(lblCounter.Text) - 1).ToString();\r\n                if (lblCounter.Text == \"0\")\r\n                {\r\n                    timer1.Enabled = false;\r\n                    MessageBox.Show(\"برنده شدی رفت\");\r\n                }\r\n            }\r\n            else\r\n            {\r\n                timer1.Enabled = false;\r\n                MessageBox.Show(\"شما باختیت\");\r\n                //Process.Start(\"CMD.exe\",\"shutdown\");\r\n                generator();\r\n            }   \r\n        }\r\n\r\n        private void Form1_Load(object sender, EventArgs e)\r\n        {\r\n            generator();\r\n        }\r\n\r\n        private void timer1_Tick(object sender, EventArgs e)\r\n        {\r\n            Second = Convert.ToInt32(lblSecond.Text);\r\n            Min = Convert.ToInt32(lblMinute.Text);\r\n            lblSecond.Text = (Second + 1).ToString();\r\n            if (Second == 60)\r\n            {\r\n                lblSecond.Text = \"00\";\r\n                Min++;\r\n            }\r\n        }\r\n\r\n        private void btnViewCode_Click(object sender, EventArgs e)\r\n        {\r\n            CodeView codeView = new CodeView();\r\n            codeView.Show();\r\n        }\r\n\r\n        private void button209_Click(object sender, EventArgs e)\r\n        {\r\n            generator();\r\n        }\r\n    }\r\n}\r\n";

        }
    }
}
