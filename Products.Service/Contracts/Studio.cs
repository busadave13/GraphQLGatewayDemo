namespace Products.Service.Contracts
{
    public class Studio
    {
        public IList<Image> Images { get; set; } = new List<Image>();
        public string Name { get; set; }
    }
}