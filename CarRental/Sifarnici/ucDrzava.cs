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
using CarRental.DB.Models;
using CarRental.DB.Service;

namespace CarRental.Sifarnici
{
    public partial class ucDrzava : DevExpress.XtraEditors.XtraUserControl
    {
        DrzavaService os;
        public ucDrzava()
        {
            InitializeComponent();

                os = new DrzavaService();
                LoadData();
        }
        void LoadData()
        {
            if (!(LicenseManager.UsageMode == LicenseUsageMode.Designtime))
            {
            IEnumerable<Drzava> dataSource = GetDataSource();
            gridControl.DataSource = dataSource;
            bsiRecordsCount.Caption = "RECORDS : " + dataSource.ToList().Count;
            gridView.MoveLastVisible();
            }
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }
        public IEnumerable<Drzava> GetDataSource()
        {
            IEnumerable<Drzava> result = os.GetAll();
            return result;
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDrzavaEdit fOE = new frmDrzavaEdit(0);
            fOE.ShowDialog();
            LoadData();
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView.FocusedRowHandle > -1)
            {
                frmDrzavaEdit fOE = new frmDrzavaEdit((int)gridView.GetFocusedRowCellValue(gcID));
                fOE.ShowDialog();
                LoadData();
            }
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView.FocusedRowHandle > -1)
            {
                os.Delete((int)gridView.GetFocusedRowCellValue(gcID));
                LoadData();
            }
        }
    }
}
