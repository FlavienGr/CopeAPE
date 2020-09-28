using System;
using System.Collections.Generic;
using System.Text;

namespace APE
{
    class Code
    {
        static public int Num1 {
            get;
            set;
        }
        static public int Num2
        {
            get;
            set;
        }
        static public int Num3
        {
            get;
            set;
        }
        public Code()
        {
            Num1 = GiveMeARandom();
            Num2 = GiveMeARandom();
            Num3 = GiveMeARandom();
        }
        private static int GiveMeARandom()
        {
            Random myRandom = new Random();

            int result = myRandom.Next(1, 999);
            return result;
        }
        public string Transform(int num)
        {
            string result;
            if (num < 100)
            {
                result = $"{num:D2}";
            }
            else
            {
                result = $"{num}";
            }
            return result;

        }
       
        }
}
