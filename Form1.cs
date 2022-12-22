using System;
using System.Threading;
using System.Windows.Forms;
using VEST_System_3._0;

namespace VEST
{
    public partial class Form1 : Form
    {

        Thread th;
        public Form1()
        {
            InitializeComponent();
        }
        public void openfrm2(object obj)
        {
            Application.Run(new Form2());
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 256)
            {
                timer1.Stop();
                this.Close();
                th = new Thread(openfrm2);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
