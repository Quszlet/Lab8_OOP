using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_OOP
{
    public partial class RelaxForm : Form
    {
        private Stopwatch stopwatch;
        public RelaxForm()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
            stopwatch.Start();
            _ = TimeRelaxing();
        }

        private async Task TimeRelaxing()
        {
            while (true)
            {
                TimeSpan elapsedTime = stopwatch.Elapsed;
                label2.Text = elapsedTime.ToString("hh\\:mm\\:ss");

                await Task.Delay(1000);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RelaxForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
