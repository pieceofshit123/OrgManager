namespace OrganisationManager.AddingDataForms
{
    partial class NewAvProductForm
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
            this.tb_volume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_names = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_type = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_volume
            // 
            this.tb_volume.Location = new System.Drawing.Point(116, 59);
            this.tb_volume.Name = "tb_volume";
            this.tb_volume.Size = new System.Drawing.Size(100, 23);
            this.tb_volume.TabIndex = 0;
            this.tb_volume.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Volume";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cb_names
            // 
            this.cb_names.FormattingEnabled = true;
            this.cb_names.Location = new System.Drawing.Point(116, 21);
            this.cb_names.Name = "cb_names";
            this.cb_names.Size = new System.Drawing.Size(100, 23);
            this.cb_names.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Name";
            // 
            // btn_type
            // 
            this.btn_type.Location = new System.Drawing.Point(244, 20);
            this.btn_type.Name = "btn_type";
            this.btn_type.Size = new System.Drawing.Size(106, 23);
            this.btn_type.TabIndex = 4;
            this.btn_type.Text = "New Prod. Type";
            this.btn_type.UseVisualStyleBackColor = true;
            this.btn_type.Click += new System.EventHandler(this.btn_type_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(142, 109);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(92, 23);
            this.btn_submit.TabIndex = 4;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.button2_Click);
            // 
            // NewAvProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 144);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_names);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_volume);
            this.Name = "NewAvProductForm";
            this.Text = "NewAvProductForm";
            this.Load += new System.EventHandler(this.NewAvProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_volume;
        private Label label1;
        private ComboBox cb_names;
        private Label label2;
        private Button btn_type;
        private Button btn_submit;
    }
}