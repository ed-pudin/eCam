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
using AForge.Video;
using AForge.Video.DirectShow;

namespace ProcesamientoP
{
    public partial class FormImage : Form
    {
        private FilterInfoCollection videoDevices;
        public VideoCaptureDevice videoSource=null;
        public bool webCamOn = false;
        public FormImage()
        {

            InitializeComponent();
           
            //Cargar dispositvos de video
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if(videoDevices.Count > 0)
            {
                foreach(FilterInfo info in videoDevices)
                {
                    cbCamera.Items.Add(info.Name);
                }
            }
            else
            {
                MessageBox.Show("No se encontró ninguna WebCam.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void btnPowerOn_Click(object sender, EventArgs e)
        {
            if(cbCamera.SelectedIndex < 0)
            {
                MessageBox.Show("No se seleccionó ninguna WebCam.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                btnPowerOn.Visible = false;

                //Metodo para encender la camara
                turnOnWebCam();

                btnPowerOff.Visible = true;
            }

        }

        private void btnPowerOff_Click(object sender, EventArgs e)
        {
            turnOffCam();
        }

        private void btnAddImg_Click(object sender, EventArgs e)
        {
            if (webCamOn)
            {
                turnOffCam();
            }
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Selecciona una imagen";
            file.Filter = "Image Files (*.jpg; *.jpeg; *.bmp; *.png)|*.jpg|All files (*.*)|*.*";

            if (file.ShowDialog() == DialogResult.OK)
            {
               
                pbImage.Image = new Bitmap(file.FileName);
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

                pbImageTaken.Image = new Bitmap(file.FileName);
                pbImageTaken.SizeMode = PictureBoxSizeMode.StretchImage;
            }


        }

        private void btnAddImg_MouseDown(object sender, MouseEventArgs e)
        {
            BackgroundImage = System.Drawing.Image.FromFile("Resources\\iconGalleryPressed.png");
            btnAddImg.BackgroundImage = BackgroundImage;
        }

        private void btnAddImg_MouseUp(object sender, MouseEventArgs e)
        {
            BackgroundImage = System.Drawing.Image.FromFile("Resources\\iconGallery.png");
            btnAddImg.BackgroundImage = BackgroundImage;
        }

        private void btnTakeP_Click(object sender, EventArgs e)
        {
            if(!webCamOn)
            {
                MessageBox.Show("La WebCam se encuentra apagada, por favor enciéndela.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pbImageTaken.Image = (Image)pbImage.Image.Clone();
                pbImageTaken.SizeMode = PictureBoxSizeMode.StretchImage;
            }
           
        }

        private void btnTakeP_MouseDown(object sender, MouseEventArgs e)
        {
            BackgroundImage = System.Drawing.Image.FromFile("Resources\\takePhotoPressed.png");
            btnTakeP.BackgroundImage = BackgroundImage;
        }

        private void btnTakeP_MouseUp(object sender, MouseEventArgs e)
        {
            BackgroundImage = System.Drawing.Image.FromFile("Resources\\takePhoto.png");
            btnTakeP.BackgroundImage = BackgroundImage;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (pbImageTaken.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
                saveFileDialog.Title = "Guardar imagen como";
                saveFileDialog.Filter = "Image Files (*.jpg)|*.jpg";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbImageTaken.Image.Save(saveFileDialog.FileName);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al guardar la imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se ha detectado algún archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_MouseDown(object sender, MouseEventArgs e)
        {
            BackgroundImage = System.Drawing.Image.FromFile("Resources\\savePressed.png");
            btnSave.BackgroundImage = BackgroundImage;

        }

        private void btnSave_MouseUp(object sender, MouseEventArgs e)
        {
            BackgroundImage = System.Drawing.Image.FromFile("Resources\\save.png");
            btnSave.BackgroundImage = BackgroundImage;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
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
            webCamOn = true;
        }

        private void Frame(object sender, NewFrameEventArgs eventArgs)
        {
            // get new frame. clonar el bitmap
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pbImage.Image = bitmap;
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
           
        }
        public void turnOffCam()
        {
            videoSource.SignalToStop();

            webCamOn = false;
            pbImage.Image = null;

            btnPowerOn.Visible = true;
            btnPowerOff.Visible = false;
        }
    }
}
