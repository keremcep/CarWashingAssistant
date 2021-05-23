using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace CarWashingAssistant.Localization
{
    public static class CarWashingAssistantLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(CarWashingAssistantConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(CarWashingAssistantLocalizationConfigurer).GetAssembly(),
                        "CarWashingAssistant.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
