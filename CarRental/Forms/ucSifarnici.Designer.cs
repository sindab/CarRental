namespace CarRental.Forms
{
    partial class ucSifarnici
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
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.firmaNavBarGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.opstinaNavBarGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.mjestoNavBarGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.DrzavaNavBarGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.bojaNavBarGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.lokacijaNavBarGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.oblikNavBarGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.markaNavBarGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.opstinaNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.mjestoNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.DrzavaNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.strucnaSpremaNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.radnoMjestoNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.tipRadnogOdnosaNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.nacinPrestankaRONavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.firmaNavigationPage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ucFirma1 = new CarRental.Sifarnici.ucFirma();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.ucDrzava1 = new CarRental.Sifarnici.ucDrzava();
            this.ucOpstine1 = new CarRental.Sifarnici.ucOpstine();
            this.ucMjesta1 = new CarRental.Sifarnici.ucMjesta();
            this.ucLokacija1 = new CarRental.Sifarnici.ucLokacija();
            this.ucBoja1 = new CarRental.Sifarnici.ucBoja();
            this.ucOblik1 = new CarRental.Sifarnici.ucOblik();
            this.ucMarka1 = new CarRental.Sifarnici.ucMarka();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.opstinaNavigationPage.SuspendLayout();
            this.mjestoNavigationPage.SuspendLayout();
            this.DrzavaNavigationPage.SuspendLayout();
            this.strucnaSpremaNavigationPage.SuspendLayout();
            this.radnoMjestoNavigationPage.SuspendLayout();
            this.tipRadnogOdnosaNavigationPage.SuspendLayout();
            this.nacinPrestankaRONavigationPage.SuspendLayout();
            this.firmaNavigationPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabbedView
            // 
            this.tabbedView.RootContainer.Element = null;
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.firmaNavBarGroup;
            this.navBarControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.firmaNavBarGroup,
            this.DrzavaNavBarGroup,
            this.opstinaNavBarGroup,
            this.mjestoNavBarGroup,
            this.lokacijaNavBarGroup,
            this.bojaNavBarGroup,
            this.oblikNavBarGroup,
            this.markaNavBarGroup});
            this.navBarControl.Location = new System.Drawing.Point(0, 0);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 234;
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl.Size = new System.Drawing.Size(234, 648);
            this.navBarControl.TabIndex = 0;
            this.navBarControl.Text = "navBarControl";
            this.navBarControl.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("Office 2013");
            this.navBarControl.ActiveGroupChanged += new DevExpress.XtraNavBar.NavBarGroupEventHandler(this.navBarControl_ActiveGroupChanged);
            // 
            // firmaNavBarGroup
            // 
            this.firmaNavBarGroup.Caption = "Firma";
            this.firmaNavBarGroup.Expanded = true;
            this.firmaNavBarGroup.Name = "firmaNavBarGroup";
            // 
            // opstinaNavBarGroup
            // 
            this.opstinaNavBarGroup.Caption = "Opština";
            this.opstinaNavBarGroup.Name = "opstinaNavBarGroup";
            // 
            // mjestoNavBarGroup
            // 
            this.mjestoNavBarGroup.Caption = "Mjesto";
            this.mjestoNavBarGroup.Name = "mjestoNavBarGroup";
            // 
            // DrzavaNavBarGroup
            // 
            this.DrzavaNavBarGroup.Caption = "Država";
            this.DrzavaNavBarGroup.Name = "DrzavaNavBarGroup";
            // 
            // bojaNavBarGroup
            // 
            this.bojaNavBarGroup.Caption = "Boja";
            this.bojaNavBarGroup.Name = "bojaNavBarGroup";
            // 
            // lokacijaNavBarGroup
            // 
            this.lokacijaNavBarGroup.Caption = "Lokacija";
            this.lokacijaNavBarGroup.Name = "lokacijaNavBarGroup";
            // 
            // oblikNavBarGroup
            // 
            this.oblikNavBarGroup.Caption = "Oblik vozila";
            this.oblikNavBarGroup.Name = "oblikNavBarGroup";
            // 
            // markaNavBarGroup
            // 
            this.markaNavBarGroup.Caption = "Marka vozila";
            this.markaNavBarGroup.Name = "markaNavBarGroup";
            // 
            // navigationFrame
            // 
            this.navigationFrame.Appearance.BackColor = System.Drawing.Color.White;
            this.navigationFrame.Appearance.Options.UseBackColor = true;
            this.navigationFrame.Controls.Add(this.opstinaNavigationPage);
            this.navigationFrame.Controls.Add(this.mjestoNavigationPage);
            this.navigationFrame.Controls.Add(this.DrzavaNavigationPage);
            this.navigationFrame.Controls.Add(this.strucnaSpremaNavigationPage);
            this.navigationFrame.Controls.Add(this.radnoMjestoNavigationPage);
            this.navigationFrame.Controls.Add(this.tipRadnogOdnosaNavigationPage);
            this.navigationFrame.Controls.Add(this.nacinPrestankaRONavigationPage);
            this.navigationFrame.Controls.Add(this.firmaNavigationPage);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(234, 0);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.firmaNavigationPage,
            this.opstinaNavigationPage,
            this.mjestoNavigationPage,
            this.DrzavaNavigationPage,
            this.strucnaSpremaNavigationPage,
            this.radnoMjestoNavigationPage,
            this.tipRadnogOdnosaNavigationPage,
            this.nacinPrestankaRONavigationPage});
            this.navigationFrame.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.navigationFrame.SelectedPage = this.firmaNavigationPage;
            this.navigationFrame.Size = new System.Drawing.Size(770, 648);
            this.navigationFrame.TabIndex = 0;
            this.navigationFrame.Text = "navigationFrame";
            // 
            // opstinaNavigationPage
            // 
            this.opstinaNavigationPage.Controls.Add(this.ucDrzava1);
            this.opstinaNavigationPage.Name = "opstinaNavigationPage";
            this.opstinaNavigationPage.Size = new System.Drawing.Size(770, 648);
            // 
            // mjestoNavigationPage
            // 
            this.mjestoNavigationPage.Controls.Add(this.ucOpstine1);
            this.mjestoNavigationPage.Name = "mjestoNavigationPage";
            this.mjestoNavigationPage.Size = new System.Drawing.Size(770, 648);
            // 
            // DrzavaNavigationPage
            // 
            this.DrzavaNavigationPage.Controls.Add(this.ucMjesta1);
            this.DrzavaNavigationPage.Name = "DrzavaNavigationPage";
            this.DrzavaNavigationPage.Size = new System.Drawing.Size(770, 648);
            // 
            // strucnaSpremaNavigationPage
            // 
            this.strucnaSpremaNavigationPage.Controls.Add(this.ucLokacija1);
            this.strucnaSpremaNavigationPage.Name = "strucnaSpremaNavigationPage";
            this.strucnaSpremaNavigationPage.Size = new System.Drawing.Size(770, 648);
            // 
            // radnoMjestoNavigationPage
            // 
            this.radnoMjestoNavigationPage.Controls.Add(this.ucBoja1);
            this.radnoMjestoNavigationPage.Name = "radnoMjestoNavigationPage";
            this.radnoMjestoNavigationPage.Size = new System.Drawing.Size(770, 648);
            // 
            // tipRadnogOdnosaNavigationPage
            // 
            this.tipRadnogOdnosaNavigationPage.Controls.Add(this.ucOblik1);
            this.tipRadnogOdnosaNavigationPage.Name = "tipRadnogOdnosaNavigationPage";
            this.tipRadnogOdnosaNavigationPage.Size = new System.Drawing.Size(770, 648);
            // 
            // nacinPrestankaRONavigationPage
            // 
            this.nacinPrestankaRONavigationPage.Controls.Add(this.ucMarka1);
            this.nacinPrestankaRONavigationPage.Name = "nacinPrestankaRONavigationPage";
            this.nacinPrestankaRONavigationPage.Size = new System.Drawing.Size(770, 648);
            // 
            // firmaNavigationPage
            // 
            this.firmaNavigationPage.Caption = "firmaNavigationPage";
            this.firmaNavigationPage.Controls.Add(this.ucFirma1);
            this.firmaNavigationPage.Controls.Add(this.labelControl8);
            this.firmaNavigationPage.Name = "firmaNavigationPage";
            this.firmaNavigationPage.Size = new System.Drawing.Size(770, 648);
            // 
            // ucFirma1
            // 
            this.ucFirma1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucFirma1.Location = new System.Drawing.Point(0, 0);
            this.ucFirma1.Name = "ucFirma1";
            this.ucFirma1.Size = new System.Drawing.Size(770, 648);
            this.ucFirma1.TabIndex = 4;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 25.25F);
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Appearance.Options.UseTextOptions = true;
            this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl8.Location = new System.Drawing.Point(0, 0);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(770, 648);
            this.labelControl8.TabIndex = 3;
            this.labelControl8.Text = "Firma";
            // 
            // ucDrzava1
            // 
            this.ucDrzava1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDrzava1.Location = new System.Drawing.Point(0, 0);
            this.ucDrzava1.Name = "ucDrzava1";
            this.ucDrzava1.Size = new System.Drawing.Size(770, 648);
            this.ucDrzava1.TabIndex = 0;
            // 
            // ucOpstine1
            // 
            this.ucOpstine1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucOpstine1.Location = new System.Drawing.Point(0, 0);
            this.ucOpstine1.Name = "ucOpstine1";
            this.ucOpstine1.Size = new System.Drawing.Size(770, 648);
            this.ucOpstine1.TabIndex = 0;
            // 
            // ucMjesta1
            // 
            this.ucMjesta1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMjesta1.Location = new System.Drawing.Point(0, 0);
            this.ucMjesta1.Name = "ucMjesta1";
            this.ucMjesta1.Size = new System.Drawing.Size(770, 648);
            this.ucMjesta1.TabIndex = 0;
            // 
            // ucLokacija1
            // 
            this.ucLokacija1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLokacija1.Location = new System.Drawing.Point(0, 0);
            this.ucLokacija1.Name = "ucLokacija1";
            this.ucLokacija1.Size = new System.Drawing.Size(770, 648);
            this.ucLokacija1.TabIndex = 0;
            // 
            // ucBoja1
            // 
            this.ucBoja1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBoja1.Location = new System.Drawing.Point(0, 0);
            this.ucBoja1.Name = "ucBoja1";
            this.ucBoja1.Size = new System.Drawing.Size(770, 648);
            this.ucBoja1.TabIndex = 0;
            // 
            // ucOblik1
            // 
            this.ucOblik1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucOblik1.Location = new System.Drawing.Point(0, 0);
            this.ucOblik1.Name = "ucOblik1";
            this.ucOblik1.Size = new System.Drawing.Size(770, 648);
            this.ucOblik1.TabIndex = 0;
            // 
            // ucMarka1
            // 
            this.ucMarka1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMarka1.Location = new System.Drawing.Point(0, 0);
            this.ucMarka1.Name = "ucMarka1";
            this.ucMarka1.Size = new System.Drawing.Size(770, 648);
            this.ucMarka1.TabIndex = 0;
            // 
            // ucSifarnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.navBarControl);
            this.Name = "ucSifarnici";
            this.Size = new System.Drawing.Size(1004, 648);
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.opstinaNavigationPage.ResumeLayout(false);
            this.mjestoNavigationPage.ResumeLayout(false);
            this.DrzavaNavigationPage.ResumeLayout(false);
            this.strucnaSpremaNavigationPage.ResumeLayout(false);
            this.radnoMjestoNavigationPage.ResumeLayout(false);
            this.tipRadnogOdnosaNavigationPage.ResumeLayout(false);
            this.nacinPrestankaRONavigationPage.ResumeLayout(false);
            this.firmaNavigationPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup opstinaNavBarGroup;
        private DevExpress.XtraNavBar.NavBarGroup mjestoNavBarGroup;
        private DevExpress.XtraBars.Navigation.NavigationPage opstinaNavigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage mjestoNavigationPage;
        private DevExpress.XtraNavBar.NavBarGroup DrzavaNavBarGroup;
        private DevExpress.XtraNavBar.NavBarGroup bojaNavBarGroup;
        private DevExpress.XtraNavBar.NavBarGroup lokacijaNavBarGroup;
        private DevExpress.XtraNavBar.NavBarGroup oblikNavBarGroup;
        private DevExpress.XtraNavBar.NavBarGroup markaNavBarGroup;
        private DevExpress.XtraBars.Navigation.NavigationPage DrzavaNavigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage strucnaSpremaNavigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage radnoMjestoNavigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage tipRadnogOdnosaNavigationPage;
        private DevExpress.XtraBars.Navigation.NavigationPage nacinPrestankaRONavigationPage;
        private DevExpress.XtraNavBar.NavBarGroup firmaNavBarGroup;
        private DevExpress.XtraBars.Navigation.NavigationPage firmaNavigationPage;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private Sifarnici.ucFirma ucFirma1;
        private Sifarnici.ucDrzava ucDrzava1;
        private Sifarnici.ucOpstine ucOpstine1;
        private Sifarnici.ucMjesta ucMjesta1;
        private Sifarnici.ucLokacija ucLokacija1;
        private Sifarnici.ucBoja ucBoja1;
        private Sifarnici.ucOblik ucOblik1;
        private Sifarnici.ucMarka ucMarka1;
        //private Sifarnici.ucNacionalnost ucNacionalnost1;
        //private Sifarnici.ucStrucnaSprema ucStrucnaSprema1;
        //private Sifarnici.ucRadnoMjesto ucRadnoMjesto1;
        //private Sifarnici.ucTipRadnogOdnosa ucTipRadnogOdnosa1;
        //private Sifarnici.ucNacinPrestankaRO ucNacinPrestankaRO1;
        //private Sifarnici.ucPorodicnoStanje ucPorodicnoStanje1;
        //private Sifarnici.ucFirma ucFirma1;
    }
}
