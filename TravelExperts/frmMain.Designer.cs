namespace TravelExperts
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPackages = new Button();
            btnProducts = new Button();
            btnSuppliers = new Button();
            btnProdSupp = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnPackages
            // 
            btnPackages.Location = new Point(54, 44);
            btnPackages.Name = "btnPackages";
            btnPackages.Size = new Size(126, 23);
            btnPackages.TabIndex = 0;
            btnPackages.Text = "Packages";
            btnPackages.UseVisualStyleBackColor = true;
            btnPackages.Click += btnPackages_Click;
            // 
            // btnProducts
            // 
            btnProducts.Location = new Point(54, 102);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(126, 23);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Location = new Point(240, 44);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(126, 23);
            btnSuppliers.TabIndex = 2;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnProdSupp
            // 
            btnProdSupp.Location = new Point(240, 102);
            btnProdSupp.Name = "btnProdSupp";
            btnProdSupp.Size = new Size(126, 23);
            btnProdSupp.TabIndex = 3;
            btnProdSupp.Text = "Products Suppliers";
            btnProdSupp.UseVisualStyleBackColor = true;
            btnProdSupp.Click += btnProdSupp_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(172, 169);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(413, 231);
            Controls.Add(btnExit);
            Controls.Add(btnProdSupp);
            Controls.Add(btnSuppliers);
            Controls.Add(btnProducts);
            Controls.Add(btnPackages);
            Name = "frmMain";
            Text = "Main Page";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPackages;
        private Button btnProducts;
        private Button btnSuppliers;
        private Button btnProdSupp;
        private Button btnExit;
    }
}