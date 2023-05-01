namespace TravelExperts
{
    partial class frmProdSup
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
            btnExit = new Button();
            btnAdd = new Button();
            dgvProdSup = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProdSup).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(820, 568);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(101, 46);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(51, 568);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(103, 46);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvProdSup
            // 
            dgvProdSup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdSup.Location = new Point(51, 41);
            dgvProdSup.Name = "dgvProdSup";
            dgvProdSup.RowHeadersWidth = 82;
            dgvProdSup.RowTemplate.Height = 25;
            dgvProdSup.Size = new Size(870, 508);
            dgvProdSup.TabIndex = 3;
            dgvProdSup.CellClick += dgvProdSup_CellClick;
            // 
            // frmProdSup
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 654);
            Controls.Add(btnExit);
            Controls.Add(btnAdd);
            Controls.Add(dgvProdSup);
            Name = "frmProdSup";
            Text = "Products Suppliers";
            Load += frmProdSup_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdSup).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Button btnAdd;
        private DataGridView dgvProdSup;
    }
}