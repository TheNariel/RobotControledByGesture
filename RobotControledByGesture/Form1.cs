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
using AForge.Video;
using AForge.Video.DirectShow;

namespace RobotControledByGesture
{
    public partial class Form1 : Form
    {
       
        Robot R;
        public Form1()
        {

            InitializeComponent();

        }

        private FilterInfoCollection webcam;
        private VideoCaptureDevice cam;


        private void Form1_Load(object sender, EventArgs e)
        {
            R  = new Robot();
           // R.InitializeRobotAsync("COM8");

            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in webcam)
            {
                comboBox1.Items.Add(VideoCaptureDevice.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                R.ForwardAsync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            R.StopMoving();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cam = new VideoCaptureDevice(webcam[comboBox1.SelectedIndex].MonikerString);
            cam.NewFrame += new NewFrameEventHandler(Cam_NewFrame);
            cam.Start();
        }

        void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bit;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cam.IsRunning)
            {
                cam.Stop();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            button3.Visible = true;

            button4.Visible = true;
        }
    }
}
