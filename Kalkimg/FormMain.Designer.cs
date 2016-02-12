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
			this.maintainAspectRatio = new System.Windows.Forms.CheckBox();
			this.scaleUp = new System.Windows.Forms.CheckBox();
			this.fullSize = new System.Windows.Forms.CheckBox();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
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
			this.currentImagePictureBox.Location = new System.Drawing.Point(12, 39);
			this.currentImagePictureBox.Name = "currentImagePictureBox";
			this.currentImagePictureBox.Size = new System.Drawing.Size(452, 461);
			this.currentImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
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
			// maintainAspectRatio
			// 
			this.maintainAspectRatio.AutoSize = true;
			this.maintainAspectRatio.Checked = true;
			this.maintainAspectRatio.CheckState = System.Windows.Forms.CheckState.Checked;
			this.maintainAspectRatio.Location = new System.Drawing.Point(174, 16);
			this.maintainAspectRatio.Name = "maintainAspectRatio";
			this.maintainAspectRatio.Size = new System.Drawing.Size(130, 17);
			this.maintainAspectRatio.TabIndex = 6;
			this.maintainAspectRatio.Text = "Maintain Aspect Ratio";
			this.maintainAspectRatio.UseVisualStyleBackColor = true;
			this.maintainAspectRatio.CheckedChanged += new System.EventHandler(this.options_CheckedChanged);
			// 
			// scaleUp
			// 
			this.scaleUp.AutoSize = true;
			this.scaleUp.Checked = true;
			this.scaleUp.CheckState = System.Windows.Forms.CheckState.Checked;
			this.scaleUp.Location = new System.Drawing.Point(310, 16);
			this.scaleUp.Name = "scaleUp";
			this.scaleUp.Size = new System.Drawing.Size(70, 17);
			this.scaleUp.TabIndex = 7;
			this.scaleUp.Text = "Scale Up";
			this.scaleUp.UseVisualStyleBackColor = true;
			this.scaleUp.CheckedChanged += new System.EventHandler(this.options_CheckedChanged);
			// 
			// fullSize
			// 
			this.fullSize.AutoSize = true;
			this.fullSize.Location = new System.Drawing.Point(386, 16);
			this.fullSize.Name = "fullSize";
			this.fullSize.Size = new System.Drawing.Size(65, 17);
			this.fullSize.TabIndex = 8;
			this.fullSize.Text = "Full Size";
			this.fullSize.UseVisualStyleBackColor = true;
			this.fullSize.CheckedChanged += new System.EventHandler(this.options_CheckedChanged);
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.Filter = "C2P Files (*.c2p)|*.c2p";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(476, 512);
			this.Controls.Add(this.fullSize);
			this.Controls.Add(this.scaleUp);
			this.Controls.Add(this.maintainAspectRatio);
			this.Controls.Add(this.saveImage);
			this.Controls.Add(this.loadImage);
			this.Controls.Add(this.currentImagePictureBox);
			this.Name = "FormMain";
			this.Text = "Kalkimg";
			((System.ComponentModel.ISupportInitialize)(this.currentImagePictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.PictureBox currentImagePictureBox;
		private System.Windows.Forms.Button loadImage;
		private System.Windows.Forms.Button saveImage;
		private System.Windows.Forms.CheckBox maintainAspectRatio;
		private System.Windows.Forms.CheckBox scaleUp;
		private System.Windows.Forms.CheckBox fullSize;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
	}
}

