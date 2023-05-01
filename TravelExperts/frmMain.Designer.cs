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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            btnPackages = new Button();
            btnProducts = new Button();
            btnSuppliers = new Button();
            btnProdSupp = new Button();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnPackages
            // 
            btnPackages.Location = new Point(182, 484);
            btnPackages.Margin = new Padding(6, 6, 6, 6);
            btnPackages.Name = "btnPackages";
            btnPackages.Size = new Size(234, 49);
            btnPackages.TabIndex = 0;
            btnPackages.Text = "Packages";
            btnPackages.UseVisualStyleBackColor = true;
            btnPackages.Click += btnPackages_Click;
            // 
            // btnProducts
            // 
            btnProducts.Location = new Point(182, 565);
            btnProducts.Margin = new Padding(6, 6, 6, 6);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(234, 49);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Location = new Point(606, 484);
            btnSuppliers.Margin = new Padding(6, 6, 6, 6);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(234, 49);
            btnSuppliers.TabIndex = 2;
            btnSuppliers.Text = "Suppliers";
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnProdSupp
            // 
            btnProdSupp.Location = new Point(606, 565);
            btnProdSupp.Margin = new Padding(6, 6, 6, 6);
            btnProdSupp.Name = "btnProdSupp";
            btnProdSupp.Size = new Size(234, 49);
            btnProdSupp.TabIndex = 3;
            btnProdSupp.Text = "Products Suppliers";
            btnProdSupp.UseVisualStyleBackColor = true;
            btnProdSupp.Click += btnProdSupp_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(446, 650);
            btnExit.Margin = new Padding(6, 6, 6, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(139, 49);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(540, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(450, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 67);
            label1.Name = "label1";
            label1.Size = new Size(460, 158);
            label1.TabIndex = 6;
            label1.Text = "Travel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(12, 196);
            label2.Name = "label2";
            label2.Size = new Size(519, 158);
            label2.TabIndex = 7;
            label2.Text = "Experts";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(1028, 742);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            Controls.Add(btnProdSupp);
            Controls.Add(btnSuppliers);
            Controls.Add(btnProducts);
            Controls.Add(btnPackages);
            Margin = new Padding(6, 6, 6, 6);
            Name = "frmMain";
            Text = "Main Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPackages;
        private Button btnProducts;
        private Button btnSuppliers;
        private Button btnProdSupp;
        private Button btnExit;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}