using RestaurantSystem.Data;
using RestaurantSystem.Handler;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RestaurantSystem.UI
{
    public partial class MenuDetailsForm : Form
    {
        
        public MenuDetailsForm()
        {
            InitializeComponent();
        } 

        public string ItemNameDetails
        {
            get => itemName.Text;
            set => itemName.Text = value;
        }

        public string ItemDescriptionDetails
        {
            get => itemDescription.Text;
            set => itemDescription.Text = value;
        }
        public decimal ItemPriceDetails
        {
            get => decimal.Parse(itemPriceDetails.Text.Substring(1));
            set => itemPriceDetails.Text = $"\u20b1 {value:0.00}";
        }

        public string ItemListIngredientsDetails
        {
            get => listIngredients.Text;
            set => listIngredients.Text = value;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
