using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcesamientoP
{
    public partial class FormVideo : Form
    {
        VideoCapture videoC;
        bool isPlaying = false;
        int TotalFrames;
        int CurrentFramesNo;
        Mat CurrentFrame; //frame q se muestra en el picture box
        int FPS;

        public FormVideo()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddImg_Click(object sender, EventArgs e)
        {

        }

        private void btnTakeP_Click(object sender, EventArgs e)
        {

        }

        private void btnPowerOn_Click(object sender, EventArgs e)
        {
            btnPowerOn.Visible = false;
            btnPowerOff.Visible = true;
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddVid_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            openFile.Title = "Selecciona un video";
            openFile.Filter = "All Media Files (*.mp4)|*.mp4|All files (*.*)|*.*";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                videoC = new VideoCapture(openFile.FileName);
                TotalFrames = Convert.ToInt32(videoC.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameCount));
                FPS = Convert.ToInt32(videoC.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps));
                CurrentFrame = new Mat();
                CurrentFramesNo = 0;

                videoC.Read(CurrentFrame);

                pbVideo.Image = CurrentFrame.Bitmap;
                pbVideo.SizeMode = PictureBoxSizeMode.StretchImage;

            }

        }

        private void btnPlayVid_Click(object sender, EventArgs e)
        {
            if (videoC == null)
            {
                MessageBox.Show("No se ha detectado algún archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            btnPlayVid.Visible = false;
            btnStopVid.Visible = true;
            isPlaying = true;

            PlayVideo();
        }

        private void btnPowerOff_Click(object sender, EventArgs e)
        {
            btnPowerOff.Visible = false;
            btnPowerOn.Visible = true;
        }

        private void btnAddVid_MouseDown(object sender, MouseEventArgs e)
        {
            BackgroundImage = System.Drawing.Image.FromFile("Resources\\iconVideoPressed.png");
            btnAddVid.BackgroundImage = BackgroundImage;
        }

        private void btnAddVid_MouseUp(object sender, MouseEventArgs e)
        {
            BackgroundImage = System.Drawing.Image.FromFile("Resources\\iconVideo.png");
            btnAddVid.BackgroundImage = BackgroundImage;
        }

        private void btnStopVid_Click(object sender, EventArgs e)
        {
            btnPlayVid.Visible = true;
            btnStopVid.Visible = false;
            isPlaying = false;
        }

        private void pbVideo_Click(object sender, EventArgs e)
        {

        }

        private async void PlayVideo()
        {
           if(videoC == null)
           {
               MessageBox.Show("No se ha detectado algún archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

           }

           try
           {
                while (isPlaying == true && CurrentFramesNo<TotalFrames)
                {
                    //se toma la posicion del frame donde estamos y se setea
                    videoC.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, CurrentFramesNo);
                    videoC.Read(CurrentFrame);
                    pbVideo.Image = CurrentFrame.Bitmap;
                    pbVideo.SizeMode = PictureBoxSizeMode.StretchImage;
                    CurrentFramesNo+=1;
                    await Task.Delay(500 / FPS);
                }
            }
            catch(Exception e)
           {
               MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }


        }
    }
}
