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

namespace CarRental.Forms
{
    public partial class ucKupci : DevExpress.XtraEditors.XtraUserControl
    {
        OsobaService rs;
        IEnumerable<Osoba> dataSource;
        Osoba trenutni;

        public ucKupci()
        {
            InitializeComponent();
        }

        private void ucRadnici_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                if (System.IO.File.Exists(openFileDialog1.FileName))
                    gridView.RestoreLayoutFromXml(openFileDialog1.FileName);

                LoadData(0);
                MjestoService ms = new MjestoService();
                IEnumerable<Mjesto> mj = ms.GetAll();
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
                    TrenutniOsoba = dataSource.Where(x => x.ID == focusID).FirstOrDefault(); 
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
                frmKupacEdit fK=new frmKupacEdit();
                fK.Osoba = TrenutniOsoba; 
                fK.ShowDialog();
                LoadData(0);
            }
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            Osoba newR = new Osoba()
            {
                AdresaStan = string.Empty,
                BrLK = string.Empty,
                BrPasos=string.Empty,
                BrVozacka=string.Empty,
                eMail = string.Empty,
                Ime = string.Empty,
                JMBG = string.Empty,
                Napomena = string.Empty,
                Pol = "Muški",
                Prezime = string.Empty,
                TelefonMob = string.Empty,
                TelefonStan = string.Empty,
            };
            frmKupacEdit fK = new frmKupacEdit();
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
