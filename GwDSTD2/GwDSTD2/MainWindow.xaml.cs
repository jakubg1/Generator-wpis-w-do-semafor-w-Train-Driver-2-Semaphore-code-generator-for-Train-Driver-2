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
        public MainWindow()
        {
            InitializeComponent();
            Closing += OnClosing;
        }

        internal void OnClosing(object sender, CancelEventArgs e)
        {
            //Properties.Settings.Default.Language = this.Height;


            //save all settings to file
            Properties.Settings.Default.Save();
        }

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
    }
}
