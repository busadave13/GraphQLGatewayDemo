using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class SkuType : ObjectType<Sku>
    {
        protected override void Configure(IObjectTypeDescriptor<Sku> descriptor)
        {
            descriptor.BindFieldsExplicitly();
            
            descriptor.Field(b => b.AdditionalLicenseTerms).Type<StringType>();
            descriptor.Field(b => b.BundledSkus).Type<ListType<BundledSkuType>>().UseFiltering();
            descriptor.Field(b => b.Copyright).Type<StringType>();
            descriptor.Field(b => b.Features).Type<ListType<StringType>>();
            descriptor.Field(b => b.FirstAvailableDate).Type<StringType>();
            descriptor.Field(b => b.FulfillmentType).Type<StringType>();
            descriptor.Field(b => b.Images).Type<ListType<ImageType>>().UseFiltering();
            descriptor.Field(b => b.InstallationTerms).Type<StringType>();
            descriptor.Field(b => b.InventoryControlSkuId).Type<StringType>();
            descriptor.Field(b => b.IsPreOrder).Type<BooleanType>();
            descriptor.Field(b => b.IsRepurchasable).Type<BooleanType>();
            descriptor.Field(b => b.Languages).Type<StringType>();
            //descriptor.Field(b => b.MaxDownloadSizeInBytes).Type<UnsignedLongType>();
            //descriptor.Field(b => b.MaxInstallSizeInBytes).Type<UnsignedLongType>();
            descriptor.Field(b => b.Packages).Type<ListType<PackageType>>().UseFiltering();
            descriptor.Field(b => b.PrivacyPolicyUri).Type<StringType>();
            descriptor.Field(b => b.RecurrencePolicy).Type<RecurrencePolicyType>();
            descriptor.Field(b => b.ReleaseNotes).Type<StringType>();
            descriptor.Field(b => b.SkuDescription).Type<StringType>();
            descriptor.Field(b => b.SkuMovieProperties).Type<SkuMoviePropertiesType>();
            descriptor.Field(b => b.SkuId).Type<StringType>();
            descriptor.Field(b => b.SkuTitle).Type<StringType>();
            descriptor.Field(b => b.SkuButtonTitle).Type<StringType>();
            descriptor.Field(b => b.SkuType).Type<StringType>();
            descriptor.Field(b => b.MaxAllowedQuantity).Type<IntType>();
            descriptor.Field(b => b.MinAllowedQuantity).Type<IntType>();
        }
    }
}
