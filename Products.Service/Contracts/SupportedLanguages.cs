namespace Products.Service.Contracts
{
    public class SupportedLanguages
    {
        public IDictionary<string, GenericMetadataStatusEnum> InterfaceLanguageSupported { get; set; }
        public IDictionary<string, GenericMetadataStatusEnum> GamePlayAudioLanguageSupported { get; set; }
        public IDictionary<string, GenericMetadataStatusEnum> SubtitlesLanguageSupported { get; set; }
        public GenericMetadataStatusEnum SupportedLanguageDisclaimer { get; set; }
    }
}