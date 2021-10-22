using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Text.Json;
using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using LPLab06_07.ViewModels;
using System.Globalization;
using System.Windows.Controls;

namespace LPLab06_07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int maxElements = 1024 * 1024;
        private List<ShopElement> list = new List<ShopElement>();
        private List<ShopElement> current = new List<ShopElement>();

        public MainWindow()
        {
            InitializeComponent();
            this.Cursor = new Cursor(@"E:\study\lab4sem\OOP\LPLab06-07\LPLab06-07\Icons\main_cursor.cur");
            DataContext = new ViewModelBase(null);
            LoadFromDisk();
            // ================================================================

            App.LanguageChanged += LanguageChanged;

            CultureInfo currLang = App.Language;

            //Заполняем меню смены языка:
            menuLanguage.Items.Clear();
            foreach (var lang in App.Languages)
            {
                MenuItem menuLang = new MenuItem();
                menuLang.Header = lang.DisplayName;
                menuLang.Tag = lang;
                menuLang.IsChecked = lang.Equals(currLang);
                menuLang.Click += ChangeLanguageClick;
                menuLang.IsChecked = false;
                menuLanguage.Items.Add(menuLang);
            }
        }

        private void LanguageChanged(Object sender, EventArgs e)
        {
            CultureInfo currLang = App.Language;

            //Отмечаем нужный пункт смены языка как выбранный язык
            foreach (MenuItem i in menuLanguage.Items)
            {
                CultureInfo ci = i.Tag as CultureInfo;
                i.IsChecked = ci != null && ci.Equals(currLang);
            }
        }

        private void ChangeLanguageClick(Object sender, EventArgs e)
        {
            MenuItem mi = sender as MenuItem;
            if (mi != null)
            {
                CultureInfo lang = mi.Tag as CultureInfo;
                if (lang != null)
                {
                    App.Language = lang;
                }
            }
        }

        private void LoadData(List<ShopElement> _list)
        {
            this.Content.Children.Clear();
            foreach(ShopElement el in _list)
            {
                this.Content.Children.Add(el.GetElement());
            }
        }

        private void EditLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void EditLabel_Click(object sender, RoutedEventArgs e)
        {
            var win = new AddItemWindow(list);
            win.ShowDialog();

            list = win.GetData();

            LoadData(list);
            SaveToDisk();
        }

        private void SaveToDisk()
        {
            FileStream fs = new FileStream("data.json", FileMode.Create);
            StreamWriter writer = new StreamWriter(fs, Encoding.ASCII);

            if (list.Count > 0)
            {
                writer.Write(JsonSerializer.Serialize<List<ShopElement>>(list));
            }
            writer.Close();
        }

        private void LoadFromDisk()
        {
            List<ShopElement> temp = new List<ShopElement>();

            string jsonInfo = "";
            StreamReader reader;

            if (File.Exists("data.json"))
            {
                jsonInfo = (reader = new StreamReader("data.json")).ReadToEnd();

                if(jsonInfo.Length == 0) { return; }

                try
                {
                    temp = JsonSerializer.Deserialize<List<ShopElement>>(jsonInfo);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Data file has some issues. Data can not be recognized.", "Error.");
                    return;
                }
                finally
                {
                    reader.Close();
                }
            }
            else
            {
                MessageBox.Show("File not found", "File error.");
                return;
            }

            list = temp;

            LoadData(list);
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            //start search panel
            SearchPanel win = new SearchPanel(list);
            win.ShowDialog();

            current = win.GetData();

            LoadData(current);
        }
    }
}
