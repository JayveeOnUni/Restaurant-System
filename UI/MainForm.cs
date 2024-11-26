using System;
using System.Windows.Forms;
using RestaurantSystem.Data;
using RestaurantSystem.Handler;


namespace RestaurantSystem.UI
{
    public partial class MainForm : Form
    {
        private readonly MenuEventHandler _menuButtonHandler;
        public MainForm()
        {
            InitializeComponent();

            var databaseHandler = new DatabaseHandler();
            _menuButtonHandler = new MenuEventHandler(databaseHandler, flpMenuItem);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            _menuButtonHandler.LoadMenuItems();
            
        }
        
        private void btnAll_Click(object sender, EventArgs e)
        {
            _menuButtonHandler.LoadMenuItems();
        }
        private void btnAppetizer_Click(object sender, EventArgs e)
        {
            _menuButtonHandler.LoadMenuItems("Appetizers");
        }

        private void btnDesserts_Click(object sender, EventArgs e)
        {
            _menuButtonHandler.LoadMenuItems("Desserts");
        }

        private void btnMainCourse_Click(object sender, EventArgs e)
        {
            _menuButtonHandler.LoadMenuItems("Main Course");
        }

        private void Beverages_Click(object sender, EventArgs e)
        {
            _menuButtonHandler.LoadMenuItems("Beverages");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            _menuButtonHandler.LoadMenuItems("All", searchTerm);
        }
    }
}
