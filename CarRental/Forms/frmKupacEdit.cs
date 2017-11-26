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
    public partial class frmKupacEdit : DevExpress.XtraEditors.XtraForm
    {
        OsobaService rs;

        public frmKupacEdit()
        {
            InitializeComponent();
        }

        private void ucOsoba_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                MjestoService ms = new MjestoService();
                IEnumerable<Mjesto> mj = ms.GetAll();
                lkpMjestoStan.Properties.DataSource = mj.ToList();

                RentaService rs = new RentaService();
                gridControl1.DataSource = rs.GetAllByVozac(Osoba.ID).ToList();
            }
        }

        private Osoba _Osoba;
        public Osoba Osoba
        {
            get
            {
                return _Osoba;
            }
            set
            {
                xtraTabControl1.Enabled = false;
                if (!(value == null))
                {
                    _Osoba = value;
                    txtID.EditValue = _Osoba.ID;
                    txtJMBG.EditValue = _Osoba.JMBG;
                    txtPrezime.EditValue = _Osoba.Prezime;
                    txtIme.EditValue = _Osoba.Ime;
                    dtRodj.EditValue = _Osoba.DatumRodjenja;
                    lkpMjestoStan.EditValue = _Osoba.MjestoStanID;
                    txtAdresa.EditValue = _Osoba.AdresaStan;
                    txtTelefon.EditValue = _Osoba.TelefonStan;
                    txtMobilni.EditValue = _Osoba.TelefonMob;
                    txtBrLK.EditValue = _Osoba.BrLK;
                    txtBrPasos.EditValue = _Osoba.BrPasos;
                    txtBrVozacka.EditValue = _Osoba.BrVozacka;
                    memoNapomena.EditValue = _Osoba.Napomena;
                    txtEmail.EditValue = _Osoba.eMail;
                    cbPol.EditValue = _Osoba.Pol;

                    rs = new OsobaService();
                    ratingControl1.EditValue = rs.Rejting(_Osoba.ID);

                    //pictureEdit1.Image = null;
                    if (!(_Osoba.Slika is null))
                    {
                        MemoryStream ms = new MemoryStream(_Osoba.Slika);
                        pictureEdit1.Image = Image.FromStream(ms);
                    }
                    else
                    {
                        if (_Osoba.Pol == "Ženski")
                        {
                            pictureEdit1.Image = Properties.Resources.women; // Image.FromFile("women.png");
                        }
                        else
                        {
                            pictureEdit1.Image = Properties.Resources.men; // Image.FromFile("men.png");
                        }
                    }
                    xtraTabControl1.Enabled = (_Osoba.ID > 0);

                    SetTabs();
                }
            }
        }

        private void Snimi()
        {
            rs = new OsobaService();
            _Osoba.JMBG = txtJMBG.EditValue.ToString();
            _Osoba.Prezime = txtPrezime.EditValue.ToString();
            _Osoba.Ime = txtIme.EditValue.ToString();
            if (dtRodj.EditValue == null) _Osoba.DatumRodjenja = null;
            else _Osoba.DatumRodjenja = Convert.ToDateTime(dtRodj.EditValue);
            if (lkpMjestoStan.EditValue == null) _Osoba.MjestoStanID = null;
            else _Osoba.MjestoStanID = Convert.ToInt32(lkpMjestoStan.EditValue);
            _Osoba.AdresaStan = txtAdresa.EditValue.ToString();
            _Osoba.TelefonStan = txtTelefon.EditValue.ToString();
            _Osoba.TelefonMob = txtMobilni.EditValue.ToString();
            _Osoba.Napomena = memoNapomena.EditValue.ToString();
            if (txtEmail.EditValue == null) _Osoba.eMail = null;
            else _Osoba.eMail = txtEmail.EditValue.ToString();
            if (cbPol.EditValue == null) _Osoba.Pol = null;
            else _Osoba.Pol = cbPol.EditValue.ToString();
            _Osoba.BrLK = txtBrLK.EditValue.ToString();
            _Osoba.BrPasos = txtBrPasos.EditValue.ToString();
            _Osoba.BrVozacka = txtBrVozacka.EditValue.ToString();
            _Osoba.Rating = ratingControl1.Rating;
            MemoryStream ms = new MemoryStream();
            pictureEdit1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            _Osoba.Slika = ms.ToArray();
            _Osoba.ID = rs.CreateOrUpdate(_Osoba);
            Osoba = rs.GetByID(_Osoba.ID);
            SetTabs();
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


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Snimi();
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Snimi();
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_Osoba.Pol == "Ženski")
            {
                pictureEdit1.Image = Properties.Resources.women; // Image.FromFile("women.png");
            }
            else
            {
                pictureEdit1.Image = Properties.Resources.men; // Image.FromFile("men.png");
            }
        }

        private void SetTabs()
        {
            if (!(LicenseManager.UsageMode == LicenseUsageMode.Designtime))
            {
                if (!(Osoba == null))
                {
                    //ucDjeca1.Roditelj = Osoba;
                }
                else
                {
                    Osoba r = new Osoba()
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

        //private void ucDjeca1_IzmjenaDjeteta(object myObject, OsobaTabele.ucDjeca.DjeteArgs myArgs)
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
            Osoba newR = new Osoba()
            {
                AdresaStan = string.Empty,
                BrLK = string.Empty,
                eMail = string.Empty,
                Ime = string.Empty,
                JMBG = string.Empty,
                Napomena = string.Empty,
                Pol = "Muški",
                Prezime = string.Empty,
                TelefonMob = string.Empty,
                TelefonStan = string.Empty,
                BrPasos = string.Empty,
                BrVozacka = string.Empty,
                Rating = 0,
            };
            Osoba = newR;
        }
    }
}
