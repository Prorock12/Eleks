using Prism.Mvvm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Infrastructure
{
    public class NotifyDataErrorViewModelBase : BindableBase, INotifyDataErrorInfo
    {
        #region INotifyDataErrorInfo

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        #endregion INotifyDataErrorInfo

        #region INotifyDataInfo

        private Dictionary<string, List<string>> propErrors = new Dictionary<string, List<string>>();

        public bool HasErrors
        {
            get
            {
                try
                {
                    var propErrorsCount = propErrors.Values.FirstOrDefault(x => x.Count > 0);
                    if (propErrorsCount != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch
                {
                    return true;
                }
            }
        }

        #endregion INotifyDataInfo

        public IEnumerable GetErrors(string propertyName)
        {
            return propErrors.ContainsKey(propertyName) ? propErrors[propertyName] : null;
        }

        public void ValidateBorderThickness(int prop, [CallerMemberName] string propertyName = null)
        {
            ClearErrors(propertyName);
            if (prop < 10 || prop > 20)
                AddError(propertyName, "BorderThickness properties must be between 10 and 20");
        }

        public void ValidateCornerRadius(int prop, [CallerMemberName] string propertyName = null)
        {
            ClearErrors(propertyName);
            if (prop < 10 || prop > 20)
                AddError(propertyName, "CornerRadius properties must be between 10 and 20");
        }

        public void ValidatePadding(int prop, [CallerMemberName] string propertyName = null)
        {
            ClearErrors(propertyName);
            if (prop < 10 || prop > 20)
                AddError(propertyName, "Padding properties must be between 10 and 20");
        }

        private void AddError(string propertyName, string error)
        {
            if (!propErrors.ContainsKey(propertyName))
                propErrors[propertyName] = new List<string>();

            if (!propErrors[propertyName].Contains(error))
            {
                propErrors[propertyName].Add(error);
                OnErrorsChanged(propertyName);
            }
        }

        private void ClearErrors(string propertyName)
        {
            if (propErrors.ContainsKey(propertyName))
            {
                propErrors.Remove(propertyName);
                OnErrorsChanged(propertyName);
            }
        }

        private void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }
    }
}