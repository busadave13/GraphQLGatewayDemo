using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class TrailerType : ObjectType<Trailer>
    {
        protected override void Configure(IObjectTypeDescriptor<Trailer> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.TrailerName).Type<StringType>();
            descriptor.Field(b => b.Uri).Type<UriType>(); ;
            descriptor.Field(b => b.DeliveryFormat).Type<StringType>();
            descriptor.Field(b => b.ResolutionFormat).Type<StringType>();
        }
    }
}
