using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcesamientoP
{
    public partial class FormMovDet : Form
    {
        private FilterInfoCollection videoDevices;
        public VideoCaptureDevice videoSource=null;
        public bool webCamOn = false;
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml"); // clase que ayuda a detectar objetos en el video stream

        public FormMovDet()
        {
            InitializeComponent();
            if (pbCam.Image != null)
                turnOffCam();
            //Cargar dispositvos de video
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count > 0)
            {
                foreach (FilterInfo info in videoDevices)
                {
                    cbCamera.Items.Add(info.Name);
                }
            }
            else
            {
                MessageBox.Show("No se encontró ninguna WebCam.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormVideo().Show();
        }

        private void btnDet_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPowerOnn_Click(object sender, EventArgs e)
        {
            if (cbCamera.SelectedIndex < 0)
            {
                MessageBox.Show("No se seleccionó ninguna WebCam.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                btnPowerOnn.Visible = false;
                turnOnWebCam();
                btnPowerOfff.Visible = true;
            }
        }

        private void btnPowerOfff_Click(object sender, EventArgs e)
        {
            turnOffCam();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void turnOnWebCam()
        {
            // create video source
            videoSource = new VideoCaptureDevice(videoDevices[cbCamera.SelectedIndex].MonikerString);
            // set NewFrame event handler
            videoSource.NewFrame += new NewFrameEventHandler(Frame);
            // start the video source
            videoSource.Start();
            pbCam.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void Frame(object sender, NewFrameEventArgs eventArgs)
        {
            int person = 0;
            Color color;

            Bitmap bitm = (Bitmap)eventArgs.Frame.Clone(); //copiar la imagen  capturada en un bitmap
            Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitm);
            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 1); //por cada rectangulo es un rostro
            foreach (Rectangle rectangle in rectangles)
            {
                person++;

                switch (person)
                {
                    case 1: color = Color.Violet; break;
                    case 2: color = Color.Green; break;
                    case 3: color = Color.Azure; break;
                    default: color = Color.White; break;
                }

                using (Graphics graphics = Graphics.FromImage(bitm))
                {
                    using (Pen pen = new Pen(color, 1))
                    {
                        graphics.DrawRectangle(pen, rectangle);
                    }
                }
            }

            // get new frame. clonar el bitmap
            pbCam.Image = bitm;

            //La excepción se dispara debido a que estas creando un nuevo thread, y este no puede modificar el UI,
            //ya que el único que puede hacerlo es el UI Thread (el hilo principal en tu programa).
            this.Invoke(new Action(() => lbNoPer.Text = person.ToString()));
        
       
        }
        public void turnOffCam()
        {
            videoSource.SignalToStop();
            webCamOn = false;
            pbCam.Image = null;

            btnPowerOnn.Visible = true;
            btnPowerOfff.Visible = false;
        }

        private void pbCam_Click(object sender, EventArgs e)
        {

        }
    }
}
