using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class BundleSlotType : ObjectType<BundleSlot>
    {
        protected override void Configure(IObjectTypeDescriptor<BundleSlot> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.SlotId).Type<StringType>();
            descriptor.Field(b => b.RenderHint).Type<StringType>();
            descriptor.Field(b => b.DisplayRank).Type<StringType>();
            descriptor.Field(b => b.Maximum).Type<StringType>();
            descriptor.Field(b => b.Minimum).Type<StringType>();
            descriptor.Field(b => b.ChildIdentifiers).Type<ListType<ChildIdentifierType>>().UseFiltering();
            descriptor.Field(b => b.SlotTitle).Type<StringType>();
        }
    }
}
