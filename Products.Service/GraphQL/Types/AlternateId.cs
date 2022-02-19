namespace Products.Service.Contracts
{
    public class AlternateIdType : ObjectType<AlternateId>
    {
        protected override void Configure(IObjectTypeDescriptor<AlternateId> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.Value).Type<StringType>();
            descriptor.Field(b => b.IdType).Type<StringType>();
        }
    }
}