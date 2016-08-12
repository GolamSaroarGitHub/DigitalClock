using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class Form1 : Form
    {
        Timer t = new Timer();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;// reperesents in milisecond
            t.Tick += new EventHandler(this.t_tick);

            t.Start();
        }
        private void t_tick(object sender, EventArgs e)
        {
            //initate the present time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;


            string time = "";
            if (hh < 10)
                time += "0" + hh;
            else
                time += hh;
            time += ":";
            if (mm < 10)
                time += "0" + mm;
            else
                time += mm;
            time += ":";
            if (ss < 10)
                time += "0" + ss;
            else
                time += ss;
            //update label text

            label1.Text = time;
        }
    }
}
