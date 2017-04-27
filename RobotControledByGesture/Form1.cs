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
using AForge.Imaging.Filters;
using System.Drawing.Imaging;
using AForge;
using AForge.Imaging;
using AForge.Math.Geometry;

namespace RobotControledByGesture
{
    public partial class Form1 : Form
    {
        int Treshold =100;
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
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            Threshold filter = new Threshold(Treshold);
            Grayscale GRfilter = new Grayscale(0.2125, 0.7154, 0.0721);
            var Mir = new Mirror(false, true);

            Mir.ApplyInPlace(bitmap);
            Bitmap grayImage = GRfilter.Apply(bitmap);
            filter.ApplyInPlace(grayImage);

            // create filter
            BlobsFiltering blobsizefilter = new BlobsFiltering();
            // configure filter
            blobsizefilter.CoupledSizeFiltering = true;
            blobsizefilter.MinWidth = 70;
            blobsizefilter.MinHeight = 70;
            // apply the filter
            filter.ApplyInPlace(grayImage);


            // process image with blob counter
            BlobCounter blobCounter = new BlobCounter();
            blobCounter.ProcessImage(grayImage);
            Blob[] blobs = blobCounter.GetObjectsInformation();

            // create convex hull searching algorithm
            GrahamConvexHull hullFinder = new GrahamConvexHull();

            // lock image to draw on it
            BitmapData data = grayImage.LockBits(
                new Rectangle(0, 0, grayImage.Width, grayImage.Height),
                    ImageLockMode.ReadWrite, grayImage.PixelFormat);

            // process each blob
            foreach (Blob blob in blobs)
            {
                List<IntPoint> leftPoints, rightPoints, edgePoints = new List<IntPoint>();

                // get blob's edge points
                blobCounter.GetBlobsLeftAndRightEdges(blob,
                    out leftPoints, out rightPoints);

                edgePoints.AddRange(leftPoints);
                edgePoints.AddRange(rightPoints);

                // blob's convex hull
                List<IntPoint> hull = hullFinder.FindHull(edgePoints);

                Drawing.Polygon(data, hull, Color.Red);
            }

            grayImage.UnlockBits(data);

            pictureBox1.Image = grayImage;
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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Treshold = (int)numericUpDown1.Value;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cam.IsRunning)
            {
                cam.Stop();
            }
        }
    }
}
