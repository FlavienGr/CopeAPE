using System;
using System.Collections.Generic;
using System.Text;

namespace APE
{
    class CodeLibe : Code
    {
        public CodeLibe()
        {
           

        }
        public void Create()
        {
            string modifyNumber1 = Transform(Num1);
            string modifyNumber2 = Transform(Num2);
            string modifyNumber3 = Transform(Num3);

            string number = $"{modifyNumber1} {modifyNumber2} {modifyNumber3}";
            Console.WriteLine($"{number}");
        }
    }
}
