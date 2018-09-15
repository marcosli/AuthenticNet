using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ML.AuthenticNet.Localization
{
    public static class AuthenticNetLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AuthenticNetConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AuthenticNetLocalizationConfigurer).GetAssembly(),
                        "ML.AuthenticNet.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
