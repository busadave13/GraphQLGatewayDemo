using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class MoviePropertiesType : ObjectType<MovieProperties>
    {
        protected override void Configure(IObjectTypeDescriptor<MovieProperties> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.Contributors).Type<ContributoType>();
            descriptor.Field(b => b.Trailers).Type<ListType<TrailerType>>();
            descriptor.Field(b => b.Studios).Type<ListType<StudioType>>();
            descriptor.Field(b => b.MovieGenres).Type<ListType<StringType>>();
            descriptor.Field(b => b.FulfillmentData).Type<FulfillmentDataType>();
            descriptor.Field(b => b.VideoInstances).Type<VideoInstanceType>();
            descriptor.Field(b => b.DurationInSeconds).Type<IntType>();
            descriptor.Field(b => b.IsVideoBundle).Type<IntType>();
            descriptor.Field(b => b.VideoType).Type<StringType>();
            descriptor.Field(b => b.BundleProducts).Type<BundleProductType>();
            descriptor.Field(b => b.MovieAwards).Type<MovieAwardType>();
        }
    }
}
