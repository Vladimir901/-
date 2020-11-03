using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Игра
{
    public partial class Form1 : Form
    {
        int m = 0;
        Logo logo = new Logo();
        public Form1()
        {

            InitializeComponent();
            this.Hide();
            Width = 100;
            Height = 100;
            
            timer1.Interval = 1000;          
            logo.Show();
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            m++;
            Logotype();
        }
        void Logotype()
        {
            if (m == 2)
            {
                timer1.Stop();
                logo.Close();
                this.WindowState = FormWindowState.Maximized;
                
            }
        }
    }
}
