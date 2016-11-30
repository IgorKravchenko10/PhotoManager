namespace PhotoManager.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.grvOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlCustomers = new DevExpress.XtraGrid.GridControl();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grvWorkTypes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlOrders = new DevExpress.XtraGrid.GridControl();
            this.bndOrders = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkAddress1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderState1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnCreateOrder = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCreateCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCreateWorkType = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnFindCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnFindOrder = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu2 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.ribbonPageHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.bndCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.bndWorkTypes = new System.Windows.Forms.BindingSource(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarOrders = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarCustomers = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarWorkTypes = new DevExpress.XtraNavBar.NavBarItem();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlWorkTypes = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this._PhotoManager_mdfDataSet = new PhotoManager._PhotoManager_mdfDataSet();
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new PhotoManager._PhotoManager_mdfDataSetTableAdapters.CustomersTableAdapter();
            this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ordersTableAdapter1 = new PhotoManager._PhotoManager_mdfDataSetTableAdapters.OrdersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvWorkTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndWorkTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWorkTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PhotoManager_mdfDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // grvOrders
            // 
            this.grvOrders.GridControl = this.gridControlCustomers;
            this.grvOrders.Name = "grvOrders";
            // 
            // gridControlCustomers
            // 
            this.gridControlCustomers.DataSource = this.customersBindingSource1;
            resources.ApplyResources(this.gridControlCustomers, "gridControlCustomers");
            gridLevelNode2.LevelTemplate = this.grvOrders;
            gridLevelNode2.RelationName = "Level1";
            this.gridControlCustomers.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gridControlCustomers.MainView = this.grvCustomers;
            this.gridControlCustomers.Name = "gridControlCustomers";
            this.gridControlCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCustomers,
            this.grvWorkTypes,
            this.grvOrders});
            // 
            // grvCustomers
            // 
            this.grvCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerId,
            this.colCustomerName,
            this.colPhoneNumber,
            this.colAddress,
            this.colCustomerNote});
            this.grvCustomers.GridControl = this.gridControlCustomers;
            this.grvCustomers.Name = "grvCustomers";
            // 
            // grvWorkTypes
            // 
            this.grvWorkTypes.GridControl = this.gridControlCustomers;
            this.grvWorkTypes.Name = "grvWorkTypes";
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControlOrders;
            this.gridView3.Name = "gridView3";
            // 
            // gridControlOrders
            // 
            this.gridControlOrders.DataSource = this.bndOrders;
            resources.ApplyResources(this.gridControlOrders, "gridControlOrders");
            this.gridControlOrders.MainView = this.gridView1;
            this.gridControlOrders.Name = "gridControlOrders";
            this.gridControlOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2,
            this.gridView3});
            // 
            // bndOrders
            // 
            this.bndOrders.DataSource = typeof(PhotoManager.ProxyClasses.PrxOrder);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colWorkType,
            this.colCustomerName1,
            this.colOrderDate1,
            this.colWorkDate1,
            this.colWorkAddress1,
            this.colPrice1,
            this.colOrderState1,
            this.colNote});
            this.gridView1.GridControl = this.gridControlOrders;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            resources.ApplyResources(this.colId, "colId");
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            resources.ApplyResources(this.colName, "colName");
            // 
            // colWorkType
            // 
            this.colWorkType.FieldName = "WorkType";
            this.colWorkType.Name = "colWorkType";
            resources.ApplyResources(this.colWorkType, "colWorkType");
            // 
            // colCustomerName1
            // 
            this.colCustomerName1.FieldName = "CustomerName";
            this.colCustomerName1.Name = "colCustomerName1";
            resources.ApplyResources(this.colCustomerName1, "colCustomerName1");
            // 
            // colOrderDate1
            // 
            this.colOrderDate1.FieldName = "OrderDate";
            this.colOrderDate1.Name = "colOrderDate1";
            resources.ApplyResources(this.colOrderDate1, "colOrderDate1");
            // 
            // colWorkDate1
            // 
            this.colWorkDate1.FieldName = "WorkDate";
            this.colWorkDate1.Name = "colWorkDate1";
            resources.ApplyResources(this.colWorkDate1, "colWorkDate1");
            // 
            // colWorkAddress1
            // 
            this.colWorkAddress1.FieldName = "WorkAddress";
            this.colWorkAddress1.Name = "colWorkAddress1";
            resources.ApplyResources(this.colWorkAddress1, "colWorkAddress1");
            // 
            // colPrice1
            // 
            this.colPrice1.FieldName = "Price";
            this.colPrice1.Name = "colPrice1";
            resources.ApplyResources(this.colPrice1, "colPrice1");
            // 
            // colOrderState1
            // 
            this.colOrderState1.FieldName = "OrderState";
            this.colOrderState1.Name = "colOrderState1";
            resources.ApplyResources(this.colOrderState1, "colOrderState1");
            // 
            // colNote
            // 
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            resources.ApplyResources(this.colNote, "colNote");
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControlOrders;
            this.gridView2.Name = "gridView2";
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barBtnCreateOrder,
            this.barBtnCreateCustomer,
            this.barBtnCreateWorkType,
            this.barButtonItem4,
            this.barBtnFindCustomer,
            this.barBtnFindOrder,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10});
            resources.ApplyResources(this.ribbon, "ribbon");
            this.ribbon.MaxItemId = 12;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageHome});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barBtnCreateOrder
            // 
            resources.ApplyResources(this.barBtnCreateOrder, "barBtnCreateOrder");
            this.barBtnCreateOrder.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnCreateOrder.Glyph")));
            this.barBtnCreateOrder.Id = 2;
            this.barBtnCreateOrder.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnCreateOrder.LargeGlyph")));
            this.barBtnCreateOrder.Name = "barBtnCreateOrder";
            this.barBtnCreateOrder.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnCreateOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCreateOrder_ItemClick);
            // 
            // barBtnCreateCustomer
            // 
            resources.ApplyResources(this.barBtnCreateCustomer, "barBtnCreateCustomer");
            this.barBtnCreateCustomer.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnCreateCustomer.Glyph")));
            this.barBtnCreateCustomer.Id = 3;
            this.barBtnCreateCustomer.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnCreateCustomer.LargeGlyph")));
            this.barBtnCreateCustomer.Name = "barBtnCreateCustomer";
            this.barBtnCreateCustomer.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnCreateCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCreateCustomer_ItemClick);
            // 
            // barBtnCreateWorkType
            // 
            resources.ApplyResources(this.barBtnCreateWorkType, "barBtnCreateWorkType");
            this.barBtnCreateWorkType.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnCreateWorkType.Glyph")));
            this.barBtnCreateWorkType.Id = 4;
            this.barBtnCreateWorkType.Name = "barBtnCreateWorkType";
            this.barBtnCreateWorkType.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnCreateWorkType.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCreateWorkType_ItemClick);
            // 
            // barButtonItem4
            // 
            resources.ApplyResources(this.barButtonItem4, "barButtonItem4");
            this.barButtonItem4.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.Glyph")));
            this.barButtonItem4.Id = 5;
            this.barButtonItem4.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.LargeGlyph")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barBtnFindCustomer
            // 
            resources.ApplyResources(this.barBtnFindCustomer, "barBtnFindCustomer");
            this.barBtnFindCustomer.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnFindCustomer.Glyph")));
            this.barBtnFindCustomer.Id = 6;
            this.barBtnFindCustomer.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnFindCustomer.LargeGlyph")));
            this.barBtnFindCustomer.Name = "barBtnFindCustomer";
            this.barBtnFindCustomer.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barBtnFindOrder
            // 
            resources.ApplyResources(this.barBtnFindOrder, "barBtnFindOrder");
            this.barBtnFindOrder.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnFindOrder.Glyph")));
            this.barBtnFindOrder.Id = 7;
            this.barBtnFindOrder.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnFindOrder.LargeGlyph")));
            this.barBtnFindOrder.Name = "barBtnFindOrder";
            this.barBtnFindOrder.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem7
            // 
            resources.ApplyResources(this.barButtonItem7, "barButtonItem7");
            this.barButtonItem7.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.Glyph")));
            this.barButtonItem7.Id = 8;
            this.barButtonItem7.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.LargeGlyph")));
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.ActAsDropDown = true;
            this.barButtonItem8.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            resources.ApplyResources(this.barButtonItem8, "barButtonItem8");
            this.barButtonItem8.DropDownControl = this.popupMenu1;
            this.barButtonItem8.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.Glyph")));
            this.barButtonItem8.Id = 9;
            this.barButtonItem8.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.LargeGlyph")));
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // popupMenu1
            // 
            this.popupMenu1.ItemLinks.Add(this.barButtonItem4);
            this.popupMenu1.ItemLinks.Add(this.barButtonItem7);
            this.popupMenu1.ItemLinks.Add(this.barButtonItem9);
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbon;
            // 
            // barButtonItem9
            // 
            resources.ApplyResources(this.barButtonItem9, "barButtonItem9");
            this.barButtonItem9.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.Glyph")));
            this.barButtonItem9.Id = 10;
            this.barButtonItem9.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.LargeGlyph")));
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.ActAsDropDown = true;
            this.barButtonItem10.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            resources.ApplyResources(this.barButtonItem10, "barButtonItem10");
            this.barButtonItem10.DropDownControl = this.popupMenu2;
            this.barButtonItem10.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.Glyph")));
            this.barButtonItem10.Id = 11;
            this.barButtonItem10.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.LargeGlyph")));
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // popupMenu2
            // 
            this.popupMenu2.Name = "popupMenu2";
            this.popupMenu2.Ribbon = this.ribbon;
            // 
            // ribbonPageHome
            // 
            this.ribbonPageHome.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPageHome.Name = "ribbonPageHome";
            resources.ApplyResources(this.ribbonPageHome, "ribbonPageHome");
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnCreateOrder);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnCreateCustomer);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnCreateWorkType);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            resources.ApplyResources(this.ribbonPageGroup2, "ribbonPageGroup2");
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem10);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            resources.ApplyResources(this.ribbonPageGroup3, "ribbonPageGroup3");
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barBtnFindCustomer);
            this.ribbonPageGroup4.ItemLinks.Add(this.barBtnFindOrder);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            resources.ApplyResources(this.ribbonPageGroup4, "ribbonPageGroup4");
            // 
            // ribbonStatusBar
            // 
            resources.ApplyResources(this.ribbonStatusBar, "ribbonStatusBar");
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            // 
            // bndCustomers
            // 
            this.bndCustomers.DataSource = typeof(PhotoManager.ProxyClasses.PrxCustomer);
            // 
            // bndWorkTypes
            // 
            this.bndWorkTypes.DataSource = typeof(PhotoManager.ProxyClasses.PrxWorkType);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            resources.ApplyResources(this.navBarControl1, "navBarControl1");
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarOrders,
            this.navBarCustomers,
            this.navBarWorkTypes});
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = ((int)(resources.GetObject("resource.ExpandedWidth")));
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            // 
            // navBarGroup1
            // 
            resources.ApplyResources(this.navBarGroup1, "navBarGroup1");
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarOrders),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarCustomers),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarWorkTypes)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarOrders
            // 
            resources.ApplyResources(this.navBarOrders, "navBarOrders");
            this.navBarOrders.Name = "navBarOrders";
            this.navBarOrders.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarOrders_LinkClicked);
            // 
            // navBarCustomers
            // 
            resources.ApplyResources(this.navBarCustomers, "navBarCustomers");
            this.navBarCustomers.Name = "navBarCustomers";
            this.navBarCustomers.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarCustomers_LinkClicked);
            // 
            // navBarWorkTypes
            // 
            resources.ApplyResources(this.navBarWorkTypes, "navBarWorkTypes");
            this.navBarWorkTypes.Name = "navBarWorkTypes";
            this.navBarWorkTypes.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarWorkTypes_LinkClicked);
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Orders.OrderName";
            this.gridColumn1.Name = "gridColumn1";
            resources.ApplyResources(this.gridColumn1, "gridColumn1");
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "Orders.OrderName";
            this.gridColumn2.Name = "gridColumn2";
            resources.ApplyResources(this.gridColumn2, "gridColumn2");
            // 
            // colOrderId
            // 
            resources.ApplyResources(this.colOrderId, "colOrderId");
            this.colOrderId.FieldName = "Orders.OrderId";
            this.colOrderId.Name = "colOrderId";
            // 
            // gridControlWorkTypes
            // 
            this.gridControlWorkTypes.DataSource = this.bndWorkTypes;
            resources.ApplyResources(this.gridControlWorkTypes, "gridControlWorkTypes");
            this.gridControlWorkTypes.MainView = this.gridView4;
            this.gridControlWorkTypes.Name = "gridControlWorkTypes";
            this.gridControlWorkTypes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4,
            this.gridView5,
            this.gridView6});
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId1,
            this.colName1,
            this.colNote1});
            this.gridView4.GridControl = this.gridControlWorkTypes;
            this.gridView4.Name = "gridView4";
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.Name = "colId1";
            resources.ApplyResources(this.colId1, "colId1");
            // 
            // colName1
            // 
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            resources.ApplyResources(this.colName1, "colName1");
            // 
            // colNote1
            // 
            this.colNote1.FieldName = "Note";
            this.colNote1.Name = "colNote1";
            resources.ApplyResources(this.colNote1, "colNote1");
            // 
            // gridView5
            // 
            this.gridView5.GridControl = this.gridControlWorkTypes;
            this.gridView5.Name = "gridView5";
            // 
            // gridView6
            // 
            this.gridView6.GridControl = this.gridControlWorkTypes;
            this.gridView6.Name = "gridView6";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            resources.ApplyResources(this.ribbonPageGroup1, "ribbonPageGroup1");
            // 
            // _PhotoManager_mdfDataSet
            // 
            this._PhotoManager_mdfDataSet.DataSetName = "_PhotoManager_mdfDataSet";
            this._PhotoManager_mdfDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource1
            // 
            this.customersBindingSource1.DataMember = "Customers";
            this.customersBindingSource1.DataSource = this._PhotoManager_mdfDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // colCustomerId
            // 
            this.colCustomerId.FieldName = "CustomerId";
            this.colCustomerId.Name = "colCustomerId";
            resources.ApplyResources(this.colCustomerId, "colCustomerId");
            // 
            // colCustomerName
            // 
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            resources.ApplyResources(this.colCustomerName, "colCustomerName");
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.FieldName = "PhoneNumber";
            this.colPhoneNumber.Name = "colPhoneNumber";
            resources.ApplyResources(this.colPhoneNumber, "colPhoneNumber");
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            resources.ApplyResources(this.colAddress, "colAddress");
            // 
            // colCustomerNote
            // 
            this.colCustomerNote.FieldName = "CustomerNote";
            this.colCustomerNote.Name = "colCustomerNote";
            resources.ApplyResources(this.colCustomerNote, "colCustomerNote");
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlWorkTypes);
            this.Controls.Add(this.gridControlOrders);
            this.Controls.Add(this.gridControlCustomers);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvWorkTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndWorkTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWorkTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PhotoManager_mdfDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private System.Windows.Forms.BindingSource bndCustomers;
        private System.Windows.Forms.BindingSource bndOrders;
        private System.Windows.Forms.BindingSource bndWorkTypes;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarOrders;
        private DevExpress.XtraNavBar.NavBarItem navBarCustomers;
        private DevExpress.XtraNavBar.NavBarItem navBarWorkTypes;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderId;
        private DevExpress.XtraGrid.GridControl gridControlCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView grvOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView grvWorkTypes;
        private DevExpress.XtraGrid.Views.Grid.GridView grvCustomers;
        private DevExpress.XtraGrid.GridControl gridControlOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridControlWorkTypes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colNote1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageHome;
        private DevExpress.XtraBars.BarButtonItem barBtnCreateOrder;
        private DevExpress.XtraBars.BarButtonItem barBtnCreateCustomer;
        private DevExpress.XtraBars.BarButtonItem barBtnCreateWorkType;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barBtnFindCustomer;
        private DevExpress.XtraBars.BarButtonItem barBtnFindOrder;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.PopupMenu popupMenu2;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkType;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName1;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate1;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkDate1;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkAddress1;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice1;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderState1;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private _PhotoManager_mdfDataSet _PhotoManager_mdfDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource1;
        private _PhotoManager_mdfDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerNote;
        private _PhotoManager_mdfDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
    }
}