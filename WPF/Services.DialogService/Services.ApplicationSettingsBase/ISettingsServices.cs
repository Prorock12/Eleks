namespace Services.ApplicationSettingsBase
{
    public interface ISettingsServices
    {
        //Language GetLanguage();
        //void SetLanguage(Language language);
        string CurrentLanguage { get; set; }

        string CurrentFolderPath { get; set; }
    }
}