using System.Configuration;
using System.Windows.Media;
using Infrastructure;

namespace Services.ApplicationSettingsBase
{
    public class SettingsServices : System.Configuration.ApplicationSettingsBase, ISettingsServices
    {
        private string _currentFolder;

        #region constants

        private const string IsAccountantEnabledDefault = "false";

        #endregion

        #region properties

        [UserScopedSetting]
        [DefaultSettingValue("en-US")]
        public string CurrentLanguage
        {
            get => (string)this[nameof(CurrentLanguage)];
            set => this[nameof(CurrentLanguage)] = (string) value;
        }


        [UserScopedSetting]
        [DefaultSettingValue(IsAccountantEnabledDefault)]
        public bool IsAccountantEnabled
        {
            get { return ((bool) this[nameof(IsAccountantEnabled)]); }

            set { this[nameof(IsAccountantEnabled)] = (bool) value; }
        }
        [UserScopedSetting]
        public string CurrentFolderPath
        {
            get => (string)this[nameof(CurrentFolderPath)];
            set => this[nameof(CurrentFolderPath)] = (object)value;
        }

        #endregion
    }
}