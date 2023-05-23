using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6_task;
namespace Week6_task
{
    class Program
    {
        static void Main(string[] args)
        {

            CoffeeShop coffeshop = new CoffeeShop("Tesha's Coffe Shop ");
            coffeshop.AddMenuItem(new MenuItem("Orange Juice", "Drink",60));
            coffeshop.AddMenuItem(new MenuItem("lemonade", "Drink",50));
            coffeshop.AddMenuItem(new MenuItem("cranberry Juice", "Drink", 100));
            coffeshop.AddMenuItem(new MenuItem("Pineapple Juice", "Drink", 100));
            coffeshop.AddMenuItem(new MenuItem("lemon iced tea", "Drink", 120));
            coffeshop.AddMenuItem(new MenuItem("Vanilla chai latte", "Drink", 150));
            coffeshop.AddMenuItem(new MenuItem("hot chocolate ", "Drink", 140));
            coffeshop.AddMenuItem(new MenuItem("iced coffe", "Drink", 140));
            coffeshop.AddMenuItem(new MenuItem("tuna sandwich", "Food", 300));
            coffeshop.AddMenuItem(new MenuItem("ham and cheese sandwich", "Food", 300));
            coffeshop.AddMenuItem(new MenuItem("egg sandwich", "Food", 200));
            coffeshop.AddMenuItem(new MenuItem("steak", "Food", 900));
            coffeshop.AddMenuItem(new MenuItem("hamburger", "Food", 600));
            coffeshop.AddMenuItem(new MenuItem("cinnamon roll", "Food", 150));
            Console.WriteLine(coffeshop.Menu);

            bool value = true;
            while (value)
            {
                Console.WriteLine("1.  Add a Menu item :");
                Console.WriteLine("2.  View the Cheapest Item in the Menu :");
                Console.WriteLine("3.  View the Drinks Menu :");
                Console.WriteLine("4.  View the Food Menu :");
                Console.WriteLine("5.  Add Order :");
                Console.WriteLine("6.  Fulfill the Order :");
                Console.WriteLine("7.  View the Order's List :");
                Console.WriteLine("8.  Total Payable Amount :");
                Console.WriteLine("9.  Exit :");
                Console.WriteLine("Enter your chosie :");
                int chosie = int.Parse(Console.ReadLine());
                if (chosie == 1)
                {
                    Console.WriteLine("Enter the Name of item :");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter type of item (Drink/Food) :");
                    string type = Console.ReadLine();
                    Console.WriteLine("ENter the price of Item :");
                    float price = float.Parse(Console.ReadLine());
                    coffeshop.AddMenuItem(new MenuItem(name, type, price));
                    Console.WriteLine(" Menu Item Added Successfully");
                }
                else if (chosie == 2)
                {
                    string cheapestItem = coffeshop.CheapestItem();
                    Console.WriteLine($"The Cheapest Item is {cheapestItem}");
                }
                else if (chosie == 3)
                {
                    Console.WriteLine("Drink Menu :");
                    List<string> drinkmenu = coffeshop.DrinksOnly();
                    foreach (string data in drinkmenu)
                    {
                        Console.WriteLine(data);
                    }
                }
                else if (chosie == 4)
                {
                    Console.WriteLine("Food Menu :");
                    List<string> foodmenu = coffeshop.FoodOnly();
                    foreach (string item in foodmenu)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (chosie == 5)
                {
                    Console.WriteLine("What would you like to Order ?");
                    var order = Console.ReadLine();
                    string result = coffeshop.AddOrder(order);
                    Console.WriteLine(result);

                }
                else if(chosie == 6)
                {
                  string fullfill=  coffeshop.FulfillOrder();
                    Console.WriteLine(fullfill);
                }
                else if (chosie == 7)
                {
                    List<string> orderlist = coffeshop.ListofOrders();
                    if (orderlist != null)
                    {
                        Console.WriteLine("Orders :");
                        foreach (var item in orderlist)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Order have been placed");
                    }
                }
                else if (chosie == 8)
                {

                    float amountdue = coffeshop.DueAmount();
                    Console.WriteLine($"The total payable  Amount : {amountdue}");
                }
                else if (chosie == 9)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input ...");
                }
                Console.ReadKey();
            }
            
                
            }

          

           
            
           
            
          
           
            

        }
        
        
    }

