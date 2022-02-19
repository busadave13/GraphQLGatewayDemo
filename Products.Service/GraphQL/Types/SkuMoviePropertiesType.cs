using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class SkuMoviePropertiesType : ObjectType<SkuMovieProperties>
    {
        protected override void Configure(IObjectTypeDescriptor<SkuMovieProperties> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.HasDisneyMetadata).Type<BooleanType>();
            descriptor.Field(b => b.FulfillmentData).Type<FulfillmentDataType>();
            descriptor.Field(b => b.VideoInstances).Type<VideoInstanceType>();
        }
    }
}
