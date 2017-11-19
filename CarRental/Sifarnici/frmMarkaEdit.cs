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
    public partial class frmMarkaEdit : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        MarkaService os;
        Marka marka;
        int markaID;

        public frmMarkaEdit(int Id)
        {
            InitializeComponent();

            if (!(LicenseManager.UsageMode == LicenseUsageMode.Designtime))
            {
                markaID = Id;
                os = new MarkaService();
                LoadData(Id);
            }
        }
        void LoadData(int Id)
        {
            marka = GetDataSource(Id);
            //txtSifra.EditValue = marka.Sifra;
            txtNaziv.EditValue = marka.Naziv;
        }
        public Marka GetDataSource(int iD)
        {
            Marka result;
            if (markaID == 0)
            {
                result = new Marka();
                //result.Sifra = "";
                result.Naziv = "";
            }
            else
            {
                result = os.GetByID(markaID);
            }
            return result;
        }

        void Snimi()
        {
            //marka.Sifra = txtSifra.EditValue.ToString();
            //if (!(txtSifra.EditValue is null)) { marka.Sifra = txtSifra.EditValue.ToString(); }
            marka.Naziv = txtNaziv.EditValue.ToString();
            os.CreateOrUpdate(marka);
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData(markaID);
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
            os.Delete(marka);
        }

        private void bbiClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }
    }
}
