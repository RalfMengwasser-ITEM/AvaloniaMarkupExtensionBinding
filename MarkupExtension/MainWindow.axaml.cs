using Avalonia.Controls;
using Translations;

namespace MarkupExtension
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void SelectedLanguageChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                string twoletter = (e.AddedItems[0] as ComboBoxItem).Tag.ToString();

                if (twoletter == "de")
                {
                    TranslateBind.Instance.CurrentCulture = new System.Globalization.CultureInfo("de");
                }
                else
                {
                    TranslateBind.Instance.CurrentCulture = new System.Globalization.CultureInfo("en");
                }
            }
        }

    }
}
