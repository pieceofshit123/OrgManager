namespace OrganisationManager.ViewForms
{
    partial class ProviderViewForm
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
            this.btn_RemoveSupProduct = new System.Windows.Forms.Button();
            this.btn_NewSupProduct = new System.Windows.Forms.Button();
            this.btn_RemoveProvider = new System.Windows.Forms.Button();
            this.btn_NewProvider = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_providers = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_supProducts = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_RemoveSupProduct);
            this.panel1.Controls.Add(this.btn_NewSupProduct);
            this.panel1.Controls.Add(this.btn_RemoveProvider);
            this.panel1.Controls.Add(this.btn_NewProvider);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 43);
            this.panel1.TabIndex = 1;
            // 
            // btn_RemoveSupProduct
            // 
            this.btn_RemoveSupProduct.Location = new System.Drawing.Point(383, 12);
            this.btn_RemoveSupProduct.Name = "btn_RemoveSupProduct";
            this.btn_RemoveSupProduct.Size = new System.Drawing.Size(94, 23);
            this.btn_RemoveSupProduct.TabIndex = 0;
            this.btn_RemoveSupProduct.Text = "Delete Product";
            this.btn_RemoveSupProduct.UseVisualStyleBackColor = true;
            this.btn_RemoveSupProduct.Click += new System.EventHandler(this.btn_RemoveSupProduct_Click);
            // 
            // btn_NewSupProduct
            // 
            this.btn_NewSupProduct.Location = new System.Drawing.Point(269, 12);
            this.btn_NewSupProduct.Name = "btn_NewSupProduct";
            this.btn_NewSupProduct.Size = new System.Drawing.Size(94, 23);
            this.btn_NewSupProduct.TabIndex = 0;
            this.btn_NewSupProduct.Text = "New Product";
            this.btn_NewSupProduct.UseVisualStyleBackColor = true;
            this.btn_NewSupProduct.Click += new System.EventHandler(this.btn_NewSupProduct_Click);
            // 
            // btn_RemoveProvider
            // 
            this.btn_RemoveProvider.Location = new System.Drawing.Point(122, 12);
            this.btn_RemoveProvider.Name = "btn_RemoveProvider";
            this.btn_RemoveProvider.Size = new System.Drawing.Size(94, 23);
            this.btn_RemoveProvider.TabIndex = 0;
            this.btn_RemoveProvider.Text = "Delete Provder";
            this.btn_RemoveProvider.UseVisualStyleBackColor = true;
            this.btn_RemoveProvider.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_NewProvider
            // 
            this.btn_NewProvider.Location = new System.Drawing.Point(12, 12);
            this.btn_NewProvider.Name = "btn_NewProvider";
            this.btn_NewProvider.Size = new System.Drawing.Size(94, 23);
            this.btn_NewProvider.TabIndex = 0;
            this.btn_NewProvider.Text = "New Provider";
            this.btn_NewProvider.UseVisualStyleBackColor = true;
            this.btn_NewProvider.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb_providers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 314);
            this.panel2.TabIndex = 2;
            // 
            // lb_providers
            // 
            this.lb_providers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_providers.FormattingEnabled = true;
            this.lb_providers.ItemHeight = 15;
            this.lb_providers.Location = new System.Drawing.Point(0, 0);
            this.lb_providers.Name = "lb_providers";
            this.lb_providers.Size = new System.Drawing.Size(252, 314);
            this.lb_providers.TabIndex = 0;
            this.lb_providers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb_providers_MouseClick);
            this.lb_providers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_providers_MouseDoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lb_supProducts);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(252, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 314);
            this.panel3.TabIndex = 2;
            // 
            // lb_supProducts
            // 
            this.lb_supProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_supProducts.FormattingEnabled = true;
            this.lb_supProducts.ItemHeight = 15;
            this.lb_supProducts.Location = new System.Drawing.Point(0, 0);
            this.lb_supProducts.Name = "lb_supProducts";
            this.lb_supProducts.Size = new System.Drawing.Size(237, 314);
            this.lb_supProducts.TabIndex = 0;
            this.lb_supProducts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_supProducts_MouseDoubleClick);
            // 
            // ProviderViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 357);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProviderViewForm";
            this.Text = "ProviderViewForm";
            this.Load += new System.EventHandler(this.ProviderViewForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Button btn_RemoveProvider;
        private Button btn_NewProvider;
        private Panel panel2;
        private ListBox lb_providers;
        private Panel panel3;
        private ListBox lb_supProducts;
        private Button btn_RemoveSupProduct;
        private Button btn_NewSupProduct;
    }
}