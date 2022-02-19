using Entitlements.Service.GraphQL.Types;

namespace Entitlements.Service
{
    public class EntitlementType : ObjectType<Entitlement>
    {
        protected override void Configure(IObjectTypeDescriptor<Entitlement> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.AcquiredDate).Type<DateTimeType>();
            descriptor.Field(b => b.ModifiedDate).Type<DateTimeType>();
            descriptor.Field(b => b.IsSatisfiedEntitlement).Type<BooleanType>();
            descriptor.Field(b => b.ProductId).Type<StringType>();
            descriptor.Field(b => b.ProductFamily).Type<StringType>();
            descriptor.Field(b => b.SatisfiedByProductId).Type<StringType>();
            descriptor.Field(b => b.ProductKind).Type<StringType>();
            descriptor.Field(b => b.AutoRenew).Type<BooleanType>();
            descriptor.Field(b => b.Status).Type<StringType>();
            descriptor.Field(b => b.StartDate).Type<DateTimeType>();
            descriptor.Field(b => b.EndDate).Type<DateTimeType>();
            descriptor.Field(b => b.IsTrial).Type<BooleanType>();
            descriptor.Field(b => b.RecurrenceSkuId).Type<StringType>();
            descriptor.Field(b => b.SkuId).Type<StringType>();
            descriptor.Field(b => b.IsWithinResellerRestrictionPeriod).Type<BooleanType>();
            descriptor.Field(b => b.RecurrenceId).Type<StringType>();
            descriptor.Field(b => b.SharingSource).Type<StringType>();
            descriptor.Field(b => b.EntitlementKey).Type<StringType>();
            descriptor.Field(b => b.EntitlementId).Type<StringType>();
            descriptor.Field(b => b.MultiStoreSource).Type<StringType>();
            descriptor.Field(b => b.SandboxId).Type<StringType>();
            descriptor.Field(b => b.Source).Type<StringType>();
            descriptor.Field(b => b.Beneficiary).Type<BeneficiaryType>();
            descriptor.Field(b => b.Purchaser).Type<BeneficiaryType>();
        }
    }
}
