namespace PhotoManager.Forms
{
    partial class FrmCreateCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateCustomer));
            this.ribbonControl = new DevExpress.ExpressApp.Win.Templates.Ribbon.XafRibbonControlV2();
            this.barActionContainerFilters = new DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer();
            this.barContainerFilters = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.barActionContainerTools = new DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer();
            this.barContainerTools = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.barActionContainerDiagnostic = new DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer();
            this.barContainerDiagnostic = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.barActionContainerOptions = new DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer();
            this.barContainerOptions = new DevExpress.XtraBars.BarLinkContainerExItem();
            this.applicationMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.barButtonSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonClose = new DevExpress.XtraBars.BarButtonItem();
            this.defaultPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonGroupSave = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonGroupClose = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.viewSitePanel = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.textEditAddress = new DevExpress.XtraEditors.TextEdit();
            this.textEditPhone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.viewSiteManager = new DevExpress.ExpressApp.Win.Templates.ViewSiteManager(this.components);
            this.modelSynchronizationManager = new DevExpress.ExpressApp.Win.Templates.ModelSynchronizationManager(this.components);
            this.formStateModelSynchronizer = new DevExpress.ExpressApp.Win.Core.FormStateModelSynchronizer(this.components);
            this.contextMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barActionContainerFilters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barActionContainerTools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barActionContainerDiagnostic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barActionContainerOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSitePanel)).BeginInit();
            this.viewSitePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ActionContainers.Add(this.barActionContainerFilters);
            this.ribbonControl.ActionContainers.Add(this.barActionContainerTools);
            this.ribbonControl.ActionContainers.Add(this.barActionContainerDiagnostic);
            this.ribbonControl.ActionContainers.Add(this.barActionContainerOptions);
            this.ribbonControl.ApplicationButtonDropDownControl = this.applicationMenu;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.barButtonSave,
            this.barButtonClose});
            resources.ApplyResources(this.ribbonControl, "ribbonControl");
            this.ribbonControl.MaxItemId = 7;
            this.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.defaultPage});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            // 
            // barActionContainerFilters
            // 
            this.barActionContainerFilters.ActionCategory = "Filters";
            this.barActionContainerFilters.BarContainerItem = this.barContainerFilters;
            // 
            // barContainerFilters
            // 
            resources.ApplyResources(this.barContainerFilters, "barContainerFilters");
            this.barContainerFilters.Id = 26;
            this.barContainerFilters.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerFilters.Name = "barContainerFilters";
            // 
            // barActionContainerTools
            // 
            this.barActionContainerTools.ActionCategory = "Tools";
            this.barActionContainerTools.BarContainerItem = this.barContainerTools;
            this.barActionContainerTools.IsMenuMode = true;
            // 
            // barContainerTools
            // 
            resources.ApplyResources(this.barContainerTools, "barContainerTools");
            this.barContainerTools.Id = 13;
            this.barContainerTools.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerTools.Name = "barContainerTools";
            // 
            // barActionContainerDiagnostic
            // 
            this.barActionContainerDiagnostic.ActionCategory = "Diagnostic";
            this.barActionContainerDiagnostic.BarContainerItem = this.barContainerDiagnostic;
            this.barActionContainerDiagnostic.IsMenuMode = true;
            // 
            // barContainerDiagnostic
            // 
            resources.ApplyResources(this.barContainerDiagnostic, "barContainerDiagnostic");
            this.barContainerDiagnostic.Id = 16;
            this.barContainerDiagnostic.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerDiagnostic.Name = "barContainerDiagnostic";
            // 
            // barActionContainerOptions
            // 
            this.barActionContainerOptions.ActionCategory = "Options";
            this.barActionContainerOptions.BarContainerItem = this.barContainerOptions;
            this.barActionContainerOptions.IsMenuMode = true;
            // 
            // barContainerOptions
            // 
            resources.ApplyResources(this.barContainerOptions, "barContainerOptions");
            this.barContainerOptions.Id = 14;
            this.barContainerOptions.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems;
            this.barContainerOptions.Name = "barContainerOptions";
            // 
            // applicationMenu
            // 
            this.applicationMenu.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.LargeImagesText;
            this.applicationMenu.Name = "applicationMenu";
            this.applicationMenu.Ribbon = this.ribbonControl;
            // 
            // barButtonSave
            // 
            resources.ApplyResources(this.barButtonSave, "barButtonSave");
            this.barButtonSave.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonSave.Glyph")));
            this.barButtonSave.Id = 5;
            this.barButtonSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonSave.LargeGlyph")));
            this.barButtonSave.Name = "barButtonSave";
            this.barButtonSave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonSave_ItemClick);
            // 
            // barButtonClose
            // 
            resources.ApplyResources(this.barButtonClose, "barButtonClose");
            this.barButtonClose.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonClose.Glyph")));
            this.barButtonClose.Id = 6;
            this.barButtonClose.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonClose.LargeGlyph")));
            this.barButtonClose.Name = "barButtonClose";
            this.barButtonClose.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonClose_ItemClick);
            // 
            // defaultPage
            // 
            this.defaultPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonGroupSave,
            this.ribbonGroupClose});
            this.defaultPage.Name = "defaultPage";
            resources.ApplyResources(this.defaultPage, "defaultPage");
            // 
            // ribbonGroupSave
            // 
            this.ribbonGroupSave.AllowTextClipping = false;
            this.ribbonGroupSave.ItemLinks.Add(this.barButtonSave);
            this.ribbonGroupSave.Name = "ribbonGroupSave";
            this.ribbonGroupSave.ShowCaptionButton = false;
            resources.ApplyResources(this.ribbonGroupSave, "ribbonGroupSave");
            // 
            // ribbonGroupClose
            // 
            this.ribbonGroupClose.AllowTextClipping = false;
            this.ribbonGroupClose.ItemLinks.Add(this.barButtonClose);
            this.ribbonGroupClose.Name = "ribbonGroupClose";
            this.ribbonGroupClose.ShowCaptionButton = false;
            resources.ApplyResources(this.ribbonGroupClose, "ribbonGroupClose");
            // 
            // ribbonStatusBar
            // 
            resources.ApplyResources(this.ribbonStatusBar, "ribbonStatusBar");
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            // 
            // viewSitePanel
            // 
            this.viewSitePanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.viewSitePanel.Controls.Add(this.groupControl2);
            this.viewSitePanel.Controls.Add(this.groupControl1);
            resources.ApplyResources(this.viewSitePanel, "viewSitePanel");
            this.viewSitePanel.Name = "viewSitePanel";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.memoEdit1);
            resources.ApplyResources(this.groupControl2, "groupControl2");
            this.groupControl2.Name = "groupControl2";
            // 
            // memoEdit1
            // 
            resources.ApplyResources(this.memoEdit1, "memoEdit1");
            this.memoEdit1.MenuManager = this.ribbonControl;
            this.memoEdit1.Name = "memoEdit1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textEditAddress);
            this.groupControl1.Controls.Add(this.textEditPhone);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.textEditName);
            resources.ApplyResources(this.groupControl1, "groupControl1");
            this.groupControl1.Name = "groupControl1";
            // 
            // textEditAddress
            // 
            resources.ApplyResources(this.textEditAddress, "textEditAddress");
            this.textEditAddress.MenuManager = this.ribbonControl;
            this.textEditAddress.Name = "textEditAddress";
            // 
            // textEditPhone
            // 
            resources.ApplyResources(this.textEditPhone, "textEditPhone");
            this.textEditPhone.MenuManager = this.ribbonControl;
            this.textEditPhone.Name = "textEditPhone";
            // 
            // labelControl3
            // 
            resources.ApplyResources(this.labelControl3, "labelControl3");
            this.labelControl3.Name = "labelControl3";
            // 
            // labelControl5
            // 
            resources.ApplyResources(this.labelControl5, "labelControl5");
            this.labelControl5.Name = "labelControl5";
            // 
            // labelControl4
            // 
            resources.ApplyResources(this.labelControl4, "labelControl4");
            this.labelControl4.Name = "labelControl4";
            // 
            // textEditName
            // 
            resources.ApplyResources(this.textEditName, "textEditName");
            this.textEditName.MenuManager = this.ribbonControl;
            this.textEditName.Name = "textEditName";
            // 
            // viewSiteManager
            // 
            this.viewSiteManager.ViewSiteControl = this.viewSitePanel;
            // 
            // modelSynchronizationManager
            // 
            this.modelSynchronizationManager.ModelSynchronizableComponents.Add(this.formStateModelSynchronizer);
            // 
            // formStateModelSynchronizer
            // 
            this.formStateModelSynchronizer.Form = this;
            // 
            // contextMenu
            // 
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Ribbon = this.ribbonControl;
            // 
            // FrmCreateCustomer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewSitePanel);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Name = "FrmCreateCustomer";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barActionContainerFilters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barActionContainerTools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barActionContainerDiagnostic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barActionContainerOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSitePanel)).EndInit();
            this.viewSitePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private DevExpress.ExpressApp.Win.Templates.Ribbon.XafRibbonControlV2 ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.PanelControl viewSitePanel;
        private DevExpress.ExpressApp.Win.Core.FormStateModelSynchronizer formStateModelSynchronizer;
        private DevExpress.ExpressApp.Win.Templates.ModelSynchronizationManager modelSynchronizationManager;
        private DevExpress.ExpressApp.Win.Templates.ViewSiteManager viewSiteManager;
        private DevExpress.XtraBars.PopupMenu contextMenu;
        private DevExpress.XtraBars.Ribbon.RibbonPage defaultPage;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonGroupSave;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonGroupClose;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerFilters;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerTools;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerDiagnostic;
        private DevExpress.XtraBars.BarLinkContainerExItem barContainerOptions;
        private DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer barActionContainerFilters;
        private DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer barActionContainerTools;
        private DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer barActionContainerDiagnostic;
        private DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer barActionContainerOptions;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraEditors.TextEdit textEditAddress;
        private DevExpress.XtraEditors.TextEdit textEditPhone;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonSave;
        private DevExpress.XtraBars.BarButtonItem barButtonClose;
    }
}