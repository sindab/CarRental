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

namespace CarRental
{
    public partial class frmDokumentEdit : DevExpress.XtraEditors.XtraForm
    {
        RentaService rs;

        public frmDokumentEdit()
        {
            InitializeComponent();
        }

        private void ucRenta_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            { 
                MjestoService ms = new MjestoService();
                IEnumerable<Mjesto> mj = ms.GetAll();
                lkpMjestoRodj.Properties.DataSource = mj.ToList();
                lkpMjestoStan.Properties.DataSource = mj.ToList();
                OpstinaService os = new OpstinaService();
                lkpOpstinaIzdavanjaRK.Properties.DataSource = os.GetAll().ToList();
                //NacionalnostService ns = new NacionalnostService();
                //lkpNacionalnost.Properties.DataSource = ns.GetAll().ToList();
                DrzavaService ds = new DrzavaService();
                lkpDrzava.Properties.DataSource = ds.GetAll().ToList();
                //PorodicnoStanjeService ps = new PorodicnoStanjeService();
                //lkpPorodicnoStanje.Properties.DataSource = ps.GetAll().ToList();
                //StrucnaSpremaService ss = new StrucnaSpremaService();
                //lkpStrucnaSprema.Properties.DataSource = ss.GetAll().ToList();
                //PoslovnaJedinicaService pjs = new PoslovnaJedinicaService();
                //lkpPoslovnaJedinica.Properties.DataSource = pjs.GetAll().ToList();
                //RadnoMjestoService rms = new RadnoMjestoService();
                //lkpRadnoMjesto.Properties.DataSource = rms.GetAll().ToList();
                //TipRadnogOdnosaService trs = new TipRadnogOdnosaService();
                //lkpTipRadnogOdnosa.Properties.DataSource = trs.GetAll().ToList();
                //NacinPrestankaROService nps = new NacinPrestankaROService();
                //lkpNacinPrestanka.Properties.DataSource = nps.GetAll().ToList();

                //ucRadniStaz1.Renta = Renta;
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
                xtraTabControl1.Enabled = false;
                if (!(value == null))
                {
                    _Renta = value;
                    txtID.EditValue = _Renta.ID;
                    //txtJMBG.EditValue = _Renta.JMBG;
                    //txtPrezime.EditValue = _Renta.Prezime;
                    //txtIme.EditValue = _Renta.Ime;
                    ////txtDjevPrezime.EditValue = _Renta.DjevPrezime;
                    ////txtImeOca.EditValue = _Renta.ImeOca;
                    ////txtTitula.EditValue = _Renta.Titula;
                    ////txtFunkcija.EditValue = _Renta.Funkcija;
                    ////lkpMjestoRodj.EditValue = _Renta.MjestoRodjenja;
                    //dtRodj.EditValue = _Renta.DatumRodjenja;
                    ////lkpDrzava.EditValue = _Renta.DrzavaID;
                    ////lkpNacionalnost.EditValue = _Renta.NacionalnostID;
                    ////lkpPorodicnoStanje.EditValue = _Renta.PorodicnoStanjeID;
                    //lkpMjestoStan.EditValue = _Renta.MjestoStanID;
                    //txtAdresa.EditValue = _Renta.AdresaStan;
                    //txtTelefon.EditValue = _Renta.TelefonStan;
                    //txtMobilni.EditValue = _Renta.TelefonMob;
                    //txtTelPosao.EditValue = _Renta.TelefonPosao;
                    ////txtZanimanje.EditValue = _Renta.Zanimanje;
                    ////lkpStrucnaSprema.EditValue = _Renta.StrucnaSpremaID;
                    ////txtZavrsenaSkola.EditValue = _Renta.ZavrsenaSkola;
                    ////lkpRadnoMjesto.EditValue = _Renta.RadnoMjestoID;
                    //txtBrojLK.EditValue = _Renta.BrLK;
                    ////txtBrojRK.EditValue = _Renta.BrRadneKnj;
                    ////lkpOpstinaIzdavanjaRK.EditValue = _Renta.OpstinaIzdavanjaRK;
                    ////txtLicniBrO.EditValue = _Renta.LicniBrOsiguranja;
                    //////dtPrvoZapos.EditValue = _Renta.DatumPrvogZapos;
                    ////txtPreMjeseci.EditValue = _Renta.PrethodniStazMj;
                    ////txtPreDana.EditValue = _Renta.PrethodniStazDan;
                    //////txtPreFirmaMj.EditValue = _Renta.PrethodniStazUFirmiMj;
                    //////txtPreFirmaDana.EditValue = _Renta.PrethodniStazUFirmiDan;
                    ////dtZapos.EditValue = _Renta.DatumRodjenja;
                    ////lkpTipRadnogOdnosa.EditValue = _Renta.TipRadnogOdnosaID;
                    ////lkpNacinPrestanka.EditValue = _Renta.NacinPrestankaRoID;
                    ////dtPrestanka.EditValue = _Renta.DatumPrestankaRO;
                    //memoNapomena.EditValue = _Renta.Napomena;
                    //txtEmail.EditValue = _Renta.eMail;
                    ////lkpPoslovnaJedinica.EditValue = _Renta.PoslovnaJedinicaID;
                    //cbPol.EditValue = _Renta.Pol;

                    ////pictureEdit1.Image = null;
                    //if (!(_Renta.Slika is null))
                    //{
                    //    MemoryStream ms = new MemoryStream(_Renta.Slika);
                    //    pictureEdit1.Image = Image.FromStream(ms);
                    //}
                    //else
                    //{
                    //    if (_Renta.Pol == "Ženski")
                    //    {
                    //        pictureEdit1.Image = Image.FromFile("women.png");
                    //    }
                    //    else
                    //    {
                    //        pictureEdit1.Image = Image.FromFile("men.png");
                    //    }
                    //}
                    xtraTabControl1.Enabled = (_Renta.ID > 0);

                SetTabs();
                }
            }
        }


        private void Snimi()
        {
            rs = new RentaService();
            //_Renta.JMBG = txtJMBG.EditValue.ToString();
            //_Renta.Prezime = txtPrezime.EditValue.ToString();
            //_Renta.Ime = txtIme.EditValue.ToString();
            ////_Renta.DjevPrezime = txtDjevPrezime.EditValue.ToString();
            ////_Renta.ImeOca = txtImeOca.EditValue.ToString();
            ////_Renta.Titula = txtTitula.EditValue.ToString();
            ////_Renta.Funkcija = txtFunkcija.EditValue.ToString();


            //////_Renta.MjestoRodjenja = (int)lkpMjestoRodj.EditValue;
            ////if (lkpMjestoRodj.EditValue == null) _Renta.MjestoRodjenja = null;
            ////else _Renta.MjestoRodjenja = Convert.ToInt32(lkpMjestoRodj.EditValue);

            ////_Renta.DatumRodjenja = (DateTime)dtRodj.EditValue;
            //if (dtRodj.EditValue == null) _Renta.DatumRodjenja = null;
            //else _Renta.DatumRodjenja = Convert.ToDateTime(dtRodj.EditValue);

            //////_Renta.DrzavaID = (int)lkpDrzava.EditValue;
            ////if (lkpDrzava.EditValue == null) _Renta.DrzavaID = null;
            ////else _Renta.DrzavaID = Convert.ToInt32(lkpDrzava.EditValue);

            //////_Renta.NacionalnostID = (int)lkpNacionalnost.EditValue;
            ////if (lkpNacionalnost.EditValue == null) _Renta.NacionalnostID = null;
            ////else _Renta.NacionalnostID = Convert.ToInt32(lkpNacionalnost.EditValue);

            //////_Renta.PorodicnoStanjeID = (int)lkpPorodicnoStanje.EditValue;
            ////if (lkpPorodicnoStanje.EditValue == null) _Renta.PorodicnoStanjeID = null;
            ////else _Renta.PorodicnoStanjeID = Convert.ToInt32(lkpPorodicnoStanje.EditValue);

            ////_Renta.MjestoStan = (int)lkpMjestoStan.EditValue;
            //if (lkpMjestoStan.EditValue == null) _Renta.MjestoStanID = null;
            //else _Renta.MjestoStanID = Convert.ToInt32(lkpMjestoStan.EditValue);

            //_Renta.AdresaStan = txtAdresa.EditValue.ToString();
            //_Renta.TelefonStan = txtTelefon.EditValue.ToString();
            //_Renta.TelefonMob = txtMobilni.EditValue.ToString();
            //_Renta.TelefonPosao = txtTelPosao.EditValue.ToString();
            ////_Renta.Zanimanje = txtZanimanje.EditValue.ToString();
            //////_Renta.StrucnaSpremaID = (int)lkpStrucnaSprema.EditValue;
            ////if (lkpStrucnaSprema.EditValue == null) _Renta.StrucnaSpremaID = null;
            ////else _Renta.StrucnaSpremaID = Convert.ToInt32(lkpStrucnaSprema.EditValue);

            ////_Renta.ZavrsenaSkola = txtZavrsenaSkola.EditValue.ToString();
            //////_Renta.RadnoMjestoID = (int)lkpRadnoMjesto.EditValue;
            ////if (lkpRadnoMjesto.EditValue == null) _Renta.RadnoMjestoID = null;
            ////else _Renta.RadnoMjestoID = Convert.ToInt32(lkpRadnoMjesto.EditValue);

            //_Renta.BrLK = txtBrojLK.EditValue.ToString();
            ////_Renta.BrRadneKnj = txtBrojRK.EditValue.ToString();
            //////_Renta.OpstinaIzdavanjaRK = (int)lkpOpstinaIzdavanjaRK.EditValue;
            ////if (lkpOpstinaIzdavanjaRK.EditValue == null) _Renta.OpstinaIzdavanjaRK = null;
            ////else _Renta.OpstinaIzdavanjaRK = Convert.ToInt32(lkpOpstinaIzdavanjaRK.EditValue);

            ////_Renta.LicniBrOsiguranja = txtLicniBrO.EditValue.ToString();
            ////////_Renta.DatumPrvogZapos = (DateTime)dtPrvoZapos.EditValue;
            //////if (dtPrvoZapos.EditValue == null) _Renta.DatumPrvogZapos = null;
            //////else _Renta.DatumPrvogZapos = Convert.ToDateTime(dtPrvoZapos.EditValue);

            //////_Renta.PrethodniStazMj = (int)txtPreMjeseci.EditValue;
            ////if (txtPreMjeseci.EditValue == null) _Renta.PrethodniStazMj = null;
            ////else _Renta.PrethodniStazMj = Convert.ToInt32(txtPreMjeseci.EditValue);

            //////_Renta.PrethodniStazDan = (int)txtPreDana.EditValue;
            ////if (txtPreDana.EditValue == null) _Renta.PrethodniStazDan = null;
            ////else _Renta.PrethodniStazDan = Convert.ToInt32(txtPreDana.EditValue);

            //////_Renta.PrethodniStazUFirmiMj = (int)txtPreFirmaMj.EditValue;
            ////if (txtPreFirmaMj.EditValue == null) _Renta.PrethodniStazUFirmiMj = null;
            ////else _Renta.PrethodniStazUFirmiMj = Convert.ToInt32(txtPreFirmaMj.EditValue);

            //////_Renta.PrethodniStazUFirmiDan = (int)txtPreFirmaDana.EditValue;
            ////if (txtPreFirmaDana.EditValue == null) _Renta.PrethodniStazUFirmiDan = null;
            ////else _Renta.PrethodniStazUFirmiDan = Convert.ToInt32(txtPreFirmaDana.EditValue);

            //////_Renta.DatumZapos = (DateTime)dtZapos.EditValue;
            ////if (dtZapos.EditValue == null) _Renta.DatumRodjenja = null;
            ////else _Renta.DatumRodjenja = Convert.ToDateTime(dtZapos.EditValue);

            //////_Renta.TipRadnogOdnosaID = (int)lkpTipRadnogOdnosa.EditValue;
            ////if (lkpTipRadnogOdnosa.EditValue == null) _Renta.TipRadnogOdnosaID = null;
            ////else _Renta.TipRadnogOdnosaID = Convert.ToInt32(lkpTipRadnogOdnosa.EditValue);

            //////_Renta.NacinPrestankaRoID = (int)lkpNacinPrestanka.EditValue;
            ////if (lkpNacinPrestanka.EditValue == null) _Renta.NacinPrestankaRoID = null;
            ////else _Renta.NacinPrestankaRoID = Convert.ToInt32(lkpNacinPrestanka.EditValue);

            //////_Renta.DatumPrestankaRO = (DateTime)dtPrestanka.EditValue;
            ////if (dtPrestanka.EditValue == null) _Renta.DatumPrestankaRO = null;
            ////else _Renta.DatumPrestankaRO = Convert.ToDateTime(dtPrestanka.EditValue);

            //_Renta.Napomena = memoNapomena.EditValue.ToString();
            ////_Renta.eMail = txtEmail.EditValue.ToString();
            //if (txtEmail.EditValue == null) _Renta.eMail = null;
            //else _Renta.eMail = txtEmail.EditValue.ToString();
            ////_Renta.PoslovnaJedinicaID = (int)lkpPoslovnaJedinica.EditValue;
            ////if (lkpPoslovnaJedinica.EditValue == null) _Renta.PoslovnaJedinicaID = null;
            ////else _Renta.PoslovnaJedinicaID = Convert.ToInt32(lkpPoslovnaJedinica.EditValue);

            ////_Renta.Pol = cbPol.EditValue.ToString();
            //if (cbPol.EditValue == null) _Renta.Pol = null;
            //else _Renta.Pol = cbPol.EditValue.ToString();

            ////_Renta.Slika = m_barrImg;
            //MemoryStream ms = new MemoryStream();
            //pictureEdit1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            //_Renta.Slika = ms.ToArray();

            //_Renta.ID = rs.CreateOrUpdate(_Renta);
            Renta = rs.GetByID(_Renta.ID);

            SetTabs();
        }
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Snimi();
        }
        
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Snimi();
        }

        private void SetTabs()
        {
            if (!(LicenseManager.UsageMode == LicenseUsageMode.Designtime))
            {
                if (!(Renta == null))
                {
                    //ucDjeca1.Roditelj = Renta;
                    //ucGOList1.Roditelj = Renta;
                    //ucKursList1.Roditelj = Renta;
                    //ucBolovanjeList1.Roditelj = Renta;
                    //ucRadniStaz1.Renta = Renta;
                }
                else
                {
                    Renta r = new Renta()
                    {
                        ID = 0
                    };
                    //ucDjeca1.Roditelj = r;
                    //ucGOList1.Roditelj = r;
                    //ucKursList1.Roditelj = r;
                    //ucBolovanjeList1.Roditelj = r;
                    //ucRadniStaz1.Renta = r;
                }
                //ucDjete1.AfterSave += this.DjeteAfterSave;
                //ucGOEdit1.AfterSave += this.GOAfterSave;
                //ucKursEdit1.AfterSave += this.KursAfterSave;
                //ucBolovanjeEdit1.AfterSave += this.BolovanjeAfterSave;
            }
        }

        private void DjeteAfterSave(object sender, EventArgs e)
        {
            if (!(LicenseManager.UsageMode == LicenseUsageMode.Designtime))
            {
                //ucDjeca1.LoadData();
            }
        }
        
    }
}
