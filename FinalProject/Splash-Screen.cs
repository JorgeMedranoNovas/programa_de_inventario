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

namespace FinalProject
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();

        }      

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            this.timer1.Start();     
      
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);

            if (progressBar1.Value == 99)
            {
                MainScreen main = new MainScreen();
                main.Show();
                this.Hide();
            }            

        }

       
    }
}
