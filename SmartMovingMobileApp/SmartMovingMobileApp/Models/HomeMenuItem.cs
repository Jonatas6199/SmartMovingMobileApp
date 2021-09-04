using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMovingMobileApp.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Home,
        Charts
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
