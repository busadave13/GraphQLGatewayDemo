namespace Products.Service.Contracts
{
    public enum BadgeType
    {
        PreOrder = 0,
        UltimateGamePass = 1,
        PCGamePass = 2,
        ConsoleGamePass = 3,
        JustForYou = 4,
    }

    public class Badge
    {
        public BadgeType Type { get; set; }
    }
}