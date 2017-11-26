using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using System.ComponentModel.DataAnnotations;
using System.IO;
using CarRental.DB.Models;
using CarRental.DB.Service;

namespace CarRental.Forms
{
    public partial class frmDokumentEdit : DevExpress.XtraEditors.XtraForm
    {
        RentaService rs;
        VoziloService vs;
        Vozilo vozilo;

        public frmDokumentEdit()
        {
            InitializeComponent();

            rs = new RentaService();
            vs = new VoziloService();
        }

        private void ucRenta_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                OsobaService oss = new OsobaService();
                IEnumerable<Lookups> osobe = oss.GetLookup();
                lkpKupac.Properties.DataSource = osobe.ToList();
                lkpDrugaOsoba.Properties.DataSource = osobe.ToList();
                lkpVozilo.Properties.DataSource = vs.GetAll().ToList();
                LokacijaService ls = new LokacijaService();
                IEnumerable<Lokacija> lokacije = ls.GetAll();
                lkpPreuzimanje.Properties.DataSource = lokacije.ToList();
                lkpZaPovrat.Properties.DataSource = lokacije.ToList();
                lkpLokPovRaz.Properties.DataSource = lokacije.ToList();
                lkpLokVracanje.Properties.DataSource = lokacije.ToList();

                autoGroupForTabs.SelectedTabPage = autoGroupForContact;
            }
        }
        private Renta _Renta;
        public Renta Renta
        {
            get
            {
                return _Renta;
            }
            set
            {
                if (!(value == null))
                {
                    _Renta = value;
                    txtID.EditValue = _Renta.ID;
                    txtBroj.EditValue = _Renta.Broj;
                    dtDatum.EditValue = _Renta.Datum;
                    lkpKupac.EditValue = _Renta.OsobaID;
                    lkpDrugaOsoba.EditValue = _Renta.DrugaOsobaID;
                    lkpVozilo.EditValue = _Renta.VoziloID;
                    txtStanjeBrojilaStart.EditValue = _Renta.StanjeBrojilaStart;
                    txtStanjeGorivoStart.EditValue = _Renta.StanjeGorivoStart;
                    dtOd.EditValue = _Renta.DatumOd;
                    dtDo.EditValue = _Renta.DatumDo;
                    lkpPreuzimanje.EditValue = _Renta.LokacijaPreuzimanje;
                    lkpZaPovrat.EditValue = _Renta.LokacijaZaPovrat;
                    txtCena.EditValue = _Renta.Cijena;
                    txtDanaZaduzen.EditValue = _Renta.DanaZaRacun;
                    txtRabat.EditValue = _Renta.Rabat;
                    txtPdv.EditValue = _Renta.PDV;
                    //txtIznos.EditValue = _Renta.Iznos;
                    txtDepozit.EditValue = _Renta.Depozit;
                    cbIsZaduzen.Checked = (bool)_Renta.IsZaduzen;

                    txtStanjeBrojiloStartRazd.EditValue = _Renta.StanjeBrojilaStart;
                    txtStanjeGorivaStartRazd.EditValue = _Renta.StanjeGorivoStart;
                    txtStanjeBrojilaKraj.EditValue = _Renta.StanjeBrojilaKraj;
                    txtStanjeGorivoKraj.EditValue = _Renta.StanjeGorivoKraj;

                    cbProduzen.Checked = (bool)_Renta.IsProduzen;
                    dtProduzen.EditValue = _Renta.DatumProduzenDo;

                    cbRazduzen.Checked = (bool)_Renta.IsRazduzen;
                    dtDoRazd.EditValue = _Renta.DatumDo;
                    dtRazd.EditValue = _Renta.DatumRazduzen;
                    lkpLokPovRaz.EditValue = _Renta.LokacijaZaPovrat;
                    lkpLokVracanje.EditValue = _Renta.LokacijaVraceno;

                    //txtCenaRazd.EditValue = _Renta.Cijena;
                    //txtDanaRazd.EditValue = _Renta.DanaZaRacun;
                    //txtRabatRazd.EditValue = _Renta.Rabat;
                    //txtPDVRazd.EditValue = _Renta.PDV;
                    //txtIznosRazd.EditValue = _Renta.Iznos;
                    //txtDepozitRazd.EditValue = _Renta.Depozit;
                    //txtNaplata.EditValue = _Renta.Naplata;
                    cbPlaceno.Checked = (bool)_Renta.IsPlaceno;
                    ratingControl1.EditValue = _Renta.RatingKupca;

                    memoOpisZaduzenje.EditValue = _Renta.OpisZaduzen;
                    memoOpisRazduzenje.EditValue = _Renta.OpisRazduzen;

                    RacunajDanaZaduzen();
                    LoadCarPicture(_Renta.VoziloID);

                    ProvjeriZaduzeno(!(bool)_Renta.IsZaduzen);
                }
            }
        }

        private void ProvjeriZaduzeno(bool enable)
        {
            dtDatum.Enabled = enable;
            lkpKupac.Enabled = enable;
            lkpVozilo.Enabled = enable;
            lkpDrugaOsoba.Enabled = enable;
            txtStanjeBrojilaStart.Enabled = enable;
            txtStanjeGorivoStart.Enabled = enable;
            dtOd.Enabled = enable;
            dtDo.Enabled = enable;
            lkpPreuzimanje.Enabled = enable;
            lkpZaPovrat.Enabled = enable;
            txtCena.Enabled = enable;
            txtDanaZaduzen.Enabled = false;
            txtRabat.Enabled = enable;
            txtPdv.Enabled = enable;
            txtDepozit.Enabled = enable;
            txtIznos.Enabled = enable;
            autoGroupForJob.Enabled = !enable;
            layoutControlGroup5.Enabled = !enable;
        }

        private void LoadCarPicture(int voziloID)
        {
            if (voziloID > 0)
            {
                vozilo = vs.GetByID(voziloID);
                if (!(vozilo.Slika is null))
                {
                    MemoryStream ms = new MemoryStream(vozilo.Slika);
                    pictureEdit1.Image = Image.FromStream(ms);
                    return;
                }
            }
            pictureEdit1.Image = Properties.Resources.car;
        }

        private void Snimi()
        {
            _Renta.Broj = (int)txtBroj.EditValue;
            if (dtDatum.EditValue == null) _Renta.Datum = DateTime.Today;
            else _Renta.Datum = Convert.ToDateTime(dtDatum.EditValue);
            if (lkpKupac.EditValue == null) _Renta.OsobaID = 0;
            else _Renta.OsobaID = Convert.ToInt32(lkpKupac.EditValue);
            if (lkpVozilo.EditValue == null) _Renta.VoziloID = 0;
            else _Renta.VoziloID = Convert.ToInt32(lkpVozilo.EditValue);
            if (lkpDrugaOsoba.EditValue == null) _Renta.DrugaOsobaID = null;
            else _Renta.DrugaOsobaID = Convert.ToInt32(lkpDrugaOsoba.EditValue);

            if (txtStanjeBrojilaStart.EditValue == null) _Renta.StanjeBrojilaStart = 0;
            else _Renta.StanjeBrojilaStart = Convert.ToInt32(txtStanjeBrojilaStart.EditValue);
            if (txtStanjeGorivoStart.EditValue == null) _Renta.StanjeGorivoStart = 0;
            else _Renta.StanjeGorivoStart = Convert.ToInt32(txtStanjeGorivoStart.EditValue);

            if (dtOd.EditValue == null) _Renta.DatumOd = DateTime.Today;
            else _Renta.DatumOd = Convert.ToDateTime(dtOd.EditValue);
            if (dtDo.EditValue == null) _Renta.DatumDo = DateTime.Today;
            else _Renta.DatumDo = Convert.ToDateTime(dtDo.EditValue);

            if (lkpPreuzimanje.EditValue == null) _Renta.LokacijaPreuzimanje = null;
            else _Renta.LokacijaPreuzimanje = Convert.ToInt32(lkpPreuzimanje.EditValue);
            if (lkpZaPovrat.EditValue == null) _Renta.LokacijaZaPovrat = null;
            else _Renta.LokacijaZaPovrat = Convert.ToInt32(lkpZaPovrat.EditValue);

            if (txtCena.EditValue == null) _Renta.Cijena = 0;
            else _Renta.Cijena = Convert.ToInt32(txtCena.EditValue);
            if (txtRabat.EditValue == null) _Renta.Rabat = 0;
            else _Renta.Rabat = Convert.ToInt32(txtRabat.EditValue);
            if (txtPdv.EditValue == null) _Renta.PDV = 0;
            else _Renta.PDV = Convert.ToInt32(txtPdv.EditValue);
            if (txtDepozit.EditValue == null) _Renta.Depozit = 0;
            else _Renta.Depozit = Convert.ToInt32(txtDepozit.EditValue);
            if (txtIznos.EditValue == null) _Renta.Iznos = 0;
            else _Renta.Iznos = Convert.ToInt32(txtIznos.EditValue);
            _Renta.IsZaduzen = cbIsZaduzen.Checked;

            if (txtDanaRazd.EditValue == null) _Renta.DanaZaRacun = 0;
            else _Renta.DanaZaRacun = Convert.ToInt32(txtDanaRazd.EditValue);

            if (txtStanjeBrojilaKraj.EditValue == null) _Renta.StanjeBrojilaKraj = 0;
            else _Renta.StanjeBrojilaKraj = Convert.ToInt32(txtStanjeBrojilaKraj.EditValue);
            if (txtStanjeGorivoKraj.EditValue == null) _Renta.StanjeGorivoKraj = 0;
            else _Renta.StanjeGorivoKraj = Convert.ToInt32(txtStanjeGorivoKraj.EditValue);
            _Renta.IsRazduzen = cbRazduzen.Checked;
            _Renta.IsProduzen = cbProduzen.Checked;
            if (dtRazd.EditValue == null) _Renta.DatumRazduzen = DateTime.Today;
            else _Renta.DatumRazduzen = Convert.ToDateTime(dtRazd.EditValue);
            if (dtProduzen.EditValue == null) _Renta.DatumProduzenDo = DateTime.Today;
            else _Renta.DatumProduzenDo = Convert.ToDateTime(dtProduzen.EditValue);

            if (memoOpisZaduzenje.EditValue == null) _Renta.OpisZaduzen = string.Empty;
            else _Renta.OpisZaduzen = memoOpisZaduzenje.EditValue.ToString();
            if (memoOpisRazduzenje.EditValue == null) _Renta.OpisRazduzen = string.Empty;
            else _Renta.OpisRazduzen = memoOpisRazduzenje.EditValue.ToString();

            if (lkpLokVracanje.EditValue == null) _Renta.LokacijaVraceno = null;
            else _Renta.LokacijaVraceno = Convert.ToInt32(lkpLokVracanje.EditValue);

            if (txtNaplata.EditValue == null) _Renta.Naplata = 0;
            else _Renta.Naplata = Convert.ToInt32(txtNaplata.EditValue);

            _Renta.RatingKupca = ratingControl1.Rating;
            _Renta.IsPlaceno = cbPlaceno.Checked;


            //_Renta.Napomena = memoNapomena.EditValue.ToString();
            //if (txtEmail.EditValue == null) _Renta.eMail = null;
            //else _Renta.eMail = txtEmail.EditValue.ToString();
            //MemoryStream ms = new MemoryStream();
            //pictureEdit1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            //_Renta.Slika = ms.ToArray();

            _Renta.ID = rs.CreateOrUpdate(_Renta);
            Renta = rs.GetByID(_Renta.ID);
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Snimi();
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Snimi();
            this.Close();
        }

        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Snimi();
            Renta = rs.VratiNovuRentu();
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pictureEdit1.Image = Properties.Resources.car;
        }

        private void lkpVozilo_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void lkpVozilo_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            //object oldV = e.OldValue;
            //object newV = e.NewValue;
            if ((int)e.NewValue > 0)
            {
                LoadCarPicture((int)e.NewValue);
                if (e.OldValue != e.NewValue)
                {
                    //if (txtStanjeBrojilaStart.EditValue == null || (int)txtStanjeBrojilaStart.EditValue == 0)
                    txtStanjeBrojilaStart.EditValue = rs.StanjeBrojilaMax((int)e.NewValue);
                    //if (txtStanjeGorivoStart.EditValue == null || (int)txtStanjeGorivoStart.EditValue == 0)
                    txtStanjeGorivoStart.EditValue = rs.StanjeGorivaMax((int)e.NewValue);
                    txtCena.EditValue = vozilo.Cijena;
                }
            }
        }

        private void dtOd_EditValueChanged(object sender, EventArgs e)
        {
            RacunajDanaZaduzen();
        }

        private void dtDo_EditValueChanged(object sender, EventArgs e)
        {
            dtDoRazd.EditValue = dtDo.EditValue;
            dtRazd.EditValue = dtDo.EditValue;
            RacunajDanaZaduzen();
        }

        private void RacunajDanaZaduzen()
        {
            try
            {
                txtDanaZaduzen.EditValue = (dtRazd.DateTime - dtOd.DateTime).TotalDays + 1;
            }
            catch (Exception)
            {
                txtDanaZaduzen.EditValue = 0;
            }
        }

        private void RacunajIznos()
        {
            decimal cena;
            int dana;
            decimal rabat;
            decimal pdv;
            try
            {
                cena = (decimal)txtCena.EditValue;
                int.TryParse(txtDanaZaduzen.EditValue.ToString(), out dana);
                rabat = (decimal)txtRabat.EditValue / 100;
                pdv = (decimal)txtPdv.EditValue / 100;
                txtIznos.EditValue = ((cena * dana) * (1 - rabat)) * (1 + pdv); // - Rabat * PDV
            }
            catch (Exception exc)
            {
                txtIznos.EditValue = 0;
            }
            txtIznosRazd.EditValue = txtIznos.EditValue;

            RacunajZaNaplatu();
        }

        private void RacunajZaNaplatu()
        {
            //decimal d = 0;
            //try
            //{
            //    decimal.TryParse(txtNaplata.EditValue.ToString(), out d);
            //}
            //catch (Exception)
            //{
            //    d = 0;
            //}
            //if (d == 0)
            //{
            decimal iznos;
            decimal depozit;
            try
            {
                iznos = (decimal)txtIznos.EditValue;
                depozit = (decimal)txtDepozitRazd.EditValue;
                txtNaplata.EditValue = iznos - depozit;
            }
            catch (Exception exc)
            {
                txtNaplata.EditValue = 0;
            }
            //}
        }

        private void cbIsZaduzen_CheckedChanged(object sender, EventArgs e)
        {
            //Snimi();
            ProvjeriZaduzeno(!cbIsZaduzen.Checked);
        }

        private void txtCena_EditValueChanged(object sender, EventArgs e)
        {
            txtCenaRazd.EditValue = txtCena.EditValue;
            RacunajIznos();
        }

        private void txtDana_EditValueChanged(object sender, EventArgs e)
        {
            txtDanaRazd.EditValue = txtDanaZaduzen.EditValue;
            RacunajIznos();
        }

        private void txtRabat_EditValueChanged(object sender, EventArgs e)
        {
            txtRabatRazd.EditValue = txtRabat.EditValue;
            RacunajIznos();
        }

        private void txtPdv_EditValueChanged(object sender, EventArgs e)
        {
            txtPDVRazd.EditValue = txtPdv.EditValue;
            RacunajIznos();
        }

        private void cbProduzen_CheckedChanged(object sender, EventArgs e)
        {
            dtProduzen.Enabled = cbProduzen.Checked;
        }

        private void cbRazduzen_CheckedChanged(object sender, EventArgs e)
        {
            if (dtRazd.EditValue == null)
                dtRazd.EditValue = dtDoRazd.EditValue;
            layoutControlGroup5.Enabled = cbRazduzen.Checked;
        }

        private void txtDepozit_EditValueChanged(object sender, EventArgs e)
        {
            txtDepozitRazd.EditValue = txtDepozit.EditValue;
        }

        private void dtRazd_EditValueChanged(object sender, EventArgs e)
        {
            RacunajDanaRazduzen();
        }

        private void RacunajDanaRazduzen()
        {
            try
            {
                double days = (dtRazd.DateTime - dtOd.DateTime).TotalDays + 1;
                if (days > -1)
                    txtDanaRazd.EditValue = days;
            }
            catch (Exception)
            {
                txtDanaRazd.EditValue = 0;
            }
            txtDanaZaduzen.EditValue = txtDanaRazd.EditValue;
        }

        private void txtIznos_EditValueChanged(object sender, EventArgs e)
        {
            RacunajRabat();
        }

        private void RacunajRabat()
        {
            this.txtRabat.EditValueChanged -= new System.EventHandler(this.txtRabat_EditValueChanged);
            decimal cena;
            int dana;
            decimal iznos;
            decimal pdv;
            decimal rabat;
            try
            {
                cena = (decimal)txtCena.EditValue;
                int.TryParse(txtDanaZaduzen.EditValue.ToString(), out dana);
                iznos = (decimal)txtIznos.EditValue;
                pdv = (decimal)txtPdv.EditValue / 100;
                rabat = Math.Round((1 - (iznos / ((cena * dana) * (1 + pdv)))), 2);
                if (Math.Round((decimal)txtRabat.EditValue, 2) != rabat*100)
                    txtRabat.EditValue = rabat*100;
            }
            catch (Exception exc)
            {

            }
            txtIznosRazd.EditValue = txtIznos.EditValue;
            txtRabatRazd.EditValue = txtRabat.EditValue;
            RacunajZaNaplatu();
            this.txtRabat.EditValueChanged += new System.EventHandler(this.txtRabat_EditValueChanged);
        }
    }
}
