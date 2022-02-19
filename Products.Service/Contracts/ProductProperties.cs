namespace Products.Service.Contracts
{
    public class ProductProperties
    {        
        public bool XboxLiveGoldRequired { get; set; }
        public IList<string> XboxCrossGenProductIds { get; set; }
        public bool IsEAPCGame { get; set; }
        public DateTime? PrivateBeforeDateHint { get; set; }
        public int PCDVersion { get; set; }
    }
}