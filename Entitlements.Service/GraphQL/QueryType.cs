namespace Entitlements.Service
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor
                .Field(f => f.GetEntitlementsAsync(CancellationToken.None))
                .Type<ListType<EntitlementType>>();
        }
    }
}
