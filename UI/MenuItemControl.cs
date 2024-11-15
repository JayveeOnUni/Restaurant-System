using RestaurantSystem.Data;
using RestaurantSystem.Handler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.UI
{
    public partial class MenuItemControl : UserControl
    {
        private Form detailForm;

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

        private void MenuItemControl_Click(object sender, EventArgs e)
        {
            Panel clickedPanel = sender as Panel;
            int itemID = (int)clickedPanel.Tag; // Assuming Tag contains the itemID

            // Pass the existing details panel to DetailsFormHandler
            var detailsHandler = new DetailsFormHandler(new DatabaseHandler(), detailForm);
            detailsHandler.LoadMenuDetails(itemID);
        }
    }
}
