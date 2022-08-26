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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            FormImage fI = new FormImage();
            fI.TopLevel = false;
            fI.AutoScroll = true;
            panelswitch.Controls.Add(fI);

            foreach (Control control in panelswitch.Controls)
            {

                if (control != fI) { control.Hide(); }
                else { control.Show(); }

            }
            btnFoto.BackColor = ColorTranslator.FromHtml("#04395E");
            
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            FormVideo fV = new FormVideo();
            fV.TopLevel = false;
            fV.AutoScroll = true;
            panelswitch.Controls.Add(fV);

            foreach (Control control in panelswitch.Controls)
            {

                if (control != fV) { control.Hide(); }
                else { control.Show(); }

            }
            btnVideo.BackColor = ColorTranslator.FromHtml("#04395E");
            btnFoto.BackColor = ColorTranslator.FromHtml("#031D44");
            btnDet.BackColor = ColorTranslator.FromHtml("#031D44");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDet_Click(object sender, EventArgs e)
        {

            FormMovDet fMD = new FormMovDet();
            fMD.TopLevel = false;
            fMD.AutoScroll = true;
            panelswitch.Controls.Add(fMD);

            foreach (Control control in panelswitch.Controls)
            {

                if (control != fMD) { control.Hide(); }
                else { control.Show(); }

            }
            btnDet.BackColor = ColorTranslator.FromHtml("#04395E");
            btnVideo.BackColor = ColorTranslator.FromHtml("#031D44");
            btnFoto.BackColor = ColorTranslator.FromHtml("#031D44");

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            FormImage fI = new FormImage();
            fI.TopLevel = false;
            fI.AutoScroll = true;
            panelswitch.Controls.Add(fI);

            foreach (Control control in panelswitch.Controls)
            {

                if (control != fI) { control.Hide(); }
                else { control.Show(); }

            }

            btnFoto.BackColor = ColorTranslator.FromHtml("#04395E");
            btnDet.BackColor = ColorTranslator.FromHtml("#031D44");
            btnVideo.BackColor = ColorTranslator.FromHtml("#031D44");

        }
    }
}
