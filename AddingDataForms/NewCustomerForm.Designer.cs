namespace OrganisationManager
{
    partial class NewCustomerForm
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
            this.tb_name = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_gender = new System.Windows.Forms.Label();
            this.lb_products = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_newProduct = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(69, 34);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 23);
            this.tb_name.TabIndex = 0;
            this.tb_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(170, 228);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 1;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rb_gender
            // 
            this.rb_gender.AutoSize = true;
            this.rb_gender.Location = new System.Drawing.Point(18, 82);
            this.rb_gender.Name = "rb_gender";
            this.rb_gender.Size = new System.Drawing.Size(45, 15);
            this.rb_gender.TabIndex = 2;
            this.rb_gender.Text = "Gender";
            this.rb_gender.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_products
            // 
            this.lb_products.FormattingEnabled = true;
            this.lb_products.ItemHeight = 15;
            this.lb_products.Location = new System.Drawing.Point(229, 35);
            this.lb_products.Name = "lb_products";
            this.lb_products.Size = new System.Drawing.Size(200, 124);
            this.lb_products.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Purchased";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_newProduct
            // 
            this.btn_newProduct.Location = new System.Drawing.Point(229, 165);
            this.btn_newProduct.Name = "btn_newProduct";
            this.btn_newProduct.Size = new System.Drawing.Size(95, 23);
            this.btn_newProduct.TabIndex = 1;
            this.btn_newProduct.Text = "New Product";
            this.btn_newProduct.UseVisualStyleBackColor = true;
            this.btn_newProduct.Click += new System.EventHandler(this.btn_newProduct_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(69, 80);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(36, 19);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "M";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(111, 80);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(36, 19);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "W";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(334, 165);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(95, 23);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "Delete Product";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // NewCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 263);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lb_products);
            this.Controls.Add(this.rb_gender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_newProduct);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.tb_name);
            this.Name = "NewCustomerForm";
            this.Text = "NewCustomerForm";
            this.Load += new System.EventHandler(this.NewCustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_name;
        private Button btn_submit;
        private Label label1;
        private Label rb_gender;
        private ListBox lb_products;
        private Label label3;
        private Button btn_newProduct;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button btn_Delete;
    }
}