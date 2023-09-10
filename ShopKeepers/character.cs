/* **************************************************
* ShopKeepers - Character v0.1.0
* Author: Joel Leckie
* Created: Sep. 2023
*  v0.1.0 - Created character class.
 ************************************************** */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopKeepers
{
    internal class character
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        private string race;
        public string Race { get { return race; } set { race = value; } }

        private int age;

    }
}
