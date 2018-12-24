using Emgu.CV;
using Emgu.CV.CvEnum;
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

namespace SimpleShapeRecognition {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
			textBox1.Select();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
			MessageBox.Show("Proudly Made by\r\n\t10170320 李云烽\r\n\t10170325 李健纯\r\n\t10170347 姜子威\r\n\t10170348 姚迪昭", "About Project");
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void openBitmapToolStripMenuItem_Click(object sender, EventArgs e) {
			OpenFileDialog fd = new OpenFileDialog();
			fd.Multiselect = false;
			fd.Title = "Open Bitmap";
			fd.Filter = "Bitmap|*.bmp;*.jpg;*.jepg";
			if (fd.ShowDialog() == DialogResult.OK) {
				Image<Bgr, Byte> srcImage = new Image<Bgr, byte>(fd.FileName);
				CvInvoke.Imshow("Source", srcImage);
				pictureBox1.Image = srcImage.Bitmap;

				//将图像转换为灰度
				UMat grayImage = new UMat();
				CvInvoke.CvtColor(srcImage, grayImage, ColorConversion.Bgr2Gray);

				//使用高斯滤波去除噪声
				CvInvoke.GaussianBlur(grayImage, grayImage, new Size(5, 5), 3);
				CvInvoke.Imshow("Blur Image", grayImage);
				pictureBox2.Image = grayImage.Bitmap;

				//霍夫圆检测
				CircleF[] circles = CvInvoke.HoughCircles(grayImage, HoughType.Gradient, 2.0, 20.0, 100.0, 180.0, 5);
				Image<Bgr, Byte> recognizedImage = srcImage.Clone();
				foreach (CircleF circle in circles)
					recognizedImage.Draw(circle, new Bgr(Color.Blue), 4);

// 				LineSegment2D[] lines = CvInvoke.HoughLinesP(grayImage, 1, Math.PI / 180, 500, 100, 10);
// 				foreach (var line in lines)
// 					recognizedImage.Draw(line, new Bgr(Color.Red), 4);

				CvInvoke.Imshow("Hough Transformed Image", recognizedImage);
				//CvInvoke.WaitKey(0);
			}
		}

		private void optionsToolStripMenuItem_Click(object sender, EventArgs e) {
			new Form1Options().ShowDialog(this);
		}

		internal void log(string s) {
			textBox1.AppendText(s + "\r\n");
		}
	}
}
