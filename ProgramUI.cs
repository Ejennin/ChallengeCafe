using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeCafe
{
    class ProgramUI
    {
        MenubRepository _menubRepository = new MenubRepository();
        
        //method that starts the application
        public void Run()
        {
            SeedRepo();
            Menu();
        }

        //menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {




                //Display options
                Console.WriteLine("select a menu option:\n" +
                    "1. View all Menu Items\n" +
                    "2. Add new Menu Item\n" +
                    "3. Remove Menu Item\n" +
                    "4. Exit");
                //Console.ReadKey();
                //Get user input
                string input = Console.ReadLine();
                //Evaluate
                switch (input)
                {
                    case "1":
                        //View all items
                        GetAllMenubItems();
                        break;
                    case "2":
                        //add new items
                        AddMenubItems();
                        break;
                    case "3":
                        //remove menu item
                        RemoveMenuByName();
                        Console.WriteLine(" The Item has been removed");
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("Good Bye");
                        Console.ReadLine();
                        keepRunning = false;//Exit Keep
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;

                }


                //Console.WriteLine("Please press any Key to continue");
                // Console.ReadKey();    
                //  Console.Clear();

            }
        }

        //private void View all items()
        private void GetAllMenubItems()
        {
            Console.Clear();
            List<Menub> listOfContent = _menubRepository.GetMenubList();

            foreach (Menub content in listOfContent)
            {
                Console.WriteLine($"{content.Name}\n " +
                    $"{content.MealNumber}\n" +
                    $"{content.Description}\n" +
                    $"{content.Price}\n" +
                    $"{content.Ingredients}");
            }
        }



        //private void add new items()
        private void AddMenubItems()
        {
            Console.Clear();
            Menub menubItem = new Menub();
            Console.WriteLine("Name of the item you want add");

            menubItem.Name = Console.ReadLine();

            Console.WriteLine("What is the price 'format 00.00' ");
            menubItem.Price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the Meal # ");
            menubItem.MealNumber = Console.ReadLine();

            Console.WriteLine("What are the ingredients");
            menubItem.Ingredients = Console.ReadLine();
            Console.WriteLine("What is the description?");
            menubItem.Description = Console.ReadLine();

            _menubRepository.AddMenubContent(menubItem);
            Console.WriteLine("Your item has been added.");
            Console.ReadLine();

        }
        //private void remove menu items()
        private void RemoveMenuByName()
        {


            Console.Clear();
            Console.WriteLine("Please enter the name of the item to be removed.");
            string name = Console.ReadLine();
            Menub menub = _menubRepository.GetMealByName(name);

            if (menub.Name.ToLower() == name.ToLower())
            {
                _menubRepository.RemoveMenuByName(menub.Name);

            }
        }
        public void SeedRepo()
        {
            Menub burger = new Menub("BurgerBasket", 6.50, "#1", "Beef Patty", "Beef Burger with Fries and Drink");
            Menub hotdog = new Menub("HotDogBasket", 6.50, "#1", "Beef wiener", "Beef wiener with Fries and Drink");
            Menub veggie = new Menub("VeggieBasket", 6.50, "#1", "Beef Patty", "Beef Burger with Fries and Drink");

            _menubRepository.AddMenubContent(burger);
            _menubRepository.AddMenubContent(hotdog);
            _menubRepository.AddMenubContent(veggie);

        }

        //private void exit()



    }
}
