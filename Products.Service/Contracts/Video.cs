namespace Products.Service.Contracts
{
    public class Video
    {
        public System.Uri Uri { get; set; }
        public string VideoPurpose { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string Caption { get; set; }
        public Image PreviewImage { get; set; }
        public int SortOrder { get; set; }
    }
}