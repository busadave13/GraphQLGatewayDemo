using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class VideoInstanceType : ObjectType<VideoInstance>
    {
        protected override void Configure(IObjectTypeDescriptor<VideoInstance> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.ResolutionDetail).Type<StringType>();
            descriptor.Field(b => b.ResolutionFormat).Type<StringType>();
            descriptor.Field(b => b.Size).Type<LongType>();
            descriptor.Field(b => b.DeliveryFormat).Type<StringType>();
        }
    }
}
