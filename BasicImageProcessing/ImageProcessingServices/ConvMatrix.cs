namespace BasicImageProcessing.ImageProcessingServices
{
    public class ConvMatrix
    {
        public int TopLeft { get; set; } = 0;
        public int TopMid { get; set; } = 0;
        public int TopRight { get; set; } = 0;

        public int MidLeft { get; set; } = 0;
        public int Pixel { get; set; } = 1;
        public int MidRight { get; set; } = 0;

        public int BottomLeft { get; set; } = 0;
        public int BottomMid { get; set; } = 0;
        public int BottomRight { get; set; } = 0;

        public int Factor { get; set; } = 1;
        public int Offset { get; set; } = 0;

        public ConvMatrix() { }

        public ConvMatrix(int val)
        {
            TopLeft = TopMid = TopRight =
            MidLeft = Pixel = MidRight =
            BottomLeft = BottomMid = BottomRight =
            val;
        }

        public void SetAll(int val)
        {
            TopLeft = TopMid = TopRight =
            MidLeft = Pixel = MidRight =
            BottomLeft = BottomMid = BottomRight =
            val;
        }
    }
}
