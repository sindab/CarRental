namespace CarRental.Forms
{
    partial class ucVozila
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
            this.gridView = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.Slika = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gcID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.RegBr = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.MarkaID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.lkpMarka = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Tip = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.OblikID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.lkpOblik = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BojaID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.lkpBoja = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Napomena = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.BrojVrata = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.BrojSjedista = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ZapreminaGorivo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.NetoTezina = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.Nosivost = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.Sasija = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.BrMotora = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.TipMotora = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ZapreminaMotor = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.Snaga = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.Godina = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.DatumReg = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.Cijena = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
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
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpMarka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpOblik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpBoja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
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
            this.lkpMarka,
            this.lkpBoja,
            this.lkpOblik,
            this.repositoryItemImageEdit1,
            this.repositoryItemPictureEdit1});
            this.gridControl.Size = new System.Drawing.Size(1161, 560);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand2,
            this.gridBand1,
            this.gridBand6});
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.gcID,
            this.RegBr,
            this.Sasija,
            this.MarkaID,
            this.Tip,
            this.BojaID,
            this.OblikID,
            this.Godina,
            this.BrMotora,
            this.Snaga,
            this.ZapreminaMotor,
            this.TipMotora,
            this.NetoTezina,
            this.BrojVrata,
            this.BrojSjedista,
            this.Nosivost,
            this.DatumReg,
            this.ZapreminaGorivo,
            this.Cijena,
            this.Napomena,
            this.Slika});
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
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // gridBand2
            // 
            this.gridBand2.Columns.Add(this.Slika);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 0;
            this.gridBand2.Width = 136;
            // 
            // Slika
            // 
            this.Slika.Caption = "Slika";
            this.Slika.ColumnEdit = this.repositoryItemPictureEdit1;
            this.Slika.FieldName = "Slika";
            this.Slika.Name = "Slika";
            this.Slika.RowCount = 4;
            this.Slika.Visible = true;
            this.Slika.Width = 136;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.repositoryItemPictureEdit1.ZoomAccelerationFactor = 1D;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Opšti podaci";
            this.gridBand1.Columns.Add(this.gcID);
            this.gridBand1.Columns.Add(this.RegBr);
            this.gridBand1.Columns.Add(this.MarkaID);
            this.gridBand1.Columns.Add(this.Tip);
            this.gridBand1.Columns.Add(this.OblikID);
            this.gridBand1.Columns.Add(this.BojaID);
            this.gridBand1.Columns.Add(this.Napomena);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 1;
            this.gridBand1.Width = 560;
            // 
            // gcID
            // 
            this.gcID.Caption = "ID";
            this.gcID.FieldName = "ID";
            this.gcID.Name = "gcID";
            this.gcID.Visible = true;
            this.gcID.Width = 35;
            // 
            // RegBr
            // 
            this.RegBr.Caption = "Reg.br.";
            this.RegBr.FieldName = "RegBr";
            this.RegBr.Name = "RegBr";
            this.RegBr.Visible = true;
            this.RegBr.Width = 63;
            // 
            // MarkaID
            // 
            this.MarkaID.Caption = "Marka";
            this.MarkaID.ColumnEdit = this.lkpMarka;
            this.MarkaID.FieldName = "MarkaID";
            this.MarkaID.Name = "MarkaID";
            this.MarkaID.Visible = true;
            this.MarkaID.Width = 96;
            // 
            // lkpMarka
            // 
            this.lkpMarka.AutoHeight = false;
            this.lkpMarka.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpMarka.DisplayMember = "Naziv";
            this.lkpMarka.KeyMember = "MarkaID";
            this.lkpMarka.Name = "lkpMarka";
            this.lkpMarka.NullText = "";
            this.lkpMarka.ValueMember = "ID";
            this.lkpMarka.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Tip
            // 
            this.Tip.Caption = "Tip";
            this.Tip.FieldName = "Tip";
            this.Tip.Name = "Tip";
            this.Tip.Visible = true;
            this.Tip.Width = 141;
            // 
            // OblikID
            // 
            this.OblikID.Caption = "Oblik";
            this.OblikID.ColumnEdit = this.lkpOblik;
            this.OblikID.FieldName = "OblikID";
            this.OblikID.Name = "OblikID";
            this.OblikID.Visible = true;
            this.OblikID.Width = 124;
            // 
            // lkpOblik
            // 
            this.lkpOblik.AutoHeight = false;
            this.lkpOblik.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpOblik.DisplayMember = "Naziv";
            this.lkpOblik.KeyMember = "OblikID";
            this.lkpOblik.Name = "lkpOblik";
            this.lkpOblik.NullText = "";
            this.lkpOblik.ValueMember = "ID";
            this.lkpOblik.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // BojaID
            // 
            this.BojaID.Caption = "Boja";
            this.BojaID.ColumnEdit = this.lkpBoja;
            this.BojaID.FieldName = "BojaID";
            this.BojaID.Name = "BojaID";
            this.BojaID.Visible = true;
            this.BojaID.Width = 101;
            // 
            // lkpBoja
            // 
            this.lkpBoja.AutoHeight = false;
            this.lkpBoja.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpBoja.DisplayMember = "Naziv";
            this.lkpBoja.KeyMember = "BojaID";
            this.lkpBoja.Name = "lkpBoja";
            this.lkpBoja.NullText = "";
            this.lkpBoja.ValueMember = "ID";
            this.lkpBoja.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Napomena
            // 
            this.Napomena.Caption = "Napomena";
            this.Napomena.FieldName = "Napomena";
            this.Napomena.Name = "Napomena";
            this.Napomena.RowCount = 3;
            this.Napomena.RowIndex = 1;
            this.Napomena.Visible = true;
            this.Napomena.Width = 560;
            // 
            // gridBand6
            // 
            this.gridBand6.Caption = "Performanse";
            this.gridBand6.Columns.Add(this.BrojVrata);
            this.gridBand6.Columns.Add(this.BrojSjedista);
            this.gridBand6.Columns.Add(this.ZapreminaGorivo);
            this.gridBand6.Columns.Add(this.NetoTezina);
            this.gridBand6.Columns.Add(this.Nosivost);
            this.gridBand6.Columns.Add(this.Sasija);
            this.gridBand6.Columns.Add(this.BrMotora);
            this.gridBand6.Columns.Add(this.TipMotora);
            this.gridBand6.Columns.Add(this.ZapreminaMotor);
            this.gridBand6.Columns.Add(this.Snaga);
            this.gridBand6.Columns.Add(this.Godina);
            this.gridBand6.Columns.Add(this.DatumReg);
            this.gridBand6.Columns.Add(this.Cijena);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.VisibleIndex = 2;
            this.gridBand6.Width = 417;
            // 
            // BrojVrata
            // 
            this.BrojVrata.Caption = "Vrata";
            this.BrojVrata.FieldName = "BrojVrata";
            this.BrojVrata.Name = "BrojVrata";
            this.BrojVrata.Visible = true;
            this.BrojVrata.Width = 69;
            // 
            // BrojSjedista
            // 
            this.BrojSjedista.Caption = "Sjedišta";
            this.BrojSjedista.FieldName = "BrojSjedista";
            this.BrojSjedista.Name = "BrojSjedista";
            this.BrojSjedista.Visible = true;
            this.BrojSjedista.Width = 77;
            // 
            // ZapreminaGorivo
            // 
            this.ZapreminaGorivo.Caption = "Rezervoar";
            this.ZapreminaGorivo.FieldName = "ZapreminaGorivo";
            this.ZapreminaGorivo.Name = "ZapreminaGorivo";
            this.ZapreminaGorivo.Visible = true;
            this.ZapreminaGorivo.Width = 102;
            // 
            // NetoTezina
            // 
            this.NetoTezina.Caption = "Težina";
            this.NetoTezina.FieldName = "NetoTezina";
            this.NetoTezina.Name = "NetoTezina";
            this.NetoTezina.Visible = true;
            this.NetoTezina.Width = 69;
            // 
            // Nosivost
            // 
            this.Nosivost.Caption = "Nosivost";
            this.Nosivost.FieldName = "Nosivost";
            this.Nosivost.Name = "Nosivost";
            this.Nosivost.Visible = true;
            this.Nosivost.Width = 100;
            // 
            // Sasija
            // 
            this.Sasija.Caption = "Šasija";
            this.Sasija.FieldName = "Sasija";
            this.Sasija.Name = "Sasija";
            this.Sasija.RowIndex = 1;
            this.Sasija.Visible = true;
            this.Sasija.Width = 213;
            // 
            // BrMotora
            // 
            this.BrMotora.Caption = "Br.motora";
            this.BrMotora.FieldName = "BrMotora";
            this.BrMotora.Name = "BrMotora";
            this.BrMotora.RowIndex = 1;
            this.BrMotora.Visible = true;
            this.BrMotora.Width = 204;
            // 
            // TipMotora
            // 
            this.TipMotora.Caption = "Tip motora";
            this.TipMotora.FieldName = "TipMotora";
            this.TipMotora.Name = "TipMotora";
            this.TipMotora.RowIndex = 2;
            this.TipMotora.Visible = true;
            this.TipMotora.Width = 161;
            // 
            // ZapreminaMotor
            // 
            this.ZapreminaMotor.Caption = "Zapremina";
            this.ZapreminaMotor.FieldName = "ZapreminaMotor";
            this.ZapreminaMotor.Name = "ZapreminaMotor";
            this.ZapreminaMotor.RowIndex = 2;
            this.ZapreminaMotor.Visible = true;
            this.ZapreminaMotor.Width = 149;
            // 
            // Snaga
            // 
            this.Snaga.Caption = "Snaga";
            this.Snaga.FieldName = "Snaga";
            this.Snaga.Name = "Snaga";
            this.Snaga.RowIndex = 2;
            this.Snaga.Visible = true;
            this.Snaga.Width = 107;
            // 
            // Godina
            // 
            this.Godina.Caption = "Godište";
            this.Godina.FieldName = "Godina";
            this.Godina.Name = "Godina";
            this.Godina.RowIndex = 3;
            this.Godina.Visible = true;
            this.Godina.Width = 119;
            // 
            // DatumReg
            // 
            this.DatumReg.Caption = "Registracija";
            this.DatumReg.FieldName = "DatumReg";
            this.DatumReg.Name = "DatumReg";
            this.DatumReg.RowIndex = 3;
            this.DatumReg.Visible = true;
            this.DatumReg.Width = 180;
            // 
            // Cijena
            // 
            this.Cijena.Caption = "Cijena";
            this.Cijena.FieldName = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.RowIndex = 3;
            this.Cijena.Visible = true;
            this.Cijena.Width = 118;
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
            this.ribbonControl.Size = new System.Drawing.Size(1161, 116);
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 676);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1161, 27);
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xml";
            this.openFileDialog1.FileName = "Renta.xml";
            this.openFileDialog1.Filter = "XML|*.xml";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Renta.xml";
            this.saveFileDialog1.Filter = "XML|*.xml";
            // 
            // ucVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Name = "ucVozila";
            this.Size = new System.Drawing.Size(1161, 703);
            this.Load += new System.EventHandler(this.ucVozila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpMarka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpOblik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpBoja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
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
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit lkpMarka;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit lkpBoja;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit lkpOblik;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gridView;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gcID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn MarkaID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn RegBr;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Tip;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Godina;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn OblikID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Cijena;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn BojaID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Sasija;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn BrMotora;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Snaga;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ZapreminaMotor;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn TipMotora;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn NetoTezina;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn BrojVrata;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn BrojSjedista;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Nosivost;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn DatumReg;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ZapreminaGorivo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Napomena;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn Slika;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
    }
}
