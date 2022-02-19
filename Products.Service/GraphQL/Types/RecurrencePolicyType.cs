using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class RecurrencePolicyType : ObjectType<RecurrencePolicy>
    {
        protected override void Configure(IObjectTypeDescriptor<RecurrencePolicy> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.Duration).Type<DurationType>();
            descriptor.Field(b => b.InitialDuration).Type<DurationType>();
            descriptor.Field(b => b.RecurrencePolicyId).Type<StringType>();
            descriptor.Field(b => b.IsRecurring).Type<StringType>();
            descriptor.Field(b => b.HasTrial).Type<BooleanType>();
        }
    }
}
