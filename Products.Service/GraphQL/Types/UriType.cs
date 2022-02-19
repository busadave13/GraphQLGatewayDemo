namespace Products.Service.GraphQL.Types
{
    public class UriType : ObjectType<Uri>
    {
        protected override void Configure(IObjectTypeDescriptor<Uri> descriptor)
        {
            descriptor.BindFieldsExplicitly();

            descriptor.Field(b => b.AbsoluteUri).Type<StringType>();
            descriptor.Field(b => b.Host).Type<StringType>();
            descriptor.Field(b => b.Scheme).Type<StringType>();
            descriptor.Field(b => b.Port).Type<IntType>();
            descriptor.Field(b => b.PathAndQuery).Type<StringType>();
            descriptor.Field(b => b.AbsolutePath).Type<StringType>();
        }
    }
}
