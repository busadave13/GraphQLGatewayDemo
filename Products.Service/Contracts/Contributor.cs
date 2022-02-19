namespace Products.Service.Contracts
{
    public class Contributor
    {
        public string Name { get; set; }
        public IList<AlternateId> AlternateIds { get; set; } = new List<AlternateId>();
        public string RoleType { get; set; }
        public IList<Image> Images { get; set; } = new List<Image>();
        public string ContributorId { get; set; }
        public int Order { get; set; }
        public string Role { get; set; }
    }
}