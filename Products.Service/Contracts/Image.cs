namespace Products.Service.Contracts
{
    public class Image
    {
        public string Caption { get; set; }
        public int Height { get; set; }
        public string ImagePurpose { get; set; }
        public string ImagePositionInfo { get; set; }
        public int Width { get; set; }
        public System.Uri Uri { get; set; }
        public string BackgroundColor { get; set; }
    }
}