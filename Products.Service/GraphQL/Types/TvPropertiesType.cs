using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class TvPropertiesType : ObjectType<TvProperties>
    {
        protected override void Configure(IObjectTypeDescriptor<TvProperties> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.TvGenres).Type<ListType<StringType>>();
            descriptor.Field(b => b.ExpectedNumberOfEpisodes).Type<IntType>(); ;
            descriptor.Field(b => b.IsComplete).Type<BooleanType>();
            descriptor.Field(b => b.FirstEpisodeId).Type<StringType>();
            descriptor.Field(b => b.PresaleFulfillmentDate).Type<StringType>();
            descriptor.Field(b => b.ComingSoonPurchaseDate).Type<StringType>(); ;
            descriptor.Field(b => b.OriginalPublicationDate).Type<StringType>();
            descriptor.Field(b => b.Networks).Type<ListType<NetworkType>>(); ;
            descriptor.Field(b => b.TotalPublishedNumberOfSeasons).Type<IntType>();
            descriptor.Field(b => b.TvParentProducts).Type<ListType<TVParentProductType>>();
        }
    }
}
