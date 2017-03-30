using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RobotControledByGesture.Lego;

namespace RobotControledByGesture
{
    public partial class Form1 : Form
    {
       
        Robot R;
        public Form1()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            R  = new Robot();
            R.InitializeRobotAsync("COM8");
        }

        private void button1_Click(object sender, EventArgs e)
        {
                R.ForwardAsync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            R.StopMoving();
        }
    }
}
