using Pragma.Core;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Pragma.Core
{
    public static class ImageTool

    {
        /// <summary>
        /// Faz um color shift na imagem, mudando o espectro de cores baseado na cor passada.
        /// </summary>
        /// <param name="image">Imagem a ser convertida.</param>
        /// <param name="color">Cor a ser usada.</param>
        /// <returns>Nova imagem, aplicando o color shift.</returns>
        public static Bitmap ColorShift(Bitmap image, Color color)
        {
            var newImage = new Bitmap(image);

            //ColorShift
            for (int x = 0; x < image.Width; x++)
                for (int y = 0; y < image.Height; y++)
                    newImage.SetPixel(x, y, ColorTool.ColorShift(image.GetPixel(x, y), color));

            return newImage;
        }

        /// <summary>
        /// Redimensiona uma imagem
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <param name="cropTransparent">Indica se o método deve ignorar linhas ou colunas totalmente transparentes da imagem.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap Resize(Bitmap image, int width, int height, bool cropTransparent = true)
        {
            //var destRect = new Rectangle(0, 0, width, height);
            var destRect = new PointF[] { new PointF(0, 0), new PointF(width, 0), new PointF(0, height) };
            var destImage = new Bitmap(width, height);
            RectangleF imageCropRect;
            if (cropTransparent)
                imageCropRect = CropImage(image);
            else
                imageCropRect = new RectangleF(0, 0, image.Width, image.Height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, imageCropRect, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        //TODO: Limpar e documentar
        private static RectangleF CropImage(Bitmap image)
        {
            var rect = new RectangleF(0, 0, image.Width, image.Height);
            for (int y = 0; y < image.Height / 2; y++)
            {
                var shouldCrop = true;
                for (int x = 0; x < image.Width; x++)
                {
                    if (image.GetPixel(x, y).A == 0)
                        continue;
                    else
                    {
                        shouldCrop = false;
                        break;
                    }
                }
                if (shouldCrop)
                {
                    rect.Y++;
                    rect.Height--;
                }
                else
                    break;
            }

            for (int y = image.Height - 1; y > image.Height / 2; y--)
            {
                var shouldCrop = true;
                for (int x = 0; x < image.Width; x++)
                {
                    if (image.GetPixel(x, y).A == 0)
                        continue;
                    else
                    {
                        shouldCrop = false;
                        break;
                    }
                }
                if (shouldCrop)
                {
                    rect.Height--;
                }
                else
                    break;
            }

            for (int x = 0; x < image.Width / 2; x++)
            {
                var shouldCrop = true;
                for (int y = 0; y < image.Height; y++)
                {
                    if (image.GetPixel(x, y).A == 0)
                        continue;
                    else
                    {
                        shouldCrop = false;
                        break;
                    }
                }
                if (shouldCrop)
                {
                    rect.X++;
                    rect.Width--;
                }
                else
                    break;
            }

            for (int x = image.Width - 1; x > image.Width / 2; x--)
            {
                var shouldCrop = true;
                for (int y = 0; y < image.Height; y++)
                {
                    if (image.GetPixel(x, y).A == 0)
                        continue;
                    else
                    {
                        shouldCrop = false;
                        break;
                    }
                }
                if (shouldCrop)
                {
                    rect.Width--;
                }
                else
                    break;
            }

            return rect;
        }
    }
}
