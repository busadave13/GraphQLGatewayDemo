namespace Products.Service
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor
                .Field(f => f.GetProductsAsync(CancellationToken.None))
                .Type<ListType<ProductContractType>>();

                descriptor
                .Field(f => f.GetProductByIdAsync(default, CancellationToken.None))
                .Type<ListType<ProductContractType>>();

                descriptor
                .Field(f => f.GetProductsByIdAsync(default, CancellationToken.None))
                .Type<ListType<ProductContractType>>();
        }
    }
}
