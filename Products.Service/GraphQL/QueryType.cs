﻿namespace Products.Service
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor
                .Field(f => f.GetProductsAsync(CancellationToken.None))
                .Type<ListType<ProductContractType>>();
        }
    }
}
