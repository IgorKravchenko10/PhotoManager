using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using PhotoManager.ProxyClasses;

namespace PhotoManager.Forms
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        PmContext PmContext = new PmContext();

        public MainForm()
        {
            SplashScreenManager.ShowForm(typeof(SplashScreen1));
            InitializeComponent();
            SplashScreenManager.CloseForm();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_PhotoManager_mdfDataSet.Customers' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the '_PhotoManager_mdfDataSet.Customers' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the '_PhotoManager_mdfDataSet2.Customers' table. You can move, or remove it, as needed.
            this.WindowState = FormWindowState.Maximized;

            SplashScreenManager.ShowForm(typeof(WaitForm1));

            try
            {
                LoadOrders();
                SetGridVisible(gridControlOrders);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            SplashScreenManager.CloseForm();

        }

        public void FillTree()
        {

        }

        private void SetGridVisible(DevExpress.XtraGrid.GridControl gridControl)
        {
            this.gridControlCustomers.Visible = (gridControl == this.gridControlCustomers);
            this.gridControlOrders.Visible = (gridControl == this.gridControlOrders);
            this.gridControlWorkTypes.Visible = (gridControl == this.gridControlWorkTypes);
        }

        public void LoadOrders()
        {
            List<PrxOrder> orders = Adapters.OrdersAdapter.GetList(PmContext);
            bndOrders.DataSource = orders;
        }

        public void LoadWorkTypes()
        {
            List<PrxWorkType> workTypes = Adapters.WorkTypesAdapter.GetList(PmContext);
            bndWorkTypes.DataSource = workTypes;
        }

        private enum GroupTreeNodeTypeEnum
        {
            Orders,
            Customers,
            WorkTypes
        }

        private class GroupTreeNode
        {
            public GroupTreeNodeTypeEnum GroupTreeNodeType { get; set; }

        }

        private void navBarOrders_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadOrders();
            SetGridVisible(gridControlOrders);
        }

        private void navBarCustomers_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.customersTableAdapter.Fill(this._PhotoManager_mdfDataSet.Customers);
            this.ordersTableAdapter1.Fill(this._PhotoManager_mdfDataSet.Orders);

            SetGridVisible(gridControlCustomers);
        }

        private void navBarWorkTypes_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadWorkTypes();
            SetGridVisible(gridControlWorkTypes);
        }

        private void barBtnCreateOrder_ItemClick(object sender, ItemClickEventArgs e)
        {

            FrmCreateOrder frmCreate = new FrmCreateOrder();
            frmCreate.ShowDialog();
            LoadOrders();
            SetGridVisible(gridControlOrders);
        }

        private void barBtnCreateCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmCreateCustomer frmCreateCustomer = new FrmCreateCustomer();
            frmCreateCustomer.ShowDialog();
            this.customersTableAdapter.Fill(this._PhotoManager_mdfDataSet.Customers);
            this.ordersTableAdapter1.Fill(this._PhotoManager_mdfDataSet.Orders);

            SetGridVisible(gridControlCustomers);

        }

        private void barBtnCreateWorkType_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}