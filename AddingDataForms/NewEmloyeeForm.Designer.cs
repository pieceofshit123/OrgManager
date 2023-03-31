namespace OrganisationManager.AddingDataForms
{
    partial class NewEmloyeeForm
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
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rb_gender = new System.Windows.Forms.RadioButton();
            this.lb_gender = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_disDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_empDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_salary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_passport = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(122, 54);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(36, 19);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "W";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rb_gender
            // 
            this.rb_gender.AutoSize = true;
            this.rb_gender.Location = new System.Drawing.Point(80, 54);
            this.rb_gender.Name = "rb_gender";
            this.rb_gender.Size = new System.Drawing.Size(36, 19);
            this.rb_gender.TabIndex = 9;
            this.rb_gender.TabStop = true;
            this.rb_gender.Text = "M";
            this.rb_gender.UseVisualStyleBackColor = true;
            // 
            // lb_gender
            // 
            this.lb_gender.AutoSize = true;
            this.lb_gender.Location = new System.Drawing.Point(29, 56);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(45, 15);
            this.lb_gender.TabIndex = 6;
            this.lb_gender.Text = "Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(80, 25);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 23);
            this.tb_name.TabIndex = 5;
            // 
            // tb_disDate
            // 
            this.tb_disDate.Location = new System.Drawing.Point(135, 79);
            this.tb_disDate.Name = "tb_disDate";
            this.tb_disDate.Size = new System.Drawing.Size(100, 23);
            this.tb_disDate.TabIndex = 5;
            this.tb_disDate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dissmisal Date";
            // 
            // tb_empDate
            // 
            this.tb_empDate.Location = new System.Drawing.Point(135, 108);
            this.tb_empDate.Name = "tb_empDate";
            this.tb_empDate.Size = new System.Drawing.Size(100, 23);
            this.tb_empDate.TabIndex = 5;
            this.tb_empDate.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Emloyment Date";
            // 
            // tb_salary
            // 
            this.tb_salary.Location = new System.Drawing.Point(316, 79);
            this.tb_salary.Name = "tb_salary";
            this.tb_salary.Size = new System.Drawing.Size(100, 23);
            this.tb_salary.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Salary";
            // 
            // tb_passport
            // 
            this.tb_passport.Location = new System.Drawing.Point(316, 108);
            this.tb_passport.Name = "tb_passport";
            this.tb_passport.Size = new System.Drawing.Size(100, 23);
            this.tb_passport.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Passport";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(176, 154);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 10;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(316, 48);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(100, 23);
            this.cb_type.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Type";
            // 
            // NewEmloyeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 189);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rb_gender);
            this.Controls.Add(this.lb_gender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_passport);
            this.Controls.Add(this.tb_salary);
            this.Controls.Add(this.tb_empDate);
            this.Controls.Add(this.tb_disDate);
            this.Controls.Add(this.tb_name);
            this.Name = "NewEmloyeeForm";
            this.Text = "NewEmloyeeForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewEmloyeeForm_FormClosed);
            this.Load += new System.EventHandler(this.NewEmloyeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton radioButton2;
        private RadioButton rb_gender;
        private Label lb_gender;
        private Label label1;
        private TextBox tb_name;
        private TextBox tb_disDate;
        private Label label3;
        private TextBox tb_empDate;
        private Label label4;
        private TextBox tb_salary;
        private Label label5;
        private TextBox tb_passport;
        private Label label6;
        private Button btn_submit;
        private ComboBox cb_type;
        private Label label7;
    }
}