using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GwDSTD2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        #region variables

        #endregion

        #region window events, constructor

        public MainWindow()
        {
            InitializeComponent();
            LoadUserSettings();
            Closing += OnClosing;
        }

        private void LoadUserSettings()
        {
            string language = Properties.UserSettings.Default.Language;
            string generateCodeType = Properties.UserSettings.Default.GenerateCodeType;

            if (language.Equals("Polish"))
            {
                MenuSettingsLanguagePolish.IsChecked = true;
                MenuSettingsLanguageEnglish.IsChecked = !MenuSettingsLanguagePolish.IsChecked;
                ResourceDictionary dictionary = new ResourceDictionary();
                dictionary.Source = new Uri("Resources/PolishDictionary.xaml", UriKind.Relative);
                this.Resources.MergedDictionaries.Add(dictionary);
            }
            else if (language.Equals("English"))
            {
                MenuSettingsLanguageEnglish.IsChecked = true;
                MenuSettingsLanguagePolish.IsChecked = !MenuSettingsLanguageEnglish.IsChecked;
                ResourceDictionary dictionary = new ResourceDictionary();
                dictionary.Source = new Uri("Resources/EnglishDictionary.xaml", UriKind.Relative);
                this.Resources.MergedDictionaries.Add(dictionary);
            }

            if (generateCodeType.Equals("Editor"))
            {
                MenuSettingsCodeDestinationEditor.IsChecked = true;
                MenuSettingsCodeDestinationFile.IsChecked = !MenuSettingsCodeDestinationEditor.IsChecked;
            }
            else if (generateCodeType.Equals("File"))
            {
                MenuSettingsCodeDestinationFile.IsChecked = true;
                MenuSettingsCodeDestinationEditor.IsChecked = !MenuSettingsCodeDestinationFile.IsChecked;
            }
        }

        internal void OnClosing(object sender, CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(Application.Current.Resources["DialogExitQuestion"].ToString(),
                Application.Current.Resources["DialogExitQuestion"].ToString(), MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (result == MessageBoxResult.Yes)
            {
                e.Cancel = false;
                Properties.UserSettings.Default.Save();
            }
            else
            {
                e.Cancel = true;
            }
        }

        #endregion

        #region menu events

        private void MenuSettingsLanguagePolish_Click(object sender, RoutedEventArgs e)
        {
            MenuSettingsLanguagePolish.IsChecked = MenuSettingsLanguageEnglish.IsChecked;
            MenuSettingsLanguageEnglish.IsChecked = !MenuSettingsLanguageEnglish.IsChecked;
            ResourceDictionary dictionary = new ResourceDictionary();
            dictionary.Source = new Uri("Resources/PolishDictionary.xaml", UriKind.Relative);
            this.Resources.MergedDictionaries.Add(dictionary);
            Properties.UserSettings.Default.Language = "Polish";
        }

        private void MenuSettingsLanguageEnglish_Click(object sender, RoutedEventArgs e)
        {
            MenuSettingsLanguageEnglish.IsChecked = MenuSettingsLanguagePolish.IsChecked;
            MenuSettingsLanguagePolish.IsChecked = !MenuSettingsLanguagePolish.IsChecked;
            ResourceDictionary dictionary = new ResourceDictionary();
            dictionary.Source = new Uri("Resources/EnglishDictionary.xaml", UriKind.Relative);
            this.Resources.MergedDictionaries.Add(dictionary);
            Properties.UserSettings.Default.Language = "English";
        }

        private void MenuSettingsCodeDestinationEditor_Click(object sender, RoutedEventArgs e)
        {
            MenuSettingsCodeDestinationEditor.IsChecked = MenuSettingsCodeDestinationFile.IsChecked;
            MenuSettingsCodeDestinationFile.IsChecked = !MenuSettingsCodeDestinationFile.IsChecked;
            Properties.UserSettings.Default.GenerateCodeType = "Editor";
        }

        private void MenuSettingsCodeDestinationFile_Click(object sender, RoutedEventArgs e)
        {
            MenuSettingsCodeDestinationFile.IsChecked = MenuSettingsCodeDestinationEditor.IsChecked;
            MenuSettingsCodeDestinationEditor.IsChecked = !MenuSettingsCodeDestinationEditor.IsChecked;
            Properties.UserSettings.Default.GenerateCodeType = "File";
        }

        private void MenuSettingsSemaphoreTypeSblSemaphore_Click(object sender, RoutedEventArgs e)
        {
            MenuSettingsSemaphoreTypeSblSemaphore.IsChecked = MenuSettingsSemaphoreTypeSblSemaphore.IsChecked;
            MenuSettingsSemaphoreTypeRepeater.IsChecked = !MenuSettingsSemaphoreTypeSblSemaphore.IsChecked;
            MenuSettingsSemaphoreTypeNormalSemaphore.IsChecked = !MenuSettingsSemaphoreTypeSblSemaphore.IsChecked;
            MenuSettingsSemaphoreTypeManeuverShield.IsChecked = !MenuSettingsSemaphoreTypeSblSemaphore.IsChecked;
            MenuSettingsSemaphoreTypeWarningShield.IsChecked = !MenuSettingsSemaphoreTypeSblSemaphore.IsChecked;
        }

        private void MenuSettingsSemaphoreTypeRepeater_Click(object sender, RoutedEventArgs e)
        {
            MenuSettingsSemaphoreTypeRepeater.IsChecked = MenuSettingsSemaphoreTypeRepeater.IsChecked;
            MenuSettingsSemaphoreTypeSblSemaphore.IsChecked = !MenuSettingsSemaphoreTypeRepeater.IsChecked;
            MenuSettingsSemaphoreTypeNormalSemaphore.IsChecked = !MenuSettingsSemaphoreTypeRepeater.IsChecked;
            MenuSettingsSemaphoreTypeManeuverShield.IsChecked = !MenuSettingsSemaphoreTypeRepeater.IsChecked;
            MenuSettingsSemaphoreTypeWarningShield.IsChecked = !MenuSettingsSemaphoreTypeRepeater.IsChecked;
        }

        private void MenuSettingsSemaphoreTypeNormalSemaphore_Click(object sender, RoutedEventArgs e)
        {
            MenuSettingsSemaphoreTypeNormalSemaphore.IsChecked = MenuSettingsSemaphoreTypeNormalSemaphore.IsChecked;
            MenuSettingsSemaphoreTypeRepeater.IsChecked = !MenuSettingsSemaphoreTypeNormalSemaphore.IsChecked;
            MenuSettingsSemaphoreTypeSblSemaphore.IsChecked = !MenuSettingsSemaphoreTypeNormalSemaphore.IsChecked;
            MenuSettingsSemaphoreTypeManeuverShield.IsChecked = !MenuSettingsSemaphoreTypeNormalSemaphore.IsChecked;
            MenuSettingsSemaphoreTypeWarningShield.IsChecked = !MenuSettingsSemaphoreTypeNormalSemaphore.IsChecked;
        }

        private void MenuSettingsSemaphoreTypeManeuverShield_Click(object sender, RoutedEventArgs e)
        {
            MenuSettingsSemaphoreTypeManeuverShield.IsChecked = MenuSettingsSemaphoreTypeManeuverShield.IsChecked;
            MenuSettingsSemaphoreTypeRepeater.IsChecked = !MenuSettingsSemaphoreTypeManeuverShield.IsChecked;
            MenuSettingsSemaphoreTypeNormalSemaphore.IsChecked = !MenuSettingsSemaphoreTypeManeuverShield.IsChecked;
            MenuSettingsSemaphoreTypeSblSemaphore.IsChecked = !MenuSettingsSemaphoreTypeManeuverShield.IsChecked;
            MenuSettingsSemaphoreTypeWarningShield.IsChecked = !MenuSettingsSemaphoreTypeManeuverShield.IsChecked;
        }

        private void MenuSettingsSemaphoreTypeWarningShield_Click(object sender, RoutedEventArgs e)
        {
            MenuSettingsSemaphoreTypeWarningShield.IsChecked = MenuSettingsSemaphoreTypeWarningShield.IsChecked;
            MenuSettingsSemaphoreTypeRepeater.IsChecked = !MenuSettingsSemaphoreTypeWarningShield.IsChecked;
            MenuSettingsSemaphoreTypeNormalSemaphore.IsChecked = !MenuSettingsSemaphoreTypeWarningShield.IsChecked;
            MenuSettingsSemaphoreTypeManeuverShield.IsChecked = !MenuSettingsSemaphoreTypeWarningShield.IsChecked;
            MenuSettingsSemaphoreTypeSblSemaphore.IsChecked = !MenuSettingsSemaphoreTypeWarningShield.IsChecked;
        }

        private void MenuFileOpen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuFileSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuFileReset_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuFileExit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuAboutAuthors_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuAboutVersion_Click(object sender, RoutedEventArgs e)
        {

        }

        #endregion

        private void MenuDebug_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Ścieżka pliku konfiguracyjnego\n" + ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath);
            MessageBox.Show(sb.ToString());
        }
    }
}
