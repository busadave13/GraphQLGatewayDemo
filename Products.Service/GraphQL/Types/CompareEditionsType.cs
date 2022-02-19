using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class CompareEditionsType : ObjectType<CompareEditions>
    {
        protected override void Configure(IObjectTypeDescriptor<CompareEditions> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.UpsellImages).Type<ListType<ImageType>>();
            descriptor.Field(b => b.BackgroundImages).Type<ListType<ImageType>>();
            descriptor.Field(b => b.UpsellText).Type<ListType<StringType>>();
            descriptor.Field(b => b.EarlyAccess).Type<DurationType>();
        }
    }
}
