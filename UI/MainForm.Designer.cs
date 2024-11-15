namespace RestaurantSystem.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblRestaurantName = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Logo_Holder = new System.Windows.Forms.PictureBox();
            this.Center_Panel = new System.Windows.Forms.Panel();
            this.flpMenuItem = new System.Windows.Forms.FlowLayoutPanel();
            this.flpCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnAppetizer = new System.Windows.Forms.Button();
            this.btnDesserts = new System.Windows.Forms.Button();
            this.btnMainCourse = new System.Windows.Forms.Button();
            this.Beverages = new System.Windows.Forms.Button();
            this.lblOrderDetail = new System.Windows.Forms.Label();
            this.pnlOrder.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Holder)).BeginInit();
            this.Center_Panel.SuspendLayout();
            this.flpCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOrder
            // 
            this.pnlOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlOrder.Controls.Add(this.lblOrderDetail);
            this.pnlOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOrder.Location = new System.Drawing.Point(1107, 0);
            this.pnlOrder.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(336, 857);
            this.pnlOrder.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHeader.Controls.Add(this.lblRestaurantName);
            this.pnlHeader.Controls.Add(this.txtSearch);
            this.pnlHeader.Controls.Add(this.Logo_Holder);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1107, 94);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblRestaurantName
            // 
            this.lblRestaurantName.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurantName.Location = new System.Drawing.Point(78, 17);
            this.lblRestaurantName.Name = "lblRestaurantName";
            this.lblRestaurantName.Size = new System.Drawing.Size(146, 63);
            this.lblRestaurantName.TabIndex = 2;
            this.lblRestaurantName.Text = "Restaurant Name";
            this.lblRestaurantName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(229, 37);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(799, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Logo_Holder
            // 
            this.Logo_Holder.Image = ((System.Drawing.Image)(resources.GetObject("Logo_Holder.Image")));
            this.Logo_Holder.Location = new System.Drawing.Point(9, 10);
            this.Logo_Holder.Margin = new System.Windows.Forms.Padding(2);
            this.Logo_Holder.Name = "Logo_Holder";
            this.Logo_Holder.Size = new System.Drawing.Size(64, 77);
            this.Logo_Holder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo_Holder.TabIndex = 0;
            this.Logo_Holder.TabStop = false;
            // 
            // Center_Panel
            // 
            this.Center_Panel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Center_Panel.Controls.Add(this.flpMenuItem);
            this.Center_Panel.Controls.Add(this.flpCategory);
            this.Center_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Center_Panel.Location = new System.Drawing.Point(0, 94);
            this.Center_Panel.Margin = new System.Windows.Forms.Padding(2);
            this.Center_Panel.Name = "Center_Panel";
            this.Center_Panel.Size = new System.Drawing.Size(1107, 763);
            this.Center_Panel.TabIndex = 0;
            // 
            // flpMenuItem
            // 
            this.flpMenuItem.AutoScroll = true;
            this.flpMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flpMenuItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMenuItem.Location = new System.Drawing.Point(0, 81);
            this.flpMenuItem.Margin = new System.Windows.Forms.Padding(2);
            this.flpMenuItem.Name = "flpMenuItem";
            this.flpMenuItem.Size = new System.Drawing.Size(1107, 682);
            this.flpMenuItem.TabIndex = 0;
            // 
            // flpCategory
            // 
            this.flpCategory.AutoSize = true;
            this.flpCategory.Controls.Add(this.btnAll);
            this.flpCategory.Controls.Add(this.btnAppetizer);
            this.flpCategory.Controls.Add(this.btnDesserts);
            this.flpCategory.Controls.Add(this.btnMainCourse);
            this.flpCategory.Controls.Add(this.Beverages);
            this.flpCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpCategory.Location = new System.Drawing.Point(0, 0);
            this.flpCategory.Margin = new System.Windows.Forms.Padding(2);
            this.flpCategory.Name = "flpCategory";
            this.flpCategory.Size = new System.Drawing.Size(1107, 81);
            this.flpCategory.TabIndex = 1;
            // 
            // btnAll
            // 
            this.btnAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAll.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(38, 12);
            this.btnAll.Margin = new System.Windows.Forms.Padding(38, 12, 38, 12);
            this.btnAll.Name = "btnAll";
            this.btnAll.Padding = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btnAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAll.Size = new System.Drawing.Size(135, 57);
            this.btnAll.TabIndex = 0;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnAppetizer
            // 
            this.btnAppetizer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppetizer.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppetizer.Location = new System.Drawing.Point(249, 12);
            this.btnAppetizer.Margin = new System.Windows.Forms.Padding(38, 12, 38, 12);
            this.btnAppetizer.Name = "btnAppetizer";
            this.btnAppetizer.Padding = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btnAppetizer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAppetizer.Size = new System.Drawing.Size(135, 57);
            this.btnAppetizer.TabIndex = 0;
            this.btnAppetizer.Text = "Appetizer";
            this.btnAppetizer.UseVisualStyleBackColor = true;
            this.btnAppetizer.Click += new System.EventHandler(this.btnAppetizer_Click);
            // 
            // btnDesserts
            // 
            this.btnDesserts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesserts.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesserts.Location = new System.Drawing.Point(460, 12);
            this.btnDesserts.Margin = new System.Windows.Forms.Padding(38, 12, 38, 12);
            this.btnDesserts.Name = "btnDesserts";
            this.btnDesserts.Padding = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btnDesserts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDesserts.Size = new System.Drawing.Size(135, 57);
            this.btnDesserts.TabIndex = 0;
            this.btnDesserts.Text = "Desserts";
            this.btnDesserts.UseVisualStyleBackColor = true;
            this.btnDesserts.Click += new System.EventHandler(this.btnDesserts_Click);
            // 
            // btnMainCourse
            // 
            this.btnMainCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainCourse.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainCourse.Location = new System.Drawing.Point(671, 12);
            this.btnMainCourse.Margin = new System.Windows.Forms.Padding(38, 12, 38, 12);
            this.btnMainCourse.Name = "btnMainCourse";
            this.btnMainCourse.Padding = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btnMainCourse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMainCourse.Size = new System.Drawing.Size(135, 57);
            this.btnMainCourse.TabIndex = 0;
            this.btnMainCourse.Text = "Main Course";
            this.btnMainCourse.UseVisualStyleBackColor = true;
            this.btnMainCourse.Click += new System.EventHandler(this.btnMainCourse_Click);
            // 
            // Beverages
            // 
            this.Beverages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Beverages.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Beverages.Location = new System.Drawing.Point(882, 12);
            this.Beverages.Margin = new System.Windows.Forms.Padding(38, 12, 38, 12);
            this.Beverages.Name = "Beverages";
            this.Beverages.Padding = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.Beverages.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Beverages.Size = new System.Drawing.Size(135, 57);
            this.Beverages.TabIndex = 0;
            this.Beverages.Text = "Beverages";
            this.Beverages.UseVisualStyleBackColor = true;
            this.Beverages.Click += new System.EventHandler(this.Beverages_Click);
            // 
            // lblOrderDetail
            // 
            this.lblOrderDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOrderDetail.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDetail.Location = new System.Drawing.Point(0, 0);
            this.lblOrderDetail.Name = "lblOrderDetail";
            this.lblOrderDetail.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblOrderDetail.Size = new System.Drawing.Size(332, 63);
            this.lblOrderDetail.TabIndex = 2;
            this.lblOrderDetail.Text = "Order Details";
            this.lblOrderDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1443, 857);
            this.Controls.Add(this.Center_Panel);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Restaurant System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlOrder.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Holder)).EndInit();
            this.Center_Panel.ResumeLayout(false);
            this.Center_Panel.PerformLayout();
            this.flpCategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel Center_Panel;
        private System.Windows.Forms.PictureBox Logo_Holder;
        private System.Windows.Forms.FlowLayoutPanel flpMenuItem;
        private System.Windows.Forms.Button btnDesserts;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnAppetizer;
        private System.Windows.Forms.Button btnMainCourse;
        private System.Windows.Forms.Button Beverages;
        private System.Windows.Forms.FlowLayoutPanel flpCategory;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblRestaurantName;
        private System.Windows.Forms.Label lblOrderDetail;
    }
}

    