namespace OrganisationManager.ViewForms
{
    partial class SectionsAndShopRoomVIewForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_sections = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_shopRooms = new System.Windows.Forms.ListBox();
            this.btn_newSection = new System.Windows.Forms.Button();
            this.btn_editSection = new System.Windows.Forms.Button();
            this.btn_deleteSection = new System.Windows.Forms.Button();
            this.btn_newShopRoom = new System.Windows.Forms.Button();
            this.btn_editShopRoom = new System.Windows.Forms.Button();
            this.btn_deleteShopRoom = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_deleteShopRoom);
            this.panel1.Controls.Add(this.btn_deleteSection);
            this.panel1.Controls.Add(this.btn_editShopRoom);
            this.panel1.Controls.Add(this.btn_newShopRoom);
            this.panel1.Controls.Add(this.btn_editSection);
            this.panel1.Controls.Add(this.btn_newSection);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 45);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb_sections);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 405);
            this.panel2.TabIndex = 1;
            // 
            // lb_sections
            // 
            this.lb_sections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_sections.FormattingEnabled = true;
            this.lb_sections.ItemHeight = 15;
            this.lb_sections.Location = new System.Drawing.Point(0, 0);
            this.lb_sections.Name = "lb_sections";
            this.lb_sections.Size = new System.Drawing.Size(301, 405);
            this.lb_sections.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lb_shopRooms);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(301, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(313, 405);
            this.panel3.TabIndex = 2;
            // 
            // lb_shopRooms
            // 
            this.lb_shopRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_shopRooms.FormattingEnabled = true;
            this.lb_shopRooms.ItemHeight = 15;
            this.lb_shopRooms.Location = new System.Drawing.Point(0, 0);
            this.lb_shopRooms.Name = "lb_shopRooms";
            this.lb_shopRooms.Size = new System.Drawing.Size(313, 405);
            this.lb_shopRooms.TabIndex = 0;
            // 
            // btn_newSection
            // 
            this.btn_newSection.Location = new System.Drawing.Point(12, 12);
            this.btn_newSection.Name = "btn_newSection";
            this.btn_newSection.Size = new System.Drawing.Size(85, 23);
            this.btn_newSection.TabIndex = 0;
            this.btn_newSection.Text = "New Section";
            this.btn_newSection.UseVisualStyleBackColor = true;
            this.btn_newSection.Click += new System.EventHandler(this.btn_newSection_Click);
            // 
            // btn_editSection
            // 
            this.btn_editSection.Location = new System.Drawing.Point(103, 12);
            this.btn_editSection.Name = "btn_editSection";
            this.btn_editSection.Size = new System.Drawing.Size(89, 23);
            this.btn_editSection.TabIndex = 0;
            this.btn_editSection.Text = "Edit Section";
            this.btn_editSection.UseVisualStyleBackColor = true;
            this.btn_editSection.Click += new System.EventHandler(this.btn_editSection_Click);
            // 
            // btn_deleteSection
            // 
            this.btn_deleteSection.Location = new System.Drawing.Point(198, 12);
            this.btn_deleteSection.Name = "btn_deleteSection";
            this.btn_deleteSection.Size = new System.Drawing.Size(90, 23);
            this.btn_deleteSection.TabIndex = 0;
            this.btn_deleteSection.Text = "Delete Section";
            this.btn_deleteSection.UseVisualStyleBackColor = true;
            this.btn_deleteSection.Click += new System.EventHandler(this.btn_deleteSection_Click);
            // 
            // btn_newShopRoom
            // 
            this.btn_newShopRoom.Location = new System.Drawing.Point(321, 12);
            this.btn_newShopRoom.Name = "btn_newShopRoom";
            this.btn_newShopRoom.Size = new System.Drawing.Size(91, 23);
            this.btn_newShopRoom.TabIndex = 0;
            this.btn_newShopRoom.Text = "New S.Room";
            this.btn_newShopRoom.UseVisualStyleBackColor = true;
            this.btn_newShopRoom.Click += new System.EventHandler(this.btn_newShopRoom_Click);
            // 
            // btn_editShopRoom
            // 
            this.btn_editShopRoom.Location = new System.Drawing.Point(418, 12);
            this.btn_editShopRoom.Name = "btn_editShopRoom";
            this.btn_editShopRoom.Size = new System.Drawing.Size(89, 23);
            this.btn_editShopRoom.TabIndex = 0;
            this.btn_editShopRoom.Text = "Edit S.Room";
            this.btn_editShopRoom.UseVisualStyleBackColor = true;
            this.btn_editShopRoom.Click += new System.EventHandler(this.btn_editShopRoom_Click);
            // 
            // btn_deleteShopRoom
            // 
            this.btn_deleteShopRoom.Location = new System.Drawing.Point(513, 12);
            this.btn_deleteShopRoom.Name = "btn_deleteShopRoom";
            this.btn_deleteShopRoom.Size = new System.Drawing.Size(98, 23);
            this.btn_deleteShopRoom.TabIndex = 0;
            this.btn_deleteShopRoom.Text = "Delete S.Room";
            this.btn_deleteShopRoom.UseVisualStyleBackColor = true;
            this.btn_deleteShopRoom.Click += new System.EventHandler(this.btn_deleteShopRoom_Click);
            // 
            // SectionsAndShopRoomVIewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SectionsAndShopRoomVIewForm";
            this.Text = "SectionsAndShopRoomVIewForm";
            this.Load += new System.EventHandler(this.SectionsAndShopRoomVIewForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ListBox lb_sections;
        private Panel panel3;
        private ListBox lb_shopRooms;
        private Button btn_deleteShopRoom;
        private Button btn_deleteSection;
        private Button btn_editShopRoom;
        private Button btn_newShopRoom;
        private Button btn_editSection;
        private Button btn_newSection;
    }
}