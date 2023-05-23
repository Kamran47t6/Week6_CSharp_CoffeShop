using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6_task;
namespace Week6_task
{
    class CoffeeShop
    {
        public string name;
        public List<MenuItem> Menu = new List<MenuItem>();
        public List<string> Orders;
        public CoffeeShop(string name)
        {
            this.name = name;
            Menu = new List<MenuItem>();
            Orders = new List<string>();
        }
        public void AddMenuItem(MenuItem item)
        {
            Menu.Add(item);
        }
        public string AddOrder(string itemName)
        {
            MenuItem item = Menu.FirstOrDefault(x => x.Name == itemName);
            if (item != null)
            {
                Orders.Add(itemName);
                return $"Order Added :{itemName}";
            }
            else
            {
                return $"This item {itemName}is currently unavailable ..";
            }
        }
        public string FulfillOrder()
        {
            if (Orders.Count > 0)
            {
                string item = Orders[0];
                Orders.RemoveAt(0);
                return $"THe {item} is ready ";
            }
            else 
            {
                return "All Orders have been fulfilled ..";
            }

        }
        public List<string> ListofOrders()
        {
            if (Orders.Count > 0)
            {
                return Orders;
            }
            else
            {
                return null;
            }
        }
        public float DueAmount()
        {
            float totalAmount = 0;
            foreach(string itemName in Orders)
            {
                MenuItem item = Menu.FirstOrDefault(x => x.Name == itemName);
                if (item != null)
                {
                    totalAmount = totalAmount + item.Price;
                }
            }
            return totalAmount;
        }
        public string CheapestItem()
        {
            MenuItem cheapestItem = Menu.OrderBy(x => x.Price).FirstOrDefault();
            if(cheapestItem != null)
            {
                return cheapestItem.Name;
            }
            else
            {
                return null;
            }
        }
        public List<string> DrinksOnly()
        {
            List<string> drinks= Menu.Where(x => x.Type == "Drink").Select(x => x.Name).ToList();
            return drinks;
        }
        public List<string> FoodOnly()
        {
            List<string> fooditems = Menu.Where(x => x.Type == "Food").Select(x => x.Name).ToList();
            return fooditems;
        }
    }
}
