using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using eProdaja.Mobile.Services;
using eProdaja.Model;
using eProdaja.Model.Requests;
using Xamarin.Forms;

namespace eProdaja.Mobile.ViewModels
{
    public class KupovineViewModel : BaseViewModel
    {
        private readonly APIService _kupovine = new APIService("Kupovine");
        private readonly APIService _kupovineStavke = new APIService("KupovineStavke");
        private readonly APIService _covidPass = new APIService("CovidPass");

        public KupovineViewModel()
        {
            InitCommand = new Command(async () => await Init());
            KupovineList.Clear();
        }
        public ICommand InitCommand { get; set; }


        public ObservableCollection<Narudzbe> KupovineList { get; set; } = new ObservableCollection<Narudzbe>();

        DateTime _selectedPocetak = DateTime.MinValue;
        public DateTime SelectedPocetak
        {
            get { return _selectedPocetak; }
            set
            { SetProperty(ref _selectedPocetak, value); }
        }

        DateTime _selectedKraj = DateTime.MinValue;
        public DateTime SelectedKraj
        {
            get { return _selectedKraj; }
            set
            { SetProperty(ref _selectedKraj, value); }
        }

        public async Task Init()
        {
            if (SelectedPocetak <= SelectedKraj)
            {
                var listKupovine = await _kupovine.Get<List<Narudzbe>>(null);
                var listKupovineStavke = await _kupovineStavke.Get<List<NarudzbaStavke>>(null);
                var listCovidPass = await _covidPass.Get<List<CovidPass>>(null);

                KupovineList.Clear();

                foreach (var item in listKupovine)
                {
                    if (item.Datum >= SelectedPocetak && item.Datum <= SelectedKraj )
                    {
                        decimal suma = 0;
                        foreach (var stavka in listKupovineStavke)
                        {
                            if (item.NarudzbaId == stavka.NarudzbaId)
                            {
                                suma += stavka.Kolicina * stavka.Proizvod.Cijena;
                            }
                        }

                        item.Ukupno = suma;

                        bool isCovidPass = false;
                        foreach (var covidPass in listCovidPass)
                        {
                            if (item.KupacId == covidPass.KupacId)
                            {
                                if (item.Datum >= covidPass.DatumPocetak && item.Datum <= covidPass.DatumKraj)
                                {
                                    isCovidPass = true;
                                }
                            }
                        }

                        if (isCovidPass)
                        {
                            item.PosjedovanjeCovidPass = "DA";
                        }
                        else
                        {
                            item.PosjedovanjeCovidPass = "NE";
                        }
                        
                        KupovineList.Add(item);
                    }
                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Odabrani datumi nisu validni", "OK");
                return;
            }


        }        
    }
}
