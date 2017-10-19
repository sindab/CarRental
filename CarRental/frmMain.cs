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

namespace CarRental
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        void navBarControl_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
            navigationFrame.SelectedPageIndex = navBarControl.Groups.IndexOf(e.Group);
        }
        void barButtonNavigation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
            navBarControl.ActiveGroup = navBarControl.Groups[barItemIndex];
        }

        //private void ucRadnici1_IzmjenaOsobaa(object myObject, ucRadnici.OsobaArgs myArgs)
        //{
        //    //Osoba
        //    // ucOsoba ucOsoba1 = new ucOsoba();
        //    //// 
        //    //// ucOsoba1
        //    //// 
        //    //ucOsoba1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
        //    //ucOsoba1.Dock = System.Windows.Forms.DockStyle.Fill;
        //    //ucOsoba1.Location = new System.Drawing.Point(0, 0);
        //    //ucOsoba1.Name = "ucOsoba1";
        //    ////ucOsoba1.Osoba = null;
        //    ucOsoba1.Osoba = myArgs.Osoba;
        //    //ucOsoba1.Size = new System.Drawing.Size(756, 380);
        //    //ucOsoba1.TabIndex = 2;
        //    //employeeNavigationPage.Controls.Add(ucOsoba1);
        //    navBarControl.ActiveGroup = navBarControl.Groups[1];
        //}

        

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //dokumenti
            navBarControl.ActiveGroup = navBarControl.Groups[0];
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //kupci
            navBarControl.ActiveGroup = navBarControl.Groups[1];
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //vozila
            navBarControl.ActiveGroup = navBarControl.Groups[2];
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //sifarnici
            navBarControl.ActiveGroup = navBarControl.Groups[3];
        }
    }
}