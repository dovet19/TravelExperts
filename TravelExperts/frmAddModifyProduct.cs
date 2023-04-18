using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsData;

namespace TravelExpertsGUI
{
    public partial class frmAddModifyProduct : Form
    {
        // public because main form needs to set it
        public Product currentProduct;
        public bool isAdd;
        public frmAddModifyProduct()
        {
            InitializeComponent();
        }

        private void frmAddModifyProduct_Load(object sender, EventArgs e)
        {
            if (isAdd) // it is Add
            {
                this.Text = "Add Product";
                txtProductId.Enabled = true;
            }
            else //it is Modify
            {
                this.Text = "Modify Product";
                DisplayProduct();
                txtProductId.Enabled = false;
            }
        }

        private void DisplayProduct()
        {
            if (currentProduct != null)
            {
                txtProductId.Text = currentProduct.ProductId.ToString();
                txtProductName.Text = currentProduct.ProdName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool valid = true;
            if (isAdd) // validate code
            {
                if (Validator.IsPresent(txtProductId))
                {
                    // check if unique
                    int code = Convert.ToInt16(txtProductId.Text);
                    List<int> codes = ProductDB.GetProductId();
                    foreach (int c in codes)
                    {
                        if (c == code)
                        {
                            MessageBox.Show($"Duplicate product ID: {code}");
                            valid = false; // found duplicate
                        }
                    }
                }
                else // empty string
                {
                    valid = false;
                }
            }
            // for both Add and Modify
            if (valid &&
                Validator.IsPresent(txtProductName) &&
                Validator.IsNonNegativeInt(txtProductName)
              ) // valid data
            {
                if (isAdd) // need to create the object
                {
                    currentProduct = new Product();
                }
                // put data in
                currentProduct.ProductId = Convert.ToInt16(txtProductId.Text);
                currentProduct.ProdName = txtProductName.Text;

                DialogResult = DialogResult.OK;
            }
        }
    }
}
