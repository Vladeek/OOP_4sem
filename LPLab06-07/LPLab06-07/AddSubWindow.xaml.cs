using System;
using System.Collections.Generic;
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
using Microsoft.Win32;

namespace LPLab06_07
{
    /// <summary>
    /// Interaction logic for AddSubWindow.xaml
    /// </summary>
    public partial class AddSubWindow : Window
    {
        private ShopElement newElement = null;
        private bool hasImage = false;
        private string imgPath = "";

        public ShopElement GetData()
        {
            return newElement;
        }

        public AddSubWindow(ShopElement editel = null)
        {
            InitializeComponent();

            this.Cursor = new Cursor(@"E:\study\lab4sem\OOP\LPLab06-07\LPLab06-07\Icons\main_cursor.cur");

            if (editel != null)
            {
                newElement = editel;
                this.Title = "Edit panel";

                SetDefaults();
            }
        }

        private void getfile_button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files(*.png; *.jpeg *.jpg)| *.png; *.jpeg *.jpg";
            ofd.InitialDirectory = @"E:\study\lab4sem\OOP\LPLab06-07\LPLab06-07\Icons\";
            ofd.ShowDialog();

            imgPath = ofd.FileName;
            if (imgPath != "") { hasImage = true; }
            else { hasImage = false; }
        }

        private bool IsValidated()
        {
            bool ri = true;

            if (title_field.Text.Length == 0) { title_field.Background = Brushes.Tomato; ri = false; } else title_field.Background = Brushes.White;
            if (sdesc_field.Text.Length == 0) { sdesc_field.Background = Brushes.Tomato; ri = false; } else sdesc_field.Background = Brushes.White;
            if (fdesc_field.Text.Length == 0) { fdesc_field.Background = Brushes.Tomato; ri = false; } else fdesc_field.Background = Brushes.White;
            if (price_field.Text.Length != 0)
            {
                try
                {
                    if (Convert.ToInt32(price_field.Text) <= 0) throw new Exception();
                    price_field.Background = Brushes.White;
                }
                catch
                {
                    price_field.Background = Brushes.Tomato;
                    ri = false;
                }
            }
            else
            {
                price_field.Background = Brushes.Tomato;
                ri = false;
            }
            if (rates_field.Text.Length != 0)
            {
                try
                {
                    if (Convert.ToDouble(rates_field.Text) <= 0.0 || Convert.ToDouble(rates_field.Text) > 5.0) throw new Exception();
                    rates_field.Background = Brushes.White;
                }
                catch
                {
                    rates_field.Background = Brushes.Tomato;
                    ri = false;
                }
            }
            else
            {
                rates_field.Background = Brushes.Tomato;
                ri = false;
            }
            if (!hasImage)
            {
                getfile_button.Background = Brushes.Tomato;
                ri = false;
            }
            else
            {
                getfile_button.Background = submit_button.Background;
            }
            

            return ri;
        }

        private void submit_button_Click(object sender, RoutedEventArgs e)
        {
            if(IsValidated())
            {
                newElement = new ShopElement(
                        title_field.Text,
                        sdesc_field.Text,
                        fdesc_field.Text,
                        imgPath,
                        Convert.ToInt32(price_field.Text),
                        Convert.ToDouble(rates_field.Text),
                        ShopElement.ShopElementCategory.Others
                    );
                if(consumRB.IsChecked == true) { newElement.Category = ShopElement.ShopElementCategory.Consumables; }
                if(musinstRB.IsChecked == true) { newElement.Category = ShopElement.ShopElementCategory.MusicalIstrument; }
                if(otherRB.IsChecked == true) { newElement.Category = ShopElement.ShopElementCategory.Others; }

                this.Close();
            }
            else
            {
                MessageBox.Show("Please, check all the fields.", "Validation error.");
            }
        }

        private void SetDefaults()
        {
            title_field.Text = newElement.Title;
            sdesc_field.Text = newElement.ShortDescription;
            fdesc_field.Text = newElement.FullDescription;
            price_field.Text = newElement.Price.ToString();
            rates_field.Text = newElement.Rates.ToString();
            imgPath = newElement.ImgPath;
            hasImage = true;
        }
    }
}
