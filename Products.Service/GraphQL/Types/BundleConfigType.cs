using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class BundleConfigType : ObjectType<BundleConfig>
    {
        protected override void Configure(IObjectTypeDescriptor<BundleConfig> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.BundleId).Type<StringType>();
            descriptor.Field(b => b.RenderHint).Type<StringType>();
            descriptor.Field(b => b.BundleSlots).Type<ListType<BundleSlotType>>().UseFiltering();
            descriptor.Field(b => b.BundleTitle).Type<StringType>();
            descriptor.Field(b => b.Description).Type<StringType>();
            descriptor.Field(b => b.ShortDescription).Type<StringType>();
        }
    }
}
