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
    public partial class frmDrzavaEdit : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DrzavaService ds;
        Drzava Drzava;
        int DrzavaID;

        public frmDrzavaEdit(int Id)
        {
            InitializeComponent();

            if (!(LicenseManager.UsageMode == LicenseUsageMode.Designtime))
            {
                DrzavaID = Id;
                ds = new DrzavaService();
                LoadData(Id);
            }
        }
        void LoadData(int Id)
        {
            Drzava = GetDataSource(Id);
            txtNaziv.EditValue = Drzava.Naziv;
        }
        public Drzava GetDataSource(int iD)
        {
            Drzava result;
            if (DrzavaID == 0)
            {
                result = new Drzava();
                result.Naziv = "";
            }
            else
            {
                result = ds.GetByID(DrzavaID);
            }
            return result;
        }

        void Snimi()
        {
            Drzava.Naziv = txtNaziv.EditValue.ToString();
            ds.CreateOrUpdate(Drzava);
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData(DrzavaID);
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
            ds.Delete(Drzava);
        }

        private void bbiClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }
    }
}
