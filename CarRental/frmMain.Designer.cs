namespace CarRental
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barSubItemNavigation = new DevExpress.XtraBars.BarSubItem();
            this.employeesBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.customersBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.mnuRadnici = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupNavigation = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.officeNavigationBar = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.rentaNavBarGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.employeesNavBarGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.vehicleNavBarGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.employeesNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ucRadnici1 = new CarRental.ucKupci();
            this.employeesLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.employeeNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.customersLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.sifarniciNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ucSifarnici1 = new CarRental.ucSifarnici();
            this.rentaNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ucDokumenti1 = new CarRental.ucDokumenti();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.employeesNavigationPage.SuspendLayout();
            this.employeeNavigationPage.SuspendLayout();
            this.sifarniciNavigationPage.SuspendLayout();
            this.rentaNavigationPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabbedView
            // 
            this.tabbedView.RootContainer.Element = null;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.skinRibbonGalleryBarItem,
            this.barSubItemNavigation,
            this.employeesBarButtonItem,
            this.customersBarButtonItem,
            this.mnuRadnici,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 53;
            this.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(790, 162);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // skinRibbonGalleryBarItem
            // 
            this.skinRibbonGalleryBarItem.Id = 14;
            this.skinRibbonGalleryBarItem.Name = "skinRibbonGalleryBarItem";
            // 
            // barSubItemNavigation
            // 
            this.barSubItemNavigation.Caption = "Navigacija";
            this.barSubItemNavigation.Id = 15;
            this.barSubItemNavigation.ImageOptions.ImageUri.Uri = "NavigationBar";
            this.barSubItemNavigation.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.employeesBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.customersBarButtonItem)});
            this.barSubItemNavigation.Name = "barSubItemNavigation";
            this.barSubItemNavigation.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // employeesBarButtonItem
            // 
            this.employeesBarButtonItem.Caption = "Radnici";
            this.employeesBarButtonItem.Id = 44;
            this.employeesBarButtonItem.Name = "employeesBarButtonItem";
            this.employeesBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonNavigation_ItemClick);
            // 
            // customersBarButtonItem
            // 
            this.customersBarButtonItem.Caption = "Customers";
            this.customersBarButtonItem.Id = 45;
            this.customersBarButtonItem.Name = "customersBarButtonItem";
            this.customersBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonNavigation_ItemClick);
            // 
            // mnuRadnici
            // 
            this.mnuRadnici.Caption = "Kupci";
            this.mnuRadnici.Id = 46;
            this.mnuRadnici.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnuRadnici.ImageOptions.Image")));
            this.mnuRadnici.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mnuRadnici.ImageOptions.LargeImage")));
            this.mnuRadnici.Name = "mnuRadnici";
            this.mnuRadnici.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Šifarnici";
            this.barButtonItem1.Id = 48;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_1);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Dokumenti";
            this.barButtonItem2.Id = 49;
            this.barButtonItem2.ImageOptions.ImageUri.Uri = "Today;Size32x32";
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Vozila";
            this.barButtonItem3.Id = 52;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupNavigation,
            this.ribbonPageGroup});
            this.ribbonPage.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage.Image")));
            this.ribbonPage.Name = "ribbonPage";
            this.ribbonPage.Text = "CarRental";
            // 
            // ribbonPageGroupNavigation
            // 
            this.ribbonPageGroupNavigation.ItemLinks.Add(this.barSubItemNavigation);
            this.ribbonPageGroupNavigation.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroupNavigation.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroupNavigation.ItemLinks.Add(this.mnuRadnici);
            this.ribbonPageGroupNavigation.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroupNavigation.Name = "ribbonPageGroupNavigation";
            this.ribbonPageGroupNavigation.Text = "Modul";
            // 
            // ribbonPageGroup
            // 
            this.ribbonPageGroup.AllowTextClipping = false;
            this.ribbonPageGroup.ItemLinks.Add(this.skinRibbonGalleryBarItem);
            this.ribbonPageGroup.Name = "ribbonPageGroup";
            this.ribbonPageGroup.ShowCaptionButton = false;
            this.ribbonPageGroup.Text = "Tema";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 568);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(790, 31);
            // 
            // officeNavigationBar
            // 
            this.officeNavigationBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.officeNavigationBar.Location = new System.Drawing.Point(0, 523);
            this.officeNavigationBar.Name = "officeNavigationBar";
            this.officeNavigationBar.NavigationClient = this.navBarControl;
            this.officeNavigationBar.Size = new System.Drawing.Size(790, 45);
            this.officeNavigationBar.TabIndex = 1;
            this.officeNavigationBar.Text = "officeNavigationBar";
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.rentaNavBarGroup;
            this.navBarControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.rentaNavBarGroup,
            this.employeesNavBarGroup,
            this.vehicleNavBarGroup,
            this.navBarGroup1});
            this.navBarControl.Location = new System.Drawing.Point(0, 162);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsLayout.StoreAppearance = true;
            this.navBarControl.OptionsNavPane.ExpandedWidth = 34;
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl.Size = new System.Drawing.Size(34, 361);
            this.navBarControl.TabIndex = 0;
            this.navBarControl.Text = "navBarControl";
            this.navBarControl.Visible = false;
            this.navBarControl.ActiveGroupChanged += new DevExpress.XtraNavBar.NavBarGroupEventHandler(this.navBarControl_ActiveGroupChanged);
            // 
            // rentaNavBarGroup
            // 
            this.rentaNavBarGroup.Caption = "Dokumenti";
            this.rentaNavBarGroup.Expanded = true;
            this.rentaNavBarGroup.Name = "rentaNavBarGroup";
            // 
            // employeesNavBarGroup
            // 
            this.employeesNavBarGroup.Caption = "Kupci";
            this.employeesNavBarGroup.Name = "employeesNavBarGroup";
            // 
            // vehicleNavBarGroup
            // 
            this.vehicleNavBarGroup.Caption = "Vozila";
            this.vehicleNavBarGroup.Name = "vehicleNavBarGroup";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Šifarnici";
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navigationFrame
            // 
            this.navigationFrame.Appearance.BackColor = System.Drawing.Color.White;
            this.navigationFrame.Appearance.Options.UseBackColor = true;
            this.navigationFrame.Controls.Add(this.employeesNavigationPage);
            this.navigationFrame.Controls.Add(this.employeeNavigationPage);
            this.navigationFrame.Controls.Add(this.sifarniciNavigationPage);
            this.navigationFrame.Controls.Add(this.rentaNavigationPage);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(34, 162);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.rentaNavigationPage,
            this.employeesNavigationPage,
            this.employeeNavigationPage,
            this.sifarniciNavigationPage});
            this.navigationFrame.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.navigationFrame.SelectedPage = this.rentaNavigationPage;
            this.navigationFrame.Size = new System.Drawing.Size(756, 361);
            this.navigationFrame.TabIndex = 0;
            this.navigationFrame.Text = "navigationFrame";
            // 
            // employeesNavigationPage
            // 
            this.employeesNavigationPage.Controls.Add(this.ucRadnici1);
            this.employeesNavigationPage.Controls.Add(this.employeesLabelControl);
            this.employeesNavigationPage.Name = "employeesNavigationPage";
            this.employeesNavigationPage.Size = new System.Drawing.Size(756, 361);
            // 
            // ucRadnici1
            // 
            this.ucRadnici1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucRadnici1.Location = new System.Drawing.Point(0, 0);
            this.ucRadnici1.Name = "ucRadnici1";
            this.ucRadnici1.Size = new System.Drawing.Size(756, 361);
            this.ucRadnici1.TabIndex = 1;
            this.ucRadnici1.TrenutniOsoba = null;
            // 
            // employeesLabelControl
            // 
            this.employeesLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 25.25F);
            this.employeesLabelControl.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.employeesLabelControl.Appearance.Options.UseFont = true;
            this.employeesLabelControl.Appearance.Options.UseForeColor = true;
            this.employeesLabelControl.Appearance.Options.UseTextOptions = true;
            this.employeesLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.employeesLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.employeesLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.employeesLabelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesLabelControl.Location = new System.Drawing.Point(0, 0);
            this.employeesLabelControl.Name = "employeesLabelControl";
            this.employeesLabelControl.Size = new System.Drawing.Size(756, 361);
            this.employeesLabelControl.TabIndex = 0;
            this.employeesLabelControl.Text = "Employees";
            // 
            // employeeNavigationPage
            // 
            this.employeeNavigationPage.Controls.Add(this.customersLabelControl);
            this.employeeNavigationPage.Name = "employeeNavigationPage";
            this.employeeNavigationPage.Size = new System.Drawing.Size(756, 361);
            // 
            // customersLabelControl
            // 
            this.customersLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 25.25F);
            this.customersLabelControl.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.customersLabelControl.Appearance.Options.UseFont = true;
            this.customersLabelControl.Appearance.Options.UseForeColor = true;
            this.customersLabelControl.Appearance.Options.UseTextOptions = true;
            this.customersLabelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.customersLabelControl.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.customersLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.customersLabelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersLabelControl.Location = new System.Drawing.Point(0, 0);
            this.customersLabelControl.Name = "customersLabelControl";
            this.customersLabelControl.Size = new System.Drawing.Size(756, 361);
            this.customersLabelControl.TabIndex = 1;
            this.customersLabelControl.Text = "Vozila";
            // 
            // sifarniciNavigationPage
            // 
            this.sifarniciNavigationPage.Controls.Add(this.ucSifarnici1);
            this.sifarniciNavigationPage.Name = "sifarniciNavigationPage";
            this.sifarniciNavigationPage.Size = new System.Drawing.Size(756, 361);
            // 
            // ucSifarnici1
            // 
            this.ucSifarnici1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSifarnici1.Location = new System.Drawing.Point(0, 0);
            this.ucSifarnici1.Name = "ucSifarnici1";
            this.ucSifarnici1.Size = new System.Drawing.Size(756, 361);
            this.ucSifarnici1.TabIndex = 0;
            // 
            // rentaNavigationPage
            // 
            this.rentaNavigationPage.Controls.Add(this.ucDokumenti1);
            this.rentaNavigationPage.Name = "rentaNavigationPage";
            this.rentaNavigationPage.Size = new System.Drawing.Size(756, 361);
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "navigationPage1";
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(750, 380);
            // 
            // ucDokumenti1
            // 
            this.ucDokumenti1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDokumenti1.Location = new System.Drawing.Point(0, 0);
            this.ucDokumenti1.Name = "ucDokumenti1";
            this.ucDokumenti1.Size = new System.Drawing.Size(756, 361);
            this.ucDokumenti1.TabIndex = 0;
            this.ucDokumenti1.TrenutniRenta = null;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 599);
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.navBarControl);
            this.Controls.Add(this.officeNavigationBar);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.employeesNavigationPage.ResumeLayout(false);
            this.employeeNavigationPage.ResumeLayout(false);
            this.sifarniciNavigationPage.ResumeLayout(false);
            this.rentaNavigationPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupNavigation;
        private DevExpress.XtraBars.BarSubItem barSubItemNavigation;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem;
        private DevExpress.XtraBars.Navigation.OfficeNavigationBar officeNavigationBar;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup employeesNavBarGroup;
        private DevExpress.XtraNavBar.NavBarGroup vehicleNavBarGroup;
        private DevExpress.XtraBars.Navigation.NavigationPage employeesNavigationPage;
        private DevExpress.XtraEditors.LabelControl employeesLabelControl;
        private DevExpress.XtraBars.Navigation.NavigationPage employeeNavigationPage;
        private DevExpress.XtraEditors.LabelControl customersLabelControl;
        private DevExpress.XtraBars.BarButtonItem employeesBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem customersBarButtonItem;
        private ucKupci ucRadnici1;
        private DevExpress.XtraBars.BarButtonItem mnuRadnici;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage sifarniciNavigationPage;
        private ucSifarnici ucSifarnici1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Navigation.NavigationPage rentaNavigationPage;
        private DevExpress.XtraNavBar.NavBarGroup rentaNavBarGroup;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private ucDokumenti ucDokumenti1;
        //private ucNotifikacije ucNotifikacije1;
        //private System.Windows.Forms.Timer timer1;
    }
}