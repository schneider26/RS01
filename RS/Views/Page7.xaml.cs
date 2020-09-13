using Newtonsoft.Json;
using RS.Models;
using RS.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page7 : ContentPage
    {
        private ObservableCollection<SignModel> myroot;
        public Page7()
        {
            InitializeComponent();
            //BindingContext = new ViewModelSign();
            BindingContext = this;

            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("RS.SignList7.json");

            using (var reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();

                List<SignModel> signs = JsonConvert.DeserializeObject<List<SignModel>>(json);
                myroot = new ObservableCollection<SignModel>(signs);
                MyListView.ItemsSource = myroot;
            }
        }
        private async void OnItemSelected(object sender, ItemTappedEventArgs e)
        {
            var details = e.Item as SignModel;
            await Navigation.PushAsync(new MyListPageDetail(details.Name, details.Rule, details.Image));
        }

    }
}