using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace LPLab06_07
{
    public sealed class ShopElement
    {
        private string _title;
        private string _shortDescription;
        private string _fullDescription;
        private string _imgPath;
        private int _price;
        private double _rates;
        private ShopElementCategory _category;

        public string Title { get => _title; set => _title = value; }
        public string ShortDescription { get => _shortDescription; set => _shortDescription = value; }
        public string FullDescription { get => _fullDescription; set => _fullDescription = value; }
        public string ImgPath { get => _imgPath; set => _imgPath = value; }
        public int Price { get => _price; set => _price = value; }
        public double Rates { get => _rates; set => _rates = value; }
        public ShopElementCategory Category { get => _category; set => _category = value; }

        public enum ShopElementCategory
        {
            MusicalIstrument,
            Consumables,
            Others
        }

        public ShopElement(string title, string shDesc, string fDesc, string path, int price, double rates, ShopElementCategory cat)
        {
            _title = title;
            _shortDescription = shDesc;
            _fullDescription = fDesc;
            _imgPath = path;
            _price = price;
            _rates = rates;
            _category = cat;
        }

        public ShopElement() { }

        public Border GetElement()
        {
            Border rb = new Border();
            rb.Width = 200;
            rb.Background = new SolidColorBrush(Colors.LightGray);
            rb.Margin = new Thickness(30);
            rb.Padding = new Thickness(20);
            rb.CornerRadius = new System.Windows.CornerRadius(7);

            StackPanel stp = new StackPanel();
            rb.Child = stp;

            Image image = new Image();
            image.Width = 150;
            image.Height = 150;
            image.HorizontalAlignment = HorizontalAlignment.Center;
            image.Source = new BitmapImage(new Uri(_imgPath, UriKind.Absolute));

            Label title = new Label(); // title
            title.FontFamily = new FontFamily("Cardana");
            title.FontSize = 20;
            title.Margin = new Thickness(5);
            title.FontWeight = FontWeights.Bold;
            title.HorizontalAlignment = HorizontalAlignment.Center;
            title.Content = _title;

            TextBlock shDescript = new TextBlock(); // short description
            shDescript.FontFamily = new FontFamily("Cardana");
            shDescript.FontSize = 16;
            shDescript.MaxWidth = 150;
            shDescript.FontWeight = FontWeights.DemiBold;
            shDescript.HorizontalAlignment = HorizontalAlignment.Center;
            shDescript.TextWrapping = TextWrapping.Wrap;
            if(_shortDescription.Length < 20)
                shDescript.Text = _shortDescription;
            else
            {
                shDescript.Text = _shortDescription.Substring(0, 20) + "...";
            }

            TextBlock fDescript = new TextBlock(); // full description
            fDescript.FontFamily = new FontFamily("Cardana");
            fDescript.FontSize = 12;
            fDescript.TextWrapping = TextWrapping.Wrap;
            fDescript.FontWeight = FontWeights.Light;
            fDescript.FontStyle = FontStyles.Italic;
            fDescript.HorizontalAlignment = HorizontalAlignment.Center;
            if (_fullDescription.Length < 40)
                fDescript.Text = _fullDescription;
            else
            {
                fDescript.Text = _fullDescription.Substring(0, 40) + "...";
            }

            Label ratesLabel = new Label();
            ratesLabel.Content = "Rates: " + Math.Round(_rates, 2);
            ratesLabel.FontFamily = new FontFamily("Cardana");
            ratesLabel.FontSize = 12;
            ratesLabel.Margin = new Thickness(5);
            ratesLabel.FontWeight = FontWeights.Bold;
            ratesLabel.HorizontalAlignment = HorizontalAlignment.Center;

            ProgressBar ratesPBar = new ProgressBar();
            ratesPBar.Width = 150;
            ratesPBar.Maximum = 5.0;
            ratesPBar.Value = _rates;
            if(_rates >= 4.0) ratesPBar.Foreground = Brushes.LimeGreen;
            else
                if(_rates >= 2.5) ratesPBar.Foreground = Brushes.Orange;
            else ratesPBar.Foreground = Brushes.Red;

            Label priceLabel = new Label();
            priceLabel.Content = "Br " + _price;
            priceLabel.FontFamily = new FontFamily("Cardana");
            priceLabel.FontSize = 16;
            priceLabel.Margin = new Thickness(5);
            priceLabel.FontWeight = FontWeights.Regular;
            priceLabel.HorizontalAlignment = HorizontalAlignment.Center;

            stp.Children.Add(image);
            stp.Children.Add(title);
            stp.Children.Add(shDescript);
            stp.Children.Add(fDescript);
            stp.Children.Add(ratesLabel);
            stp.Children.Add(ratesPBar);
            stp.Children.Add(priceLabel);

            
            
            return rb;
        }
    }
}
