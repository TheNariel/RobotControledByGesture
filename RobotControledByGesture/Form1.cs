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
using System.IO.Ports;

namespace RobotControledByGesture
{
    public partial class Form1 : Form
    {
        bool talk = false;
        Robot R;
        private FilterInfoCollection webcam;
        private VideoCaptureDevice cam;
        string[] ports;

        public Form1()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get a list of serial port names.
            ports = SerialPort.GetPortNames();
            foreach (string P in ports)
            {
                comPortCombo.Items.Add(P);
            }
            // Get a list of webcams.           
            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in webcam)
            {
                comboBox1.Items.Add(VideoCaptureDevice.Name);
            }
        }

        void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap grayImage = getWebcamPic(eventArgs);

            Blob[] blobs = getBlobs(grayImage);

            if (blobs.Length > 0)
            {
                Blob blob = blobs[0];
                List<IntPoint> hull = getHull(blob, grayImage);

                IntPoint middle = getMiddle(hull);

                handleHull(hull, middle);

                // lock image to draw on it
                BitmapData data = grayImage.LockBits(
                    new Rectangle(0, 0, grayImage.Width, grayImage.Height),
                        ImageLockMode.ReadWrite, grayImage.PixelFormat);

                Drawing.FillRectangle(data, new Rectangle(middle.X, middle.Y, 10, 10), Color.Red);
                Drawing.Polygon(data, hull, Color.Red);


                grayImage.UnlockBits(data);
            }
            pictureBox1.Image = grayImage;
        }

        private List<IntPoint> getHull(Blob blob, Bitmap grayImage)
        {
            GrahamConvexHull hullFinder = new GrahamConvexHull();
            List<IntPoint> leftPoints, rightPoints, edgePoints = new List<IntPoint>();
            BlobCounter blobCounter = getBlobCounter(grayImage);
            // get blob's edge points
            blobCounter.GetBlobsLeftAndRightEdges(blob,
                out leftPoints, out rightPoints);

            edgePoints.AddRange(leftPoints);
            edgePoints.AddRange(rightPoints);

            // blob's convex hull
            return hullFinder.FindHull(edgePoints);
        }

        private Blob[] getBlobs(Bitmap grayImage)
        {
            // process image with blob counter
            BlobCounter blobCounter = getBlobCounter(grayImage);
            return blobCounter.GetObjectsInformation();
        }

        private BlobCounter getBlobCounter(Bitmap grayImage)
        {
            // process image with blob counter
            BlobCounter blobCounter = new BlobCounter();
            blobCounter.ObjectsOrder = ObjectsOrder.Size;
            blobCounter.FilterBlobs = true;
            blobCounter.MinWidth = (int)blobWidthNumeric.Value; 
            blobCounter.MinHeight = (int)blobHeightNumeric.Value;

            blobCounter.ProcessImage(grayImage);
            return blobCounter;
        }

        private Bitmap getWebcamPic(NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

          //  Threshold filter = new Threshold((int)tresholdNumeric.Value);
         //   Grayscale GRfilter = new Grayscale(0.2125, 0.7154, 0.0721);
            EuclideanColorFiltering euclidFilter = new EuclideanColorFiltering(new RGB((byte)RNumeric.Value, (byte)GNumeric.Value, (byte)BNumeric.Value), (byte)radiusNumeric.Value);
            var Mir = new Mirror(false, true);

            Mir.ApplyInPlace(bitmap);

            Rectangle cloneRect = new Rectangle(0, 0, 320, 240);
            PixelFormat format =
                 bitmap.PixelFormat;
            Bitmap cloneBitmap = bitmap.Clone(cloneRect, format);

            euclidFilter.ApplyInPlace(cloneBitmap);
           // Bitmap grayImage = GRfilter.Apply(cloneBitmap);
         //   filter.ApplyInPlace(grayImage);

            return cloneBitmap;
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
                int distance = Math.Abs(Y.Last() - Y.First());
                int diff = diffXMax - diffXMin;
                if (distance > 150)
                {//Runn
                    if (diff > -20 && diff < 20)
                    {
                        if (talk) R.ForwardAsync((int)maxSpeedNumeric.Value);
                        updateInfoLabel("run");
                    }
                    else
                    {

                        if (diff > 0)
                        {
                            if (talk) R.LeftRunAsync((int)runTurnNumeric.Value);
                            updateInfoLabel("Run + Left");
                        }
                        else
                        {
                            if (talk) R.RightRunAsync((int)runTurnNumeric.Value);
                            updateInfoLabel("Run + Right");
                        }
                    }
                }
                else
                {//Stop
                    if (diff > -20 && diff < 20)
                    {
                        if (talk) R.StopMoving();
                        updateInfoLabel("Stop");
                    }
                    else
                    {

                        if (diff > 0)
                        {
                            if (talk) R.LeftAsync((int)turningSpeedNumeric.Value);
                            updateInfoLabel("Stop + Left");
                        }
                        else
                        {
                            if (talk) R.RightAsync((int)turningSpeedNumeric.Value);
                            updateInfoLabel("Stop + Right");
                        }
                    };
                }


            }
        }

        private void updateInfoLabel(string v)
        {
            if (this.infoLabel.InvokeRequired)
            {
                this.infoLabel.BeginInvoke((MethodInvoker)delegate () { this.infoLabel.Text = v; });
            }
            else
            {
                this.infoLabel.Text = v;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            cam = new VideoCaptureDevice(webcam[comboBox1.SelectedIndex].MonikerString);
            //Resolution Number 0 {Width=640, Height=480}
            cam.VideoResolution = cam.VideoCapabilities[0];
            cam.NewFrame += new NewFrameEventHandler(Cam_NewFrame);
            cam.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (cam.IsRunning)
            {
                cam.Stop();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            startButton.Visible = true;
            stopButton.Visible = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
            if (R != null)
            {
                R.AbortCommands();
            }
        }

        private void comPortCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            connectButton.Visible = true;
            robotCheckBox.Visible = true;
            testConectionBox.Visible = true;
            robotSettingsBox.Visible = true;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            R = new Robot();
            R.InitializeRobotAsync(ports[comPortCombo.SelectedIndex]);
        }

        private void robotCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            talk = robotCheckBox.Checked;
        }

        private void beepButton_Click(object sender, EventArgs e)
        {
            R.PlayToneAsync(50, 200, 10);
        }
    }
}
