using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    public class Heritage
    {
        public string Model {  get; set; }
        public int ProductionYear { get; set; }
        public double SpeedMax { get; set; }    

    }

    public class Car : Heritage 
    { 
        public int NumberOfDoors { get; set; }
        
    }

    public class ShopItem
    {
        public string ScuNumber { get; set; }
        public DateTime ExpiryDate { get; set; }
        public double Price { get; set; }

    }

    public class Meat : ShopItem 
    {
    public bool StoredInTheFridge { get; set; }

    }

    public class Fish : ShopItem
    {
        public bool Farmed { get; set; }

    }
}
