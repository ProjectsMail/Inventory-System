using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Parent_Items
    {
        public double apple;
        public double banana;
        public double cherry;
        public double grape;
        public double mango;
        public double orange;

        public double tomato;
        public double cucumber;
        public double potatoes;
        public double peas;
        public double onions;
        public double spinach;

        public double milkshake;
        public double vanilla_cone;
        public double classic_vanilla;
        public double vanilla_milkshake;
        public double chocolate_milkshake;
        public double strawberry_milkshake;

        public double fruits_cost;
        public double vegetables_cost;
        public double milkshake_cost;
        public double items_cost;


        public double apple_price = 0.4;
        public double banana_price = 1.8;
        public double cherry_price = 2.5;
        public double grape_price = 2.3;
        public double mango_price = 1.86;
        public double orange_price = 1.78;

        public double tomato_price = 0.3;
        public double cucumber_price = 0.4;
        public double potatoes_price = 1.1;
        public double peas_price = 0.9;
        public double onions_price = 0.7;
        public double spinach_price = 0.6;

        public int milkshake_price = 5;
        public int vanilla_cone_price = 6;
        public int classic_vanilla_price = 7;
        public int vanilla_milkshake_price = 8;
        public int chocolate_milkshake_price = 9;
        public int strawberry_milkshake_price = 10;

        public double GetAmount()
        {
            fruits_cost = apple + banana + cherry + grape + mango + orange;
            vegetables_cost = tomato + cucumber + potatoes + peas + onions + spinach;
            milkshake_cost = milkshake + vanilla_cone + classic_vanilla + vanilla_milkshake + chocolate_milkshake + strawberry_milkshake;
            items_cost = fruits_cost + vegetables_cost + milkshake_cost;
            return items_cost;
        }
        public double tax_rate = 0.14;
        public double FindTax(double amount)
        {
            double find_tax = amount * tax_rate;
            return find_tax;
        }
        public double GetTax()
        {
            return FindTax(items_cost);
        }



    }
}
