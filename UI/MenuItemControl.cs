using System;
using System.Drawing;
using System.Windows.Forms;

namespace RestaurantSystem.UI
{
    public partial class MenuItemControl : UserControl
    {
        
        public MenuItemControl()
        {
            InitializeComponent();
        }

        public string ItemName
        {
            get => lblItemName.Text;
            set => lblItemName.Text = value;
        }

        public string ItemDescription
        {
            get => lblDescription.Text;
            set => lblDescription.Text = value;
        }

        public decimal Price
        {
            get => decimal.Parse(lblPrice.Text.Substring(1));
            set => lblPrice.Text = $"\u20b1 {value:0.00}";
        }

        public Image ItemImage
        {
            get => pictureBox.Image;
            set => pictureBox.Image = value;
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void lblItemName_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
