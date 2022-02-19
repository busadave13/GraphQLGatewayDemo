using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class ContributoType : ObjectType<Contributor>
    {
        protected override void Configure(IObjectTypeDescriptor<Contributor> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.Name).Type<StringType>();
            descriptor.Field(b => b.AlternateIds).Type<ListType<AlternateIdType>>();
            descriptor.Field(b => b.RoleType).Type<StringType>();
            descriptor.Field(b => b.Images).Type<ListType<ImageType>>();
            descriptor.Field(b => b.ContributorId).Type<StringType>();
            descriptor.Field(b => b.Order).Type<IntType>();
            descriptor.Field(b => b.Role).Type<StringType>();
        }
    }
}
