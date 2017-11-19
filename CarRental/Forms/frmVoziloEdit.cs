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
    public partial class frmVoziloEdit : DevExpress.XtraEditors.XtraForm
    {
        VoziloService rs;

        public frmVoziloEdit()
        {
            InitializeComponent();
        }

        private void frmVoziloEdit_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                MarkaService os = new MarkaService();
                List<Marka> marke = os.GetLookup();
                cbMarka.Properties.DataSource = marke;
                BojaService bs = new BojaService();
                List<Boja> boje = bs.GetLookup();
                cbBoja.Properties.DataSource = boje;
                OblikService obs = new OblikService();
                List<Oblik> oblici = obs.GetLookup();
                cbOblik.Properties.DataSource = oblici;
            }
        }

        private Vozilo _Vozilo;
        public Vozilo Vozilo
        {
            get
            {
                return _Vozilo;
            }
            set
            {
                xtraTabControl1.Enabled = false;
                if (!(value == null))
                {
                    _Vozilo = value;
                    txtID.EditValue = _Vozilo.ID;
                    txtRegBr.EditValue = _Vozilo.RegBr;
                    cbMarka.EditValue = _Vozilo.MarkaID;
                    txtTip.EditValue = _Vozilo.Tip;
                    cbOblik.EditValue = _Vozilo.OblikID;
                    cbBoja.EditValue = _Vozilo.BojaID;
                    txtGodina.EditValue = _Vozilo.Godina;
                    dtReg.EditValue = _Vozilo.DatumReg;
                    txtCena.EditValue = _Vozilo.Cijena;
                    txtVrata.EditValue = _Vozilo.BrojVrata;
                    txtSjedista.EditValue = _Vozilo.BrojSjedista;
                    txtZapreminaRez.EditValue = _Vozilo.ZapreminaGorivo;
                    txtNeto.EditValue = _Vozilo.NetoTezina;
                    txtNosivost.EditValue = _Vozilo.Nosivost;
                    txtSasija.EditValue = _Vozilo.Sasija;
                    txtBrojMotora.EditValue = _Vozilo.BrMotora;
                    txtSnaga.EditValue = _Vozilo.Snaga;
                    txtZapreminaMot.EditValue = _Vozilo.ZapreminaMotor;
                    txtTipMotora.EditValue = _Vozilo.TipMotora;
                    memoNapomena.EditValue = _Vozilo.Napomena;

                    //pictureEdit1.Image = null;
                    if (!(_Vozilo.Slika is null))
                    {
                        MemoryStream ms = new MemoryStream(_Vozilo.Slika);
                        pictureEdit1.Image = Image.FromStream(ms);
                    }
                    else
                    {
                        pictureEdit1.Image = Properties.Resources.car; // Image.FromFile("car.png");
                    }
                    xtraTabControl1.Enabled = (_Vozilo.ID > 0);

                    SetTabs();
                }
            }
        }

        private void Snimi()
        {
            if (!(txtRegBr.EditValue == null))
            {
                rs = new VoziloService();
                _Vozilo.RegBr = txtRegBr.EditValue.ToString();
                //TODO 17
                if (cbMarka.EditValue == null) _Vozilo.MarkaID = null;
                else _Vozilo.MarkaID = Convert.ToInt32(cbMarka.EditValue);
                //_Vozilo.MarkaID = cbMarka.EditValue;
                if (txtTip.EditValue == null) _Vozilo.Tip = null;
                else _Vozilo.Tip = txtTip.EditValue.ToString();
                //_Vozilo.Tip = txtTip.EditValue;
                if (cbOblik.EditValue == null) _Vozilo.OblikID = null;
                else _Vozilo.OblikID = Convert.ToInt32(cbOblik.EditValue);
                //_Vozilo.OblikID = cbOblik.EditValue;
                if (cbBoja.EditValue == null) _Vozilo.BojaID = null;
                else _Vozilo.BojaID = Convert.ToInt32(cbBoja.EditValue);
                //_Vozilo.BojaID = cbBoja.EditValue;
                if (txtGodina.EditValue == null) _Vozilo.Godina = null;
                else _Vozilo.Godina = (int)txtGodina.EditValue;
                //_Vozilo.Godina = txtGodina.EditValue;
                if (dtReg.EditValue == null) _Vozilo.DatumReg = null;
                else _Vozilo.DatumReg = Convert.ToDateTime(dtReg.EditValue);
                //_Vozilo.DatumReg = dtReg.EditValue;
                if (txtCena.EditValue == null) _Vozilo.Cijena = null;
                else _Vozilo.Cijena = (decimal)txtCena.EditValue;
                //_Vozilo.Cijena = txtCena.EditValue;
                if (txtVrata.EditValue == null) _Vozilo.BrojVrata = null;
                else _Vozilo.BrojVrata = (int)txtVrata.EditValue;
                //_Vozilo.BrojVrata = txtVrata.EditValue;
                if (txtSjedista.EditValue == null) _Vozilo.BrojSjedista = null;
                else _Vozilo.BrojSjedista = (int)txtSjedista.EditValue;
                //_Vozilo.BrojSjedista = txtSjedista.EditValue;
                if (txtZapreminaRez.EditValue == null) _Vozilo.ZapreminaGorivo = null;
                else _Vozilo.ZapreminaGorivo = (int)txtZapreminaRez.EditValue;
                //_Vozilo.ZapreminaGorivo = txtZapreminaRez.EditValue;
                if (txtNeto.EditValue == null) _Vozilo.NetoTezina = null;
                else _Vozilo.NetoTezina = (int)txtNeto.EditValue;
                //_Vozilo.NetoTezina = txtNeto.EditValue;
                if (txtNosivost.EditValue == null) _Vozilo.Nosivost = null;
                else _Vozilo.Nosivost = (int)txtNosivost.EditValue;
                //_Vozilo.Nosivost = txtNosivost.EditValue;
                if (txtSasija.EditValue == null) _Vozilo.Sasija = null;
                else _Vozilo.Sasija = txtSasija.EditValue.ToString();
                //_Vozilo.Sasija = txtSasija.EditValue;
                if (txtBrojMotora.EditValue == null) _Vozilo.BrMotora = null;
                else _Vozilo.BrMotora = txtBrojMotora.EditValue.ToString();
                //_Vozilo.BrMotora = txtBrojMotora.EditValue;
                if (txtSnaga.EditValue == null) _Vozilo.Snaga = null;
                else _Vozilo.Snaga = (int)txtSnaga.EditValue;
                //_Vozilo.Snaga = txtSnaga.EditValue;
                if (txtZapreminaMot.EditValue == null) _Vozilo.ZapreminaMotor = null;
                else _Vozilo.ZapreminaMotor = (int)txtZapreminaMot.EditValue;
                //_Vozilo.ZapreminaMotor = txtZapreminaMot.EditValue;
                if (txtTipMotora.EditValue == null) _Vozilo.TipMotora = null;
                else _Vozilo.TipMotora = txtTipMotora.EditValue.ToString();
                //_Vozilo.TipMotora = txtTipMotora.EditValue;
                if (memoNapomena.EditValue == null) _Vozilo.Napomena = null;
                else _Vozilo.Napomena = memoNapomena.EditValue.ToString();

                MemoryStream ms = new MemoryStream();
                pictureEdit1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                _Vozilo.Slika = ms.ToArray();
                _Vozilo.ID = rs.CreateOrUpdate(_Vozilo);
                Vozilo = rs.GetByID(_Vozilo.ID);
                SetTabs();
            } else
            {
                MessageBox.Show("Upišite registarski broj vozila! Podaci nisu snimljeni.");
            }
        }

        byte[] m_barrImg;
        private void pictureEdit1_ContextButtonClick(object sender, DevExpress.Utils.ContextItemClickEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            try
            {
                if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
                {
                    string strFn = openFileDialog1.FileName;
                    pictureEdit1.Image = Image.FromFile(strFn);
                    FileInfo fiImage = new FileInfo(strFn);
                    long m_lImageFileLength = fiImage.Length;
                    FileStream fs = new FileStream(strFn, FileMode.Open,
                                      FileAccess.Read, FileShare.Read);
                    m_barrImg = new byte[Convert.ToInt32(m_lImageFileLength)];
                    int iBytesRead = fs.Read(m_barrImg, 0,
                                     Convert.ToInt32(m_lImageFileLength));
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Snimi();
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pictureEdit1.Image = Properties.Resources.car;
        }

        private void SetTabs()
        {
            if (!(LicenseManager.UsageMode == LicenseUsageMode.Designtime))
            {
                if (!(Vozilo == null))
                {
                    //ucDjeca1.Roditelj = Vozilo;
                }
                else
                {
                    Vozilo r = new Vozilo()
                    {
                        ID = 0
                    };
                    //ucDjeca1.Roditelj = r;
                }
                //ucDjete1.AfterSave += this.DjeteAfterSave;
            }
        }

        private void DjeteAfterSave(object sender, EventArgs e)
        {
            if (!(LicenseManager.UsageMode == LicenseUsageMode.Designtime))
            {
                //ucDjeca1.LoadData();
            }
        }

        //private void ucDjeca1_IzmjenaDjeteta(object myObject, VoziloTabele.ucDjeca.DjeteArgs myArgs)
        //{
        //    if (!(LicenseManager.UsageMode == LicenseUsageMode.Designtime))
        //    {
        //        ucDjete1.Djete = myArgs.Djete;
        //    }
        //}

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Snimi();
            this.Close();
        }

        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Snimi();
            Vozilo newR = new Vozilo()
            {
                Napomena = string.Empty,
                RegBr = string.Empty,
            };
            Vozilo = newR;
        }
    }
}
