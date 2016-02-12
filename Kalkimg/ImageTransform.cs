using System.Diagnostics;
using System.Drawing;

namespace Kalkimg {
	class ImageTransform {
		private static Bitmap Resize(Bitmap image, int maxWidth, int maxHeight, bool maintainAspectRatio) {
			int newWidth = Utility.MAX_IMAGE_WIDTH;
			int newHeight = Utility.MAX_IMAGE_HEIGHT;

			if (maintainAspectRatio) {
				double ratioW = maxWidth / (double) image.Width;
				double ratioH = maxHeight / (double) image.Height;
				double ratio = ratioW < ratioH ? ratioW : ratioH;

				newWidth = (int) (image.Width * ratio);
				newHeight = (int) (image.Height * ratio);
			}

			Bitmap newImage = new Bitmap(newWidth, newHeight);
			Graphics g = Graphics.FromImage(newImage);

			g.DrawImage(image, 0, 0, newWidth, newHeight);

			return newImage;
		}

		private static Bitmap AddPadding(Bitmap image, int newWidth, int newHeight) {
			Debug.Assert(image.Width <= newWidth);
			Debug.Assert(image.Height <= newHeight);

			int xPos = (newWidth - image.Width) / 2;
			int yPos = (newHeight - image.Height) / 2;

			Bitmap newImage = new Bitmap(newWidth, newHeight);
			Graphics g = Graphics.FromImage(newImage);

			g.Clear(Color.White);
			g.DrawImage(image, xPos, yPos, image.Width, image.Height);

			return newImage;
		}

		public static Bitmap Transform(Bitmap image, bool maintainAspectRatio, bool scaleUp, bool fullSize) {
			Bitmap newImage = image;

			bool imageSmallerThanMax = image.Width < Utility.MAX_IMAGE_WIDTH && image.Height < Utility.MAX_IMAGE_HEIGHT;

			if (!(imageSmallerThanMax && !scaleUp)) {
				newImage = Resize(newImage, Utility.MAX_IMAGE_WIDTH, Utility.MAX_IMAGE_HEIGHT, maintainAspectRatio);
			}

			if (fullSize) {
				newImage = AddPadding(newImage, Utility.MAX_IMAGE_WIDTH, Utility.MAX_IMAGE_HEIGHT);
			}

			return newImage;
		}
	}
}
