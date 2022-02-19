using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class FulfillmentDataType : ObjectType<FulfillmentData>
    {
        protected override void Configure(IObjectTypeDescriptor<FulfillmentData> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.DistributionRight).Type<StringType>();
            descriptor.Field(b => b.VideoAttributes).Type<VideoAttributesType>();
            descriptor.Field(b => b.WuCategoryId).Type<StringType>();
            descriptor.Field(b => b.AcquisitionPeriodInHours).Type<IntType>();
            descriptor.Field(b => b.ViewingPeriodInHours).Type<IntType>();
        }
    }
}
