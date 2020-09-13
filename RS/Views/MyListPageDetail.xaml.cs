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
    public partial class MyListPageDetail : ContentPage
    {
        public MyListPageDetail(string Name, string Rule, string source)
        {
            InitializeComponent();
            MyItemNameShow.Text = Name;
            MyRuleItemShow.Text = Rule;
            MyImageCall.Source = new UriImageSource()
            {
                Uri = new Uri(source)
            };
        }
    }
}