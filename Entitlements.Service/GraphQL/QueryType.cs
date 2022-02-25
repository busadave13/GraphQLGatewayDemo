namespace Entitlements.Service
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor
                .Field(f => f.GetEntitlementsAsync(CancellationToken.None))
                .Description("Paginated query to return all entitlements")
                .Type<ListType<EntitlementType>>();

            descriptor
                .Field(f => f.GetEntitlementsByProductIdAsync(default!, default))
                .Description("Batch query to return entitlement data for the specified product Ids")
                .Type<ListType<EntitlementType>>();
        }
    }
}
