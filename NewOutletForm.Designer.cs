namespace OrganisationManager
{
    partial class NewOutletForm
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
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_size = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.lb_address = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.tb_rent = new System.Windows.Forms.TextBox();
            this.tb_utility = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_counter = new System.Windows.Forms.TextBox();
            this.tb_level = new System.Windows.Forms.TextBox();
            this.lb_level = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(112, 106);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(110, 23);
            this.tb_name.TabIndex = 0;
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(112, 64);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(322, 23);
            this.tb_address.TabIndex = 0;
            // 
            // tb_size
            // 
            this.tb_size.Location = new System.Drawing.Point(112, 154);
            this.tb_size.Name = "tb_size";
            this.tb_size.Size = new System.Drawing.Size(110, 23);
            this.tb_size.TabIndex = 0;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(189, 266);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(93, 23);
            this.btn_submit.TabIndex = 1;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "Trading Tray",
            "Kiosk",
            "Shop",
            "Store"});
            this.cb_type.Location = new System.Drawing.Point(208, 24);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(110, 23);
            this.cb_type.TabIndex = 2;
            this.cb_type.SelectedIndexChanged += new System.EventHandler(this.cb_type_SelectedIndexChanged);
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Location = new System.Drawing.Point(57, 67);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(49, 15);
            this.lb_address.TabIndex = 3;
            this.lb_address.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Size";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(67, 109);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(39, 15);
            this.lb_name.TabIndex = 3;
            this.lb_name.Text = "Name";
            this.lb_name.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Utility";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 3;
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(132, 27);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(68, 15);
            this.label_type.TabIndex = 3;
            this.label_type.Text = "Outlet Type";
            // 
            // tb_rent
            // 
            this.tb_rent.Location = new System.Drawing.Point(324, 106);
            this.tb_rent.Name = "tb_rent";
            this.tb_rent.Size = new System.Drawing.Size(110, 23);
            this.tb_rent.TabIndex = 0;
            // 
            // tb_utility
            // 
            this.tb_utility.Location = new System.Drawing.Point(324, 154);
            this.tb_utility.Name = "tb_utility";
            this.tb_utility.Size = new System.Drawing.Size(110, 23);
            this.tb_utility.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Rent";
            this.label7.Click += new System.EventHandler(this.label4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Counter";
            // 
            // tb_counter
            // 
            this.tb_counter.Location = new System.Drawing.Point(112, 199);
            this.tb_counter.Name = "tb_counter";
            this.tb_counter.Size = new System.Drawing.Size(110, 23);
            this.tb_counter.TabIndex = 0;
            // 
            // tb_level
            // 
            this.tb_level.Location = new System.Drawing.Point(324, 199);
            this.tb_level.Name = "tb_level";
            this.tb_level.Size = new System.Drawing.Size(110, 23);
            this.tb_level.TabIndex = 0;
            // 
            // lb_level
            // 
            this.lb_level.AutoSize = true;
            this.lb_level.Location = new System.Drawing.Point(280, 202);
            this.lb_level.Name = "lb_level";
            this.lb_level.Size = new System.Drawing.Size(39, 15);
            this.lb_level.TabIndex = 3;
            this.lb_level.Text = "Levels";
            this.lb_level.Click += new System.EventHandler(this.label4_Click);
            // 
            // NewOutletForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 292);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_level);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.lb_address);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.tb_counter);
            this.Controls.Add(this.tb_level);
            this.Controls.Add(this.tb_utility);
            this.Controls.Add(this.tb_rent);
            this.Controls.Add(this.tb_size);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.tb_name);
            this.Name = "NewOutletForm";
            this.Text = "NewOutlletForm";
            this.Load += new System.EventHandler(this.NewOutlletForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_name;
        private TextBox tb_address;
        private TextBox tb_size;
        private Button btn_submit;
        private ComboBox cb_type;
        private Label lb_address;
        private Label label2;
        private Label lb_name;
        private Label label4;
        private Label label5;
        private Label label_type;
        private TextBox tb_rent;
        private TextBox tb_utility;
        private Label label7;
        private Label label9;
        private TextBox tb_counter;
        private TextBox tb_level;
        private Label lb_level;
    }
}