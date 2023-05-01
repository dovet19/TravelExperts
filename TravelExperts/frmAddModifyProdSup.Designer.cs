namespace TravelExpertsGUI
{
    partial class frmAddModifyProdSup
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
            btnCancel = new Button();
            btnSave = new Button();
            label3 = new Label();
            cboProductId = new ComboBox();
            cboSupplierId = new ComboBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 51);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(131, 32);
            label2.TabIndex = 11;
            label2.Text = "Product ID:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(697, 233);
            btnCancel.Margin = new Padding(6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 49);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(84, 233);
            btnSave.Margin = new Padding(6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(117, 49);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 141);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(137, 32);
            label3.TabIndex = 13;
            label3.Text = "Supplier ID:";
            // 
            // cboProductId
            // 
            cboProductId.FormattingEnabled = true;
            cboProductId.Location = new Point(242, 51);
            cboProductId.Name = "cboProductId";
            cboProductId.Size = new Size(585, 40);
            cboProductId.TabIndex = 14;
            cboProductId.Tag = "Product";
            // 
            // cboSupplierId
            // 
            cboSupplierId.FormattingEnabled = true;
            cboSupplierId.Location = new Point(242, 141);
            cboSupplierId.Name = "cboSupplierId";
            cboSupplierId.Size = new Size(585, 40);
            cboSupplierId.TabIndex = 15;
            cboSupplierId.Tag = "Supplier";
            // 
            // frmAddModifyProdSup
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(878, 339);
            Controls.Add(cboSupplierId);
            Controls.Add(cboProductId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "frmAddModifyProdSup";
            Text = "Add/Modify Product Supplier";
            Load += frmAddModifyProdSup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnCancel;
        private Button btnSave;
        private Label label3;
        private ComboBox cboProductId;
        private ComboBox cboSupplierId;
    }
}