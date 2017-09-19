using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace Timed_Form
{
    public partial class Form1 : Form
    {
          public Form1()
        
        {
            InitializeComponent();
            Timer timer1 = new Timer(); //Initialize a new Timer of name timer1
            timer1.Tick += new EventHandler(timer1_Tick); //Link the Tick event with timer1_Tick
            timer1.Start(); //Start the timer
            Cursor.Hide();
            label1.DoubleClick -= (null);
            label1.Click -= (null);
            label1.MouseMove -= (null);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            for (int i = 1; i <= 100; i++)
            {
                // Wait 100 milliseconds.
                System.Threading.Thread.Sleep(300);
                // Report progress.
                progressBar1.Value = i;
            }

            Environment.Exit(0);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
                        
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Cursor.Position = new Point(Cursor.Position.X - 50, Cursor.Position.Y - 50);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            return;
        }

        private void Control1_MouseDoubleClick(Object sender, MouseEventArgs e)
        {
            label1.DoubleClick -= (null);
        }
    }
}
