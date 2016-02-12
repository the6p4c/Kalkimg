namespace Kalkimg {
	partial class FormMain {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.currentImagePictureBox = new System.Windows.Forms.PictureBox();
			this.loadImage = new System.Windows.Forms.Button();
			this.saveImage = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.currentImagePictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			this.openFileDialog.Filter = "Image Files (*.png, *.bmp, *.gif, *.jpg, *.jpeg)|*.png;*.bmp;*.gif;*.jpg;*.jpeg|A" +
    "ll Files (*.*)|*.*";
			// 
			// currentImagePictureBox
			// 
			this.currentImagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.currentImagePictureBox.Location = new System.Drawing.Point(12, 41);
			this.currentImagePictureBox.Name = "currentImagePictureBox";
			this.currentImagePictureBox.Size = new System.Drawing.Size(452, 270);
			this.currentImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.currentImagePictureBox.TabIndex = 3;
			this.currentImagePictureBox.TabStop = false;
			// 
			// loadImage
			// 
			this.loadImage.Location = new System.Drawing.Point(12, 12);
			this.loadImage.Name = "loadImage";
			this.loadImage.Size = new System.Drawing.Size(75, 23);
			this.loadImage.TabIndex = 4;
			this.loadImage.Text = "Load Image";
			this.loadImage.UseVisualStyleBackColor = true;
			this.loadImage.Click += new System.EventHandler(this.loadImage_Click);
			// 
			// saveImage
			// 
			this.saveImage.Location = new System.Drawing.Point(93, 12);
			this.saveImage.Name = "saveImage";
			this.saveImage.Size = new System.Drawing.Size(75, 23);
			this.saveImage.TabIndex = 5;
			this.saveImage.Text = "Save Image";
			this.saveImage.UseVisualStyleBackColor = true;
			this.saveImage.Click += new System.EventHandler(this.saveImage_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(476, 323);
			this.Controls.Add(this.saveImage);
			this.Controls.Add(this.loadImage);
			this.Controls.Add(this.currentImagePictureBox);
			this.Name = "FormMain";
			this.Text = "Kalkimg";
			((System.ComponentModel.ISupportInitialize)(this.currentImagePictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.PictureBox currentImagePictureBox;
		private System.Windows.Forms.Button loadImage;
		private System.Windows.Forms.Button saveImage;
	}
}

