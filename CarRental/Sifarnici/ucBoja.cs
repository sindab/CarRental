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
    public partial class ucBoja : DevExpress.XtraEditors.XtraUserControl
    {
        BojaService os;
        public ucBoja()
        {
            InitializeComponent();

                os = new BojaService();
                LoadData();
        }
        void LoadData()
        {
            if (!(LicenseManager.UsageMode == LicenseUsageMode.Designtime))
            {
            IEnumerable<Boja> dataSource = GetDataSource();
            gridControl.DataSource = dataSource;
            bsiRecordsCount.Caption = "RECORDS : " + dataSource.ToList().Count;
            gridView.MoveLastVisible();
            }
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }
        public IEnumerable<Boja> GetDataSource()
        {
            IEnumerable<Boja> result = os.GetAll();
            return result;
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBojaEdit fOE = new frmBojaEdit(0);
            fOE.ShowDialog();
            LoadData();
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView.FocusedRowHandle > -1)
            {
                frmBojaEdit fOE = new frmBojaEdit((int)gridView.GetFocusedRowCellValue(gcID));
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
