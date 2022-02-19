using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class XCloudPropertiesType : ObjectType<XCloudProperties>
    {
        protected override void Configure(IObjectTypeDescriptor<XCloudProperties> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.XCloudId).Type<StringType>();
            descriptor.Field(b => b.XboxTitleId).Type<LongType>();
            descriptor.Field(b => b.SupportsTouch).Type<LongType>();
        }
    }
}
