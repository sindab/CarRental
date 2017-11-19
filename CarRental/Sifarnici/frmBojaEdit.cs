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
    public partial class frmBojaEdit : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BojaService ds;
        Boja boja;
        int BojaID;

        public frmBojaEdit(int Id)
        {
            InitializeComponent();

            if (!(LicenseManager.UsageMode == LicenseUsageMode.Designtime))
            {
                BojaID = Id;
                ds = new BojaService();
                LoadData(Id);
            }
        }
        void LoadData(int Id)
        {
            boja = GetDataSource(Id);
            txtNaziv.EditValue = boja.Naziv;
        }
        public Boja GetDataSource(int iD)
        {
            Boja result;
            if (BojaID == 0)
            {
                result = new Boja();
                result.Naziv = "";
            }
            else
            {
                result = ds.GetByID(BojaID);
            }
            return result;
        }

        void Snimi()
        {
            boja.Naziv = txtNaziv.EditValue.ToString();
            ds.CreateOrUpdate(boja);
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData(BojaID);
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
            ds.Delete(boja);
        }

        private void bbiClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }
    }
}
