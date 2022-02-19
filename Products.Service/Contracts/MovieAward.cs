namespace Products.Service.Contracts
{
    public class MovieAward
    {
        public string AwardDate { get; set; }
        public string CategoryName { get; set; }
        public bool IsWinner { get; set; }
        public string OrganizationName { get; set; }
    }
}