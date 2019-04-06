using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestingSuperbowlNames
{
    class RomanNumeralEngine
    {
        public string Translate(string stuffToTranslate)
        {
            var arrayOfInput = stuffToTranslate.Split("").ToArray();

            var finalTranslation = "fun";

            var translation0 = "fun";
            var translation1 = "fun";

            if (arrayOfInput.GetLength(0) == 4)
            {
                if (arrayOfInput[0] == "3")
                {
                    translation0 = "MMM";
                } else if (arrayOfInput[0] == "2")
                {
                    translation0 = "MM";
                } else if (arrayOfInput[0] == "1")
                {
                    translation0 = "M";
                } else if (arrayOfInput[1] == "9")
                {
                    translation1 = "CM";
                } else if (arrayOfInput[1] == "8")
                {
                    translation1 = "DCCC";
                }
                else if (arrayOfInput[1] == "7")
                {
                    translation1 = "DCC";
                }
                else if (arrayOfInput[1] == "6")
                {
                    translation1 = "DC";
                }
                else if (arrayOfInput[1] == "5")
                {
                    translation1 = "D";
                }
                else if (arrayOfInput[1] == "4")
                {
                    translation1 = "CD";
                }
                else if (arrayOfInput[1] == "3")
                {
                    translation1 = "CCC";
                }
                else if (arrayOfInput[1] == "2")
                {
                    translation1 = "CC";
                }
                else if (arrayOfInput[1] == "1")
                {
                    translation1 = "C";
                }
            }

            var translate = "M";

            if(stuffToTranslate == "1")
            {
                translate = "I";
            }
            else if(stuffToTranslate == "2"){
                translate = "II";
            };

            return translate;

        }

    }
}
