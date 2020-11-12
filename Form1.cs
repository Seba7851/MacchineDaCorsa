using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacchineDaCorsa
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

        private void BlackCarBGW_DoWork(object sender, DoWorkEventArgs e)
        {
            //Genera una random
            Random rand = new Random();
            
            //ripeto il processo  finceh le macchine non superano il traguardo
            while (BlackCarPbx.Location.X < FinishLinePbx.Location.X)
            {
                //inserirsco la random nella variabile pos
                int pos = rand.Next(0, 20);
                //sposto la PictureBox in base al valore casuale generato dalla Radnom
                BlackCarPbx.Location = new Point(BlackCarPbx.Location.X+pos, BlackCarPbx.Location.Y);
                //Delay
                System.Threading.Thread.Sleep(50);
            }
            
            
            
        }

        private void RedCarBGW_DoWork(object sender, DoWorkEventArgs e)
        {
            //Genera una random
            Random rand = new Random();

            //ripeto il processo  finceh le macchine non superano il traguardo
            while (RedCarPbx.Location.X < FinishLinePbx.Location.X)
            {
                //inserirsco la random nella variabile pos
                int pos = rand.Next(0, 20);
                //sposto la PictureBox in base al valore casuale generato dalla Radnom
                RedCarPbx.Location = new Point(RedCarPbx.Location.X + pos, RedCarPbx.Location.Y);
                //Delay
                System.Threading.Thread.Sleep(50);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            BlackCarBGW.RunWorkerAsync();
            RedCarBGW.RunWorkerAsync();
        }
    }
}
