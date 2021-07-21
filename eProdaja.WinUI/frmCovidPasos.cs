using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eProdaja.Model;
using eProdaja.Model.Requests;

namespace eProdaja.WinUI
{
    public partial class frmCovidPasos : Form
    {
        private readonly APIService _kupac = new APIService("Kupac");
        private readonly APIService _covidpass = new APIService("CovidPass");
        public frmCovidPasos()
        {
            InitializeComponent();
            dgvCovidPasosi.AutoGenerateColumns = false;
        }

        private async Task LoadKupci()
        {
            var result = await _kupac.GetAll<List<Kupac>>();

            result.Insert(0, new Kupac());
            cmbKupac.DisplayMember = "ImePrezime";
            cmbKupac.ValueMember = "KupacId";
            cmbKupac.DataSource = result;

        }

        public async Task LoadData()
        {
            await LoadKupci();
            await LoadCovidPass();

        }

        public async void frmCovidPasos_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private void cmbKupac_Validating(object sender, CancelEventArgs e)
        {
            if (cmbKupac.SelectedIndex == 0)
            {
                errorProvider1.SetError(cmbKupac,"Odaberite kupca");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(cmbKupac,null);
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var request = new CovidPassInserRequest()
                {
                    KupacId = cmbKupac.SelectedIndex,
                    DatumPocetak = dtpPocetak.Value,
                    DatumKraj = dtpKraj.Value
                };
                await _covidpass.Insert<Model.CovidPass>(request);

                await LoadCovidPass();

            }
        }

        private void dtpKraj_Validating(object sender, CancelEventArgs e)
        {
            if (dtpKraj.Value < dtpPocetak.Value)
            {
                errorProvider1.SetError(dtpKraj,"Odaberite validan datum");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(dtpKraj,null);
            }
        }

        private async Task LoadCovidPass (int vrstaProizvodaId = 0)
        {
            
            var result = await _covidpass.GetAll<List<Model.CovidPass>>(null);
            dgvCovidPasosi.DataSource = result;
        }
    }
}
