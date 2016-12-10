using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            Closing += OnClosing;
        }

        internal void OnClosing(object sender, CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(Application.Current.Resources["DialogExitQuestion"].ToString(),
                Application.Current.Resources["DialogExitQuestion"].ToString(), MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (result == MessageBoxResult.Yes)
            {
                e.Cancel = false;
                Properties.Settings.Default.Save();
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
        }

        private void MenuSettingsLanguageEnglish_Click(object sender, RoutedEventArgs e)
        {
            MenuSettingsLanguageEnglish.IsChecked = MenuSettingsLanguagePolish.IsChecked;
            MenuSettingsLanguagePolish.IsChecked = !MenuSettingsLanguagePolish.IsChecked;
            ResourceDictionary dictionary = new ResourceDictionary();
            dictionary.Source = new Uri("Resources/EnglishDictionary.xaml", UriKind.Relative);
            this.Resources.MergedDictionaries.Add(dictionary);
        }

        private void MenuSettingsCodeDestinationEditor_Click(object sender, RoutedEventArgs e)
        {
            MenuSettingsCodeDestinationEditor.IsChecked = MenuSettingsCodeDestinationFile.IsChecked;
            MenuSettingsCodeDestinationFile.IsChecked = !MenuSettingsCodeDestinationFile.IsChecked;
        }

        private void MenuSettingsCodeDestinationFile_Click(object sender, RoutedEventArgs e)
        {
            MenuSettingsCodeDestinationFile.IsChecked = MenuSettingsCodeDestinationEditor.IsChecked;
            MenuSettingsCodeDestinationEditor.IsChecked = !MenuSettingsCodeDestinationEditor.IsChecked;
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
    }
}
