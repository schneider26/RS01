using RS.Models;
using RS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyListPage : ContentPage
    {
        public MyListPage()
        {
            InitializeComponent();
            BindingContext = new MyListPageViewModel();
        }

        async private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var myselecteditem = e.Item as MyListModel;
            switch (myselecteditem.id)
            {
                case 1 :
                    await Navigation.PushAsync(new Page1());
                    break;
                case 2:
                    await Navigation.PushAsync(new Page2());
                    break;
                case 3:
                    await Navigation.PushAsync(new Page3());
                    break;
                case 4:
                    await Navigation.PushAsync(new Page4());
                    break;
                case 5:
                    await Navigation.PushAsync(new Page5());
                    break;
                case 6:
                    await Navigation.PushAsync(new Page6());
                    break;
                case 7:
                    await Navigation.PushAsync(new Page7());
                    break;
                case 8:
                    await Navigation.PushAsync(new Page8());
                    break;
            }
            ((ListView)sender).SelectedItem = null;
        }
    }
}