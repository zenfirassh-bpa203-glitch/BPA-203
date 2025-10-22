using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Access_Modifires__Encupsulation__Namespace2
{
    internal class GET
    {
        public int HorsePower
        {
            get
            {
                return HorsePower;
            }
            set
            {
                if (value < 0)
                {
                    HorsePower = 0;
                }
                else
                {
                    HorsePower = value;
                }
            }
        }
    }
}
