namespace TravelExperts
{
    partial class frmPackages
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
            dgvPackages = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPackages).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1226, 600);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(101, 46);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(66, 600);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(103, 46);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvPackages
            // 
            dgvPackages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPackages.Location = new Point(66, 73);
            dgvPackages.Name = "dgvPackages";
            dgvPackages.RowHeadersWidth = 82;
            dgvPackages.RowTemplate.Height = 25;
            dgvPackages.Size = new Size(1261, 508);
            dgvPackages.TabIndex = 6;
            dgvPackages.CellClick += dgvPackage_CellClick;
            // 
            // frmPackages
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1397, 719);
            Controls.Add(btnExit);
            Controls.Add(btnAdd);
            Controls.Add(dgvPackages);
            Name = "frmPackages";
            Text = "Packages";
            Load += frmPackages_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPackages).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Button btnAdd;
        private DataGridView dgvPackages;
    }
}