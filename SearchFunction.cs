using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
    class SearchFunction
    {
        public string searchFru(List<string> fruits, string targ, string newFruit)
        {
            for (int i = 0; i < fruits.Count; i++)
            {
                if (fruits[i].ToLower().Equals(targ.ToLower()))
                {
                    if (!fruits.Contains(newFruit))
                    {
                        fruits[i] = newFruit;
                        return $"{targ} is updated to {newFruit} in the fruits array.";
                    }
                    else
                    {
                        return $"{newFruit} is already present in the list.";
                    }
                }
            }
            return $"{targ} not present in the fruits array.";
        }
    }
}
