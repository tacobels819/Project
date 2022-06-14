using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC
{
    public class neznayu
    {
        public static int Avtoriz(string login, string pasword)
        {
            if (login == "admin")
            {
                if (pasword == "admin") return 1;
                else return 2; 
            }
            return 0;
        }
    }
}
