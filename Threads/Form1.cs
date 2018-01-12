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

namespace Threads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }


        //Doc 18
        private void btncomenzar_Click(object sender, EventArgs e)
        {
            Thread hilo1 = new Thread(new ThreadStart(EjecucionHilo1));
            Thread hilo2 = new Thread(new ThreadStart(EjecucionHilo2));
            hilo1.Start();
            hilo2.Start();

        }

        public void EjecucionHilo1()
        {
            lock (lstmensajes)
            {
                for (int i = 0; i < 5; i++)
                {
                    this.lstmensajes.Items.Add("Escribiendo hilo 1");
                    Thread.Sleep(1000);
                }
            }
        }

        public void EjecucionHilo2()
        {
            lock (lstmensajes)
            {
                for (int i = 0; i < 10; i++)
                {
                    this.lstmensajes.Items.Add("Escribiendo hilo 2");
                    Thread.Sleep(1000);
                }
            }
        }

    }
}
