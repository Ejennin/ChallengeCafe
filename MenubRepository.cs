using ChallengeCafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeCafe
{
    public class MenubRepository
    {
        private List<Menub> _menubDirectory = new List<Menub>();



        //createC:\ElevenFiftyProjects\DotNetProjects\ChallengeCafe\Program.cs
        public bool AddMenubContent(Menub item)
        {
            int startingCount = _menubDirectory.Count;
            _menubDirectory.Add(item);
            bool wasAdded = _menubDirectory.Count == startingCount + 1;
            return wasAdded;
        }


        //read
        public Menub GetMealByName(string Name)
        {
            foreach (Menub menub in _menubDirectory)
                if (menub.Name.ToLower() == Name.ToLower())
                {
                    return menub;

                }
            return null;

        }

        public List<Menub> GetMenubList()
        {
            return _menubDirectory;

        }
        //update

        //delete
        public void RemoveMenuByName(string Name)
        {
            Menub menub = GetMealByName(Name);
            
            
                if (menub.Name.ToLower() == Name.ToLower())
                {
                    _menubDirectory.Remove(menub);
                    
                }
            
        }

        public Menub GetMenubItemDescription(string Description)
        {
            foreach (Menub menub in _menubDirectory)
                if (menub.Description.ToLower() == Description.ToLower())
                {
                    Console.WriteLine((menub) + " (Description)");

                }
            return null;

        }



    }
}
