using ColorChangeDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ColorChangeDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectedItemPage : ContentPage
    {
        public SelectedItemPage()
        {
            InitializeComponent();

            BindingContext = new SelectedItemViewModel();
        }
    }
}