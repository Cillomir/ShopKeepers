/* **************************************************
* ShopKeepers - Shop v0.1.0
* Author: Joel Leckie
* Created: Sep. 2023
*  v0.1.0 - Created shop class.
 ************************************************** */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopKeepers
{
   internal class shop
   {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        private character owner;
        public string Owner { get { return owner.Name; } set { owner.Name = value; } }



    }
}
