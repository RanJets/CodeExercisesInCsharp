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
            String hexa = "0123456789ABCDEF";
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

        public String binaryToHexadecimal(int binary)
        {
            int dec = 0, i=0;
            while (binary>0)
            {
               int rem = binary % 10;
               dec += rem * (int)Math.Pow(2,i);
                i++;
                binary /= 10;
            }

            i = 0;

            String digits = "0123456789ABCDEF";
            String hexa = "";
            while (dec > 0)
            {
                hexa = digits[dec % 16] + hexa;
                dec /= 16;
            }

            return hexa;

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

        public int hexadecimalToDecimal(String hexa)
        {
            String digits = "0123456789ABDCEF";
            int result = 0;
            for (int i = 0; i < hexa.Length; i++)
            {
                Char d = hexa[i];
                int a = digits.IndexOf(d);
                result = 16 * result + a;
            }
            return result;
        }

        #endregion

       
    }
}
