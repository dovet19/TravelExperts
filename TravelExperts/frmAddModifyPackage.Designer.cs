namespace TravelExpertsGUI
{
    partial class frmAddModifyPackage
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
            label3 = new Label();
            label2 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtPkgName = new TextBox();
            label1 = new Label();
            cboProdSup = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            txtDesc = new TextBox();
            txtPrice = new TextBox();
            txtCommission = new TextBox();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            txtProduct = new TextBox();
            txtSupplier = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 412);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(124, 32);
            label3.TabIndex = 21;
            label3.Text = "Start Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 319);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(176, 32);
            label2.TabIndex = 20;
            label2.Text = "Package Name:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(729, 836);
            btnCancel.Margin = new Padding(6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 49);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(311, 836);
            btnSave.Margin = new Padding(6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(117, 49);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(140, 499);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 32);
            label4.TabIndex = 24;
            label4.Text = "End Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(116, 579);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(140, 32);
            label5.TabIndex = 25;
            label5.Text = "Description:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(130, 664);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(126, 32);
            label6.TabIndex = 26;
            label6.Text = "Base Price:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(106, 751);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(150, 32);
            label7.TabIndex = 27;
            label7.Text = "Commission:";
            // 
            // txtPkgName
            // 
            txtPkgName.Location = new Point(311, 316);
            txtPkgName.Margin = new Padding(6);
            txtPkgName.Name = "txtPkgName";
            txtPkgName.Size = new Size(548, 39);
            txtPkgName.TabIndex = 28;
            txtPkgName.Tag = "Package Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 52);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(226, 32);
            label1.TabIndex = 29;
            label1.Text = "Product Supplier ID:";
            // 
            // cboProdSup
            // 
            cboProdSup.FormattingEnabled = true;
            cboProdSup.Location = new Point(311, 49);
            cboProdSup.Name = "cboProdSup";
            cboProdSup.Size = new Size(242, 40);
            cboProdSup.TabIndex = 30;
            cboProdSup.Tag = "Product Supplier ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(155, 146);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(101, 32);
            label8.TabIndex = 33;
            label8.Text = "Product:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(149, 238);
            label9.Name = "label9";
            label9.Size = new Size(107, 32);
            label9.TabIndex = 34;
            label9.Text = "Supplier:";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(311, 576);
            txtDesc.Margin = new Padding(6);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(548, 39);
            txtDesc.TabIndex = 35;
            txtDesc.Tag = "Package Description";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(311, 661);
            txtPrice.Margin = new Padding(6);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(242, 39);
            txtPrice.TabIndex = 36;
            txtPrice.Tag = "Package Base Price";
            // 
            // txtCommission
            // 
            txtCommission.Location = new Point(311, 748);
            txtCommission.Margin = new Padding(6);
            txtCommission.Name = "txtCommission";
            txtCommission.Size = new Size(242, 39);
            txtCommission.TabIndex = 37;
            txtCommission.Tag = "Package Agency Commission";
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(311, 407);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(400, 39);
            dtpStart.TabIndex = 38;
            dtpStart.Tag = "Package Start Date";
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(311, 494);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(400, 39);
            dtpEnd.TabIndex = 39;
            dtpEnd.Tag = "Package End Date";
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(311, 143);
            txtProduct.Name = "txtProduct";
            txtProduct.ReadOnly = true;
            txtProduct.Size = new Size(548, 39);
            txtProduct.TabIndex = 42;
            // 
            // txtSupplier
            // 
            txtSupplier.Location = new Point(311, 238);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.ReadOnly = true;
            txtSupplier.Size = new Size(548, 39);
            txtSupplier.TabIndex = 43;
            // 
            // frmAddModifyPackage
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(977, 912);
            Controls.Add(txtSupplier);
            Controls.Add(txtProduct);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(txtCommission);
            Controls.Add(txtPrice);
            Controls.Add(txtDesc);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(cboProdSup);
            Controls.Add(label1);
            Controls.Add(txtPkgName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "frmAddModifyPackage";
            Text = "frmAddModifyPackage";
            Load += frmAddModifyPackage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboSupplierId;
        private ComboBox cboProductId;
        private Label label3;
        private Label label2;
        private Button btnCancel;
        private Button btnSave;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtPkgName;
        private Label label1;
        private ComboBox cboProdSup;
        private Label label8;
        private Label label9;
        private TextBox txtDesc;
        private TextBox txtPrice;
        private TextBox txtCommission;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private TextBox txtProduct;
        private TextBox txtSupplier;
    }
}