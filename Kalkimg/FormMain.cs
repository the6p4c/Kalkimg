using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace Kalkimg {
	public partial class FormMain : Form {
		private Bitmap currentImageOriginal;
		private Bitmap currentImageTransformed;

		private string openedFileName;

		public FormMain() {
			InitializeComponent();
		}

		private void RunTransform() {
			if (currentImageOriginal == null) return;

			currentImageTransformed = ImageTransform.Transform(
				currentImageOriginal,
				maintainAspectRatio.Checked, scaleUp.Checked, fullSize.Checked
			);
			currentImagePictureBox.Image = currentImageTransformed;
		}

		private void loadImage_Click(object sender, EventArgs e) {
			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				openedFileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);

				currentImageOriginal = (Bitmap) Image.FromFile(openFileDialog.FileName);

				bool imageSmallerThanMax = currentImageOriginal.Width < Utility.MAX_IMAGE_WIDTH && currentImageOriginal.Height < Utility.MAX_IMAGE_HEIGHT;

				scaleUp.Enabled = imageSmallerThanMax;
				scaleUp.Checked = imageSmallerThanMax;

				RunTransform();
			}
		}

		private void saveImage_Click(object sender, EventArgs e) {
			if (currentImageTransformed == null) {
				MessageBox.Show("You must load an image.");
				return;
			}

			saveFileDialog.FileName = openedFileName;
			if (saveFileDialog.ShowDialog() == DialogResult.OK) {
				C2PFile c2pFile = new C2PFile(currentImageTransformed);

				try {
					using (BinaryWriter bw = new BinaryWriter(new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate, FileAccess.Write))) {
						bw.Write(c2pFile.FileData);
					}
				} catch (IOException ex) {
					MessageBox.Show(String.Format("Could not save file.\n\nException: {0}", ex));
				}
			}
		}

		private void options_CheckedChanged(object sender, EventArgs e) {
			RunTransform();
		}
	}
}
