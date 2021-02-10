using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace theslowproject.Localization
{
    public static class theslowprojectLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(theslowprojectConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(theslowprojectLocalizationConfigurer).GetAssembly(),
                        "theslowproject.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
