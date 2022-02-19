using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class ContentRatingType : ObjectType<ContentRating>
    {
        protected override void Configure(IObjectTypeDescriptor<ContentRating> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.RatingImageUri).Type<UriType>();
            descriptor.Field(b => b.RatingImageLinkUri).Type<UriType>();
            descriptor.Field(b => b.RatingDescription).Type<StringType>();
            descriptor.Field(b => b.Rating).Type<StringType>();
            descriptor.Field(b => b.ShortName).Type<StringType>();
            descriptor.Field(b => b.RatingAge).Type<IntType>();
            descriptor.Field(b => b.RatingId).Type<StringType>();
            descriptor.Field(b => b.Descriptors)
                .Type<ListType<StringType>>()
                .UseFiltering();
            descriptor.Field(b => b.Disclaimers)
                .Type<ListType<StringType>>()
                .UseFiltering();
            descriptor.Field(b => b.InteractiveElements)
                .Type<ListType<StringType>>()
                .UseFiltering();
        }
    }
}
