using ProductReviews.Service;
using Products.Service.Contracts;
using Products.Service.GraphQL.Types;

namespace Products.Service
{
    public class ProductContractType : ObjectType<ProductContract>
    {
        protected override void Configure(IObjectTypeDescriptor<ProductContract> descriptor)
        {
            descriptor.BindFieldsExplicitly();
            
            descriptor.Field(b => b.ProductId).Type<StringType>();
            descriptor.Field(b => b.ProductTitle).Type<StringType>();
            descriptor.Field(b => b.ProductKind).Type<StringType>();
            descriptor.Field(b => b.ProductFamily).Type<StringType>();
            descriptor.Field(b => b.ShortDescription).Type<StringType>();
            descriptor.Field(b => b.ShortTitle).Type<StringType>();
            descriptor.Field(b => b.PreferredSkuId).Type<StringType>();
            descriptor.Field(b => b.Images).Type<ListType<ImageType>>().UseFiltering();
            descriptor.Field(b => b.AlternateIds).Type<ListType<AlternateIdType>>().UseFiltering();
            descriptor.Field(b => b.DeveloperName).Type<StringType>();
            descriptor.Field(b => b.SupportUri).Type<StringType>();
            descriptor.Field(b => b.PublisherWebsiteUri).Type<StringType>();
            descriptor.Field(b => b.PublisherName).Type<StringType>();
            descriptor.Field(b => b.ProductDescription).Type<StringType>();
            descriptor.Field(b => b.Category).Type<StringType>();
            descriptor.Field(b => b.HasAddOns).Type<BooleanType>();
            descriptor.Field(b => b.ReleaseDate).Type<StringType>();
            descriptor.Field(b => b.PackageFamilyName).Type<StringType>(); 
            descriptor.Field(b => b.Videos).Type<ListType<VideoType>>().UseFiltering();
            descriptor.Field(b => b.BundleConfig).Type<ListType<BundleConfigType>>().UseFiltering();
            descriptor.Field(b => b.AverageRating).Type<FloatType>();
            descriptor.Field(b => b.RatingCount).Type<IntType>();
            descriptor.Field(b => b.ContentRating).Type<ContentRatingType>().UseFiltering();
            descriptor.Field(b => b.EligibilityProperties).Type<EligibilityPropertiesType>().UseFiltering();
            descriptor.Field(b => b.HardwareRequirements).Type<HardwareRequirementsType>().UseFiltering();
            //descriptor.Field(b => b.SkuAvailabilities).Type<ListType<SkuAvailabilityType>>().UseFiltering();
            descriptor.Field(b => b.IncludedWithPassesProductIds).Type<ListType<StringType>>();
            descriptor.Field(b => b.Categories).Type<ListType<StringType>>();
            descriptor.Field(b => b.Capabilities).Type<ListType<CapabilityType>>();
            descriptor.Field(b => b.IsDownloadable).Type<BooleanType>();
            //descriptor.Field(b => b.MaxInstallSize).Type<NonNullType<UnsignedLongType>>();
            descriptor.Field(b => b.PackageCapabilities);
            descriptor.Field(b => b.Properties).Type<ProductPropertiesType>();
            descriptor.Field(b => b.RelatedProducts).UseFiltering();
            descriptor.Field(b => b.SpecificPrices).Type<SpecificPricesType>();
            descriptor.Field(b => b.MovieProperties).Type<MoviePropertiesType>();
            descriptor.Field(b => b.TvProperties).Type<TvPropertiesType>();
            descriptor.Field(b => b.HardwareProperties).Type<HardwarePropertiesType>();
            descriptor.Field(b => b.IsPreOrder).Type<BooleanType>();
            descriptor.Field(b => b.Badges).Type<ListType<BadgeClassType>>();
            descriptor.Field(b => b.Editions).Type<ListType<StringType>>();
            descriptor.Field(b => b.BundlesBySeed).Type<ListType<StringType>>();
            descriptor.Field(b => b.AvailableOn).Type<ListType<StringType>>();
            descriptor.Field(b => b.GenericMetadata).Type<GenericMetadataType>();
            descriptor.Field(b => b.IsBaseGameFree).Type<BooleanType>();
            descriptor.Field(b => b.XCloudProperties).Type<XCloudPropertiesType>();
            descriptor.Field(b => b.PublisherId).Type<StringType>();

        }
    }
}
