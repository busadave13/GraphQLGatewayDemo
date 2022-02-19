using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class FreePlayType : ObjectType<FreePlay>
    {
        protected override void Configure(IObjectTypeDescriptor<FreePlay> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.EndDate).Type<StringType>();
            descriptor.Field(b => b.StartDate).Type<StringType>();
        }
    }
}
