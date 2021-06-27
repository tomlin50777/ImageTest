using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageTest
{
	public partial class ImageForm : System.Windows.Forms.Form
	{
		private Bitmap bitmap;
		private string path;
		private DateTime now;
		public ImageForm()
		{
			InitializeComponent();
			path = @"D:\ForYou\Test3.png";
			bitmap = new Bitmap(path);
		}
		private void PepperButton_Click(object sender, EventArgs e)
		{
			Start(null);
			Random random = new Random();
			Bitmap result = new Bitmap(bitmap.Width, bitmap.Height);
			int blackPepperNumber = 300;
			int offset = 15;
			for (int countY = 0; countY < bitmap.Height; countY++)
			{
				for (int countX = 0; countX < bitmap.Width; countX++)
				{
					int r = bitmap.GetPixel(countX, countY).R + random.Next(-offset, offset);
					int g = bitmap.GetPixel(countX, countY).G + random.Next(-offset, offset);
					int b = bitmap.GetPixel(countX, countY).B + random.Next(-offset, offset);
					if (r < 0) r = 0;
					if (r > 255) r = 255;
					if (g < 0) g = 0;
					if (g > 255) g = 255;
					if (b < 0) b = 0;
					if (b > 255) b = 255;
					result.SetPixel(countX, countY, Color.FromArgb(r, g, b));
				}
			}
			for (int count = 0; count < blackPepperNumber; count++)
			{
				int tempX = random.Next(bitmap.Width);
				int tempY = random.Next(bitmap.Height);
				result.SetPixel(tempX, tempY, Color.FromArgb(0, 0, 0));
			}
			ImageUpdate(result, "Pepper");
		}
		private void BinaryButton_Click(object sender, EventArgs e)
		{
			Start("Pepper");
			int gate = 100;
			Bitmap result = new Bitmap(bitmap.Width, bitmap.Height);
			for (int countY = 0; countY < bitmap.Height; countY++)
			{
				for (int countX = 0; countX < bitmap.Width; countX++)
				{
					Color pixel = bitmap.GetPixel(countX, countY);
					if(pixel.R + pixel.G + pixel.B > gate)
						result.SetPixel(countX, countY, Color.FromArgb(255, 255, 255));
					else
						result.SetPixel(countX, countY, Color.FromArgb(0, 0, 0));
				}
			}
			ImageUpdate(result, "Binary");
		}
		private void BlackNoiceClearButton_Click(object sender, EventArgs e)
		{
			Start("Binary");
			Bitmap result = new Bitmap(bitmap.Width, bitmap.Height);
			int gate = 3;
			int countTime = 0;
			for (int countY = 0; countY < bitmap.Height; countY++)
				for (int countX = 0; countX < bitmap.Width; countX++)
					result.SetPixel(countX, countY, bitmap.GetPixel(countX, countY));
			while (true)
			{
				countTime++;
				bool change = false;
				for (int countY = 0; countY < result.Height; countY++)
				{
					for (int countX = 0; countX < result.Width; countX++)
					{
						if (result.GetPixel(countX, countY) == Color.FromArgb(0, 0, 0))
						{
							int temp = 0;
							if (countX == 0 || result.GetPixel(countX - 1, countY) == Color.FromArgb(255, 255, 255))
								temp++;
							if (countX == result.Width - 1 || result.GetPixel(countX + 1, countY) == Color.FromArgb(255, 255, 255))
								temp++;
							if (countY == 0 || result.GetPixel(countX, countY - 1) == Color.FromArgb(255, 255, 255))
								temp++;
							if (countY == result.Height - 1 || result.GetPixel(countX, countY + 1) == Color.FromArgb(255, 255, 255))
								temp++;
							if (temp >= gate)
							{
								change = true;
								result.SetPixel(countX, countY, Color.FromArgb(255, 255, 255));
								countY--;
								countX = 0;
							}
						}
					}
				}
				if (!change)
					break;
			}
			ImageUpdate(result, "Noise Clear");
		}
		private void LocateButton_Click(object sender, EventArgs e)
		{
			Start("Noise Clear");
			int[,] map = new int[bitmap.Height, bitmap.Width];
			int classification = 0;
			Bitmap result = new Bitmap(bitmap.Width, bitmap.Height);
			for (int countY = 0; countY < bitmap.Height; countY++)
				for (int countX = 0; countX < bitmap.Width; countX++)
					result.SetPixel(countX, countY, bitmap.GetPixel(countX, countY));
			for (int countY = 0; countY < result.Height; countY++)
			{
				for (int countX = 0; countX < result.Width; countX++)
				{
					if (result.GetPixel(countX, countY) == Color.FromArgb(255, 255, 255))
					{
						LocateImage(result, map, countX, countY, classification);
						classification++;
					}
				}
			}
						

		}
		private void LocateImage(Bitmap result, int[,] map, int x, int y, int classification)
		{

		}
		private void Start(string lastFunctionName)
		{
			if(lastFunctionName != null)
				bitmap = new Bitmap(Path.Combine(Path.GetDirectoryName(path), lastFunctionName + "_" + Path.GetFileName(path)));
			now = DateTime.Now;
		}
		private void ImageUpdate(Bitmap result, string functionName)
		{
			DateTime end = DateTime.Now;
			double total = 0;
			string totalString = (string)listBox.Items[listBox.Items.Count - 1];
			result.Save(Path.Combine(Path.GetDirectoryName(path), functionName + "_" + Path.GetFileName(path)));
			pictureBox.Image = new Bitmap(result, pictureBox.Width, pictureBox.Height);
			pictureBox.Refresh();
			bitmap = result;
			nowLabel.Text = functionName + " : " + new TimeSpan(end.Ticks - now.Ticks).TotalSeconds + " S";
			totalString = totalString.Substring(totalString.IndexOf(": ") + 2, totalString.LastIndexOf(" S") - totalString.IndexOf(": ") - 2);
			total = Convert.ToDouble(totalString) + new TimeSpan(end.Ticks - now.Ticks).TotalSeconds;
			listBox.Items[listBox.Items.Count - 1] = nowLabel.Text;
			listBox.Items.Add("共 : " + total + " S");
			listBox.Refresh();

			nowLabel.Refresh();
		}
	}
}
