using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photo_Cropper
{
    public partial class Form1 : Form
    {

        private Point RectStartPoint;
        private Rectangle Rect = new Rectangle();
        private Brush selectionBrush = new SolidBrush(Color.FromArgb(128, 72, 145, 220));

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            image1.Hide();
            TargetImg.Hide();
            btnSaveImage.Hide();
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                string imageLocation = "";
                var dialog = new OpenFileDialog();
                dialog.Filter = "Image files(*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    image1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }
            btnUploadPhoto.Hide();
            image1.Show();
        }

        private void image1_MouseDown(object sender, MouseEventArgs e)
        {
            RectStartPoint = e.Location;
            Invalidate();
        }

        private void image1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Point tempEndPoint = e.Location;
            Rect.Location = new Point(
                Math.Min(RectStartPoint.X, tempEndPoint.X),
                Math.Min(RectStartPoint.Y, tempEndPoint.Y));
            Rect.Size = new Size(
                Math.Abs(RectStartPoint.X - tempEndPoint.X),
                Math.Abs(RectStartPoint.Y - tempEndPoint.Y));
            image1.Invalidate();
        }

        private void image1_Paint(object sender, PaintEventArgs e)
        {
            if (image1.Image != null)
            {
                if (Rect != null && Rect.Width > 0 && Rect.Height > 0)
                {
                    e.Graphics.DrawRectangle(Pens.Red, Rect);
                }
            }
        }

        private void image1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (Rect.Contains(e.Location))
                {
                    Debug.WriteLine("Right Click");
                }
            }

            if (Rect != null)
            {
                try
                {
                    Bitmap bit = new Bitmap(image1.Image, image1.Width, image1.Height);
                    Bitmap cropImg = new Bitmap(Rect.Width, Rect.Height);
                    Graphics g = Graphics.FromImage(cropImg);
                    g.DrawImage(bit, 0, 0, Rect, GraphicsUnit.Pixel);
                    TargetImg.Image = cropImg;
                    image1.Hide();
                }

                catch(Exception)
                {

                }

                TargetImg.Show();
                btnSaveImage.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(TargetImg != null)
            {
                SaveFileDialog saveImg = new SaveFileDialog();
                saveImg.Filter = "Image files(*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

                if(saveImg.ShowDialog() == DialogResult.OK)
                {
                    if (saveImg.FileName.EndsWith(".jpg"))
                    {
                        TargetImg.Image.Save(saveImg.FileName, ImageFormat.Jpeg);
                    }

                    else if (saveImg.FileName.EndsWith(".jpeg"))
                    {
                        TargetImg.Image.Save(saveImg.FileName, ImageFormat.Jpeg);
                    }

                    else if (saveImg.FileName.EndsWith(".png"))
                    {
                        TargetImg.Image.Save(saveImg.FileName, ImageFormat.Png);
                    }
                }
            }
        }
    }
}