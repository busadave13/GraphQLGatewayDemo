using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class AvailabilityType : ObjectType<Availability>
    {
        protected override void Configure(IObjectTypeDescriptor<Availability> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.AvailabilityId).Type<StringType>();
            descriptor.Field(b => b.Actions).Type<ListType<AvailabilityActionsType>>();
            descriptor.Field(b => b.AllowedPlatforms).Type<ListType<StringType>>();
            descriptor.Field(b => b.Price).Type<SkuAvailabilityPriceType>();
            descriptor.Field(b => b.RemediationRequired).Type<BooleanType>();
            descriptor.Field(b => b.Remediations).Type<ListType<RemediationType>>().UseFiltering();
            descriptor.Field(b => b.Affirmationid).Type<StringType>();
            descriptor.Field(b => b.PreOrderReleaseDate).Type<DateTimeType>();
            descriptor.Field(b => b.MerchandisingTags).Type<ListType<StringType>>();
            descriptor.Field(b => b.FreePlay).Type<FreePlayType>();
            descriptor.Field(b => b.PromotionalDuration).Type<DurationType>();
            descriptor.Field(b => b.EndDate).Type<DateTimeType>();
            descriptor.Field(b => b.Startdate).Type<DateTimeType>();
            descriptor.Field(b => b.PIFilter).Type<PIFilterType>();
            descriptor.Field(b => b.BundleTag).Type<StringType>();
            descriptor.Field(b => b.DisplayRank).Type<IntType>();
            descriptor.Field(b => b.HasXPriceOffer).Type<BooleanType>();
        }
    }
}
