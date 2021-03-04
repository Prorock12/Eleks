using System.Configuration;
using System.Windows.Media;
using Infrastructure;

namespace Services.ApplicationSettingsBase
{
    public class SettingsServices : System.Configuration.ApplicationSettingsBase, ISettingsServices
    {
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

        #endregion
    }
}