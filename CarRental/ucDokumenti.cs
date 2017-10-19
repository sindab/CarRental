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
    public partial class ucDokumenti : DevExpress.XtraEditors.XtraUserControl
    {
        RentaService rs;
        IEnumerable<Renta> dataSource;
        Renta trenutni;

        public ucDokumenti()
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
                    TrenutniRenta = dataSource.Where(x => x.ID == focusID).FirstOrDefault(); 
                    gridView.FocusedRowHandle = gridView.FindRow(TrenutniRenta);
                }
            }
        }

        public Renta TrenutniRenta
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
        public IEnumerable<Renta> GetDataSource()
        {
            if (!(LicenseManager.UsageMode == LicenseUsageMode.Designtime))
            {
                rs = new RentaService();
                IEnumerable<Renta> result = rs.GetAll();
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
                trenutni = new Renta();
            }
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (TrenutniRenta.ID > 0)
            {
                frmDokumentEdit fK = new frmDokumentEdit();
                fK.Renta = TrenutniRenta; 
                fK.ShowDialog();
            }
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            Renta newR = new Renta()
            {
                //AdresaStan = string.Empty,
                ////Bitovi = 0,
                //BrLK = string.Empty,
                ////BrRadneKnj = string.Empty,
                ////DjevPrezime = string.Empty,
                //eMail = string.Empty,
                ////Funkcija = string.Empty,
                //Ime = string.Empty,
                ////ImeOca = string.Empty,
                //JMBG = string.Empty,
                ////LicniBrOsiguranja = string.Empty,
                //Napomena = string.Empty,
                //Pol = "Muški",
                //Prezime = string.Empty,
                //TelefonMob = string.Empty,
                //TelefonPosao = string.Empty,
                //TelefonStan = string.Empty,
                ////Titula = string.Empty,
                ////Zanimanje = string.Empty,
                ////ZavrsenaSkola = string.Empty
            };
            frmDokumentEdit fK = new frmDokumentEdit();
            fK.Renta = newR;
            fK.ShowDialog();
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView.FocusedRowHandle > -1)
                LoadData((int)gridView.GetFocusedRowCellValue("ID"));
        }

        private void ucRenta_VisibleChanged(object sender, EventArgs e)
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
            if (TrenutniRenta.ID > 0)
            {
                if (MessageBox.Show("Da li ste sigurni u brisanje podatka?", "Potvrda brisanja", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    rs.Delete(TrenutniRenta.ID);
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
