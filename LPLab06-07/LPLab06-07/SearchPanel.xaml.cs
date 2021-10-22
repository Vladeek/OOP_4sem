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
using System.Linq;

namespace LPLab06_07
{
    /// <summary>
    /// Interaction logic for SearchPanel.xaml
    /// </summary>
    public partial class SearchPanel : Window
    {
        private List<ShopElement> selection;
        
        public List<ShopElement> GetData()
        {
            return selection;
        }

        public SearchPanel(List<ShopElement> _list)
        {
            InitializeComponent();

            this.Cursor = new Cursor(@"E:\study\lab4sem\OOP\LPLab06-07\LPLab06-07\Icons\main_cursor.cur");

            selection = new List<ShopElement>();

            foreach(ShopElement el in _list)
            {
                selection.Add(el);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var curSel = selection.Select(el => el).Where((el) => true);

            if(context_field.Text.Length > 0)
            {
                curSel = curSel.Where((el) => {
                    return 
                    el.Title.ToLower().Contains(context_field.Text.ToLower()) ||
                    el.ShortDescription.ToLower().Contains(context_field.Text.ToLower()) ||
                    el.FullDescription.ToLower().Contains(context_field.Text.ToLower());
                });
                selection = new List<ShopElement>(curSel);
                curSel = selection.Select(el => el).Where((el) => true);
            }

            ShopElement.ShopElementCategory? cat = null;
            if (consumRB.IsChecked == true) { cat = ShopElement.ShopElementCategory.Consumables; }
            if (musinstRB.IsChecked == true) { cat = ShopElement.ShopElementCategory.MusicalIstrument; }
            if (otherRB.IsChecked == true) { cat = ShopElement.ShopElementCategory.Others; }
            if(cat != null)
            {
                curSel = curSel.Where((el) => el.Category == cat);

                selection = new List<ShopElement>(curSel);
                curSel = selection.Select(el => el).Where((el) => true);
            }

            if(from_field.Text.Length > 0)
            {
                int from;
                if(Int32.TryParse(from_field.Text, out from))
                {
                    curSel = curSel.Where((el => el.Price >= from));

                    selection = new List<ShopElement>(curSel);
                    curSel = selection.Select(el => el).Where((el) => true);
                }
            }

            if(to_field.Text.Length > 0)
            {
                int to;
                if(Int32.TryParse(to_field.Text, out to))
                {
                    curSel = curSel.Where(el => el.Price <= to);

                    selection = new List<ShopElement>(curSel);
                    curSel = selection.Select(el => el).Where((el) => true);
                }
            }

            if (curSel.Count() > 0)
            {
                selection = new List<ShopElement>(curSel);
            }

            this.Close();
        }
    }
}
