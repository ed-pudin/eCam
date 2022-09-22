using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesamientoP
{
    public class Filters
    {
        public Bitmap mirror(Bitmap bmp)
        {
            Bitmap image = new Bitmap(bmp.Width, bmp.Height);

            for (Int32 y = 0; y < image.Height; y++)
            {
                int width = image.Width - 1;

                for (Int32 x = 0; x < (int)image.Width / 2; x++)
                {
                    Color px = bmp.GetPixel(x, y);
                    image.SetPixel(x, y, px);
                    image.SetPixel(width, y, px);
                    width--;
                }

            }

            return image;
        }
        public Bitmap sepia(Bitmap bmp)
        {
            Bitmap image = new Bitmap(bmp.Width, bmp.Height);

            for (Int32 y = 0; y < image.Height; y++)
                for (Int32 x = 0; x < image.Width; x++)
                {
                    Color pixelColor = bmp.GetPixel(x, y);

                    //extract pixel component ARGB
                    int a = pixelColor.A;
                    int r = pixelColor.R;
                    int g = pixelColor.G;
                    int b = pixelColor.B;

                    //calculate temp value
                    int newRed = (int)(0.393 * r + 0.769 * g + 0.189 * b);
                    int newGreen = (int)(0.349 * r + 0.686 * g + 0.168 * b);
                    int newBlue = (int)(0.272 * r + 0.534 * g + 0.131 * b);

                    //set new RGB value
                    if (newRed > 255)
                    {
                        r = 255;
                    }
                    else
                    {
                        r = newRed;
                    }

                    if (newGreen > 255)
                    {
                        g = 255;
                    }
                    else
                    {
                        g = newGreen;
                    }

                    if (newBlue > 255)
                    {
                        b = 255;
                    }
                    else
                    {
                        b = newBlue;
                    }

                    //set the new RGB value in image pixel
                    image.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }

            return image;
        }
        public Bitmap blackndwhite(Bitmap bmp)
        {
            Bitmap image = new Bitmap(bmp.Width, bmp.Height);

            for (Int32 y = 0; y < image.Height; y++)
                for (Int32 x = 0; x < image.Width; x++)
                {
                    Color pixelColor = bmp.GetPixel(x, y);

                    Int32 gs = (Int32)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);

                    image.SetPixel(x, y, Color.FromArgb(gs, gs, gs));
                }
            return image;
        }
        public Bitmap negative(Bitmap bmp)
        {
            Bitmap image = new Bitmap(bmp.Width, bmp.Height);
            for (Int32 y = 0; y < image.Height; y++)
                for (Int32 x = 0; x < image.Width; x++)
                {
                    Color pixelColor = bmp.GetPixel(x, y);
                    pixelColor = Color.FromArgb(255, (255 - pixelColor.R), (255 - pixelColor.G), (255 - pixelColor.B));
                    image.SetPixel(x, y, pixelColor);
                }


            return image;
        }

        public Bitmap blue(Bitmap bmp)
        {
            Bitmap image = new Bitmap(bmp.Width, bmp.Height);
            for (Int32 y = 0; y < image.Height; y++)
                for (Int32 x = 0; x < image.Width; x++)
                {
                    Color pixelColor = bmp.GetPixel(x, y);
                    pixelColor = Color.FromArgb(pixelColor.A, 0, 0, pixelColor.B);
                    image.SetPixel(x, y, pixelColor);
                }


            return image;
        }

    }
}
