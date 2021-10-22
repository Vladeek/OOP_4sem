using LPLab06_07.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace LPLab06_07
{
    /// <summary>
    /// Interaction logic for AddItemWindow.xaml
    /// </summary>
    public partial class AddItemWindow : Window
    {
        ShopElement selectedElement = null;
        List<ShopElement> list;
        ObservableCollection<ShopElement> obs = new ObservableCollection<ShopElement>();

        public List<ShopElement> GetData()
        {
            list.Clear();
            foreach(ShopElement el in obs)
            {
                list.Add(el);
            }

            return list;
        }

        public AddItemWindow(List<ShopElement> _list)
        {
            InitializeComponent();

            this.Cursor = new Cursor(@"E:\study\lab4sem\OOP\LPLab06-07\LPLab06-07\Icons\main_cursor.cur");

            list = _list;
            foreach(ShopElement el in list)
            {
                obs.Add(el);
            }

            listBox.ItemsSource = obs;
            DataContext = new ViewModelBase(obs);
            obs.CollectionChanged += (sender, args) =>
            {
                DeleteElementButton.IsEnabled = false;
                EditElementButton.IsEnabled = false;
            };
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                selectedElement = (ShopElement)listBox.SelectedItem;

                EditElementButton.IsEnabled = true;
                DeleteElementButton.IsEnabled = true;
            }
        }
    }
}
