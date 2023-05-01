namespace TravelExpertsGUI
{
    partial class frmAddModifySupplier
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
            label2 = new Label();
            label1 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            txtSupplierName = new TextBox();
            txtSupplierId = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 180);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(178, 32);
            label2.TabIndex = 11;
            label2.Text = "Supplier Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 67);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 32);
            label1.TabIndex = 10;
            label1.Text = "Supplier ID:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(297, 302);
            btnCancel.Margin = new Padding(6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 49);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(74, 302);
            btnSave.Margin = new Padding(6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(117, 49);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(254, 173);
            txtSupplierName.Margin = new Padding(6);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(283, 39);
            txtSupplierName.TabIndex = 7;
            txtSupplierName.Tag = "Supplier Name";
            // 
            // txtSupplierId
            // 
            txtSupplierId.Location = new Point(254, 61);
            txtSupplierId.Margin = new Padding(6);
            txtSupplierId.Name = "txtSupplierId";
            txtSupplierId.Size = new Size(186, 39);
            txtSupplierId.TabIndex = 6;
            txtSupplierId.Tag = "Supplier ID";
            // 
            // frmAddModifySupplier
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(607, 412);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtSupplierName);
            Controls.Add(txtSupplierId);
            Name = "frmAddModifySupplier";
            Text = "Add/Modify Supplier";
            Load += frmAddModifySupplier_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtSupplierName;
        private TextBox txtSupplierId;
    }
}