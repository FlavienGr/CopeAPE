using System;
using System.Collections.Generic;
using System.Text;

namespace APE
{
    class CodeRCS : Code
    {   
        static string City { get; set; }
        static string Letter { get; set; }
        public CodeRCS(string city, string letter)
        {
            City = city;
            Letter = letter;
        }
      
         public void Create()
        {
            string modifyNumber1 = Transform(Num1);
            string modifyNumber2 = Transform(Num2);
            string modifyNumber3 = Transform(Num3);

            string number = $"{modifyNumber1} {modifyNumber2} {modifyNumber3}";
            Console.WriteLine($"RCS {City} {Letter} {number}");
        }
    }
}
