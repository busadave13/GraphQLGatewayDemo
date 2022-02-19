using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class MovieAwardType : ObjectType<MovieAward>
    {
        protected override void Configure(IObjectTypeDescriptor<MovieAward> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.AwardDate).Type<StringType>();
            descriptor.Field(b => b.CategoryName).Type<StringType>();
            descriptor.Field(b => b.IsWinner).Type<BooleanType>();
            descriptor.Field(b => b.OrganizationName).Type<StringType>();
        }
    }
}
