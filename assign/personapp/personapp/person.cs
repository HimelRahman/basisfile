using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personapp
{
    class person
    {
        public string firstName;
        public string middleName;
        public string lastName;

        public string GetFullName()
        {

            return firstName + " " + middleName + " " + lastName;
        }

        public string GetReverseName()
        {
            string Name = GetFullName();

            char[] nameChar = Name.ToCharArray();
            string revarse = null;



            for (int i=Name.Length-1 ; i>= 0; i--)
            {
                revarse += nameChar[i];

            }
            return revarse;

        }
    }


}
