using System.Collections.Generic;

namespace Infrastructure
{
    public static class Languages
    {
        public static List<Language> LanguagesCollection { get; }

        static Languages()
        {
            LanguagesCollection = GetListLanguages();
            //BaseColors = GetListBaseColor();
        }

        private static List<Language> GetListLanguages()
        {
            return new List<Language>()
            {
                GetEnglishLanguage(),
                GetUkraineLanguage()
            };
        }

        private static Language GetEnglishLanguage()
        {
            return new Language("ENG", "en-US");
        }

        private static Language GetUkraineLanguage()
        {
            return new Language("Укр", "uk-UA");
        }
    }
}