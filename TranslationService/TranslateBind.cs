using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Translations
{
    public class TranslateBind : INotifyPropertyChanged
    {
        public static TranslateBind Instance
        {
            get;
        } = new TranslateBind();

        public string this[string key]
        {
            get
            {
                if (currentCulture.TwoLetterISOLanguageName.ToLower() == "de")
                    return "JA";
                else if (currentCulture.TwoLetterISOLanguageName.ToLower() == "en")
                    return "YES";
                else
                    return "wtf?";
            }
        }

        private CultureInfo currentCulture = CultureInfo.InstalledUICulture;
        public CultureInfo CurrentCulture
        {
            get { return currentCulture; }
            set
            {
                if (currentCulture != value)
                {
                    currentCulture = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
