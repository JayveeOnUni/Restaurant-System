using System;
using RestaurantSystem.Data;
using System.Windows.Forms;
using RestaurantSystem.UI;



namespace RestaurantSystem.Handler
{
    internal class DetailsFormHandler
    {
        private readonly DatabaseHandler _menuItemRepository;
        private readonly Form _detailForm;

        public DetailsFormHandler(DatabaseHandler menuItemRepository, Form detailForm)
        {
            _menuItemRepository = menuItemRepository;
            _detailForm = detailForm;
        }

        public void LoadMenuDetails(int itemID)
        {
            var menuItems = _menuItemRepository.GetMenuItemById(itemID);

            foreach (var item in menuItems)
            {
                var menuDetailsForm = new MenuDetailsForm
                {
                    ItemNameDetails = item.Name,
                    ItemDescriptionDetails = item.LongDescription,
                    ItemPriceDetails = item.Price,
                };
            }
            
            // Make the details panel visible
            _detailForm.Visible = true;
        }
}
}
