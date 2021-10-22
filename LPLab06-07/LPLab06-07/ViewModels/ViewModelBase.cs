using LPLab06_07.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPLab06_07.ViewModels
{
    public class ViewModelBase
    {
        public AddElementCommand AddElementCommand { get; private set; }
        public DeleteElementCommand DeleteElementCommand { get; private set; }
        public EditElementCommand EditElementCommand { get; private set; }

        ObservableCollection<ShopElement> _list;

        public ViewModelBase(ObservableCollection<ShopElement> list)
        {
            _list = list;
            AddElementCommand = new AddElementCommand(AddNewElement);
            DeleteElementCommand = new DeleteElementCommand(DeleteElement);
            EditElementCommand = new EditElementCommand(EditElement);
        }
  
        private void AddNewElement(ObservableCollection<ShopElement> data)
        {
            AddSubWindow addWin = new AddSubWindow();
            addWin.ShowDialog();

            if (addWin.GetData() != null)
            {
                data.Add(addWin.GetData());
            }
        }

        private void DeleteElement(ShopElement el)
        {
            _list.Remove(el);
        }

        private void EditElement(ShopElement el)
        {
            AddSubWindow addWin = new AddSubWindow(el);
            addWin.ShowDialog();

            if (addWin.GetData() != null)
            {
                _list.Remove(el);
                _list.Add(addWin.GetData());
            }
        }
    }
}
