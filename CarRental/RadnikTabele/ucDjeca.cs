﻿using System;
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

namespace CarRental.RadnikTabele
{
    public partial class ucDjeca : DevExpress.XtraEditors.XtraUserControl
    {
        public delegate void DjeteChangedHandler(object myObject, DjeteArgs myArgs);
        public event DjeteChangedHandler IzmjenaDjeteta;
        RadnikDjecaService rds;
        public ucDjeca()
        {
            InitializeComponent();
        }
        public class DjeteArgs : EventArgs
        {
            private RadnikDjeca djete;
            public DjeteArgs(RadnikDjeca djete)
            {
                this.djete = djete;
            }
            // This is a straightforward implementation for declaring a public field
            public RadnikDjeca Djete
            {
                get
                {
                    return djete;
                }
            }
        }
        private Radnik _roditelj;
        public Radnik Roditelj
        {
            get
            {
                return _roditelj;
            }
            set
            {
                if (!(value == null))
                {
                    _roditelj = value;
                    rds = new RadnikDjecaService();
                    LoadData();
                }
            }
        }

        public void LoadData()
        {
            if (!(LicenseManager.UsageMode == LicenseUsageMode.Designtime))
            {
                IEnumerable<RadnikDjeca> dataSource = GetDataSource();
                gridControl.DataSource = dataSource;
                bsiRecordsCount.Caption = "RECORDS : " + dataSource.ToList().Count;
                gridView.MoveLastVisible();
            }
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }
        public IEnumerable<RadnikDjeca> GetDataSource()
        {
            IEnumerable<RadnikDjeca> result = rds.GetByRadId(Roditelj.ID);
            return result;
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            RadnikDjeca trenutnoDjete = new RadnikDjeca()
            {
                ID = 0,
                RadID = Roditelj.ID
            };
            DjeteArgs myArgs = new DjeteArgs(trenutnoDjete);
            IzmjenaDjeteta(this, myArgs);
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridView.FocusedRowHandle > -1)
            {
                rds.Delete((int)gridView.GetFocusedRowCellValue(gcID));
                LoadData();
            }
        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // proslijedi DjeteID ucDjete

            if (!(LicenseManager.UsageMode == LicenseUsageMode.Designtime))
            {
                RadnikDjeca trenutnoDjete;
                try
                {
                    trenutnoDjete = rds.GetByID((int)gridView.GetFocusedRowCellValue(gcID));
                }
                catch (Exception)
                {
                    trenutnoDjete = new RadnikDjeca()
                    {
                        ID = 0
                    };
                }
                DjeteArgs myArgs = new DjeteArgs(trenutnoDjete);
                IzmjenaDjeteta(this, myArgs);
            }
        }
    }
}
