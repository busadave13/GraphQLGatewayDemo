using Products.Service.Contracts;

namespace Products.Service.GraphQL.Types
{
    public class InclusionType : ObjectType<Inclusion>
    {
        protected override void Configure(IObjectTypeDescriptor<Inclusion> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.Approachability).Type<GenericMetadataStatusEnumType>();
            descriptor.Field(b => b.Globalization).Type<GlobalizationType>();
            descriptor.Field(b => b.Representation);
            descriptor.Field(b => b.GamingAwards);
            descriptor.Field(b => b.MainCharacterRepresentation);
            descriptor.Field(b => b.PlayerExpression);
        }
    }
}
