namespace RestaurantSystem.UI
{
    partial class MenuDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuDetailsForm));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pictureBoxDetails = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.itemName = new System.Windows.Forms.Label();
            this.itemDescription = new System.Windows.Forms.Label();
            this.itemIngredients = new System.Windows.Forms.Label();
            this.listIngredients = new System.Windows.Forms.Label();
            this.itemPriceDetails = new System.Windows.Forms.Label();
            this.customerOrderDetails = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.orderSides = new System.Windows.Forms.Button();
            this.orderToppings = new System.Windows.Forms.Button();
            this.orderPreferences = new System.Windows.Forms.Button();
            this.orderReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pictureBoxDetails
            // 
            this.pictureBoxDetails.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDetails.Image")));
            this.pictureBoxDetails.Location = new System.Drawing.Point(36, 12);
            this.pictureBoxDetails.Name = "pictureBoxDetails";
            this.pictureBoxDetails.Size = new System.Drawing.Size(366, 346);
            this.pictureBoxDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDetails.TabIndex = 0;
            this.pictureBoxDetails.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(699, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 36);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.Location = new System.Drawing.Point(452, 80);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(162, 24);
            this.itemName.TabIndex = 2;
            this.itemName.Text = "Name of the food";
            // 
            // itemDescription
            // 
            this.itemDescription.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemDescription.Location = new System.Drawing.Point(451, 107);
            this.itemDescription.Name = "itemDescription";
            this.itemDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.itemDescription.Size = new System.Drawing.Size(341, 162);
            this.itemDescription.TabIndex = 3;
            this.itemDescription.Text = resources.GetString("itemDescription.Text");
            // 
            // itemIngredients
            // 
            this.itemIngredients.AutoSize = true;
            this.itemIngredients.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemIngredients.Location = new System.Drawing.Point(451, 269);
            this.itemIngredients.Name = "itemIngredients";
            this.itemIngredients.Size = new System.Drawing.Size(112, 24);
            this.itemIngredients.TabIndex = 2;
            this.itemIngredients.Text = "Ingredients:";
            // 
            // listIngredients
            // 
            this.listIngredients.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listIngredients.Location = new System.Drawing.Point(452, 299);
            this.listIngredients.Name = "listIngredients";
            this.listIngredients.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listIngredients.Size = new System.Drawing.Size(341, 127);
            this.listIngredients.TabIndex = 3;
            this.listIngredients.Text = resources.GetString("listIngredients.Text");
            // 
            // itemPriceDetails
            // 
            this.itemPriceDetails.AutoSize = true;
            this.itemPriceDetails.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPriceDetails.Location = new System.Drawing.Point(32, 370);
            this.itemPriceDetails.Name = "itemPriceDetails";
            this.itemPriceDetails.Size = new System.Drawing.Size(52, 24);
            this.itemPriceDetails.TabIndex = 2;
            this.itemPriceDetails.Text = "Price";
            // 
            // customerOrderDetails
            // 
            this.customerOrderDetails.AutoSize = true;
            this.customerOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerOrderDetails.Location = new System.Drawing.Point(33, 422);
            this.customerOrderDetails.Name = "customerOrderDetails";
            this.customerOrderDetails.Size = new System.Drawing.Size(126, 18);
            this.customerOrderDetails.TabIndex = 4;
            this.customerOrderDetails.Text = "Customize Order:";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(698, 453);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(94, 36);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Back";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // orderSides
            // 
            this.orderSides.Location = new System.Drawing.Point(36, 453);
            this.orderSides.Name = "orderSides";
            this.orderSides.Size = new System.Drawing.Size(94, 36);
            this.orderSides.TabIndex = 1;
            this.orderSides.Text = "Sides";
            this.orderSides.UseVisualStyleBackColor = true;
            this.orderSides.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // orderToppings
            // 
            this.orderToppings.Location = new System.Drawing.Point(136, 453);
            this.orderToppings.Name = "orderToppings";
            this.orderToppings.Size = new System.Drawing.Size(94, 36);
            this.orderToppings.TabIndex = 1;
            this.orderToppings.Text = "Toppings";
            this.orderToppings.UseVisualStyleBackColor = true;
            this.orderToppings.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // orderPreferences
            // 
            this.orderPreferences.Location = new System.Drawing.Point(236, 453);
            this.orderPreferences.Name = "orderPreferences";
            this.orderPreferences.Size = new System.Drawing.Size(94, 36);
            this.orderPreferences.TabIndex = 1;
            this.orderPreferences.Text = "Preferences";
            this.orderPreferences.UseVisualStyleBackColor = true;
            this.orderPreferences.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // orderReset
            // 
            this.orderReset.Location = new System.Drawing.Point(236, 414);
            this.orderReset.Name = "orderReset";
            this.orderReset.Size = new System.Drawing.Size(94, 36);
            this.orderReset.TabIndex = 1;
            this.orderReset.Text = "Reset";
            this.orderReset.UseVisualStyleBackColor = true;
            this.orderReset.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MenuDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(809, 501);
            this.Controls.Add(this.customerOrderDetails);
            this.Controls.Add(this.listIngredients);
            this.Controls.Add(this.itemDescription);
            this.Controls.Add(this.itemPriceDetails);
            this.Controls.Add(this.itemIngredients);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.orderReset);
            this.Controls.Add(this.orderPreferences);
            this.Controls.Add(this.orderToppings);
            this.Controls.Add(this.orderSides);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBoxDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuDetailsForm";
            this.Text = "MenuDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox pictureBoxDetails;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label itemDescription;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Label customerOrderDetails;
        private System.Windows.Forms.Label listIngredients;
        private System.Windows.Forms.Label itemPriceDetails;
        private System.Windows.Forms.Label itemIngredients;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button orderReset;
        private System.Windows.Forms.Button orderPreferences;
        private System.Windows.Forms.Button orderToppings;
        private System.Windows.Forms.Button orderSides;
    }
}