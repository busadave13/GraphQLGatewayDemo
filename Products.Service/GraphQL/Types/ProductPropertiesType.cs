using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class ProductPropertiesType : ObjectType<ProductProperties>
    {
        protected override void Configure(IObjectTypeDescriptor<ProductProperties> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.XboxLiveGoldRequired).Type<BooleanType>();
            descriptor.Field(b => b.XboxCrossGenProductIds).Type<ListType<StringType>>();
            descriptor.Field(b => b.IsEAPCGame).Type<BooleanType>();
            descriptor.Field(b => b.PrivateBeforeDateHint).Type<DateTimeType>();
            descriptor.Field(b => b.PCDVersion).Type<IntType>();
        }
        
    }
}
