using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeCafe
{

    //poco  

    public class Menub
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string MealNumber { get; set; }
        
        public string Ingredients { get; set; }
        public string Description { get; set; }

        public Menub(){}
        public Menub(string name, double price, string mealNumber, string ingredients, string description )
        {
            Name = name;
            Price = price;
            MealNumber = mealNumber;
            
            Ingredients = ingredients;
            Description = description;




        }


    }







}
//properties
//constructors
//fields




