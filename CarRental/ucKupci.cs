using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
using CarRental.DB.Models;
using CarRental.DB.Service;
using Microsoft.Win32;

namespace CarRental
{
    public partial class ucKupci : DevExpress.XtraEditors.XtraUserControl
    {
        OsobaService rs;
        IEnumerable<Osoba> dataSource;
        Osoba trenutni;
        //public delegate void OsobaChangedHandler(object myObject, OsobaArgs myArgs);
        //public event OsobaChangedHandler IzmjenaOsobaa;
        //RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"Software\Kadrovska\frmOsobaLayout");

        public ucKupci()
        {
            InitializeComponent();
            //gridView.RestoreLayoutFromXml("frmOsobaLayout.xml");

        }
        //private string PathName
        //{
        //    get
        //    {
        //        //using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"Software\Kadrovska"))
        //        //{
        //            return (string)registryKey.GetValue("frmOsobaLayout");
        //        //}
        //    }
        //}

        private void ucRadnici_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                if (System.IO.File.Exists(openFileDialog1.FileName))
                    gridView.RestoreLayoutFromXml(openFileDialog1.FileName);

                LoadData(0);

                //gridView1.RestoreLayoutFromRegistry("frmOsobaLayout");

                MjestoService ms = new MjestoService();
                IEnumerable<Mjesto> mj = ms.GetAll();
                lkpMjestoRodjenja.DataSource = mj.ToList();
                lkpMjestoStan.DataSource = mj.ToList();
            }
        }

        public void LoadData(int focusID)
        {
            if (!(LicenseManager.UsageMode == LicenseUsageMode.Designtime))
            {
                dataSource = GetDataSource();
                gridControl.DataSource = dataSource;
                gridView.ExpandAllGroups();
                bsiRecordsCount.Caption = "RECORDS : " + dataSource.ToList().Count;
                if (focusID > 0)
                {
                    TrenutniOsoba = dataSource.Where(x => x.ID == focusID).FirstOrDefault(); // dt.Rows.IndexOf(dt.Rows.Find(< key_value >));
                    gridView.FocusedRowHandle = gridView.FindRow(TrenutniOsoba);
                }
            }
        }

        public Osoba TrenutniOsoba
        {
            get
            {
                return trenutni;
            }
            set
            {
                trenutni = value;
            }
        }

        //public class OsobaArgs : EventArgs
        //{
        //    private Osoba osoba;
        //    public OsobaArgs(Osoba Osoba)
        //    {
        //        this.osoba = Osoba;
        //    }
        //    // This is a straightforward implementation for declaring a public field
        //    public Osoba Osoba
        //    {
        //        get
        //        {
        //            return osoba;
        //        }
        //    }
        //}
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }
        public IEnumerable<Osoba> GetDataSource()
        {
            if (!(LicenseManager.UsageMode == LicenseUsageMode.Designtime))
            {
                rs = new OsobaService();
                IEnumerable<Osoba> result = rs.GetAll();
                return result;
            }
            else { return null; }
        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView.FocusedRowHandle > -1)
            {
                trenutni = dataSource.First(x => x.ID == (int)gridView.GetFocusedRowCellValue("ID"));
            }
            else
            {
                trenutni = new Osoba();
            }
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (TrenutniOsoba.ID > 0)
            {
                //OsobaArgs myArgs = new OsobaArgs(rs.GetByID(TrenutniOsoba.ID));
                //IzmjenaOsobaa(this, myArgs);
                frmKupac fK=new frmKupac();
                fK.Osoba = TrenutniOsoba; // rs.GetByID(TrenutniOsoba.ID);
                fK.ShowDialog();
            }
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            Osoba newR = new Osoba()
            {
                AdresaStan = string.Empty,
                //Bitovi = 0,
                BrLK = string.Empty,
                //BrRadneKnj = string.Empty,
                //DjevPrezime = string.Empty,
                eMail = string.Empty,
                //Funkcija = string.Empty,
                Ime = string.Empty,
                //ImeOca = string.Empty,
                JMBG = string.Empty,
                //LicniBrOsiguranja = string.Empty,
                Napomena = string.Empty,
                Pol = "Muški",
                Prezime = string.Empty,
                TelefonMob = string.Empty,
                TelefonPosao = string.Empty,
                TelefonStan = string.Empty,
                //Titula = string.Empty,
                //Zanimanje = string.Empty,
                //ZavrsenaSkola = string.Empty
            };
            //OsobaArgs myArgs = new OsobaArgs(newR);
            //IzmjenaOsobaa(this, myArgs);
            frmKupac fK = new frmKupac();
            fK.Osoba = newR;
            fK.ShowDialog();
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView.FocusedRowHandle > -1)
                LoadData((int)gridView.GetFocusedRowCellValue("ID"));
        }

        private void ucRadnici_VisibleChanged(object sender, EventArgs e)
        {
            if (!(this.DesignMode))
            {
                if ((gridView.FocusedRowHandle > -1) && (int)gridView.GetFocusedRowCellValue("ID") > 0)
                {
                    LoadData((int)gridView.GetFocusedRowCellValue("ID"));
                }
                else { LoadData(0); }
            }
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (TrenutniOsoba.ID > 0)
            {
                if (MessageBox.Show("Da li ste sigurni u brisanje podatka?", "Potvrda brisanja", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    rs.Delete(TrenutniOsoba.ID);
                    LoadData(0);
                }
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            saveFileDialog1.ShowDialog();
            gridView.SaveLayoutToXml(openFileDialog1.FileName);
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            openFileDialog1.ShowDialog();
            gridView.RestoreLayoutFromXml(openFileDialog1.FileName);
        }
    }
}
