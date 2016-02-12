using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Kalkimg {
	public partial class FormMain : Form {
		private Bitmap currentImage;

		public FormMain() {
			InitializeComponent();
		}

		private void loadImage_Click(object sender, EventArgs e) {
			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				Bitmap selectedImage = (Bitmap) Image.FromFile(openFileDialog.FileName);

				bool exceedsWidth = selectedImage.Width > 0x136;
				bool exceedsHeight = selectedImage.Height > 0x191;

				if (exceedsWidth && exceedsHeight) {
					MessageBox.Show("Could not load image: width exceeds 301px and height exceeds 401px.");
				} else if (exceedsWidth) {
					MessageBox.Show("Could not load image: width exceeds 310px.");
				} else if (exceedsHeight) {
					MessageBox.Show("Could not load image: height exceeds 401px.");
				} else {
					currentImage = selectedImage;
					currentImagePictureBox.Image = currentImage;
				}
			}
		}

		private void saveImage_Click(object sender, EventArgs e) {
			if (currentImage == null) {
				MessageBox.Show("You must load an image.");
				return;
			}

			C2PFile c2pFile = new C2PFile(currentImage);

			try {
				using (BinaryWriter bw = new BinaryWriter(new FileStream("out.bin", FileMode.OpenOrCreate, FileAccess.Write))) {
					bw.Write(c2pFile.FileData);
				}
			} catch (IOException ex) {
				MessageBox.Show(String.Format("Could not save file.\n\nException: {0}", ex));
			}
		}
	}
}
