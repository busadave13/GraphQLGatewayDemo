namespace Products.Service.Contracts
{
    public class Network
    {
        public IList<Image> Images { get; set; } = new List<Image>();
        public string Name { get; set; }
    }
}