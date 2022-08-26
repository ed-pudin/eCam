using AForge.Video;
using AForge.Video.DirectShow;
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

        private void btnDet_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMovDet().Show();
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //new FormImage().Show();
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
                FileVideoSource videoSource = new FileVideoSource(openFile.FileName);
                // set NewFrame event handler
                videoSource.NewFrame += new NewFrameEventHandler(Frame);
                // start the video source
                videoSource.Start();
            }

        }

        private void btnPlayVid_Click(object sender, EventArgs e)
        {
            btnPlayVid.Visible = false;
            btnStopVid.Visible = true;
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
        }

        private void pbVideo_Click(object sender, EventArgs e)
        {

        }

        private void Frame(object sender, NewFrameEventArgs eventArgs)
        {
            // get new frame. clonar el bitmap
            Bitmap bitmap = eventArgs.Frame;
            pbVideo.Image = bitmap;
            //pbVideo.Refresh();
            //pbVideo.SizeMode = PictureBoxSizeMode.StretchImage;

        }
    }
}
