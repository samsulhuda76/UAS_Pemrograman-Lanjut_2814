using System;
using System.Collections.Generic;
using System.Text;

namespace UAS_PemrogramanLanjut_2814.Model
{
    public class Item
    {
        public string item { get; set; }
        public double price { get; set; }

        public Item(string item, double price)
        {
            this.item = item;
            this.price = price;
        }
    }
}