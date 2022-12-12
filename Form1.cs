using System;
using System.Windows.Forms;
using VEST_System_3._0;

namespace VEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 256)
            {
                timer1.Stop();
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
