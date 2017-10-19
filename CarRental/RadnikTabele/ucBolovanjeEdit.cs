using System;
using System.ComponentModel;
using CarRental.DB.Service;
using CarRental.DB.Models;

namespace CarRental.RadnikTabele
{
    public partial class ucBolovanjeEdit : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler AfterSave;
        RadnikBolovanjeService ms;
        RadnikBolovanje bolovanje;

        public ucBolovanjeEdit()
        {
            InitializeComponent();
        }

        public RadnikBolovanje Bolovanje
        {
            get
            {
                return bolovanje;
            }
            set
            {
                if (!(value == null))
                {
                    layoutControlGroup1.Enabled = true;
                    bolovanje = value;
                    if (!(LicenseManager.UsageMode == LicenseUsageMode.Designtime))
                    {
                        ms = new RadnikBolovanjeService();
                        if (bolovanje.ID == 0)
                        {
                            mainRibbonPage.Text = "";
                            dtOd.EditValue = null;
                            dtDo.EditValue = null;
                            txtNapomena.EditValue = "";
                        }
                        else
                        {
                            dtOd.EditValue = bolovanje.DatumOd;
                            dtDo.EditValue = bolovanje.DatumDo;
                            txtNapomena.EditValue = bolovanje.Opis;
                        }
                    }
                }
                else
                {
                    layoutControlGroup1.Enabled = false;
                }
            }
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtOd.EditValue == null) bolovanje.DatumOd = null;
            else bolovanje.DatumOd = Convert.ToDateTime(dtOd.EditValue);
            if (dtDo.EditValue == null) bolovanje.DatumDo = null;
            else bolovanje.DatumDo = Convert.ToDateTime(dtDo.EditValue);

            if (txtNapomena.EditValue == null) bolovanje.Opis = null;
            else bolovanje.Opis = txtNapomena.EditValue.ToString();
            ms.CreateOrUpdate(bolovanje);
            this.AfterSave(this, new EventArgs());
        }
    }
}
