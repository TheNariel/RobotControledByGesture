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
using System.Diagnostics;

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
        private FilterInfoCollection webcam;
        private VideoCaptureDevice cam;


        private void Form1_Load(object sender, EventArgs e)
        {
            R = new Robot();
            R.InitializeRobotAsync("COM7");

            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in webcam)
            {
                comboBox1.Items.Add(VideoCaptureDevice.Name);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            cam = new VideoCaptureDevice(webcam[comboBox1.SelectedIndex].MonikerString);
            //Resolution Number 0 {Width=640, Height=480}
            cam.VideoResolution = cam.VideoCapabilities[0];
            cam.NewFrame += new NewFrameEventHandler(Cam_NewFrame);
            cam.Start();
        }

        void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            Threshold filter = new Threshold(Treshold);
            Grayscale GRfilter = new Grayscale(0.2125, 0.7154, 0.0721);
            EuclideanColorFiltering euclidFilter = new EuclideanColorFiltering(new RGB(186, 187, 209), 120);
            var Mir = new Mirror(false, true);

            Mir.ApplyInPlace(bitmap);

            Rectangle cloneRect = new Rectangle(0, 0, 320, 240);
            PixelFormat format =
                 bitmap.PixelFormat;
            Bitmap cloneBitmap = bitmap.Clone(cloneRect, format);

            euclidFilter.ApplyInPlace(cloneBitmap);
            Bitmap grayImage = GRfilter.Apply(cloneBitmap);
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
            if (blobs.Length > 0)
            {
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
            }
            pictureBox1.Image = grayImage;
        }
        private IntPoint getMiddle(List<IntPoint> hull)
        {
            IntPoint ret;
            int Mx = 0, My = 0;
            foreach (IntPoint h in hull)
            {
                Mx += h.X;
            }

            Mx = Mx / hull.Count;
            My = (hull[hull.Count / 2].Y + hull[(hull.Count / 2) - 1].Y + hull[(hull.Count / 2) + 1].Y) / 3;
            ret = new IntPoint(Mx, My);
            return ret;
        }

        private void handleHull(List<IntPoint> hull, IntPoint middle)
        {
            if (hull != null)
            {
                List<int> Y = new List<int>();
                List<int> X = new List<int>();
                foreach (IntPoint P in hull)
                {                    
                    Y.Add(P.Y);
                    X.Add(P.X);
                }
                Y.Sort();
                X.Sort();
                int diffXMax = Math.Abs(middle.X - X.First());
                int diffXMin = Math.Abs(middle.X - X.Last());
                int distance = Math.Abs(Y.Last()- Y.First());
                int diff = diffXMax - diffXMin;
                Debug.Print(distance.ToString());

                if (distance > 150)
                {//Runn
                    if (diff > -20 && diff < 20)
                    {
                          R.ForwardAsync();
                        Debug.Print("run");
                    }
                    else
                    {

                        if (diff > 0)
                        {
                            R.LeftRunAsync();
                            Debug.Print("Run + Left");
                        }
                        else
                        {
                            R.RightRunAsync();
                            Debug.Print("Run + Right");
                        }
                    }
                }
                else
                {//Stop
                    if (diff > -20 && diff < 20)
                    {
                        R.StopMoving();
                        Debug.Print("Stup");
                    }
                    else
                    {

                        if (diff > 0)
                        {
                            R.LeftAsync();
                            Debug.Print("Stop + Left");
                        }
                        else
                        {
                            R.RightAsync();
                            Debug.Print("Stop + Right");
                        }
                    };
                }
               

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
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
        }
    }
}
