using System.Drawing;

namespace BasicImageProcessing.ImageProcessingServices.Extensions
{
    public static class BitmapConvolutionExtensions
    {
        public static Bitmap Sharpen(this Bitmap image)
        {
            ConvMatrix m = new ConvMatrix();
            m.SetAll(0);
            m.Pixel = 5;
            m.TopMid = m.MidLeft = m.MidRight = m.BottomMid = -1;
            m.Factor = 1;

            Bitmap newImage = (Bitmap)image.Clone();
            ConvolutionFilterService.Conv3x3(newImage, m);
            return newImage;
        }

        public static Bitmap Smooth(this Bitmap image)
        {
            ConvMatrix m = new ConvMatrix();
            m.SetAll(1);
            m.Pixel = 1;
            m.Factor = 9;

            Bitmap newImage = (Bitmap)image.Clone();
            ConvolutionFilterService.Conv3x3(newImage, m);
            return newImage;
        }

        public static Bitmap GaussianBlur(this Bitmap image)
        {
            ConvMatrix m = new ConvMatrix();
            m.TopLeft = 1; m.TopMid = 2; m.TopRight = 1;
            m.MidLeft = 2; m.Pixel = 4; m.MidRight = 2;
            m.BottomLeft = 1; m.BottomMid = 2; m.BottomRight = 1;
            m.Factor = 16;

            Bitmap newImage = (Bitmap)image.Clone();
            ConvolutionFilterService.Conv3x3(newImage, m);
            return newImage;
        }

        public static Bitmap MeanRemoval(this Bitmap image, int weight = 9)
        {
            ConvMatrix m = new ConvMatrix(-1)
            {
                Pixel = weight,
                Factor = weight - 8
            };

            Bitmap newImage = (Bitmap)image.Clone();
            ConvolutionFilterService.Conv3x3(newImage, m);
            return newImage;
        }


        public static Bitmap EmbossLaplacian(this Bitmap image, int weight = 4)
        {
            ConvMatrix m = new ConvMatrix(-1)
            {
                Pixel = weight,
                TopMid = 0,
                MidLeft = 0,
                MidRight = 0,
                BottomMid = 0,
                Factor = 1,
                Offset = 127
            };

            Bitmap newImage = (Bitmap)image.Clone();
            ConvolutionFilterService.Conv3x3(newImage, m);
            return newImage;
        }

        public static Bitmap EmbossLaplacianHorizontalVertical(this Bitmap image, int weight = 4)
        {
            ConvMatrix m = new ConvMatrix(0)
            {
                Pixel = weight,
                TopMid = -1,
                MidLeft = -1,
                MidRight = -1,
                BottomMid = -1,
                Factor = 1,
                Offset = 127
            };

            Bitmap newImage = (Bitmap)image.Clone();
            ConvolutionFilterService.Conv3x3(newImage, m);
            return newImage;
        }

        public static Bitmap EmbossLaplacianAllDirections(this Bitmap image, int weight = 8)
        {
            ConvMatrix m = new ConvMatrix(-1)
            {
                Pixel = weight,
                Factor = 1,
                Offset = 127
            };

            Bitmap newImage = (Bitmap)image.Clone();
            ConvolutionFilterService.Conv3x3(newImage, m);
            return newImage;
        }

        public static Bitmap EmbossLaplacianLossy(this Bitmap image, int weight = 4)
        {
            ConvMatrix m = new ConvMatrix(-2)
            {
                Pixel = weight,
                TopLeft = 1,
                TopRight = 1,
                BottomMid = 1,
                Factor = 1,
                Offset = 127
            };

            Bitmap newImage = (Bitmap)image.Clone();
            ConvolutionFilterService.Conv3x3(newImage, m);
            return newImage;
        }

        public static Bitmap EmbossLaplacianHorizontalOnly(this Bitmap image, int weight = 2)
        {
            ConvMatrix m = new ConvMatrix(0)
            {
                Pixel = weight,
                MidLeft = -1,
                MidRight = -1,
                Factor = 1,
                Offset = 127
            };

            Bitmap newImage = (Bitmap)image.Clone();
            ConvolutionFilterService.Conv3x3(newImage, m);
            return newImage;
        }

        public static Bitmap EmbossLaplacianVerticalOnly(this Bitmap image, int weight = 0)
        {
            ConvMatrix m = new ConvMatrix(0)
            {
                Pixel = weight,
                TopMid = -1,
                BottomMid = 1,
                Factor = 1,
                Offset = 127
            };

            Bitmap newImage = (Bitmap)image.Clone();
            ConvolutionFilterService.Conv3x3(newImage, m);
            return newImage;
        }
    }
}
