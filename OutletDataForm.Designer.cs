namespace OrganisationManager
{
    partial class OutletDataForm
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
            this.lb_name = new System.Windows.Forms.Label();
            this.btn_sections = new System.Windows.Forms.Button();
            this.btn_shoppingRooms = new System.Windows.Forms.Button();
            this.lb_address = new System.Windows.Forms.Label();
            this.btn_soldProduct = new System.Windows.Forms.Button();
            this.lb_type = new System.Windows.Forms.Label();
            this.lb_rent = new System.Windows.Forms.Label();
            this.lb_utility = new System.Windows.Forms.Label();
            this.lb_size = new System.Windows.Forms.Label();
            this.lb_counters = new System.Windows.Forms.Label();
            this.lb_level = new System.Windows.Forms.Label();
            this.btn_availableProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_name.Location = new System.Drawing.Point(64, 19);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(52, 20);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "Name:";
            // 
            // btn_sections
            // 
            this.btn_sections.Location = new System.Drawing.Point(64, 261);
            this.btn_sections.Name = "btn_sections";
            this.btn_sections.Size = new System.Drawing.Size(198, 23);
            this.btn_sections.TabIndex = 2;
            this.btn_sections.Text = "Sections";
            this.btn_sections.UseVisualStyleBackColor = true;
            this.btn_sections.Click += new System.EventHandler(this.btn_sections_Click);
            // 
            // btn_shoppingRooms
            // 
            this.btn_shoppingRooms.Location = new System.Drawing.Point(65, 290);
            this.btn_shoppingRooms.Name = "btn_shoppingRooms";
            this.btn_shoppingRooms.Size = new System.Drawing.Size(197, 23);
            this.btn_shoppingRooms.TabIndex = 2;
            this.btn_shoppingRooms.Text = "Shop. Rooms";
            this.btn_shoppingRooms.UseVisualStyleBackColor = true;
            this.btn_shoppingRooms.Click += new System.EventHandler(this.btn_shoppingRooms_Click);
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_address.Location = new System.Drawing.Point(54, 43);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(65, 20);
            this.lb_address.TabIndex = 3;
            this.lb_address.Text = "Address:";
            // 
            // btn_soldProduct
            // 
            this.btn_soldProduct.Location = new System.Drawing.Point(65, 319);
            this.btn_soldProduct.Name = "btn_soldProduct";
            this.btn_soldProduct.Size = new System.Drawing.Size(197, 23);
            this.btn_soldProduct.TabIndex = 4;
            this.btn_soldProduct.Text = "Sold Products";
            this.btn_soldProduct.UseVisualStyleBackColor = true;
            this.btn_soldProduct.Click += new System.EventHandler(this.btn_soldProduct_Click);
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_type.Location = new System.Drawing.Point(71, 67);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(43, 20);
            this.lb_type.TabIndex = 3;
            this.lb_type.Text = "Type:";
            // 
            // lb_rent
            // 
            this.lb_rent.AutoSize = true;
            this.lb_rent.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_rent.Location = new System.Drawing.Point(72, 92);
            this.lb_rent.Name = "lb_rent";
            this.lb_rent.Size = new System.Drawing.Size(42, 20);
            this.lb_rent.TabIndex = 3;
            this.lb_rent.Text = "Rent:";
            // 
            // lb_utility
            // 
            this.lb_utility.AutoSize = true;
            this.lb_utility.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_utility.Location = new System.Drawing.Point(65, 119);
            this.lb_utility.Name = "lb_utility";
            this.lb_utility.Size = new System.Drawing.Size(51, 20);
            this.lb_utility.TabIndex = 3;
            this.lb_utility.Text = "Utility:";
            // 
            // lb_size
            // 
            this.lb_size.AutoSize = true;
            this.lb_size.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_size.Location = new System.Drawing.Point(76, 144);
            this.lb_size.Name = "lb_size";
            this.lb_size.Size = new System.Drawing.Size(39, 20);
            this.lb_size.TabIndex = 3;
            this.lb_size.Text = "Size:";
            // 
            // lb_counters
            // 
            this.lb_counters.AutoSize = true;
            this.lb_counters.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_counters.Location = new System.Drawing.Point(48, 169);
            this.lb_counters.Name = "lb_counters";
            this.lb_counters.Size = new System.Drawing.Size(70, 20);
            this.lb_counters.TabIndex = 3;
            this.lb_counters.Text = "Counters:";
            // 
            // lb_level
            // 
            this.lb_level.AutoSize = true;
            this.lb_level.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_level.Location = new System.Drawing.Point(64, 194);
            this.lb_level.Name = "lb_level";
            this.lb_level.Size = new System.Drawing.Size(52, 20);
            this.lb_level.TabIndex = 3;
            this.lb_level.Text = "Levels:";
            // 
            // btn_availableProduct
            // 
            this.btn_availableProduct.Location = new System.Drawing.Point(65, 348);
            this.btn_availableProduct.Name = "btn_availableProduct";
            this.btn_availableProduct.Size = new System.Drawing.Size(197, 23);
            this.btn_availableProduct.TabIndex = 4;
            this.btn_availableProduct.Text = "Available Product";
            this.btn_availableProduct.UseVisualStyleBackColor = true;
            this.btn_availableProduct.Click += new System.EventHandler(this.btn_availableProduct_Click);
            // 
            // OutletDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 376);
            this.Controls.Add(this.btn_availableProduct);
            this.Controls.Add(this.btn_soldProduct);
            this.Controls.Add(this.lb_level);
            this.Controls.Add(this.lb_counters);
            this.Controls.Add(this.lb_size);
            this.Controls.Add(this.lb_utility);
            this.Controls.Add(this.lb_rent);
            this.Controls.Add(this.lb_type);
            this.Controls.Add(this.lb_address);
            this.Controls.Add(this.btn_shoppingRooms);
            this.Controls.Add(this.btn_sections);
            this.Controls.Add(this.lb_name);
            this.Name = "OutletDataForm";
            this.Text = "OutletDataForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OutletDataForm_FormClosed);
            this.Load += new System.EventHandler(this.OutletDataForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_name;
        private Button btn_sections;
        private Button btn_shoppingRooms;
        private Label lb_address;
        private Button btn_soldProduct;
        private Label lb_type;
        private Label lb_rent;
        private Label lb_utility;
        private Label lb_size;
        private Label lb_counters;
        private Label lb_level;
        private Button btn_availableProduct;
    }
}