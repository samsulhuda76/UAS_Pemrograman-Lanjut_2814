using System;
using System.Collections.Generic;
using System.Text;
using UAS_PemrogramanLanjut_2814.Model;

namespace UAS_PemrogramanLanjut_2814.Controller
{
    class MenuController
    {
        private List<Item> menuItem;

        public MenuController()
        {
            menuItem = new List<Item>();
        }

        public void addItem(Item item)
        {
            this.menuItem.Add(item);
        }

        public List<Item> getItems()
        {
            return this.menuItem;
        }
    }
}