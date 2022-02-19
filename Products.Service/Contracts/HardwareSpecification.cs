namespace Products.Service.Contracts
{
    public class HardwareSpecification : IEquatable<HardwareSpecification>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public bool Equals(HardwareSpecification other)
        {
            if (other == null)
            {
                return false;
            }


            return this.Name == other.Name && this.Description == other.Description;
        }
        public override bool Equals(object obj) => Equals(obj as HardwareSpecification);
        public override int GetHashCode() => (Name, Description).GetHashCode();
    }
}