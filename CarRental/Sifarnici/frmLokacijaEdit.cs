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
    public partial class frmLokacijaEdit : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        LokacijaService ms;
        Lokacija lokacija;
        int lokacijaID;

        public frmLokacijaEdit(int Id)
        {
            InitializeComponent();

            if (!(LicenseManager.UsageMode == LicenseUsageMode.Designtime))
            {
                MjestoService os = new MjestoService();
                lkpMjesta.Properties.DataSource = os.GetAll();
                lokacijaID = Id;
                ms = new LokacijaService();
                LoadData(Id);
            }
        }
        void LoadData(int Id)
        {
            lokacija = GetDataSource(Id);
            txtAdresa.EditValue = lokacija.Adresa;
            txtNaziv.EditValue = lokacija.Naziv;
            lkpMjesta.EditValue = lokacija.MjestoID;
        }
        public Lokacija GetDataSource(int iD)
        {
            Lokacija result;
            if (lokacijaID == 0)
            {
                result = new Lokacija();
                result.Adresa = "";
                result.Naziv = "";
            }
            else
            {
                result = ms.GetByID(lokacijaID);
            }
            return result;
        }

        void Snimi()
        {
            //lokacija.PostBr = (int)txtSifra.EditValue;
            if (!(txtAdresa.EditValue is null)) { lokacija.Adresa = txtAdresa.EditValue.ToString(); }
            lokacija.Naziv = txtNaziv.EditValue.ToString();
            if (!(lkpMjesta.EditValue is null)) { lokacija.MjestoID = (int)lkpMjesta.EditValue; }
            ms.CreateOrUpdate(lokacija);
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData(lokacijaID);
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
            ms.Delete(lokacija);
        }

        private void bbiClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }
    }
}
