using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExercisesInCsharp.Exercises
{
    public class Conversion
    {

        #region Decimal Conversion
        public String decToBinary(int num)
        {
            int remain;
            String result = "";
            while (num > 0)
            {
                remain = num % 2;
                result = Convert.ToString(remain) + result;
                num /= 2;
            }
            return result;
        }

        public String decToOctal(int num)
        {
            int remain;
            String result = "";
            while (num > 0)
            {
                remain = num % 8;
                result = Convert.ToString(remain) + result;
                num /= 8;
            }
            return result;
        }

        public String decToHexadecimal(int num)
        {
            int remain;
            char[] hexa = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'F' };
            String result = "";
            while (num > 0)
            {
                remain = num % 16;
                result = hexa[remain] + result;
                num /= 16;
            }
            return result;
        }

        #endregion

        #region Binary Conversion
        public int binaryToDecimal(int binaryNumber)
        {
            int dec = 0, remainder, i = 0;

            while (binaryNumber > 0)
            {
                remainder = binaryNumber % 10;
                dec = dec + remainder * (int)Math.Pow(2, i);
                i++;
                binaryNumber /= 10;


            }

            return dec;
        }


        public int binaryToOctal(int binaryNumber)
        {

            int octalNumber = 0, decimalNumber = 0, i = 0;
            while (binaryNumber != 0)
            {
                decimalNumber += (binaryNumber % 10) * (int)Math.Pow(2, i);
                ++i;
                binaryNumber /= 10;
            }

            i = 1;

            while (decimalNumber != 0)
            {
                octalNumber += (decimalNumber % 8) * i;
                decimalNumber /= 8;
                i *= 10;
            }

            return octalNumber;

        }

        #endregion

        #region Octal Conversion
        public int octalToDecimal(int octalnum)
        {
            int octal = 0, remainder, i = 0;

            while (octalnum > 0)
            {
                remainder = octalnum % 10;
                octal = octal + remainder * (int)Math.Pow(8, i);
                i++;
                octalnum /= 10;


            }

            return octal;
        }

        #endregion

        #region HexaDecimal Conversion

        public int hexaToDecimal(String hexVal)
        {
            int len = hexVal.Length;

            // Initializing base1 value
            // to 1, i.e 16^0
            int base1 = 1;

            int dec_val = 0;

            // Extracting characters as
            // digits from last character
            for (int i = len - 1; i >= 0; i--)
            {
                // if character lies in '0'-'9',
                // converting it to integral 0-9
                // by subtracting 48 from ASCII value
                if (hexVal[i] >= '0' && hexVal[i] <= '9')
                {
                    dec_val += (hexVal[i] - 48) * base1;

                    // incrementing base1 by power
                    base1 = base1 * 16;
                }

                // if character lies in 'A'-'F' ,
                // converting it to integral
                // 10 - 15 by subtracting 55
                // from ASCII value
                else if (hexVal[i] >= 'A' && hexVal[i] <= 'F')
                {
                    dec_val += (hexVal[i] - 55) * base1;

                    // incrementing base1 by power
                    base1 = base1 * 16;
                }
            }
            return dec_val;
        }

        #endregion

       
    }
}
