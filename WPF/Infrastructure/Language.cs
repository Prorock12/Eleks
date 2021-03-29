namespace Infrastructure
{
    public class Language
    {
        public string Name { get; }
        public string Culture { get; }

        public Language(string name, string culture)
        {
            Name = name;
            Culture = culture;
        }
    }
}