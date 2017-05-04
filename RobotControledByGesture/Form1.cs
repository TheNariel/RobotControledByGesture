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
        int Treshold = 100;
        Robot R;
        public Form1()
        {

            InitializeComponent();

        }
        Boolean active = true;
        private FilterInfoCollection webcam;
        private VideoCaptureDevice cam;


        private void Form1_Load(object sender, EventArgs e)
        {
            R = new Robot();
           // R.InitializeRobotAsync("COM4");

            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in webcam)
            {
                comboBox1.Items.Add(VideoCaptureDevice.Name);
            }
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



            // process image with blob counter
            BlobCounter blobCounter = new BlobCounter();
            blobCounter.ObjectsOrder = ObjectsOrder.Size;
            blobCounter.FilterBlobs = true;
            blobCounter.MinWidth = 100;
            blobCounter.MinHeight = 100;


            blobCounter.ProcessImage(grayImage);
            Blob[] blobs = blobCounter.GetObjectsInformation();

            // create convex hull searching algorithm
            GrahamConvexHull hullFinder = new GrahamConvexHull();

            // lock image to draw on it
            BitmapData data = grayImage.LockBits(
                new Rectangle(0, 0, grayImage.Width, grayImage.Height),
                    ImageLockMode.ReadWrite, grayImage.PixelFormat);

            Blob blob = blobs[0];

            List<IntPoint> leftPoints, rightPoints, edgePoints = new List<IntPoint>();

            // get blob's edge points
            blobCounter.GetBlobsLeftAndRightEdges(blob,
                out leftPoints, out rightPoints);

            edgePoints.AddRange(leftPoints);
            edgePoints.AddRange(rightPoints);

            // blob's convex hull
            List<IntPoint> hull = hullFinder.FindHull(edgePoints);
            IntPoint middle = getMiddle(hull);
            handleHull(hull, middle);

            Drawing.FillRectangle(data, new Rectangle(middle.X, middle.Y, 10, 10), Color.Red);
            Drawing.Polygon(data, hull, Color.Red);


            grayImage.UnlockBits(data);

            pictureBox1.Image = grayImage;
        }
        private IntPoint getMiddle(List<IntPoint> hull)
        {
            IntPoint ret;
            int Mx = 0, My = 0;
            foreach (IntPoint h in hull)
            {
                Mx += h.X;
                My += h.Y;
            }
            Mx = Mx / hull.Count;
            My = My / hull.Count;
            ret = new IntPoint(Mx, My);
            return ret;
        }

        private void handleHull(List<IntPoint> hull, IntPoint middle)
        {
            List<int> distances = new List<int>();
            int x;
            foreach (IntPoint P in hull)
            {
                x = middle.X - P.X;
                x = Math.Abs(x);
                distances.Add(x);
            }
            distances.Sort();
            if (distances.First() > 30)
            {
               // R.ForwardAsync();
            }
            else
            {
               // R.StopMoving();
            }

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
            if (cam!=null && cam.IsRunning)
            {
                cam.Stop();
            }
        }
    }
}
