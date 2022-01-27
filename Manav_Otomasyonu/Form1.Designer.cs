namespace Manav_Otomasyonu
{
    partial class Form1
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
            this.tcManav = new System.Windows.Forms.TabControl();
            this.tpCustomer = new System.Windows.Forms.TabPage();
            this.grdCustomers = new System.Windows.Forms.DataGridView();
            this.tpProduct = new System.Windows.Forms.TabPage();
            this.grdProducts = new System.Windows.Forms.DataGridView();
            this.tpCategories = new System.Windows.Forms.TabPage();
            this.grdCategories = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnNew = new System.Windows.Forms.Button();
            this.tcManav.SuspendLayout();
            this.tpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            this.tpProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).BeginInit();
            this.tpCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategories)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcManav
            // 
            this.tcManav.Controls.Add(this.tpCustomer);
            this.tcManav.Controls.Add(this.tpProduct);
            this.tcManav.Controls.Add(this.tpCategories);
            this.tcManav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcManav.Location = new System.Drawing.Point(0, 0);
            this.tcManav.Name = "tcManav";
            this.tcManav.SelectedIndex = 0;
            this.tcManav.Size = new System.Drawing.Size(800, 450);
            this.tcManav.TabIndex = 0;
            // 
            // tpCustomer
            // 
            this.tpCustomer.Controls.Add(this.grdCustomers);
            this.tpCustomer.Location = new System.Drawing.Point(4, 22);
            this.tpCustomer.Name = "tpCustomer";
            this.tpCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tpCustomer.Size = new System.Drawing.Size(792, 424);
            this.tpCustomer.TabIndex = 0;
            this.tpCustomer.Text = "Müşteriler";
            this.tpCustomer.UseVisualStyleBackColor = true;
            // 
            // grdCustomers
            // 
            this.grdCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCustomers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdCustomers.Location = new System.Drawing.Point(3, 3);
            this.grdCustomers.MultiSelect = false;
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCustomers.Size = new System.Drawing.Size(786, 418);
            this.grdCustomers.TabIndex = 0;
            this.grdCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustomers_CellDoubleClick);
            // 
            // tpProduct
            // 
            this.tpProduct.Controls.Add(this.grdProducts);
            this.tpProduct.Location = new System.Drawing.Point(4, 22);
            this.tpProduct.Name = "tpProduct";
            this.tpProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tpProduct.Size = new System.Drawing.Size(792, 424);
            this.tpProduct.TabIndex = 1;
            this.tpProduct.Text = "Ürünler";
            this.tpProduct.UseVisualStyleBackColor = true;
            // 
            // grdProducts
            // 
            this.grdProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdProducts.Location = new System.Drawing.Point(3, 3);
            this.grdProducts.MultiSelect = false;
            this.grdProducts.Name = "grdProducts";
            this.grdProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProducts.Size = new System.Drawing.Size(786, 418);
            this.grdProducts.TabIndex = 1;
            // 
            // tpCategories
            // 
            this.tpCategories.Controls.Add(this.grdCategories);
            this.tpCategories.Location = new System.Drawing.Point(4, 22);
            this.tpCategories.Name = "tpCategories";
            this.tpCategories.Padding = new System.Windows.Forms.Padding(3);
            this.tpCategories.Size = new System.Drawing.Size(792, 424);
            this.tpCategories.TabIndex = 2;
            this.tpCategories.Text = "Kategoriler";
            this.tpCategories.UseVisualStyleBackColor = true;
            // 
            // grdCategories
            // 
            this.grdCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCategories.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdCategories.Location = new System.Drawing.Point(3, 3);
            this.grdCategories.MultiSelect = false;
            this.grdCategories.Name = "grdCategories";
            this.grdCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCategories.Size = new System.Drawing.Size(786, 418);
            this.grdCategories.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 375);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 75);
            this.panel1.TabIndex = 0;
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(4, 3);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(140, 68);
            this.BtnNew.TabIndex = 0;
            this.BtnNew.Text = "Ekle";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tcManav);
            this.Name = "Form1";
            this.Text = "Manav Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcManav.ResumeLayout(false);
            this.tpCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            this.tpProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).EndInit();
            this.tpCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCategories)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcManav;
        private System.Windows.Forms.TabPage tpCustomer;
        private System.Windows.Forms.TabPage tpProduct;
        private System.Windows.Forms.TabPage tpCategories;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.DataGridView grdCustomers;
        private System.Windows.Forms.DataGridView grdProducts;
        private System.Windows.Forms.DataGridView grdCategories;
    }
}

