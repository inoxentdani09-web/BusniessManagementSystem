using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BusniessManagementSystem
{
    public partial class MainForm : Form
    {
        private int childFormNumber = 0;
        frmEmployee frmEmployee;
        SearchEmployee femSearch;
        ViewEmployee Vemp;
        frmCustomers frmCustomer;
        SearchCustomer SearchCus;
        frmProduct product;
        SearchProduct SearchPro;
        public MainForm()
        {
            InitializeComponent();
        }
        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmEmployee == null || frmEmployee.IsDisposed)
            {
                frmEmployee = new frmEmployee();
                frmEmployee.MdiParent = this;
                frmEmployee.Show();
            }
            else
            {
                frmEmployee.Activate();
            }
        }

        private void searchEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (femSearch == null || femSearch.IsDisposed)
            {
                femSearch = new SearchEmployee();
                femSearch.MdiParent = this;
                femSearch.Show();
            }
            else
            {
                femSearch.Activate();
            }
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmCustomer == null || frmCustomer.IsDisposed)
            {
                frmCustomer = new frmCustomers();
                frmCustomer.MdiParent = this;
                frmCustomer.Show();
            }
            else
            {
                frmCustomer.Activate();
            }
        }

        private void searchCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SearchCus == null || SearchCus.IsDisposed)
            {
                SearchCus = new SearchCustomer();
                SearchCus.MdiParent = this;
                SearchCus.Show();
            }
            else
            {
                SearchCus.Activate();
            }
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (product == null || product.IsDisposed)
            {
                product = new frmProduct();
                product.MdiParent = this;
                product.Show();
            }
            else
            {
                product.Activate();
            }
        }

        private void searchProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SearchPro == null || SearchPro.IsDisposed)
            {
                SearchPro = new SearchProduct();
                SearchPro.MdiParent = this;
                SearchPro.Show();
            }
            else
            {
                SearchPro.Activate();
            }
        }
    }
}
