using Ionic.Zlib;
using System.Drawing;
using System.IO;

namespace Kalkimg {
	class Utility {
		public static byte ConvertRange(byte originalStart, byte originalEnd, byte newStart, byte newEnd, byte value) {
			double scale = (double) (newEnd - newStart) / (originalEnd - originalStart);
			return (byte) (newStart + ((value - originalStart) * scale));
		}

		public static byte[] BitmapToRGB565Data(Bitmap image) {
			byte[] imageData = new byte[image.Width * image.Height * 2];

			int imageDataIndex = 0;

			for (int y = 0; y < image.Height; ++y) {
				for (int x = 0; x < image.Width; ++x) {
					Color c = image.GetPixel(x, y);

					byte r = ConvertRange(0, 255, 0, 0x1F, c.R);
					byte g = ConvertRange(0, 255, 0, 0x3F, c.G);
					byte b = ConvertRange(0, 255, 0, 0x1F, c.B);

					int rgb565 = (r << 11) + (g << 5) + b;
					byte rgb565_2 = (byte) (rgb565 >> 8 & 0xFF);
					byte rgb565_1 = (byte) (rgb565 & 0xFF);

					imageData[imageDataIndex] = rgb565_2;
					imageData[imageDataIndex + 1] = rgb565_1;

					imageDataIndex += 2;
				}
			}

			return imageData;
		}

		public static byte[] Compress(byte[] input) {
			using (MemoryStream ms = new MemoryStream()) {
				using (ZlibStream zls = new ZlibStream(ms, CompressionMode.Compress, CompressionLevel.BestSpeed)) {
					zls.Write(input, 0, input.Length);
				}
				return ms.ToArray();
			}
		}
	}
}
