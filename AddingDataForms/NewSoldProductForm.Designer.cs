namespace OrganisationManager.AddingDataForms
{
    partial class NewSoldProductForm
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
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_newProdType = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_productNames = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_volumeSold = new System.Windows.Forms.TextBox();
            this.tb_saleDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(145, 149);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(92, 23);
            this.btn_submit.TabIndex = 9;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_newProdType
            // 
            this.btn_newProdType.Location = new System.Drawing.Point(250, 21);
            this.btn_newProdType.Name = "btn_newProdType";
            this.btn_newProdType.Size = new System.Drawing.Size(106, 23);
            this.btn_newProdType.TabIndex = 10;
            this.btn_newProdType.Text = "New Prod. Type";
            this.btn_newProdType.UseVisualStyleBackColor = true;
            this.btn_newProdType.Click += new System.EventHandler(this.btn_newProdType_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Product Name";
            // 
            // cb_productNames
            // 
            this.cb_productNames.FormattingEnabled = true;
            this.cb_productNames.Location = new System.Drawing.Point(115, 22);
            this.cb_productNames.Name = "cb_productNames";
            this.cb_productNames.Size = new System.Drawing.Size(100, 23);
            this.cb_productNames.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Volume Sold";
            // 
            // tb_volumeSold
            // 
            this.tb_volumeSold.Location = new System.Drawing.Point(115, 51);
            this.tb_volumeSold.Name = "tb_volumeSold";
            this.tb_volumeSold.Size = new System.Drawing.Size(100, 23);
            this.tb_volumeSold.TabIndex = 5;
            // 
            // tb_saleDate
            // 
            this.tb_saleDate.Location = new System.Drawing.Point(115, 80);
            this.tb_saleDate.Name = "tb_saleDate";
            this.tb_saleDate.Size = new System.Drawing.Size(100, 23);
            this.tb_saleDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sale Date";
            // 
            // NewSoldProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 175);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_newProdType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_productNames);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_saleDate);
            this.Controls.Add(this.tb_volumeSold);
            this.Name = "NewSoldProductForm";
            this.Text = "NewSoldProductForm";
            this.Load += new System.EventHandler(this.NewSoldProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_submit;
        private Button btn_newProdType;
        private Label label2;
        private ComboBox cb_productNames;
        private Label label1;
        private TextBox tb_volumeSold;
        private TextBox tb_saleDate;
        private Label label3;
    }
}