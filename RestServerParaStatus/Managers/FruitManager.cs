using JsonFruit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestServerParaStatus.Managers
{
    public class FruitManager
    {
        public List<Fruit> fruits = new List<Fruit>();

        public FruitManager()
        {
            fruits.Add(new Fruit("Banana"));
            fruits.Add(new Fruit("Apple"));
        }

        public List<Fruit> GetList(string substring)
        {
            List<Fruit> result = new List<Fruit>(fruits);
            if (substring != null)
            {
                result = result.FindAll(fruit => fruit.typeOfFruit.Contains(substring, StringComparison.OrdinalIgnoreCase));
            }

            return result;
        }
    }
}
