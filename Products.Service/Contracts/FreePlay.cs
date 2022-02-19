namespace Products.Service.Contracts
{
    public class FreePlay
    {
        public string EndDate { get; set; }
        public string StartDate { get; set; }

        public FreePlay Clone() => new FreePlay()
        {
            EndDate = EndDate,
            StartDate = StartDate,
        };
    }
}