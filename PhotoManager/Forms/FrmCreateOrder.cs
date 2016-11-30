using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Templates.ActionControls;
using DevExpress.ExpressApp.Win.Controls;
using DevExpress.ExpressApp.Win.SystemModule;
using DevExpress.ExpressApp.Win.Templates;
using DevExpress.ExpressApp.Win.Templates.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using PhotoManager.ProxyClasses;
using PhotoManager.DataObjects;

namespace PhotoManager.Forms
{
    public partial class FrmCreateOrder : DevExpress.XtraBars.Ribbon.RibbonForm, IContextMenuHolder, IWindowTemplate, IBarManagerHolder, ISupportViewChanged, ISupportUpdate, IViewSiteTemplate, ISupportStoreSettings, IViewHolder
    {
        private static readonly object viewChanged = new object();
        private static readonly object settingsReloaded = new object();
        private StatusMessagesHelper statusMessagesHelper;

        private List<PrxCustomer> Customers = new List<PrxCustomer>();


        protected virtual void RaiseViewChanged(DevExpress.ExpressApp.View view)
        {
            EventHandler<TemplateViewChangedEventArgs> handler = (EventHandler<TemplateViewChangedEventArgs>)Events[viewChanged];
            if (handler != null)
            {
                handler(this, new TemplateViewChangedEventArgs(view));
            }
        }
        protected virtual void RaiseSettingsReloaded()
        {
            EventHandler handler = (EventHandler)Events[settingsReloaded];
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

        public FrmCreateOrder()
        {
            InitializeComponent();
            ribbonControl.Manager.ForceLinkCreate();
        }

        #region IActionControlsSite Members

        #endregion

        #region IFrameTemplate Members
        void IFrameTemplate.SetView(DevExpress.ExpressApp.View view)
        {
            viewSiteManager.SetView(view);
            RaiseViewChanged(view);
        }
        ICollection<IActionContainer> IFrameTemplate.GetContainers()
        {
            return new IActionContainer[] { };
        }
        IActionContainer IFrameTemplate.DefaultContainer
        {
            get { return null; }
        }
        #endregion

        #region IWindowTemplate Members
        void IWindowTemplate.SetCaption(string caption)
        {
            Text = caption;
        }
        void IWindowTemplate.SetStatus(ICollection<string> statusMessages)
        {
            statusMessagesHelper.SetMessages(statusMessages);
        }
        bool IWindowTemplate.IsSizeable
        {
            get { return FormBorderStyle == FormBorderStyle.Sizable; }
            set { FormBorderStyle = (value ? FormBorderStyle.Sizable : FormBorderStyle.FixedDialog); }
        }
        #endregion

        #region IBarManagerHolder Members
        BarManager IBarManagerHolder.BarManager
        {
            get { return ribbonControl.Manager; }
        }
        event EventHandler IBarManagerHolder.BarManagerChanged
        {
            add { }
            remove { }
        }
        #endregion

        #region IContextMenuHolder
        PopupMenu IContextMenuHolder.ContextMenu
        {
            get { return contextMenu; }
        }
        #endregion

        #region ISupportViewChanged Members
        event EventHandler<TemplateViewChangedEventArgs> ISupportViewChanged.ViewChanged
        {
            add { Events.AddHandler(viewChanged, value); }
            remove { Events.RemoveHandler(viewChanged, value); }
        }
        #endregion

        #region ISupportUpdate Members
        void ISupportUpdate.BeginUpdate()
        {
            if (ribbonControl.Manager != null)
            {
                ribbonControl.Manager.BeginUpdate();
            }
        }
        void ISupportUpdate.EndUpdate()
        {
            if (ribbonControl.Manager != null)
            {
                ribbonControl.Manager.EndUpdate();
            }
        }
        #endregion

        #region IViewSiteTemplate Members
        object IViewSiteTemplate.ViewSiteControl
        {
            get { return viewSiteManager.ViewSiteControl; }
        }
        #endregion

        #region ISupportStoreSettings Members
        void ISupportStoreSettings.SetSettings(IModelTemplate settings)
        {
            IModelTemplateWin templateModel = (IModelTemplateWin)settings;
            TemplatesHelper templatesHelper = new TemplatesHelper(templateModel);
            IModelFormState formState;
            if (viewSiteManager.View != null)
            {
                formState = templatesHelper.GetFormStateNode(viewSiteManager.View.Id);
            }
            else
            {
                formState = templatesHelper.GetFormStateNode();
            }
            formStateModelSynchronizer.Model = formState;
            templatesHelper.SetRibbonSettings(ribbonControl);
        }
        void ISupportStoreSettings.ReloadSettings()
        {
            modelSynchronizationManager.ApplyModel();
            RaiseSettingsReloaded();
        }
        void ISupportStoreSettings.SaveSettings()
        {
            SuspendLayout();
            try
            {
                modelSynchronizationManager.SynchronizeModel();
            }
            finally
            {
                ResumeLayout();
            }
        }
        event EventHandler ISupportStoreSettings.SettingsReloaded
        {
            add { Events.AddHandler(settingsReloaded, value); }
            remove { Events.RemoveHandler(settingsReloaded, value); }
        }
        #endregion

        #region IViewHolder Members
        DevExpress.ExpressApp.View IViewHolder.View
        {
            get { return viewSiteManager.View; }
        }
        #endregion

        private void FrmCreate_Load(object sender, EventArgs e)
        {
            FillListBox();
            FillWorkTypes();
            FillCustomers();
        }

        private void FillWorkTypes()
        {
            List<PrxWorkType> workTypes = Adapters.WorkTypesAdapter.GetListSql();
            cmbCategory.DataSource = workTypes;
            cmbCategory.ValueMember = "Id";
            cmbCategory.DisplayMember = "Name";
        }

        private void FillListBox()
        {
            listBoxControl1.DataSource = Customers;
            listBoxControl1.DisplayMember = "Name";
        }

        private void FillCustomers()
        {
            List<PrxCustomer> customers = Adapters.CustomersAdapter.GetListSql();
            cmbCustomer.DataSource = customers;
            cmbCustomer.ValueMember = "Id";
            cmbCustomer.DisplayMember = "Name";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Customers.Add((PrxCustomer)cmbCustomer.SelectedItem);
            listBoxControl1.Refresh();

        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Customers.Remove((PrxCustomer)listBoxControl1.SelectedItem);
            listBoxControl1.Refresh();
        }

        private void barButtonSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            List<Order> Orders = new List<Order>();
            foreach (PrxCustomer item in Customers)
            {
                Order order = new Order()
                {
                    WorkAddress = textEdit1.Text,
                    OrderDate = dateEditOrder.DateTime,
                    WorkDate = dateEditWork.DateTime,
                    CustomerId = item.Id,
                    OrderNote = memoEdit1.Text,
                    Price = Convert.ToDouble(calcEdit1.Value),
                    WorkTypeId = (int)cmbCategory.SelectedValue,
                    OrderState = 0,
                    OrderName = cmbCategory.SelectedText + " " + item.Name
                };
                Orders.Add(order);
            }
            AddToDatabase(Orders);
            this.Close();
        }

        private void AddToDatabase(List<Order> orders)
        {
            PmContext pmContext = new PmContext();
            foreach (Order item in orders)
            {
                pmContext.Orders.Add(item);
                pmContext.SaveChanges();
            }

        }
        private void barButtonClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            using (FrmCreateCustomer frmCreateCustomer = new FrmCreateCustomer())
            {
                if (frmCreateCustomer.ShowDialog(this) == DialogResult.OK)
                {
                    FillCustomers();

                }
            }
        }
    }
}
