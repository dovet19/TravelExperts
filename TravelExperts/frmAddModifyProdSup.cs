using TravelExpertsData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpertsGUI
{
    public partial class frmAddModifyProdSup : Form
    {
        // public because main form needs to set it
        public ProductsSupplier currentProdSup;
        public bool isAdd;
        public frmAddModifyProdSup()
        {
            InitializeComponent();
        }

        private void frmAddModifyProdSup_Load(object sender, EventArgs e)
        {
            // populate combo boxes
            LoadProductIDComboBox();
            LoadSupplierIDComboBox();

            // differntiate between add and modify
            if (isAdd) // it is Add
            {
                this.Text = "Add Product Supplier";
                cboProductId.SelectedIndex = -1; // no product selected when adding
                cboSupplierId.SelectedIndex = -1; // no supplier selected when adding
            }
            else //it is Modify
            {
                this.Text = "Modify Product Supplier";
                DisplayProdSup();
            }
        }

        private void LoadProductIDComboBox()
        {
            List<ProductDTO> products = ProductDB.GetProducts();
            cboProductId.DataSource = products;
            cboProductId.DisplayMember = "ProdName";
            cboProductId.ValueMember = "ProductId";
        }

        private void LoadSupplierIDComboBox()
        {
            List<SupplierDTO> suppliers = SupplierDB.GetSuppliers();
            cboSupplierId.DataSource = suppliers;
            cboSupplierId.DisplayMember = "SupName";
            cboSupplierId.ValueMember = "SupplierId";
        }

        private void DisplayProdSup()
        {
            if (currentProdSup != null)
            {
                cboProductId.SelectedValue = currentProdSup.ProductId;
                cboSupplierId.SelectedValue = currentProdSup.SupplierId;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool valid = true;
            // for both Add and Modify
            if (valid &&
                Validator.IsSelected(cboProductId) &&
                Validator.IsSelected(cboSupplierId)

              ) // valid data
            {
                if (isAdd) // need to create the object
                {
                    currentProdSup = new ProductsSupplier();
                }
                // put data in
                currentProdSup.ProductId = Convert.ToInt16(cboProductId.SelectedValue);
                currentProdSup.SupplierId = Convert.ToInt16(cboSupplierId.SelectedValue);

                DialogResult = DialogResult.OK;
            }
        }
    }
}
