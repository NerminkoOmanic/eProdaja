using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eProdaja.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eProdaja.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KupovinePage : ContentPage
    {
        KupovineViewModel model = null;
        public KupovinePage()
        {
            InitializeComponent();
            BindingContext = model = new KupovineViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DpKraj.Date = DateTime.Today;
            DpPocetak.Date = DateTime.Today;
        }
    }
}