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

        #region counters and variables

        // wpisywanie wartości
        private string debug;

        // typ semafora
        // 0 - semafor
        // 1 - tarcza ostrzegawcza
        // 2 - powtarzacz
        // 3 - tarcza manewrowa
        // 4 - semafor SBL
        private int typsemafora;

        // kolejność powtarzacza
        // 0 - ISp
        // 1 - IISp
        // 2 - IIISp
        private int kolejnoscpowtarzacza;

        // odchylenie semafora
        // -1 - semafor karzełkowy
        // 0 - lewo
        // 1 - prosto
        // 2 - prawo
        private int odchylsemafora;

        // miejsce wstawienia kodu
        // 0 - notatnik
        // 1 - edytor
        private int wst;

        // wskaźniki
        private bool w1;
        private bool w18;
        private bool w19;
        private bool w20;
        private bool w24;

        // opcje dodatkowe
        private bool uniew;

        // pasy
        private bool ppom;
        private bool pziel;

        // komory
        // 0 - brak
        // 1 - niebieska
        // 2 - zielona
        // 3 - pomarańczowa - odn. do n. sem.
        // 4 - pomarańczowa - ograniczenie prędkości
        // 5 - czerwona
        // 6 - biała
        private int komora1;
        private int komora2;
        private int komora3;
        private int komora4;
        private int komora5;

        // ilość komór
        private int ilosckomor;

        //predkosci na semaforach
        private bool predkosc40;
        private bool predkosc60;
        private bool predkosc100;
        private bool predkosc40na60;
        private bool predkosc100naVmax;
        private bool komoraBiala;

        // zmienna przechowująca kod
        private string kod;

        #endregion

        #region window events, constructor

        public MainWindow()
        {

            typsemafora = 0;
            kolejnoscpowtarzacza = 0;
            odchylsemafora = 0;
            wst = 0;
            w1 = false;
            w18 = false;
            w19 = false;
            w20 = false;
            w24 = false;
            uniew = false;
            ppom = false;
            pziel = false;
            komora1 = 0;
            komora2 = 0;
            komora3 = 0;
            komora4 = 0;
            komora5 = 0;
            predkosc40 = false;
            predkosc60 = false;
            predkosc100 = false;
            predkosc40na60 = false;
            predkosc100naVmax = false;
            komoraBiala = false;
            kod = "";

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

            typsemafora = 0;
        }

        private void MenuSettingsSemaphoreTypeRepeater_Click(object sender, RoutedEventArgs e)
        {
            MenuSettingsSemaphoreTypeRepeater.IsChecked = MenuSettingsSemaphoreTypeRepeater.IsChecked;
            MenuSettingsSemaphoreTypeSblSemaphore.IsChecked = !MenuSettingsSemaphoreTypeRepeater.IsChecked;
            MenuSettingsSemaphoreTypeNormalSemaphore.IsChecked = !MenuSettingsSemaphoreTypeRepeater.IsChecked;
            MenuSettingsSemaphoreTypeManeuverShield.IsChecked = !MenuSettingsSemaphoreTypeRepeater.IsChecked;
            MenuSettingsSemaphoreTypeWarningShield.IsChecked = !MenuSettingsSemaphoreTypeRepeater.IsChecked;

            typsemafora = 1;
        }

        private void MenuSettingsSemaphoreTypeNormalSemaphore_Click(object sender, RoutedEventArgs e)
        {
            MenuSettingsSemaphoreTypeNormalSemaphore.IsChecked = MenuSettingsSemaphoreTypeNormalSemaphore.IsChecked;
            MenuSettingsSemaphoreTypeRepeater.IsChecked = !MenuSettingsSemaphoreTypeNormalSemaphore.IsChecked;
            MenuSettingsSemaphoreTypeSblSemaphore.IsChecked = !MenuSettingsSemaphoreTypeNormalSemaphore.IsChecked;
            MenuSettingsSemaphoreTypeManeuverShield.IsChecked = !MenuSettingsSemaphoreTypeNormalSemaphore.IsChecked;
            MenuSettingsSemaphoreTypeWarningShield.IsChecked = !MenuSettingsSemaphoreTypeNormalSemaphore.IsChecked;

            typsemafora = 2;
        }

        private void MenuSettingsSemaphoreTypeManeuverShield_Click(object sender, RoutedEventArgs e)
        {
            MenuSettingsSemaphoreTypeManeuverShield.IsChecked = MenuSettingsSemaphoreTypeManeuverShield.IsChecked;
            MenuSettingsSemaphoreTypeRepeater.IsChecked = !MenuSettingsSemaphoreTypeManeuverShield.IsChecked;
            MenuSettingsSemaphoreTypeNormalSemaphore.IsChecked = !MenuSettingsSemaphoreTypeManeuverShield.IsChecked;
            MenuSettingsSemaphoreTypeSblSemaphore.IsChecked = !MenuSettingsSemaphoreTypeManeuverShield.IsChecked;
            MenuSettingsSemaphoreTypeWarningShield.IsChecked = !MenuSettingsSemaphoreTypeManeuverShield.IsChecked;

            typsemafora = 3;
        }

        private void MenuSettingsSemaphoreTypeWarningShield_Click(object sender, RoutedEventArgs e)
        {
            MenuSettingsSemaphoreTypeWarningShield.IsChecked = MenuSettingsSemaphoreTypeWarningShield.IsChecked;
            MenuSettingsSemaphoreTypeRepeater.IsChecked = !MenuSettingsSemaphoreTypeWarningShield.IsChecked;
            MenuSettingsSemaphoreTypeNormalSemaphore.IsChecked = !MenuSettingsSemaphoreTypeWarningShield.IsChecked;
            MenuSettingsSemaphoreTypeManeuverShield.IsChecked = !MenuSettingsSemaphoreTypeWarningShield.IsChecked;
            MenuSettingsSemaphoreTypeSblSemaphore.IsChecked = !MenuSettingsSemaphoreTypeWarningShield.IsChecked;

            typsemafora = 4;
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
            MessageBox.Show("Help...");
        }

        private void MenuAboutAuthors_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("About...");
        }

        private void MenuAboutVersion_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Version...");
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
