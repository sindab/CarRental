using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
using System.IO;
using DevExpress.XtraLayout.Helpers;
using DevExpress.XtraLayout;
using CarRental.DB.Service;
using CarRental.DB.Models;
using DevExpress.XtraBars;

namespace CarRental.Sifarnici
{
    public partial class frmOblikEdit : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        OblikService ds;
        Oblik oblik;
        int OblikID;

        public frmOblikEdit(int Id)
        {
            InitializeComponent();

            if (!(LicenseManager.UsageMode == LicenseUsageMode.Designtime))
            {
                OblikID = Id;
                ds = new OblikService();
                LoadData(Id);
            }
        }
        void LoadData(int Id)
        {
            oblik = GetDataSource(Id);
            txtNaziv.EditValue = oblik.Naziv;
        }
        public Oblik GetDataSource(int iD)
        {
            Oblik result;
            if (OblikID == 0)
            {
                result = new Oblik();
                result.Naziv = "";
            }
            else
            {
                result = ds.GetByID(OblikID);
            }
            return result;
        }

        void Snimi()
        {
            oblik.Naziv = txtNaziv.EditValue.ToString();
            ds.CreateOrUpdate(oblik);
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData(OblikID);
        }

        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            Snimi();
        }

        private void bbiSaveAndClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Snimi();
            Close();
        }

        private void bbiSaveAndNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            Snimi();
            LoadData(0);
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            ds.Delete(oblik);
        }

        private void bbiClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }
    }
}
