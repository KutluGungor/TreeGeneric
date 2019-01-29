namespace TreeGeneric.UI
{
    partial class FrmTreeTypes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteTree = new System.Windows.Forms.Button();
            this.btnEditTree = new System.Windows.Forms.Button();
            this.btnAddTree = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteTree);
            this.panel1.Controls.Add(this.btnEditTree);
            this.panel1.Controls.Add(this.btnAddTree);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 86);
            this.panel1.TabIndex = 0;
            // 
            // btnDeleteTree
            // 
            this.btnDeleteTree.Location = new System.Drawing.Point(597, 25);
            this.btnDeleteTree.Name = "btnDeleteTree";
            this.btnDeleteTree.Size = new System.Drawing.Size(118, 33);
            this.btnDeleteTree.TabIndex = 2;
            this.btnDeleteTree.Text = "Ağaç Tipi Sil";
            this.btnDeleteTree.UseVisualStyleBackColor = true;
            this.btnDeleteTree.Click += new System.EventHandler(this.btnDeleteTree_Click);
            // 
            // btnEditTree
            // 
            this.btnEditTree.Location = new System.Drawing.Point(323, 25);
            this.btnEditTree.Name = "btnEditTree";
            this.btnEditTree.Size = new System.Drawing.Size(118, 33);
            this.btnEditTree.TabIndex = 1;
            this.btnEditTree.Text = "Ağaç Tipi Düzenle";
            this.btnEditTree.UseVisualStyleBackColor = true;
            this.btnEditTree.Click += new System.EventHandler(this.btnEditTree_Click);
            // 
            // btnAddTree
            // 
            this.btnAddTree.Location = new System.Drawing.Point(28, 25);
            this.btnAddTree.Name = "btnAddTree";
            this.btnAddTree.Size = new System.Drawing.Size(118, 33);
            this.btnAddTree.TabIndex = 0;
            this.btnAddTree.Text = "Ağaç Tipi Ekle";
            this.btnAddTree.UseVisualStyleBackColor = true;
            this.btnAddTree.Click += new System.EventHandler(this.btnAddTree_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(845, 315);
            this.dataGridView1.TabIndex = 1;
            // 
            // FrmTreeTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 401);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FrmTreeTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ağaçlar";
            this.Load += new System.EventHandler(this.FrmTreeTypes_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteTree;
        private System.Windows.Forms.Button btnEditTree;
        private System.Windows.Forms.Button btnAddTree;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}