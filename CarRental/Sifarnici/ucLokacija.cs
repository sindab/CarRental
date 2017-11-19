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
using DevExpress.XtraBars;
using System.ComponentModel.DataAnnotations;
using CarRental.DB.Service;
using CarRental.DB.Models;

namespace CarRental.Sifarnici
{
    public partial class ucLokacija : DevExpress.XtraEditors.XtraUserControl
    {
        LokacijaService ms;
        public ucLokacija()
        {
            InitializeComponent();

            if (!(LicenseManager.UsageMode == LicenseUsageMode.Designtime))
            {
                MjestoService os = new MjestoService();
                lkpMjesta.DataSource = os.GetAll();
                ms = new LokacijaService();
                LoadData();
            }
        }
        void LoadData()
        {
            IEnumerable<Lokacija> dataSource = GetDataSource();
            gridControl.DataSource = dataSource;
            bsiRecordsCount.Caption = "RECORDS : " + dataSource.ToList().Count;
            gridView.MoveLastVisible();
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }
        public IEnumerable<Lokacija> GetDataSource()
        {
            IEnumerable<Lokacija> result = ms.GetAll();
            return result;
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLokacijaEdit fOE = new frmLokacijaEdit(0);
            fOE.ShowDialog();
            LoadData();
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView.FocusedRowHandle > -1)
            {
                frmLokacijaEdit fOE = new frmLokacijaEdit((int)gridView.GetFocusedRowCellValue(gcID));
                fOE.ShowDialog();
                LoadData();
            }
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView.FocusedRowHandle > -1)
            {
                ms.Delete((int)gridView.GetFocusedRowCellValue(gcID));
                LoadData();
            }
        }
    }
}
