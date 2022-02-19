using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class PIFilterType : ObjectType<PIFilter>
    {
        protected override void Configure(IObjectTypeDescriptor<PIFilter> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.ExclusionProperties).Type<ListType<StringType>>();
            descriptor.Field(b => b.InclusionProperties).Type<ListType<StringType>>();
    }
    }
}
