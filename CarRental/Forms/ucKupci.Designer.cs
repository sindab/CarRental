namespace CarRental.Forms
{
    partial class ucKupci
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcJMBG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPrezime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcIme = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDatumRodjenja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcMjestoStan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkpMjestoStan = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcAdresaStan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTelefonStan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTelefonMob = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcBrLK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcBrPasos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcBrVozacka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNapomena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcEMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpMjestoStan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 116);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lkpMjestoStan});
            this.gridControl.Size = new System.Drawing.Size(800, 457);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcID,
            this.gcJMBG,
            this.gcPrezime,
            this.gcIme,
            this.gcDatumRodjenja,
            this.gcMjestoStan,
            this.gcAdresaStan,
            this.gcTelefonStan,
            this.gcTelefonMob,
            this.gcBrLK,
            this.gcBrPasos,
            this.gcBrVozacka,
            this.gcNapomena,
            this.gcEMail,
            this.gcPol});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.OptionsFind.AlwaysVisible = true;
            this.gridView.OptionsFind.FindNullPrompt = "Tekst za pretragu...";
            this.gridView.OptionsLayout.Columns.StoreAllOptions = true;
            this.gridView.OptionsLayout.Columns.StoreAppearance = true;
            this.gridView.OptionsLayout.StoreAllOptions = true;
            this.gridView.OptionsLayout.StoreAppearance = true;
            this.gridView.OptionsLayout.StoreFormatRules = true;
            this.gridView.OptionsView.ShowPreview = true;
            this.gridView.PreviewFieldName = "Napomena";
            this.gridView.PreviewLineCount = 1;
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // gcID
            // 
            this.gcID.Caption = "Šifra";
            this.gcID.FieldName = "ID";
            this.gcID.Name = "gcID";
            // 
            // gcJMBG
            // 
            this.gcJMBG.Caption = "JMBG";
            this.gcJMBG.FieldName = "JMBG";
            this.gcJMBG.Name = "gcJMBG";
            this.gcJMBG.Visible = true;
            this.gcJMBG.VisibleIndex = 0;
            this.gcJMBG.Width = 82;
            // 
            // gcPrezime
            // 
            this.gcPrezime.Caption = "Prezime";
            this.gcPrezime.FieldName = "Prezime";
            this.gcPrezime.Name = "gcPrezime";
            this.gcPrezime.Visible = true;
            this.gcPrezime.VisibleIndex = 1;
            this.gcPrezime.Width = 124;
            // 
            // gcIme
            // 
            this.gcIme.Caption = "Ime";
            this.gcIme.FieldName = "Ime";
            this.gcIme.Name = "gcIme";
            this.gcIme.Visible = true;
            this.gcIme.VisibleIndex = 2;
            this.gcIme.Width = 128;
            // 
            // gcDatumRodjenja
            // 
            this.gcDatumRodjenja.Caption = "Datum rođenja";
            this.gcDatumRodjenja.FieldName = "DatumRodjenja";
            this.gcDatumRodjenja.Name = "gcDatumRodjenja";
            // 
            // gcMjestoStan
            // 
            this.gcMjestoStan.Caption = "Mjesto stanovanja";
            this.gcMjestoStan.ColumnEdit = this.lkpMjestoStan;
            this.gcMjestoStan.FieldName = "MjestoStan";
            this.gcMjestoStan.Name = "gcMjestoStan";
            this.gcMjestoStan.Visible = true;
            this.gcMjestoStan.VisibleIndex = 5;
            this.gcMjestoStan.Width = 98;
            // 
            // lkpMjestoStan
            // 
            this.lkpMjestoStan.AutoHeight = false;
            this.lkpMjestoStan.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpMjestoStan.DisplayMember = "Naziv";
            this.lkpMjestoStan.KeyMember = "MjestoStan";
            this.lkpMjestoStan.Name = "lkpMjestoStan";
            this.lkpMjestoStan.NullText = "";
            this.lkpMjestoStan.ValueMember = "ID";
            this.lkpMjestoStan.View = this.gridView4;
            // 
            // gridView4
            // 
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // gcAdresaStan
            // 
            this.gcAdresaStan.Caption = "Adresa";
            this.gcAdresaStan.FieldName = "AdresaStan";
            this.gcAdresaStan.Name = "gcAdresaStan";
            this.gcAdresaStan.Visible = true;
            this.gcAdresaStan.VisibleIndex = 4;
            this.gcAdresaStan.Width = 134;
            // 
            // gcTelefonStan
            // 
            this.gcTelefonStan.Caption = "Telefon";
            this.gcTelefonStan.FieldName = "TelefonStan";
            this.gcTelefonStan.Name = "gcTelefonStan";
            this.gcTelefonStan.Visible = true;
            this.gcTelefonStan.VisibleIndex = 7;
            this.gcTelefonStan.Width = 91;
            // 
            // gcTelefonMob
            // 
            this.gcTelefonMob.Caption = "Mobilni";
            this.gcTelefonMob.FieldName = "TelefonMob";
            this.gcTelefonMob.Name = "gcTelefonMob";
            this.gcTelefonMob.Visible = true;
            this.gcTelefonMob.VisibleIndex = 6;
            this.gcTelefonMob.Width = 80;
            // 
            // gcBrLK
            // 
            this.gcBrLK.Caption = "LK broj";
            this.gcBrLK.FieldName = "BrLK";
            this.gcBrLK.Name = "gcBrLK";
            // 
            // gcBrPasos
            // 
            this.gcBrPasos.Caption = "Pasoš";
            this.gcBrPasos.FieldName = "BrPasos";
            this.gcBrPasos.Name = "gcBrPasos";
            // 
            // gcBrVozacka
            // 
            this.gcBrVozacka.Caption = "Vozačka";
            this.gcBrVozacka.FieldName = "BrVozacka";
            this.gcBrVozacka.Name = "gcBrVozacka";
            // 
            // gcNapomena
            // 
            this.gcNapomena.Caption = "Napomena";
            this.gcNapomena.FieldName = "Napomena";
            this.gcNapomena.Name = "gcNapomena";
            // 
            // gcEMail
            // 
            this.gcEMail.Caption = "eMail";
            this.gcEMail.FieldName = "eMail";
            this.gcEMail.Name = "gcEMail";
            // 
            // gcPol
            // 
            this.gcPol.Caption = "Pol";
            this.gcPol.FieldName = "Pol";
            this.gcPol.Name = "gcPol";
            this.gcPol.Visible = true;
            this.gcPol.VisibleIndex = 3;
            this.gcPol.Width = 47;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.bbiNew,
            this.bbiEdit,
            this.bbiDelete,
            this.bbiRefresh,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 3;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(800, 116);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Štampa tabele";
            this.bbiPrintPreview.Id = 14;
            this.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview";
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            this.bbiPrintPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrintPreview_ItemClick);
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // bbiNew
            // 
            this.bbiNew.Caption = "Novi";
            this.bbiNew.Id = 16;
            this.bbiNew.ImageOptions.ImageUri.Uri = "New";
            this.bbiNew.Name = "bbiNew";
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Izmjena";
            this.bbiEdit.Id = 17;
            this.bbiEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiEdit.Name = "bbiEdit";
            this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Brisanje";
            this.bbiDelete.Id = 18;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Osvježi";
            this.bbiRefresh.Id = 19;
            this.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Snimi izgled tabele";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.ImageUri.Uri = "ExportToXML";
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Učitaj izgled tabele";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.ImageUri.Uri = "SaveAndNew";
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "CarRental";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Podaci";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiPrintPreview);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Izvještaji i export";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Tema";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 573);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(800, 27);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xml";
            this.openFileDialog1.FileName = "Kupci.xml";
            this.openFileDialog1.Filter = "XML|*.xml";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Kupci.xml";
            this.saveFileDialog1.Filter = "XML|*.xml";
            // 
            // ucKupci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Name = "ucKupci";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.ucRadnici_Load);
            this.VisibleChanged += new System.EventHandler(this.ucRadnici_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpMjestoStan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn gcID;
        private DevExpress.XtraGrid.Columns.GridColumn gcJMBG;
        private DevExpress.XtraGrid.Columns.GridColumn gcPrezime;
        private DevExpress.XtraGrid.Columns.GridColumn gcIme;
        private DevExpress.XtraGrid.Columns.GridColumn gcDatumRodjenja;
        private DevExpress.XtraGrid.Columns.GridColumn gcMjestoStan;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit lkpMjestoStan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gcAdresaStan;
        private DevExpress.XtraGrid.Columns.GridColumn gcTelefonStan;
        private DevExpress.XtraGrid.Columns.GridColumn gcTelefonMob;
        private DevExpress.XtraGrid.Columns.GridColumn gcBrLK;
        private DevExpress.XtraGrid.Columns.GridColumn gcBrPasos;
        private DevExpress.XtraGrid.Columns.GridColumn gcBrVozacka;
        private DevExpress.XtraGrid.Columns.GridColumn gcNapomena;
        private DevExpress.XtraGrid.Columns.GridColumn gcEMail;
        private DevExpress.XtraGrid.Columns.GridColumn gcPol;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}
