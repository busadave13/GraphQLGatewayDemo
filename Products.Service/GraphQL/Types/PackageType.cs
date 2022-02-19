using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class PackageType : ObjectType<Package>
    {
        protected override void Configure(IObjectTypeDescriptor<Package> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.ContentId).Type<StringType>();
            descriptor.Field(b => b.KeyId).Type<StringType>();
            descriptor.Field(b => b.SupportsIntelligentDelivery).Type<BooleanType>();
            descriptor.Field(b => b.SupportsInstallFeatures).Type<BooleanType>();
        }
    }
}
