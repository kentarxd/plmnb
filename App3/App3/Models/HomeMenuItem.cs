using System;
using System.Collections.Generic;
using System.Text;

namespace App3.Models
{
    public enum MenuItemType
    {
        Browse,
        Gazetki,
        O_nas

    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
