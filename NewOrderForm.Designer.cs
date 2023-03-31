namespace OrganisationManager
{
    partial class NewOrderForm
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
            this.lb_request = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_deleteRequest = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.tb_cost = new System.Windows.Forms.TextBox();
            this.tb_orderNumber = new System.Windows.Forms.TextBox();
            this.tb_volume = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.cb_provider = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_newRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_request
            // 
            this.lb_request.FormattingEnabled = true;
            this.lb_request.ItemHeight = 15;
            this.lb_request.Location = new System.Drawing.Point(330, 42);
            this.lb_request.Name = "lb_request";
            this.lb_request.Size = new System.Drawing.Size(197, 139);
            this.lb_request.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total Cost";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Requests";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Order Number";
            // 
            // btn_deleteRequest
            // 
            this.btn_deleteRequest.Location = new System.Drawing.Point(432, 187);
            this.btn_deleteRequest.Name = "btn_deleteRequest";
            this.btn_deleteRequest.Size = new System.Drawing.Size(95, 23);
            this.btn_deleteRequest.TabIndex = 6;
            this.btn_deleteRequest.Text = "Delete Request";
            this.btn_deleteRequest.UseVisualStyleBackColor = true;
            this.btn_deleteRequest.Click += new System.EventHandler(this.btn_deleteRequest_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(229, 240);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 7;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // tb_cost
            // 
            this.tb_cost.Location = new System.Drawing.Point(104, 100);
            this.tb_cost.Name = "tb_cost";
            this.tb_cost.Size = new System.Drawing.Size(121, 23);
            this.tb_cost.TabIndex = 4;
            // 
            // tb_orderNumber
            // 
            this.tb_orderNumber.Location = new System.Drawing.Point(104, 71);
            this.tb_orderNumber.Name = "tb_orderNumber";
            this.tb_orderNumber.Size = new System.Drawing.Size(121, 23);
            this.tb_orderNumber.TabIndex = 5;
            // 
            // tb_volume
            // 
            this.tb_volume.Location = new System.Drawing.Point(104, 129);
            this.tb_volume.Name = "tb_volume";
            this.tb_volume.Size = new System.Drawing.Size(121, 23);
            this.tb_volume.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Volume";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Order Date";
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(104, 158);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(200, 23);
            this.dtp_date.TabIndex = 12;
            // 
            // cb_provider
            // 
            this.cb_provider.FormattingEnabled = true;
            this.cb_provider.Location = new System.Drawing.Point(104, 42);
            this.cb_provider.Name = "cb_provider";
            this.cb_provider.Size = new System.Drawing.Size(121, 23);
            this.cb_provider.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Provider";
            // 
            // btn_newRequest
            // 
            this.btn_newRequest.Location = new System.Drawing.Point(331, 187);
            this.btn_newRequest.Name = "btn_newRequest";
            this.btn_newRequest.Size = new System.Drawing.Size(95, 23);
            this.btn_newRequest.TabIndex = 6;
            this.btn_newRequest.Text = "New Request";
            this.btn_newRequest.UseVisualStyleBackColor = true;
            this.btn_newRequest.Click += new System.EventHandler(this.btn_newRequest_Click);
            // 
            // NewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 275);
            this.Controls.Add(this.cb_provider);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.lb_request);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_newRequest);
            this.Controls.Add(this.btn_deleteRequest);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.tb_volume);
            this.Controls.Add(this.tb_cost);
            this.Controls.Add(this.tb_orderNumber);
            this.Name = "NewOrderForm";
            this.Text = "NewOrderForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewOrderForm_FormClosed);
            this.Load += new System.EventHandler(this.NewOrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lb_request;
        private Label label2;
        private Label label3;
        private Label label1;
        private Button btn_deleteRequest;
        private Button btn_submit;
        private TextBox tb_cost;
        private TextBox tb_orderNumber;
        private TextBox tb_volume;
        private Label label4;
        private Label label5;
        private DateTimePicker dtp_date;
        private ComboBox cb_provider;
        private Label label6;
        private Button btn_newRequest;
    }
}