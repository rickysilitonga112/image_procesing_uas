using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// libraries
using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;

// video libraries
using AForge.Video;
using AForge.Video.DirectShow;
using System.Collections;


namespace uasCitra_MKB
{
    public partial class Form1 : Form
    {
        Bitmap sourceImage;
        // filters
        Bitmap RGBImage, HSLImage, YCbCrImage;

        // track
        Bitmap track;

        //Space antara min Trackbar dan max Trackbar
        int TRACK_SPACE = 2;

        //HSL trackbar variable
        int Hmin, Hmax;
        float Smin, Smax, Lmin, Lmax;

        //RGB trackbar variable
        int Rmin, Rmax, Gmin, Gmax, Bmin, Bmax;

        //YCbCr trackbar variable
        float Ymin, Ymax, Cbmin, Cbmax, Crmin, Crmax;

        // pilihan channel
        int pilChannel = 1;

        // video global variables
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoDevice;
        private ArrayList listCamera = new ArrayList();
        Bitmap detectedImage = null;


        bool cameraUsed = false;


        public Form1()
        {
            InitializeComponent();
            trackBarInit(pilChannel);
            trackBarReset(pilChannel);
            trackBarEnable(false);
            labelReset();

            // picture box border
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
        }





        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void RGBFiltering()
        {
            if (sourceImage == null) return;
            // create filter
            ColorFiltering filter = new ColorFiltering();
            // set color ranges to keep
            filter.Red = new IntRange(Rmin, Rmax);
            filter.Green = new IntRange(Gmin, Gmax);
            filter.Blue = new IntRange(Bmin, Bmax);
            // apply the filter
            RGBImage = filter.Apply(sourceImage);
            pictureBox3.Image = RGBImage;
        }

        private void trackBarMin1_Scroll(object sender, EventArgs e)
        {
            if (trackBarMax1.Value - trackBarMin1.Value <= TRACK_SPACE) 
            { 
                trackBarMin1.Value = trackBarMax1.Value - TRACK_SPACE;
            }

            if(pilChannel == 1)
            {
                Rmin = trackBarMin1.Value;
                labelMin1.Text = string.Format("RMin : {0}", Rmin);
                RGBFiltering(sourceImage);
            }
            else if(pilChannel == 2)
            {
                Hmin = trackBarMin1.Value;
                labelMin1.Text = string.Format("HueMin : {0}", Hmin);
                HSLFiltering(sourceImage);
            }
            else if(pilChannel == 3)
            {
                Ymin = (float)trackBarMin1.Value / 100;
                labelMin1.Text = string.Format("Ymin : {0}", Ymin);
                YCbCrFiltering(sourceImage);
            }
            trackObject();

        }

        private void trackBarMax1_Scroll(object sender, EventArgs e)
        {
            if(trackBarMax1.Value - trackBarMin1.Value <= TRACK_SPACE)
            {
                trackBarMax1.Value = trackBarMin1.Value + TRACK_SPACE;
            }

            if(pilChannel == 1)
            {
                Rmax = trackBarMax1.Value;
                labelMax1.Text = string.Format("RMax : {0}", Rmax);
                RGBFiltering(sourceImage);
            } 
            else if(pilChannel == 2)
            {
                Hmax = trackBarMax1.Value;
                labelMax1.Text = string.Format("HueMax : {0}", Hmax);
                HSLFiltering(sourceImage);
            }
            else if(pilChannel == 3)
            {
                Ymax = (float)trackBarMax1.Value / 100;
                labelMax2.Text = string.Format("Ymax : {0}", Ymax);
                YCbCrFiltering(sourceImage);
            }
            trackObject();


        }

        private void trackBarMin2_Scroll(object sender, EventArgs e)
        {
            if (trackBarMax2.Value - trackBarMin2.Value <= TRACK_SPACE)
            {
                trackBarMin2.Value = trackBarMax2.Value - TRACK_SPACE;
            }
            if(pilChannel == 1)
            {
                Gmin = trackBarMin2.Value;
                labelMin2.Text = string.Format("GMin : {0}", Gmin);
                RGBFiltering(sourceImage);
            }
            else if(pilChannel == 2)
            {
                Smin = (float)trackBarMin2.Value / 100; ;
                labelMin2.Text = string.Format("SMin : {0}", Smin);
                HSLFiltering(sourceImage);
            }
            else if(pilChannel == 3)
            {
                Cbmin = (float)trackBarMin2.Value / 100;
                labelMin2.Text = string.Format("Cbmin : {0}", Cbmin);
                YCbCrFiltering(sourceImage);
            }
            trackObject();
        }


        private void trackBarMax2_Scroll(object sender, EventArgs e)
        {
            if (trackBarMax2.Value - trackBarMin2.Value <= TRACK_SPACE)
            {
                trackBarMax2.Value = trackBarMin2.Value + TRACK_SPACE;
            }
            if(pilChannel == 1)
            {
                Gmax = trackBarMax2.Value;
                labelMax2.Text = string.Format("GMax : {0}", Gmax);
                RGBFiltering(sourceImage);
            }
            else if(pilChannel == 2)
            {
                Smax = (float)trackBarMax2.Value / 100;
                labelMax2.Text = string.Format("SMax : {0}", Smax);
                HSLFiltering(sourceImage);
            }
            else if (pilChannel == 3)
            {
                Cbmax = (float)trackBarMax2.Value / 100;
                labelMax2.Text = string.Format("Cbmax : {0}", Cbmax);
                YCbCrFiltering(sourceImage);
            }
            trackObject();
        }

        private void trackBarMin3_Scroll(object sender, EventArgs e)
        {
            if (trackBarMax3.Value - trackBarMin3.Value <= TRACK_SPACE)
            {
                trackBarMin3.Value = trackBarMax3.Value - TRACK_SPACE;
            }
            if(pilChannel == 1)
            {
                Bmin = trackBarMin3.Value;
                labelMin3.Text = string.Format("BMin : {0}", Bmin);
                RGBFiltering(sourceImage);
            }
            else if(pilChannel == 2)
            {
                Lmin = (float)trackBarMin3.Value / 100;
                labelMin3.Text = string.Format("LMin : {0}", Lmin);
                HSLFiltering(sourceImage);
            }
            else if(pilChannel == 3)
            {
                Crmin = (float)trackBarMin3.Value / 100;
                labelMin3.Text = string.Format("Crmin : {0}", Crmin);
                YCbCrFiltering(sourceImage);
            }
            trackObject();
        }

        private void trackBarMax3_Scroll(object sender, EventArgs e)
        {
            if (trackBarMax3.Value - trackBarMin3.Value <= TRACK_SPACE)
            {
                trackBarMax3.Value = trackBarMin3.Value + TRACK_SPACE;
            }
            if(pilChannel == 1)
            {
                Bmax = trackBarMax3.Value;
                labelMax3.Text = string.Format("BMax : {0}", Bmax);
                RGBFiltering(sourceImage);
            }
            else if(pilChannel == 2)
            {
                Lmax = (float)trackBarMax3.Value / 100;
                labelMax3.Text = string.Format("LMax : {0}", Lmax);
                HSLFiltering(sourceImage);
            }
            else if(pilChannel == 3)
            {
                Crmax = (float)trackBarMax3.Value / 100;
                labelMax3.Text = string.Format("Crmax : {0}", Crmax);
                YCbCrFiltering(sourceImage);
            }
            trackObject();
        }

        // pilihan channel filter
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pilChannel = 1;
            trackBarInit(pilChannel);
            trackBarReset(pilChannel);
            labelReset(pilChannel);
            trackBarEnable(true);
            groupBox5.Text = "RGB Image Control Function";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pilChannel = 2;
            trackBarInit(pilChannel);
            trackBarReset(pilChannel);
            labelReset(pilChannel);
            trackBarEnable(true);
            groupBox5.Text = "HSL Image Control Function";

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pilChannel = 3;
            trackBarInit(pilChannel);
            trackBarReset(pilChannel);
            labelReset(pilChannel);
            trackBarEnable(true);
            groupBox5.Text = "YCbCR Image Control Function";

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        //////////////////////////
        ///     MY FUNCTION    ///
        //////////////////////////

        // INIT FUNCTION
        private void trackBarInit(int channel)
        {
            if(channel == 1)
            {
                trackBarMin1.Maximum = 255;
                trackBarMin2.Maximum = 255;
                trackBarMin3.Maximum = 255;
                trackBarMax1.Maximum = 255;
                trackBarMax2.Maximum = 255;
                trackBarMax3.Maximum = 255;
            }
            else if(channel == 2)
            {
                trackBarMin1.Maximum = 360;
                trackBarMin2.Maximum = 100;
                trackBarMin3.Maximum = 100;
                trackBarMax1.Maximum = 360;
                trackBarMax2.Maximum = 100;
                trackBarMax3.Maximum = 100;
            }
            else if(channel == 3)
            {

                trackBarMin1.Maximum = 100;
                trackBarMin2.Minimum = -50;
                trackBarMin2.Maximum = 50;
                trackBarMin3.Minimum = -50;
                trackBarMin3.Maximum = 50;
                trackBarMax1.Maximum = 100;
                trackBarMax2.Minimum = -50;
                trackBarMax2.Maximum = 50;
                trackBarMax3.Minimum = -50;
                trackBarMax3.Maximum = 50;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenCamera();
            cameraUsed = true;
        }

        private void trackBarReset(int filterChannel)
        {
            if(filterChannel == 1)
            {
                // -------- RGB ---------
                // RGB channel value
                trackBarMin1.Value = 0;
                trackBarMin2.Value = 0;
                trackBarMin3.Value = 0;
                trackBarMax1.Value = 255;
                trackBarMax2.Value = 255;
                trackBarMax3.Value = 255;

                // RGB value reset
                Rmin = 0; Rmax = 255;
                Gmin = 0; Gmax = 255;
                Bmin = 0; Bmax = 255;
            }
            else if (filterChannel == 2)
            {
                // -------- HSL ---------
                // HSL Channel Value
                trackBarMin1.Value = 0;
                trackBarMin2.Value = 0;
                trackBarMin3.Value = 0;
                trackBarMax1.Value = 360;
                trackBarMax2.Value = 100;
                trackBarMax3.Value = 100;

                // HSL channel value
                Hmin = trackBarMin1.Value;
                Hmax = trackBarMax1.Value;
                Smin = (float)trackBarMin2.Value / 100;
                Smax = (float)trackBarMax2.Value / 100;
                Lmin = (float)trackBarMin3.Value / 100;
                Lmax = (float)trackBarMax3.Value / 100;
            }
            else if(filterChannel == 3)
            {
                // -------- YCbCr ---------
                // YCbCr channel value
                trackBarMin1.Value = 0;
                trackBarMin2.Value = -50;
                trackBarMin3.Value = -50;
                trackBarMax1.Value = 100;
                trackBarMax2.Value = 50;
                trackBarMax3.Value = 50;

                // YCbCr value reset
                Ymin = (float)trackBarMin1.Value / 100;
                Ymax = (float)trackBarMax1.Value / 100;
                Cbmin = (float)trackBarMin2.Value / 100;
                Cbmax = (float)trackBarMax2.Value / 100;
                Crmin = (float)trackBarMin3.Value / 100;
                Crmax = (float)trackBarMax3.Value / 100;
            }
        }

        private void trackBarEnable(bool isEnable = true)
        {
            trackBarMin1.Enabled = isEnable;
            trackBarMin2.Enabled = isEnable;
            trackBarMin3.Enabled = isEnable;
            trackBarMax1.Enabled = isEnable;
            trackBarMax2.Enabled = isEnable;
            trackBarMax3.Enabled = isEnable;
        }

        private void labelReset(int filterChannel)
        {
            if(filterChannel == 1)
            {
                labelMin1.Text = string.Format("RMin : {0}", trackBarMin1.Value);
                labelMin2.Text = string.Format("GMin : {0}", trackBarMin2.Value);
                labelMin3.Text = string.Format("BMin : {0}", trackBarMin3.Value);
                labelMax1.Text = string.Format("RMax : {0}", trackBarMax1.Value);
                labelMax2.Text = string.Format("GMax : {0}", trackBarMax2.Value);
                labelMax3.Text = string.Format("BMax : {0}", trackBarMax3.Value);
            }
            else if(filterChannel == 2)
            {
                labelMin1.Text = string.Format("HueMin : {0}", trackBarMin1.Value);
                labelMin2.Text = string.Format("SMin : {0}", (float)trackBarMin2.Value / 100);
                labelMin3.Text = string.Format("LMin : {0}", (float)trackBarMin3.Value / 100);
                labelMax1.Text = string.Format("HueMax : {0}", trackBarMax1.Value);
                labelMax2.Text = string.Format("SMax : {0}", (float)trackBarMax2.Value / 100);
                labelMax3.Text = string.Format("LMax : {0}", (float)trackBarMax3.Value / 100);
            }
            else if(filterChannel == 3)
            {
                labelMax1.Text = string.Format("Ymax : {0}", (float)trackBarMax1.Value / 100);
                labelMin1.Text = string.Format("Ymin : {0}", (float)trackBarMin1.Value / 100);
                labelMax2.Text = string.Format("Cbmax : {0}", (float)trackBarMax2.Value / 100);
                labelMin2.Text = string.Format("Cbmin : {0}", (float)trackBarMin2.Value / 100);
                labelMax3.Text = string.Format("Crmax : {0}", (float)trackBarMax3.Value / 100);
                labelMin3.Text = string.Format("Crmin : {0}", (float)trackBarMin3.Value / 100);
            }

        }

        private void videoSourcePlayer1_NewFrame(object sender, ref Bitmap image)
        {
            try
            {
                Bitmap histogramImage = image.Clone() as Bitmap;

                sourceImage = image.Clone() as Bitmap;
                
                if (pilChannel == 1)
                {
                    //detect the image
                    RGBFiltering(image.Clone() as Bitmap);
                    //traking the image
                    objectTracking(image.Clone() as Bitmap, RGBImage);
                }
                else if(pilChannel == 2)
                {
                    HSLFiltering(image.Clone() as Bitmap);
                    //traking the image
                    objectTracking(image.Clone() as Bitmap, HSLImage);
                }
                else if(pilChannel == 3)
                {
                    YCbCrFiltering(image.Clone() as Bitmap);
                    //traking the image
                    objectTracking(image.Clone() as Bitmap, YCbCrImage);
                }

                hitungHistogram(histogramImage);

            }
            catch
            {
            }
        }

        private void objectTracking(Bitmap srcImage, Bitmap filterImage)
        {
            detectedImage = filterImage;

            if (srcImage == null || detectedImage == null) return;
            //copy detected image to the new one
            Bitmap newImage = (Bitmap)detectedImage.Clone();
            //blob counter on the detected image
            BlobCounter bc = new BlobCounter();
            bc.MinHeight = 20;
            bc.MinWidth = 20;
            bc.FilterBlobs = true;
            bc.ObjectsOrder = ObjectsOrder.Area;
            bc.ProcessImage(newImage);
            Rectangle[] rects = bc.GetObjectsRectangles();
            foreach (Rectangle recs in rects)
            {
                if (rects.Length > 0)
                {
                    Rectangle objectRect = rects[0];
                    Graphics graph = Graphics.FromImage(srcImage);
                    using (Pen pen = new Pen(Color.FromArgb(255, 0, 0), 10))
                    {
                        graph.DrawRectangle(pen, objectRect);
                    }
                    graph.Dispose();
                }
            }
            //draw tracked object on picture box
            pictureBox2.Image = srcImage;
        }

        // open camera
        private void OpenCamera()
        {
            try
            {
                usbcamera = comboBox1.SelectedIndex.ToString();
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count != 0)
                {
                    // add all devices to combo
                    foreach (FilterInfo device in videoDevices)
                    {
                        listCamera.Add(device.Name);
                    }
                }
                else
                {
                    MessageBox.Show("Camera devices found");
                }

                videoDevice = new VideoCaptureDevice(videoDevices[Convert.ToInt32(usbcamera)].MonikerString);
                OpenVideoSource(videoDevice);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count != 0)
            {
                // add all devices to combo
                foreach (FilterInfo device in videoDevices)
                {
                    comboBox1.Items.Add(device.Name);
                }
            }
            else
            {
                comboBox1.Items.Add("No DirectShow devices found");
            }
            comboBox1.SelectedIndex = 0;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (videoDevice != null && videoDevice.IsRunning)
                videoDevice.Stop(); 
        }

        private void videoSourcePlayer1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        // ---- RGB FILTER -----
        private void RGBFiltering(Bitmap srcImage)
        {
            // create filter
            ColorFiltering filter = new ColorFiltering();
            // set color ranges to keep
            filter.Red = new IntRange(Rmin, Rmax);
            filter.Green = new IntRange(Gmin, Gmax);
            filter.Blue = new IntRange(Bmin, Bmax);
            // apply the filter
            RGBImage = filter.Apply(srcImage);
            pictureBox3.Image = RGBImage;
            pictureBox1.Image = RGBImage;
        }

        // ---- HSL FILTER ----
        private void HSLFiltering(Bitmap srcImage)
        {
            // create filter
            HSLFiltering filter = new HSLFiltering();
            filter.Hue = new IntRange(Hmin, Hmax);
            filter.Saturation = new Range(Smin, Smax);
            filter.Luminance = new Range(Lmin, Lmax);
            // apply the filter
            HSLImage = filter.Apply(srcImage);
            pictureBox1.Image = HSLImage;
            pictureBox3.Image = HSLImage;
        }

        // ---- YCbCr FILTER ----
        private void YCbCrFiltering(Bitmap srcImage)
        {
            // create filter
            YCbCrFiltering filter = new YCbCrFiltering();
            // set color ranges to keep
            filter.Y = new Range(Ymin, Ymax);
            filter.Cb = new Range(Cbmin, Cbmax);
            filter.Cr = new Range(Crmin, Crmax);
            YCbCrImage = filter.Apply(srcImage);
            //draw the picture
            pictureBox1.Image = YCbCrImage;
            pictureBox3.Image = YCbCrImage;
        }

        // ---- CLOSE BUTTON ----
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ---- RESET BUTTON ----
        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = sourceImage;
            pictureBox2.Image = sourceImage;

            trackBarEnable(false);

            // init
            trackBarMax1.Maximum = 255;
            trackBarMax2.Maximum = 255;
            trackBarMax3.Maximum = 255;
            trackBarMin1.Minimum = 0;
            trackBarMin2.Minimum = 0;
            trackBarMin3.Minimum = 0;

            // trackbar reset
            trackBarMin1.Value = 0;
            trackBarMin2.Value = 0;
            trackBarMin3.Value = 0;
            trackBarMax1.Value = 255;
            trackBarMax2.Value = 255;
            trackBarMax3.Value = 255;



            // reset radio
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            // reset label
            labelReset();

            groupBox5.Text = "Image Control Trackbar";
        }

        private void labelReset()
        {
            labelMin1.Text = "";
            labelMin2.Text = "";
            labelMin3.Text = "";
            labelMax1.Text = "";
            labelMax2.Text = "";
            labelMax3.Text = "";
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


        // ---- HISTOGRAM ----
        private void hitungHistogram(Bitmap histogramImage)
        {
            if (histogramImage == null) return;



            ImageStatistics stat = new ImageStatistics(histogramImage);

            int[] redStat = stat.Red.Values;
            int[] greenStat = stat.Blue.Values;
            int[] blueStat = stat.Blue.Values;
            int[] gab = gabungHistogram(redStat, greenStat, blueStat);
            histogram1.Color = Color.Navy;
            histogram1.Values = gab;

        }

        int[] gabungHistogram(int[] r, int[] g, int[] b)
        {
            int[] c = new int[256 * 3];
            for (int i = 0; i < 256; i++)
                c[i] = r[i];
            for (int i = 256; i < 512; i++)
                c[i] = g[i - 256];
            for (int i = 512; i < 768; i++)
                c[i] = b[i - 512];
            return c;
        }

        // ---- TRACK OBJECT ----
        private void trackObject()
        {
            if (!cameraUsed)
            {
                if (pilChannel == 1)
                {
                    if (RGBImage == null) return;
                    track = RGBImage;
                }
                else if (pilChannel == 2)
                {
                    if (HSLImage == null) return;
                    track = HSLImage;
                }
                else if (pilChannel == 3)
                {
                    if (YCbCrImage == null) return;
                    track = YCbCrImage;
                }

                Bitmap tempImage = new Bitmap(sourceImage);
                pictureBox2.Image = tempImage;
                BlobCounter bc = new BlobCounter();
                bc.MinHeight = 5;
                bc.MinWidth = 5;
                bc.FilterBlobs = true;
                bc.ObjectsOrder = ObjectsOrder.Area;
                bc.ProcessImage(track);
                Rectangle[] rects = bc.GetObjectsRectangles();
                foreach (Rectangle recs in rects)
                    if (rects.Length > 0)
                    {
                        Rectangle objectRect = rects[0]; //= recs;
                        Graphics graph = Graphics.FromImage(tempImage);
                        using (Pen pen = new Pen(Color.FromArgb(255, 0, 0), 2))
                        {
                            graph.DrawRectangle(pen, objectRect);
                        }
                        graph.Dispose();
                    }
            }

        }

        // ---- video source player ----
        // usb camera definition
        private static string _usbcamera;
        public string usbcamera
        {
            get { return _usbcamera; }
            set { _usbcamera = value; }
        }
        // opening the video source
        private void OpenVideoSource(IVideoSource source)
        {
            try
            {
                // set busy cursor
                this.Cursor = Cursors.WaitCursor;
                // stop current video source
                CloseCurrentVideoSource();
                // start new video source
                videoSourcePlayer1.VideoSource = source;
                videoSourcePlayer1.Start();
                this.Cursor = Cursors.Default;
            }
            catch { }
        }

        // closing the video source
        public void CloseCurrentVideoSource()
        {
            try
            {
                if (videoSourcePlayer1.VideoSource != null)
                {
                    videoSourcePlayer1.SignalToStop();
                    // wait ~ 3 seconds
                    for (int i = 0; i < 30; i++)
                    {
                        if (!videoSourcePlayer1.IsRunning)
                            break;
                        System.Threading.Thread.Sleep(100);
                    }
                    if (videoSourcePlayer1.IsRunning)
                    {
                        videoSourcePlayer1.Stop();
                    }
                    videoSourcePlayer1.VideoSource = null;
                }
            }
            catch { }
        }

        // open file button
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sourceImage = (Bitmap)Bitmap.FromFile(openFileDialog1.FileName);
                pictureBox3.Image = sourceImage;
                pictureBox1.Image = sourceImage;
                pictureBox2.Image = sourceImage;

                pictureBox3.BorderStyle = BorderStyle.FixedSingle;


                // ---- HISTOGRAM ----
                hitungHistogram(sourceImage);
            }
        }
    }
}
