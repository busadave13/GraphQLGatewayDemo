using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class TVParentProductType : ObjectType<TVParentProduct>
    {
        protected override void Configure(IObjectTypeDescriptor<TVParentProduct> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.ParentProductId).Type<StringType>();
            descriptor.Field(b => b.Position).Type<IntType>();
            descriptor.Field(b => b.SeriesTitle).Type<FloatType>();
        }
    }
}
